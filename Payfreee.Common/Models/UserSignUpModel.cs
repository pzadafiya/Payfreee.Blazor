﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payfreee.Common.Models
{
	public class UserSignUpModel
	{
		[Required]
		public string Email { get; set; }

		[Required]
		public string FirstName { get; set; }
		
		[Required]
		public string LastName { get; set; }
		
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Compare("Password")]
		public string ConfirmPassword { get; set; }
	}
}
