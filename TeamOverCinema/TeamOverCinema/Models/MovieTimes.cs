using System.ComponentModel.DataAnnotations;

namespace TeamOverCinema.Models
{
    public class MovieTimes
    {
        [Key]
        public int MovieId { get; set; }
        public string? MovieName { get; set; }
        public DateTime? MovieDate { get; set; }
    }
}
