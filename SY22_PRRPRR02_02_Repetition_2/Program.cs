using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_02_Repetition_2 {
	internal class Program {
		static void Main(string[] args) {

			List<int> listOfInts = new List<int>();

			Console.WriteLine(listOfInts.Count);

			listOfInts.Add(3);
			listOfInts.Add(5);
			listOfInts.Add(6);

			Console.WriteLine(listOfInts.Count);

			Console.WriteLine("------");

			for (int i = 0; i < listOfInts.Count; i++) {
				Console.WriteLine(listOfInts[i]);
			}

		}
	}
}
