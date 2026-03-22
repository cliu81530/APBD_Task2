using System;
using System.Security.Cryptography.X509Certificates;
namespace APBD_TASK2.Models
{
    public class Rental
    {
        public Guid Id { get; } = Guid.NewGuid();

        public User Renter { get; set; }
        public Equipment Item { get; set; }

        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; private set; }
        public bool IsReturned => ReturnDate.HasValue;
        public Rental(User renter, Equipment item, 
                    DateTime rentalDate, int durationDays)
        {
            Renter = renter;
            Item = item;
            RentalDate = rentalDate;
            DueDate = rentalDate.AddDays(durationDays);
        }
        public void ReturnItem(DateTime returnDate)
        {
            if (IsReturned)
                throw new InvalidOperationException("Item has already been returned.");

            ReturnDate = returnDate;
            Item.Status = Enums.EquipmentStatus.Available;
        }

        public decimal CalculatePenalty()
        {
            if (!IsReturned)
                throw new InvalidOperationException("Item has not been returned yet.");

            if (ReturnDate <= DueDate)
                return 0m;

            int lateDays = (ReturnDate.Value - DueDate).Days;
            return lateDays * Item.DailyPenaltyRate;
        }
    }
}