namespace Payfreee.Common.Service.Contracts
{
	using System;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using Payfreee.Common.Meta.Enums;
	using Payfreee.Common.Service.Models;

	public interface IToastService
	{

#pragma warning disable CA1003 // Use generic event handler instances
		event Action<string, ToastLevel, string> OnShow;
#pragma warning restore CA1003 // Use generic event handler instances

		void ShowInfo(string message, string heading = "");
		void ShowSuccess(string message, string heading = "");
		void ShowWarning(string message, string heading = "");
		void ShowError(string message, string heading = "");
		void ShowToast(string message, ToastLevel level, string heading = "");
	}
}
