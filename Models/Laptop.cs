using System.Data.Common;
using System.Text;

namespace APBD_TASK2.Models
{
    public class Laptop : Equipment
    {
        public string processor {get; set;}
        public int ram{ get; set;}


        public Laptop(string n, string p, StringBuilder r) : base(name)
        {
            this.processor = p;
            this.ram = r;
            this.DailyPenaltyRate = 15m; // Laptops have a higher penalty rate
        }

        public override string GetDescription()
        {
            return $"[Laptop] ID: {id}, Name: {Name}, CPU: {processor}, RAM: {ram}GB, Status: {Status}";
        }
    }
}   