namespace Payfreee.Common.Service.Contracts
{
	using System;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using Payfreee.Common.Meta.Enums;
	using Payfreee.Common.Service.Models;
	using Payfreee.Data.Models;

	public interface IAuthenticationService
    {
        User User { get; }
        Task Initialize();
        Task Login(string username, string password);
        Task Logout();
    }

}
