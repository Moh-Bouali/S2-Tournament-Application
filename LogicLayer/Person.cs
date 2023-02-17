using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp_Synthesis_Assignment_DuelSyns.Inc
{
    public abstract class Person
    {
        protected int age;
        protected string name;
        protected string password;
        protected int id;
        protected string salt;
        public int ID { get => this.id; }
        public string Name { get => this.name; }
        public int Age { get => this.age; }
        public string Password { get => this.password; }
        public string Salt { get => this.salt; }
        public Person(string name, int id, string password, string salt)
        {
            this.name = name;
            this.password = password;
            this.salt = salt;
            this.id = id;
        }

        public Person(int age, string name, int id ,string password, string salt)
        {
            this.age = age;
            this.name = name;
            this.password = password;
            this.salt = salt;
            this.id = id;
        }
        public virtual string GetInfo()
        {
            return $"Name : {this.name}, ID : {this.id}";
        }
        public bool CheckIfCorrect(int id, string password)
        {
            return id == this.id && password == this.password;
        }
    }
}
