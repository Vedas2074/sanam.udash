using System;
using AccessModifierAndMethods;
using LearningClasses;


class Program
{



    static void Main()
    {
        // SelectionStatement selectionStatement = new SelectionStatement();
        // selectionStatement.LearnSwitchCases();

        // AccessModifier accessModifier = new AccessModifier;
        // accessModifier.DoSomething();

        // Person person = new Person;
        // person.name = "Sanam";
        // person.Age = 179;

        // var x = person.Age;
        // var y= person.Address;

        // var person1 = new Person("sanam","ktm",21);
        // person1.Name = "sanam";
        // person1.Address= "ktm";
        // person1.Age= 21;

        // var person2 = new Person("susan", "ktm",22);
        // var person3 = new Person();
        // Person.scientifiName // to access static variabale use class name as object

        // var y = Math.Sqrt(9);     //static member sqrt of Math class


        // generic function 

        // Calculator calculator = new Calculator;
        // var x =calculator.Sum<int>(2,3);



        // inheritance example
        Rectangle rectangle = new Rectangle(3, 3);

        rectangle.length = 2.3;
        rectangle.Breadth = 4.4;
        var result = rectangle.GetArea();

        // object initializer 
        Rectangle a = new Rectangle(3.3, 23.4)
        {
            length = 4.5

        };

        //inheritane example with
        Rectangle r = new Rectangle(3.4, 3.4);

        var rArea = r.GetArea();
        var rparameter = r.GetPerimeter();
        var diagonal= r.GETDiagonalLength(); // interface used by the object of the recatangle class 

        
      

        Square s = new Square(3.3);
        var sperimeter = s.GetPerimeter();


        Shape ee = new Rectangle(3.4,3.1); // we can use base class to crete inherited object.

            ee.printDetails();

            // ee.GETDiagonalLength() // cannot use by this object because it is created using shape class which donot use interface
            






    }
}

