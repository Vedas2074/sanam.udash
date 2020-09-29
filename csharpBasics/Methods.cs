
using System;
using System.Linq;
class Methods
{
    void PrintInfo()
    {
        Console.WriteLine("printing Something.....");
            
            
            sum(2.3f,3.3f);
            sum (3.3f, 2.3f , 44.4f);

            Greet("sanam","Mr");
            Greet("sita");

            byte[] numbers = {2,3,4,5,23,1,33};
            
            (byte , byte) result = FindMinMax(numbers);

            PrintCustomerDetails(age: 23 , name: "sanam", isMale: true, address:" matatritha");
    }

    void PrintSomthinf(string message)
    {
        Console.WriteLine(message);
    }
        // function overlapig two function with same name
    float Multiply(float firstNum, float secondNum)
    {
        float product =firstNum * secondNum;

        return product;
    }

    float Multiply(float firstNum, float secondNum, float thirdNum)
    {
        float product =firstNum * secondNum * thirdNum ;

        return product;
    }

    // for variable numbers of arguments use params key word
    double sum(params double[]  numbers)
    {
        double sum=0;
        foreach(double num in numbers)
        {
             sum = sum + num;
        }
        return sum;
    }

    // optional arguments

    string Greet(string name, string prefix = "Miss")
        {
        string fullName =$"{prefix}, {name}"; // String interpolation

            return fullName;
        }

        //  return multiple values : usint tuples

        (byte, byte)   FindMinMax (byte[] numbers)
        {
         byte max =   numbers.Max();
         byte min = numbers.Min();

         return (min , max);
            
        }   

        void PrintCustomerDetails( string name,string address, byte age, bool isMale)
        {
            Console.WriteLine($"{name},{age},{address}");
        }

        // float Subtract(float firstNum, float secondNum)
        // {
        //     return firstNum - secondNum;
        // }

        // instend we can use 

        float subtract(float firstNum, float secondNum) => firstNum - secondNum;









}