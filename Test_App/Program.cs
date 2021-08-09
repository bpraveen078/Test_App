using System;

namespace Test_App
{
	class Program
	{
		static void Main(string[] args)
		{
			//PrintFizBuzz();
			StringReverse();
			Console.ReadLine();
		}

		static void PrintFizBuzz()
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i % 3 == 0 && i % 5 == 0) { Console.WriteLine("FizzBuzz"); }
				else if (i % 3 == 0) { Console.WriteLine("Fizz"); }
				else if (i % 5 == 0) { Console.WriteLine("Buzz"); }
			}
		}

		static void StringReverse()
		{
			string inputString = Console.ReadLine();
			char[] splitArray = inputString.ToCharArray();
			string reverseString = string.Empty;
			for (int i = 1; i <= splitArray.Length; i++)
			{
				reverseString = reverseString + splitArray[splitArray.Length - i];
			}
			Console.WriteLine(reverseString);
		}
	}
}
