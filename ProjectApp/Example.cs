using System;

class Example
{
    static void Main(string[] args)
    {
        /* bool isExit = false;
         while (!isExit)
         {
             Console.WriteLine("Want to exit this program?");
             isExit = bool.Parse(Console.ReadLine());
         }*/

        /*char[] abc = { 'a', 'b' };
        for (int i = 0; i < abc.Length; i++)
        {
            Console.WriteLine(abc[i]);
        }/*

        /*int x = 0;
        while (x < abc.Length)
        {
            Console.WriteLine(abc[x]);
            x++;
        }*/

        int[] initialNumber = { 1, 2, 3 };
        List<int> numberList = new List<int>(initialNumber);

        int userInput = int.Parse(Console.ReadLine());

        numberList.Add(userInput);

        numberList.Add(32);
        numberList.Add(21);
        numberList.Add(45);
        numberList.Add(11);
        numberList.Add(89);

        for (int i = 0; i < numberList.Count; i++)
        {
            Console.WriteLine(numberList[i]);
        }
    }
}
