using System.ComponentModel.DataAnnotations;

namespace Workshop_1.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        //question mark indicates that it is nullable
        public decimal Price { get; set; }
    }
}
