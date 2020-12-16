using Microsoft.AspNetCore.Mvc;



public class DepartmentController : Controller
{

    public IActionResult index()
    {
        var departments = Department.GetDepartments();
        return View(departments);
    }

}