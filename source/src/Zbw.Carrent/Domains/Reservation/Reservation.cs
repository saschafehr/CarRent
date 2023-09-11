namespace Zbw.Carrent.Domains.Reservation
{
    public class Reservation
    {
        public Reservation()
        {

        }
        public int ReservationNr { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalCost { get; set; }

        //public int RentalContractId { get; set; }
        public virtual ICollection<RentalContract.RentalContract> RentalContracts { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer.Customer Customers { get; set; }
    }
}
