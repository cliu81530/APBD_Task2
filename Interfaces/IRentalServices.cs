namespace APBD_TASK2.Interfaces
{
    public interface IRentalServices
    {
        void RentEquipment(int equipmentId, int customerId);
        void ReturnEquipment(int equipmentId, int customerId);
        void GenerateReport();
    }
}