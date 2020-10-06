
using System;
public abstract class Shape
{
    public abstract double GetArea();

    public abstract double GetPerimeter();


    public void printDetails()

    {
        Console.WriteLine("printing details for shape ....");
    }

}

public class Square :  Shape 
{
    public double Side{get; set;}

    public override double GetArea() => Side * Side ;

    public override double GetPerimeter() => Side + Side;
   
}

public class Rectangle :  Shape 
{
    public double length{get; set;}
    public double breadth{get; set;}

    public override double GetArea() => length* breadth  ;

    public override double GetPerimeter() => length  + breadth ;
   
}

public class Circle:  Shape 
{
    public double radius{get; set;}
   

    public override double GetArea() => Math.PI * radius * radius ;
    public override double GetPerimeter() => 2  + Math.PI +radius ;
   
}

// single inheritance 
// Multi level inheritance 


class A 
{

}


class B: A
{

}

class C : B
{

}

// mutiple inheritance 

class D: E, F
{

}

interface E
{
    
}
interface  F 
{
    
}
