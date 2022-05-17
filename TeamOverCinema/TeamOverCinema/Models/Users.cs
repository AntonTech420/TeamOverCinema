using System.ComponentModel.DataAnnotations;

namespace TeamOverCinema.Models
{
    public class Users
	{
		[Key]
		public int ID { get; set; }
		public string? UName { get; set; }
		public string? Password { get; set; }
		[EmailAddress]
		public string? Email { get; set; }
		[Phone]
		public int Phone { get; set; }
		public bool Admin { get; set; }
	}
}
