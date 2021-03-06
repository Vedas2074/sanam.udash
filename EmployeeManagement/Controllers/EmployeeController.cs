using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagement.data;
public class  EmployeeController : Controller
{
    // creating database instance 
        private readonly EMSContext db;     
        public EmployeeController(EMSContext _db)
        {
            db = _db;
        }

    // this is action for website
    public IActionResult index()                   
    {                                            
        // var db = new EMSContext();     // creating the database instance 
        var employees = db.Employees.ToList();       // Retriving all the data from Employees table from database 
        return View(employees);
        
    }

    // another action added with name  detail
    //  here the value of the argument is taken through get method because by default the action is in http get method 
    public IActionResult Detail(int id)  
    {
             var employees = db.Employees.ToList(); 
             var employee=employees.FirstOrDefault(x=>x.Id==id);

        return View(employee); // mvc prodgram will search for the cshtml file same name as view() method parameter in views folder under the same name as controller 
                        // if there is no parameter it will search same name as action name 
    
    }
    public IActionResult addEmployee() // default http method request or respose is get 
    {
        return View();
    }

    [HttpPost]   // setting the upcomming action request method to post method 
   
    public IActionResult addEmployee([FromForm]Employee employee)
    {
           db.Employees.Add(employee);
           db.SaveChanges();
           return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult DeleteEmp(int id) // here parameter firstName is obtain thorough url
    {
            var employees = db.Employees.ToList();
            var employee=employees.FirstOrDefault(x=>x.Id==id);
                // delete query
                db.Employees.Remove(employee);
                db.SaveChanges();
               return RedirectToAction("Index");

    }

  

      // for update contex
      public IActionResult UpdateEmp(int id)
    {
          var employees = db.Employees.ToList(); 
             var employee=employees.FirstOrDefault(x=>x.Id==id);

            return View(employee);
    } 
    [HttpPost]
    public IActionResult UpdateEmp([FromForm]Employee employee)
    {
            db.Employees.Attach(employee);
            db.Employees.Update(employee);  // update equery
            db.SaveChanges();

            
         
        return RedirectToAction("Index");
    }

   
}

