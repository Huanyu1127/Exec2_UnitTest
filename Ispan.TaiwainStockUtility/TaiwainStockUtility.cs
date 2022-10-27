using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan.TaiwainStockUtility
{
	public class TaiwainStockUtility
	{
		public bool IsTradingTime(DateTime dt)
		{
			int weekday = (int)dt.DayOfWeek  ;
			int dtHours = dt.Hour * 100;
			int dtMinute=dt.Minute ;
			int dtTime = dtHours + dtMinute;
			if (weekday >= 1 && weekday <= 5)
			{
				return (dtTime >= 900 && dtTime <= 1330) 
						? true : throw new Exception("時間要在9:00~13:30內");
			}
			else { throw new Exception("交易要在星期一到星期五"); }
		}
		public DateTime GetDt(string input)
		{
			bool isDateTime = DateTime.TryParse(input, out DateTime dt);
			return isDateTime ? dt : throw new Exception("請輸入正確日期");
		}

	}
}
