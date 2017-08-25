using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTvSchedule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ChannelManager ChannelManager;
        private Channel CurrentChannel;
        private DateTime CurrentPorgramsShowingDate = DateTime.Today;

        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            ChannelManager = new ChannelManager();
            ChannelManager.LoadChannelsFromFile();

            CurrentChannel = ChannelManager.Channels[0];

            List<Channel> channels = ChannelManager.Channels;
            
            for (int i = 0; i < channels.Count; i++)
            {
                Button button = Utility.ConvertChannelToButton(channels[i]);
                button.Margin = new Thickness(3, 0, 3, 0);
                button.Click += new RoutedEventHandler(this.ClickChannelButton);

                Utility.AddButtonToGrid(ChannelGrid, button, 0, i);
            }

            DisplayProgramsFromCurrentChannel();
            ((Button) ChannelGrid.Children[0]).IsEnabled = false; // disable first button
        }

        public void DisplayProgramsFromCurrentChannel()
        {
            try
            {
                UpdateDateOnScreen();
                List<TvProgram> programs = DownloadUtility.DownloadTvPrograms(CurrentChannel, CurrentPorgramsShowingDate);

                if (programs.Count == 0)
                {
                    ShowError("Sorry, can't find any tv programs for " + CurrentPorgramsShowingDate.ToShortDateString());
                    return;
                }

                HideError();
                ListViewForPorgrams.ItemsSource = programs;
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    ShowError("Sorry, can't find any tv programs for " + CurrentPorgramsShowingDate.ToShortDateString());
                }
                else
                {
                    ShowError("Please, check your internet connection");
                }
            }

            
        }

        public void ClickChannelButton(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            button.IsEnabled = false;
            EnableChannelButtonsExept(button);
            CurrentChannel = ChannelManager.FindChannelByName(button.Content.ToString());
            DisplayProgramsFromCurrentChannel();
        }

        public void ClickNextDayButton(object sender, EventArgs e)
        {
            if (CurrentPorgramsShowingDate.CompareTo(DateTime.Today.AddDays(7)) < 0)
            {
                CurrentPorgramsShowingDate = CurrentPorgramsShowingDate.AddDays(1);
                DisplayProgramsFromCurrentChannel();
            }
        }

        public void ClickTodayButton(object sender, EventArgs e)
        {
            CurrentPorgramsShowingDate = DateTime.Today;
            DisplayProgramsFromCurrentChannel();
        }

        public void ClickPreviousDayButton(object sender, EventArgs e)
        {
            if (CurrentPorgramsShowingDate.CompareTo(DateTime.Today.AddDays(-7)) > 0)
            {
                CurrentPorgramsShowingDate = CurrentPorgramsShowingDate.AddDays(-1);
                DisplayProgramsFromCurrentChannel();
            }
        }

        public void EnableChannelButtonsExept(Button button)
        {
            UIElementCollection buttons = ChannelGrid.Children;
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i] != button)
                    buttons[i].IsEnabled = true;
            }
        }

        public void UpdateDateOnScreen()
        {
            labelDate.Content = CurrentPorgramsShowingDate.ToShortDateString();
        }

        public void ShowError(string error)
        {
            LabelError.Content = error;
            LabelError.Visibility = Visibility.Visible;
            ListViewForPorgrams.Visibility = Visibility.Collapsed;
        }

        public void HideError()
        {
            LabelError.Visibility = Visibility.Collapsed;
            ListViewForPorgrams.Visibility = Visibility.Visible;
        }
        
    }
    
}
