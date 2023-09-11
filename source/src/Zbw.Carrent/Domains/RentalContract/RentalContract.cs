namespace Zbw.Carrent.Domains.RentalContract
{
    public class RentalContract
    {
        public int ContractNr { get; set; }

        public int ReservationId { get; set; }
        public virtual Reservation.Reservation Reservation { get; set; }

        public int CarId { get; set; }
        public virtual Car.Car Car { get; set; }
    }
}
