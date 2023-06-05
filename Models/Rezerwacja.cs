namespace Reservation.Models
{
    public class Rezerwacja
    {
        public int Id { get; set; }
        public int SalaId { get; set; }
        public DateTime Data { get; set; }
        public bool Zatwierdzona { get; set; }
        public int UzytkownikId { get; set; }
    }
}
