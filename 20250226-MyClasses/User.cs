namespace _20250226_MyClasses
{
    public class User : IEquatable<User>, IComparable<User>
    {
        private string name = string.Empty;
        private string email = string.Empty;

        public string Name {
            get => this.name;
            set => this.name = value;
        }
        public string Email {
            get {
                return this.email;
            }
            private set
            {
                if (value.Contains("@") == true && value.Length > 3)
                {
                    this.email = value;
                    return;
                }
                throw new ArgumentException("5678: Invalid email address");
            }
        }

        public User(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        public User(string name) : this(name, "default@gov.hu")
        {
            
        }

        public override string ToString()
        {
            return $"{this.Name}: {this.Email}";
        }

        public bool Equals(User? other)
        {
            return this.name == other?.name;
        }

        public int CompareTo(User? other)
        {
            return this.Name.CompareTo(other?.Name);
        }
    }
}
