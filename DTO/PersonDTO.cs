namespace DTO
{
    public abstract class PersonDTO
    {
        protected int age;
        protected string name;
        protected string username;
        protected string password;
        protected int id;
        protected string salt;
        public int ID { get => this.id; }
        public string Name { get => this.name; }
        public int Age { get => this.age; }

        public string Password { get => this.password; }
        public string Salt { get => this.salt; }
        public PersonDTO(string name, int id, string password, string salt)
        {
            this.name = name;
            this.password = password;
            this.salt = salt;
            this.id = id;
        }

        public PersonDTO(int age, string name, int id, string password, string salt)
        {
            this.age = age;
            this.name = name;
            this.password = password;
            this.salt = salt;
            this.id = id;
        }
    }
}