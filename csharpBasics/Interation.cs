
using System;


class IterationStatement
{
    // Pascal casing : IterationStatement for method and class
    // camel Case: iterationStatement for variable

    static void Main1()
    {
        IterationStatement interationStatement = new IterationStatement();
        interationStatement.LearnWhileLoops();
    }
    public void LearnForLoops()
    {
        int i;

        for (i = 0; i < 10; i++)
        {
            Console.WriteLine("hello world!!");
        }
        int[] numbers = { 1, 2, 3, 4, 5, 66, 6 };

        for (int x = 0; x < numbers.Length; x++)
        {

        }

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }

        }


    }

    void LearnWhileLoops()
    {
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine("Hello World !");
            i++;
        }

        String confirm = "Y";

        while (confirm == "Y")
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("do you want to reprint??");
            confirm = Console.ReadLine();
        }

        string confirm1 = "Y";

        do
        {

            Console.WriteLine("Hello World!");
            Console.WriteLine("do you want to reprint??");
            confirm1= Console.ReadLine();

        }
        while(confirm1 == "Y");
    }
}