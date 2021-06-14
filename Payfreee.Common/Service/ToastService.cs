using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Payfreee.Common.Meta.Enums;
using Payfreee.Common.Service.Contracts;
using Payfreee.Common.Service.Models;

namespace Payfreee.Common.Service
{
	public class ToastService : IToastService
	{
		public ToastService() { }

		public event Action<string, ToastLevel, string> OnShow;

		public void ShowError(string message, string heading = "")
		{
			ShowToast(message, ToastLevel.Error, heading);
		}

		public void ShowInfo(string message, string heading = "")
		{
			ShowToast(message, ToastLevel.Info, heading);
		}

		public void ShowSuccess(string message, string heading = "")
		{
			ShowToast(message, ToastLevel.Success, heading);
		}

		public void ShowWarning(string message, string heading = "")
		{
			ShowToast(message, ToastLevel.Warning, heading);
		}

		public void ShowToast(string message, ToastLevel level, string heading = "")
		{
			OnShow?.Invoke(message, level, heading);
		}


	}
}
