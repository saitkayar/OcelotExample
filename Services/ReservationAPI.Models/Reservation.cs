namespace ReservationAPI.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int BkgNumber { get; set; }
        public DateTime? BkgDate { get; set; }
        public DateTime? CheckingDate { get; set; }
        public DateTime? CheckoutDate { get; set; }
        public double Amount { get; set; }
    }
}