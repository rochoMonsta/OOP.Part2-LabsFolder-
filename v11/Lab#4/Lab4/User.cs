namespace Lab4
{
    class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public User() { }
        public User(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }
        public override string ToString()
        {
            return $"{Login} - {Password}";
        }
    }
}
