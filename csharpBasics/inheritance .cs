
using System;
public abstract class Shape
{
    public abstract double GetArea();

    public abstract double GetPerimeter();


    public virtual void printDetails() // virtual key word is used to tell child class to change this function

    {
        Console.WriteLine("printing details for shape ....");
    }

}
    public interface IDiagonalComputable
    {
        public double GETDiagonalLength();
       
    }

public class Square :  Rectangle
{       
    // base in used to access the base class
    public Square(double s): base(s,s)
    {
        
    }
    public double Side{get; set;}

    public override double GetArea() => Side * Side ;

    
   

    public override double GetPerimeter() => Side + Side;
   
}


public class Rectangle :  Shape,IDiagonalComputable
{
    public Rectangle(double l, double b)
    {
        this.length=l;
        this.Breadth=b;
    }
    public double length{get; set;}
    public double Breadth{get; set;}

    public override double GetArea() => length* Breadth  ;

public double GETDiagonalLength()=>Math.Sqrt(length*length+Breadth*Breadth);
   

    public override double GetPerimeter() => length  + Breadth ;

    public override void printDetails()
    {
        Console.WriteLine("printing details for Rectangle"); // $ sign is used as string interpolation technique
        Console.WriteLine($"Length:{length}, Breadth:{Breadth}");
        Console.WriteLine($"area:{this.GetArea()} , perimeter:{this.GetPerimeter()}");
    }
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
