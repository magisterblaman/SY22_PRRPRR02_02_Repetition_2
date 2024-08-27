using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_02_Repetition_2 {
	internal class Program {
		static void Main(string[] args) {

			List<int> uniqueNumbers = new List<int>();

			bool run = true;

			while (run) {
				Console.Clear();

				Console.WriteLine("Vänligen mata in ett heltal");

				string input = Console.ReadLine();
				int number = int.Parse(input);


				if (uniqueNumbers.Contains(number)) {
					int index = uniqueNumbers.IndexOf(number);

					uniqueNumbers.RemoveRange(0, index);
				} else {
					uniqueNumbers.Add(number);
				}


				Console.WriteLine("Vill du fortsätta?");
				string response = Console.ReadLine();
				if (response == "nej") {
					run = false;
				}

			}

		}
	}
}
