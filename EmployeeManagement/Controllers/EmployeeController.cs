using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
public class  EmployeeController : Controller
{
    // this is action for website
    public IActionResult index()  // return type is actionresult whict is generic type
    {                               // name of the method must be same as view name 
        var employees = Employee.GetEmployees(); // calling the getEmployees method of public class Employee 
        return View(employees);
        
    }

    // another action added with name  detail
    //  here the value of the argument is taken through get method because by default the action is in http get method 
    public IActionResult Detail(string firstName)  
    {
            var Employees = Employee.GetEmployees();
             var employee=Employees.FirstOrDefault(x=>x.firstname==firstName);

        return View(employee); // mvc prodgram will search for the cshtml file same name as view() method parameter in views folder under the same name as controller 
                        // if there is no parameter it will search same name as action name 
    
    }
    public IActionResult addEmployee() // default http method request or respose is get 
    {
        return View();
    }

    [HttpPost]   // setting the upcomming action request method to post method 
   
    public string addEmployee([FromForm]Employee employee)
    {
            return " Record Saved";
    } 
   
}

