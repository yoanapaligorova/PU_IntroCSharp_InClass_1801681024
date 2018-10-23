using System;
using System.IO;
using System.Text;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
			
			Console.OutputEncoding = Encoding.UTF8;
			
			//string firstName = Console.ReadLine();
			//string lastName = "Бончо";
			//string fullName = $"{firstName}{lastName}";
			//Console.WriteLine($"Candy for {fullName}!");
			string[] lines = File.ReadAllLines(@"C:\Users\fmi\Desktop\now1\PU_IntroCSharp_InClass_1801681024\W3InClass\CandyShop\files\students1.txt");

			// Display the file contents by using a foreach loop.
			Console.WriteLine("Contents of student1.txt = ");
			foreach (string line in lines)
			{
				string[] currentElement = line.Split(' ');
				string firstName = currentElement[1];
				string lastName = currentElement[3];
				string fullName = $"{firstName}{lastName}";
				int sum = 0;

				for (int i = 0; i < firstName.Length; i++)
				{
					sum += ((int)firstName[i]);
				}


				Console.WriteLine($"Candy for {fullName} => {sum}!");
			}
		}
    }
}
