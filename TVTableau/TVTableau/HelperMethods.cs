using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVTableau
{
    public static class HelperMethods
    {
        public static DateTime ConvertFromUnixTimestampToDateTime(string timestamp)
        {
            try
            {
                var unixStartTime = new DateTime(1970, 1, 1, 2, 0, 0, 0);
                return unixStartTime.AddSeconds(double.Parse(timestamp));
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
