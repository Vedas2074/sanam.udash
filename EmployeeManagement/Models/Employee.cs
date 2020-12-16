
using System;
using System.Collections.Generic;

public class Employee
{
    public string firstname {get; set;}

    public string SurName {get; set;}

    public string Address { get; set;}

    public char Gender {get; set;} = 'M';

    public double Salary {get; set;}


    public Employee(string fname,string lname, string Address, char gender, double salary)
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
