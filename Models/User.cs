namespace APBD_TASK2.Models
{
    public class User 
    {
        public static int IdCounter = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public UserType Type { get; set; }
  
        public User(string name,string email, UserType type)
        {
            Id = IdCounter++;
            Name = name;
            Type = type;
            Email = email;
        }  
    }
}