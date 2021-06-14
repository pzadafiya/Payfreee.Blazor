namespace Payfreee.Common.Service.Contracts
{
	using System;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using Payfreee.Common.Meta.Enums;
	using Payfreee.Common.Service.Models;
	using Payfreee.Data.Models;

	public interface IUserService
	{
		Task<IEnumerable<User>> GetAll();
	}
}
