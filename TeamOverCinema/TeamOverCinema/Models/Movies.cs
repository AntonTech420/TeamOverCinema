using System.ComponentModel.DataAnnotations;

namespace TeamOverCinema.Models
{
    public class Movies
	{
		[Key]
		public int ID { get; set; }
		public string? MovieImg { get; set; }
		public string? MovieName { get; set; }
		public string? ReleaseDate { get; set; }
		public bool ComingSoon { get; set; }
		public string Seats { get; set; }
		public string SeatsTaken { get; set; }
	}
}
