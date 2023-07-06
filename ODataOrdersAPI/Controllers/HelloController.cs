namespace ODataOrdersAPI.Controllers;


[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase 
{
    [HttpGet]
    public string Index()
    {
        return "Hello, world";
    }
}