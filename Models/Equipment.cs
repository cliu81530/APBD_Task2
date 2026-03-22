
namespace APBD_TASK2.Models
{
    public abstract class Equipment
    {
        public static int IdCounter = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}