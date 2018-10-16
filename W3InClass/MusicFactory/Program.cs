using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Do you want to play some music ?");
			string answer = Console.ReadLine();
			if (answer == "Yes")
			{
				using (SoundPlayer player = new SoundPlayer(@"C:\Users\fmi\Desktop\w3\PU_IntroCSharp_InClass_1801681024\W3InClass\MusicFactory\music"))
				{

					Console.WriteLine("Now plying ...");
					player.PlaySync();
					while (true)
					{
						Console.Write(".");
					}
				}
					
			}
			else if (answer == "No")
			{
				Console.WriteLine("Goodbye!");
			}
			else
			{
				Console.WriteLine("Wrong input");
			}

			

		}
	}
}
