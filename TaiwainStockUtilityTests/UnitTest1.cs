using Ispan.TaiwainStockUtility;

namespace TaiwainStockUtilityTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase("2022/10/27 13:30:00",true)]
		[TestCase("2022/10/27 9:30:00", true)]
		public void Test1_�P���@�줭_�E�I��@�I�b(string input,bool answer)
		{
			DateTime dt = new DateTime();
			var datetime = new TaiwainStockUtility();
			bool isTime = false;
			try
			{
				dt = datetime.GetDt(input);
				return;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
			try
			{
				isTime = datetime.IsTradingTime(dt);
				return;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
			Assert.AreEqual(isTime,answer);
		}
		[TestCase("2022/10/27 8:30:00", false)]
		public void Test1_�P���@�줭_��~�ɶ����~(string input, bool answer)
		{
			DateTime dt = new DateTime();
			var datetime = new TaiwainStockUtility();
			bool isTime = false;
			try
			{
				dt = datetime.GetDt(input);
				return;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
			try
			{
				isTime = datetime.IsTradingTime(dt);
				return;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
			Assert.AreEqual(isTime, answer);
		}
		[TestCase("2022/10/29 9:30:00", false)]
		public void Test1_�P������_��~�ɶ�����(string input, bool answer)
		{
			DateTime dt = new DateTime();
			var datetime = new TaiwainStockUtility();
			bool isTime = false;
			try
			{
				dt = datetime.GetDt(input);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
			try
			{
				isTime = datetime.IsTradingTime(dt);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
			Assert.AreEqual(isTime, answer);
		}
		[TestCase("2022/10/29 9:30:00", false)]
		public void Test1_�P������_��~�ɶ����~(string input, bool answer)
		{
			DateTime dt = new DateTime();
			var datetime = new TaiwainStockUtility();
			bool isTime = false;
			try
			{
				dt = datetime.GetDt(input);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
			try
			{
				isTime = datetime.IsTradingTime(dt);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
			Assert.AreEqual(isTime, answer);
		}
	}
}