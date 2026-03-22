using System.Data.Common;
using System.Text;

namespace APBD_TASK2.Models
{
    public class Laptop : Equipment
    {
        public string processor {get; set;}
        public int ram{ get; set;}


        public Laptop(string name, string p, int r) : base(name)
        {
            this.processor = p;
            this.ram = r;
        }

        public override string GetDescription()
        {
            return $"[Laptop] ID: {id}, Name: {Name}, CPU: {processor}, RAM: {ram}GB, Status: {Status}";
        }
    }
}   