using Microsoft.AspNetCore.Mvc;
public class  EmployeeController : Controller
{
    public IActionResult index()  // return type is actionresult whict is generic type
    {
        return View();
    }
}