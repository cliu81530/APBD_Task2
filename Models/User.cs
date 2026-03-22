namespace APBD_TASK2.Models
{
    public class User
    {
        public string Id { get; } = Guid.NewGuid().ToString()[..8];
        public string Name { get; set; }
        public string Email { get; set; }
        public UserType Type { get; set; } 
        public int MaxRentalLimit { get; set; } => Type switch
        {
            UserType.Regular => 2,
            UserType.Premium => 5,
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