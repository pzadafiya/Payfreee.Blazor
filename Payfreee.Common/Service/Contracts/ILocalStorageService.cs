namespace Payfreee.Common.Service.Contracts
{
	using System;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using Payfreee.Common.Meta.Enums;
	using Payfreee.Common.Service.Models;

    public interface ILocalStorageService
    {
        Task<T> GetItem<T>(string key);
        Task SetItem<T>(string key, T value);
        Task RemoveItem(string key);
    }

}
