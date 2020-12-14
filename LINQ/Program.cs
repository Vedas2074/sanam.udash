using System;
using System.Linq;
using System.Collections.Generic;


namespace LINQ
{
    class Program
    {
         static void Main(string[] args)
        {
            // LINQ languae INtegreted Query

            int[] numbers = {12,323,434,53,53,545,452345,524,542,545325425}; 
            // method Syntax
           var result= numbers.Where(num => num > 50).Select(num => num); // result datatype is INeumerable which is generic interface or datatypes 
        
            // Query syntax
            var result2 = from num in numbers where num > 50 select num; 

            // Restriction - where

            var results3 = from num in  numbers where num >50 && num < 60 select num; 

            // projections - select 
            var result4 = from num in numbers select num * num;
            
            var result5 = from num in numbers where num % 2 ==0 select num * num;
            // Ordering - order, order by descending 
            var result67 =  from num in numbers orderby num descending select num;

            //  partitaioning : take method syntax not avaiable in query syntax
            var result7 = numbers.Take(5);
            var result8 = numbers.Skip(5).Take(5);
            // quantifier 
            var result9 = numbers.Any(num => num % 2 == 0); // returns ture or false 
            var result10 = numbers.All(num => num % 2 == 0); // return false
            var result11 = numbers.Contains(23);

            // Generations 
            var result12= Enumerable.Range(1,1100);
            var result123= Enumerable.Repeat("hello World",20); // to repeat same code for certain time 



                void LearnLinqComplexCollection()
                {

                    Country c1 = new Country("Nepal","kathmandu",1234434,"Asia");
                
                    // countries.Add(c1); // adding the object c1 in List(countries) of object 
                    Country c2 = new Country("india","Delhi",232132132323213,"asia", DateTime.Parse("1947/11/1"));
                    Country c3 = new Country("England","London",232132323213,"Europe");
                    Country c4 = new Country("Bhutan","Dhaka",132323213,"asia");
                    Country c5 = new Country("Australia","Sydeny",232133563213,"austrealia");
                    Country c6 = new Country("Russia","Moscow",2321324544523453213,"Europe");
                    Country c7 = new Country("America","Wasington D C",23213332132323213,"North America");
                    List<Country> countries = new List<Country> {c1,c2,c3,c4,c5,c7};                    // creating the list of object by using generic method

                    // list of the asian country

                    var result = from c in countries 
                                    where c.Continent == "asia"
                                    select c.Name;
                                
                    // list all asian country name which are neer been  invaded

                        // var result1 = from c in countries
                                            
                        //                 where ToString(c.IndependenceDay)  ==' '
                        //                 select c.Name;

                    // List of all eurapion country in ascending order that has poulation less than 500k

                    var result2 = from c in countries
                                    orderby c.Name 
                                    where c.Population < 500000
                                    select c.Name;




                }
            
    

        }
    }
}
