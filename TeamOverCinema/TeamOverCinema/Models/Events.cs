using System.ComponentModel.DataAnnotations;

namespace TeamOverCinema.Models
{
    public class Events
	{
		[Key]
		public int ID { get; set; }
		public string? EventName { get; set; }
		public string? EventInfo { get; set; }
		public string? EventDuration { get; set; }
		public string? EventCode { get; set; }
	}
}
