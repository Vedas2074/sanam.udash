using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public class StateManagementController: Controller
{
        // parameter in method will appear as the query in url 
    public IActionResult FirstPage()
    {
        // server side 

        

        // client side 
            // 1) cookie 
            // setting cookiee in c# mvc dotnet core 
            var userName = "sanam udash";
            // creating the options object for the cookiee
            CookieOptions options = new CookieOptions();
            // setting Expires properties of the options to one hours from now 
            options.Expires = DateTime.Now.AddHours(1);
           // giving the cookie to the cookie with name user 
           // response will set cookie 
        Response.Cookies.Append("user",userName,options);    


        return View();
    }

    public IActionResult SecondPage(string name , int age )
    {
        // // getting the cookie set by first page 
        // var user = Request.Cookies["user"];
    // first parameter view name second parameter model 
        
        // 2. Query strings : string in url 
        Response.Cookies.Append("user1",name);
       var user =  Request.Cookies["user1"];
        return View("SecondPage",user);
    }
    [HttpPost]
    // getting id from another page in hidden form 
    public IActionResult SecondPage(string id)
    {
        return View("HiddenPage",id);
    } 
    

}