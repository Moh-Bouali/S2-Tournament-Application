using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WebsiteUser
    {
        public WebsiteUser()
        {
            UserName = string.Empty;
            Password = string.Empty;
            Name = string.Empty;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public string Salt { get; set; }
        public string Type { get; set; }
    }
}
