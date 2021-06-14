namespace Payfreee.Common.Service.Contracts
{
	using System;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using Payfreee.Common.Meta.Enums;
	using Payfreee.Common.Service.Models;

	public interface IHttpService
	{
		Task<T> Get<T>(string uri);
		Task<T> Post<T>(string uri, object value);
	}

}
