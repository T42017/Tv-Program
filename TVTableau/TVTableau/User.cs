using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVTableau
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}\r\nName: {Name}\r\nUsername: {UserName}";
        }
    }
}
