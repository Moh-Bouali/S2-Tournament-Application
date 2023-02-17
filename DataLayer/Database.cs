using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Database
    {
        private string connection = "Server = studmysql01.fhict.local; Uid=dbi476421;Database=dbi476421;Pwd=Admin123";

        public string Connection { get => connection; }
        public Database()
        {

        }
        public Database(string connection)
        {
            this.connection = connection;
        }
    }
}