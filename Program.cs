using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputToFile
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Borrowed heavily from Dan Parker: https://www.youtube.com/watch?v=glyfSt5mh1Y

			// Take 5 string inputs -> Store them in an array
			  // -> Write the array to text file 
			
			// Define text variable 
			string[] words = new string[5];

		
			Console.WriteLine ("Enter 5 words to write to a text file: ");

			for (int i =0; i < 5; i++) 
			{
				words [i] = Console.ReadLine(); 
			}
			// Write this array to a text file 
			StreamWriter SW = new StreamWriter(@"words.txt");

			for (int i = 0; i < 5; i++) 
			{
				SW.WriteLine (words [i]);
			}
			SW.Close();
		}

	}
}
