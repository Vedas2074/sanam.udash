using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public class StateManagementController: Controller
{
    public IActionResult firstpage(string name ,int age)
    {

        // server side 


        // client side 
        //1.cookies 
        var userName = "sanam udash";
      

        CookieOptions options = new CookieOptions();
        options.Expires = DateTime.Now.AddHours(1);
        Response.Cookies.Append("user",userName);


        return View();

       
    }
     public ViewResult secondPage()
        {
            var user = Request.Cookies["user"];

            return View(user);
        }
}