using System;
using System.Dynamic;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using APBD_TASK2.Enums;


namespace APBD_TASK2.Models
{
    public abstract class Equipment
    {
        public Guild Id{get; } = Guid.NewGuid().ToString()[..8];

        public string Name { get; set; }
        public EquipmentStatus Status { get; set; }
            = EquipmentStatus.Available;

        public virtual decimal DailyPenaltyRate { get; protected set; }
            = 10m;

        protected Equipment(string name)      
        {
            Name = name;
        }
        public abstract string GetDescription();

        public bool IsAvailable()
        {
            return Status == EquipmentStatus.Available;
        }
    }
}