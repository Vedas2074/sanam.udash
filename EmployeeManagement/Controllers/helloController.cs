using Microsoft.AspNetCore.Mvc;

public class helloController: Controller
{
    public IActionResult index()
    {
        return View();
    }
}