using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
	class Program
	{
		static void Main(string[] args)
		{
			int days = 30;
			int saving = 2; //lewa
			int throwAwayForFalseVodka = 5;
			int monthsInYear = 12;
			double result = 0;

			try
			{
				int tankPrice = int.Parse(Console.ReadLine());
				int partyDays = int.Parse(Console.ReadLine());

				int daysWithoutVodka = days - partyDays;
				int totalMonthSavings = daysWithoutVodka * saving;
				int netSaving = totalMonthSavings - (throwAwayForFalseVodka * partyDays);

				double monthsForSaving4tank = tankPrice / netSaving;

				result = monthsForSaving4tank / monthsInYear;

			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
				Console.WriteLine("Please try again ");

			}
			if (result < 0) Console.WriteLine("Never");
			else
			{
				result = Math.Round(result, 1, MidpointRounding.AwayFromZero);
				string months = result.ToString().Split(',')[1];
				Console.WriteLine($"{(int)result}years{months} months ");

			}





		}
	}
}
