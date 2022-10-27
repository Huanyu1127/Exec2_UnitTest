using Ispan.TaiwainStockUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec2_UnitTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入西元年/月/日 時:分:秒 ：");
			string input = Console.ReadLine();
			DateTime dt = new DateTime();
			var datetime = new TaiwainStockUtility();
			bool isTime = false;
			try
			{
				dt = datetime.GetDt(input);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
			try
			{
				isTime=datetime.IsTradingTime(dt);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return ;
			}
			Console.WriteLine($"您輸入的時間是{dt}在營業時間內");
		}
	}
}
