namespace APBD_TASK2.Models
{
    public class User
    {
        public string Id { get; } = Guid.NewGuid().ToString()[..8];
        public string Name { get; set; }
        public string Email { get; set; }
        public UserType Type { get; set; } 
        public int MaxRentalLimit => Type switch
        {
            UserType.Student => 2,
            UserType.Employee => 5,
            _ => 0
        };

        public User(string name, string email, UserType type)
        {
            Name = name;
            Email = email;
            Type = type;
        }
    }
}