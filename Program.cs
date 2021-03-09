using System;

namespace SplitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "This is a split up sentence.";

            string[] splitArray = first.Split(' ');

            string thisWord = splitArray[0];

            Console.WriteLine(thisWord);
        }
    }
}
