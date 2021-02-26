namespace CoursesMVC.Models
{
    public class PublisherBook
    {
        public int BookId { get; set; }
        public int PublisherId { get; set; }

        public Publisher Publisher { get; set; }
        public Book Book { get; set; }
    }
}