using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
// specifiing that this controller is webapi not view controller
[ApiController]
[Route("Test")]
// every action workas another end point because of different url in web api 
public class TestController:ControllerBase
 { //  specifing the request method 
    [HttpGet]
    // specifing the route of the action 
    [Route("name")]
    public string[] GetName()
    {
    
    return new string[] {"sanam udsh","hello world ","don hero" , "hero allam"};
    
    }
    [HttpGet]
    [Route("capitalize")]
    public IEnumerable<string> CapitalizeName()
    {
     var names = new string [] {"sanam udash","hello world "};
    var cnames =names.Select(x=>x.ToUpper()).ToArray();
     return cnames;   
    }


}