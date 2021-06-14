using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payfreee.Data.Models
{
	public class User
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		[StringLength(35)]
		public string FirstName { get; set; }

		[Required]
		[StringLength(35)]
		public string LastName { get; set; }

		public string Username { get; set; }

		[Required]
		[StringLength(75)]
		public string Email { get; set; }

		public string Password { get; set; }

		[StringLength(12)]
		public string PhoneNumber { get; set; }

		public bool IsActive { get; set; }
		public byte SecurityRoleId { get; set; }
		public DateTime CreatedDateUtc { get; set; }
		public int CreatedUserId { get; set; }
		public DateTime? UpdatedDateUtc { get; set; }
		public int? UpdatedUserId { get; set; }
		public string Token { get; set; }
	}
}
