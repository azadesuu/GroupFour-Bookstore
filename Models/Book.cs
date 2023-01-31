namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string BookID { get; set; }
        public bool isBorrowed { get; set; } = false;
        public int? BookingNumber { get; set;}
    }
}
