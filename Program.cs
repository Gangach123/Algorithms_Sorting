using System;
namespace Algorithm_Problems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to algorithm problems");
            Bubble_Sort bubbleSort = new Bubble_Sort();
            bubbleSort.UserInput<string>();

            Word_List wordList = new Word_List();
            wordList.UserInput<string>();
        }
    }
}