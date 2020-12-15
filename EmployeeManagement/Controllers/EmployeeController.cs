using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
public class  EmployeeController : Controller
{
    public IActionResult index()  // return type is actionresult whict is generic type
    {                               // name of the method must be same as view name 
        
        Person emp1 = new Person("Sanam", "Udash", "Matatritha", 'M', 2000);
        Person emp2 = new Person("Sunil", "Kunwar", "Dhading", 'M', 2000);
        Person emp3 = new Person("Susan", "Shrestha", "Chhapali", 'M', 2000);
        Person emp4 = new Person("Raman", "Thapa", "Mahadevthan", 'M', 2000);
        Person emp5 = new Person("Amrit", "Budha", "Satungal", 'M', 2000);
        Person emp6 = new Person("Bikash", "Fadera", "Highvision", 'M', 2000);

           List<Person> employees = new List<Person>() {emp1, emp2, emp3 , emp4 , emp5 , emp6 };

       



        return View(employees);
        
    }
}

