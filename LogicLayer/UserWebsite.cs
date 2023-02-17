using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class UserWebsite
    {
        public UserWebsite()
        {
            UserName = string.Empty;
            Password = string.Empty;
            Name = string.Empty;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }

        internal string? FindFirstValue(string v)
        {
            throw new NotImplementedException();
        }
    }
}
