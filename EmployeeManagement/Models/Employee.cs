
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee
{   [Required] // client side validation in form fill up 
    [Display(Name = "First Name")] // yesla garda firsname display huda xuteyara aaux i .e data anotations
    public string firstname {get; set;}
            
             [Required]
             [Display(Name = "Sur Name")]
    public string SurName {get; set;}
             
    public string Address { get; set;}
            
    public char? Gender {get; set;} = 'M'; // here ? will make the gender parameter nullable in validation process
            
    public double? Salary {get; set;} // salary is nullable

    public Employee()
    {

    }
    public Employee(string fname ="sanam",string lname= "Udash", string Address= "Matatritha", char gender= 'M', double salary = 10)
    {
        this.firstname = fname;
        this.SurName = lname;
        this .Address = Address;
        this.Gender = gender;
        this.Salary = salary;
    }

    public static List<Employee> GetEmployees()
    {
        Employee emp1 = new Employee("Sanam", "Udash", "Matatritha", 'M', 2000);
        Employee emp2 = new Employee("Sunil", "Kunwar", "Dhading", 'M', 2000);
        Employee emp3 = new Employee("Susan", "Shrestha", "Chhapali", 'M', 2000);
        Employee emp4 = new Employee("Raman", "Thapa", "Mahadevthan", 'M', 2000);
        Employee emp5 = new Employee("Amrit", "Budha", "Satungal", 'M', 2000);
        Employee emp6 = new Employee("Bikash", "Fadera", "Highvision", 'M', 2000);

           List<Employee> employees = new List<Employee>() {emp1, emp2, emp3 , emp4 , emp5 , emp6 };

           return employees;
    }




}
