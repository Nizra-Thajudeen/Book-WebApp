namespace BookWebApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string BookCategory { get; set; }
        public string Description { get; set; }
        //public IFormFile BookImage { get; set; }
        public Book()
        {

        }
    }
}
