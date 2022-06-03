using System.ComponentModel.DataAnnotations;

namespace TeamOverCinema.Models
{
	public class Users
	{
		[Key]
		public int ID { get; set; }
		[Required]
		public string? UName { get; set; }
		[Required]
		public string? Password { get; set; }
		[Required]
		[EmailAddress]
		public string? Email { get; set; }
		public int Phone { get; set; }
		public bool Admin { get; set; }
		public bool User { get; set; }
	}
}
