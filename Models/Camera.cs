namespace APBD_TASK2.Models
{
    public class Camera: Equipment
    {
        public int Megapixels { get; set; }
        public string LensType { get; set; }

        public override decimal DailyPenaltyRate => 15m;

        public Camera(string name, int megapixels, string lensType) : base(name)
        {
            Megapixels = megapixels;
            LensType = lensType;
        }

        public override string GetDescription()
        {
            return $"Camera: {Name}, {Megapixels}MP, Lens: {LensType}";
        }
    }
}