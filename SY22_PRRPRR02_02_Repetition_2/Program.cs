using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_02_Repetition_2 {
	internal class Program {
		static void Main(string[] args) {

			Console.WriteLine("Mata in ditt första tal!");
			string input1 = Console.ReadLine();
			int num1 = int.Parse(input1);

			Console.WriteLine("Mata in ditt andra tal!");
			string input2 = Console.ReadLine();
			int num2 = int.Parse(input2);

			for (int i = num1; i < num2; i++) {
				Console.Write(i);
				for (int j = 0; j < i; j++) {
					Console.Write('*');
				}
				Console.WriteLine();
			}
			
		}
	}
}
