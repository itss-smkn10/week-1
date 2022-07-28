class Program
{
    static void Main(string[] args)
    {
        int correctAnswer = 0;

        Console.WriteLine("Enter name: ");

        string name = Console.ReadLine();
        Console.WriteLine("Welcome " + name + ", to the Quiz!");

        Console.WriteLine();
        Console.WriteLine("Arithmetic Operators:");

        Console.WriteLine("1. 4 x 2 =");
        int multiply = Convert.ToInt32(Console.ReadLine());
        if (multiply == 4 * 2)
        {
            Console.WriteLine("Answer is Correct");
            correctAnswer++;
        }
        else
        {
            Console.WriteLine("Answer is Wrong");
        }

        Console.WriteLine();

        Console.WriteLine("2. 4 + 2 = ");
        int addition = Convert.ToInt32(Console.ReadLine());
        if (addition == 4 + 2)
        {
            Console.WriteLine("Answer is Correct");
            correctAnswer++;
        }
        else
        {
            Console.WriteLine("Answer is Wrong");
        }

        Console.WriteLine();

        Console.WriteLine("3. 4 - 2 = ");
        int substraction = Convert.ToInt32(Console.ReadLine());
        if (substraction == 4 - 2)
        {
            Console.WriteLine("Answer is Correct");
            correctAnswer++;
        }
        else
        {
            Console.WriteLine("Answer is Wrong");
        }

        Console.WriteLine();
        Console.WriteLine("Comparison + Arithmetic Operators:");

        Console.WriteLine("1. Is 4 is even ?");
        bool is4isEven = Convert.ToBoolean(Console.ReadLine());
        if (is4isEven == (4 % 2 == 0))
        {
            Console.WriteLine("Answer is Correct");
            correctAnswer++;
        }
        else
        {
            Console.WriteLine("Answer is Wrong");
        }

        Console.WriteLine();

        Console.WriteLine("2. Is 4 is odd ?");
        bool is4isOdd = Convert.ToBoolean(Console.ReadLine());
        if (is4isOdd == (4 % 2 != 0))
        {
            Console.WriteLine("Answer is Correct");
            correctAnswer++;
        }
        else
        {
            Console.WriteLine("Answer is Wrong");
        }

        Console.WriteLine();

        Console.WriteLine("3. Is 4 is greater than 2?");
        bool is4isGreaterThan2 = Convert.ToBoolean(Console.ReadLine());
        if (is4isGreaterThan2 == (4 > 2))
        {
            Console.WriteLine("Answer is Correct");
            correctAnswer++;
        }
        else
        {
            Console.WriteLine("Answer is Wrong");
        }

        Console.WriteLine();
        Console.WriteLine("Logical Operators:");

        Console.WriteLine("1. Is 4 is greater than 2 and 4 is odd?");
        bool is4IsGreaterThan2And4isOdd = Convert.ToBoolean(Console.ReadLine());
        if (is4IsGreaterThan2And4isOdd == (4 % 2 == 1 && 4 > 2))
        {
            Console.WriteLine("Answer is Correct");
            correctAnswer++;
        }
        else
        {
            Console.WriteLine("Answer is Wrong");
        }

        Console.WriteLine();
        Console.WriteLine("Hi " + name + ", Your correct answer is : " + correctAnswer);
    }
}