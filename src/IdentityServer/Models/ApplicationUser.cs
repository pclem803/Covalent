using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Models
{
	public class ApplicationUser : IdentityUser
	{
		public bool IsEnabled { get; set; }
		public string EmployeeId { get; set; }
	}
}