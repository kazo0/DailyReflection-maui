using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace DailyReflection.Services.Share
{
	public interface IShareService
	{
		Task ShareText(string title, string body);
	}
}
