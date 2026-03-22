using APBD_TASK2.Models;
using APBD_TASK2.Enums;
using APBD_TASK2.Interfaces;

namespace APBD_TASK2.Services
{
    public class RentalService : IRentalService
    {
        private readonly List<Rental> _rentals = new();
        private readonly List<Equipment> _equipmentInventory = new();
        private readonly List<User> _users = new();

        public void RentEquipment(User renter, Equipment item, DateTime rentalDate, int durationDays)
        {
            if (!item.IsAvailable())
                throw new InvalidOperationException($"Equipment{item.Name} is not available.");
            
            int currentCount = _rentals.Count(r => r.Renter.Id == renter.Id && !r.IsReturned);
            if (currentCount >= renter.MaxRentalLimit)
                throw new InvalidOperationException($"User {renter.Name} has reached the maximum rental limit of {renter.MaxRentalLimit}.");
            
            item.Status = EquipmentStatus.Rented;
            var rental = new Rental(renter, item, rentalDate, durationDays);
            _rentals.Add(rental);
            Console.WriteLine($"User {renter.Name} rented {item.Name} on {rentalDate:d} for {durationDays} days.");
        }

        public void ReturnEquipment(Rental rental, DateTime returnDate)
        {

            if (rental == null)
                throw new ArgumentNullException(nameof(rental));
            if (rental.IsReturned)
                throw new InvalidOperationException("This rental has already been returned.");

            rental.ReturnItem(returnDate);
        }

        public void CalculatePenalty(Rental rental)
        {
            if (rental == null)
                throw new ArgumentNullException(nameof(rental));
            if (!rental.IsReturned)
                throw new InvalidOperationException("Cannot calculate penalty for an active rental.");

            Console.WriteLine($"Penalty for rental {rental.Id}: {rental.CalculatePenalty()}");
        }
    
    }
}