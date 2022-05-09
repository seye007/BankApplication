namespace Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private static int id;

        public Customer(string firstName, string lastName, string email, string password)
        {
            CustomerId = ++id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }


    }
}
