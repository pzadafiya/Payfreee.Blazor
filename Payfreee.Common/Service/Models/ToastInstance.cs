namespace Payfreee.Common.Service.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class ToastInstance
	{
		public Guid Id { get; set; }
		public DateTime TimeStamp { get; set; }
		public ToastModel ToastModel { get; set; }
	}

	public class ToastModel
	{
		public ToastModel(string heading, string message, string baseClass, string additionalClasses, string iconClass)
		{
			Heading = heading;
			Message = message;
			BaseClass = baseClass;
			AdditionalClasses = additionalClasses;
			IconClass = iconClass;
		}

		public string Heading { get; set; }
		public string Message { get; set; }
		public string BaseClass { get; set; }
		public string AdditionalClasses { get; set; }
		public string IconClass { get; set; }
	}
}
