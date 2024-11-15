using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class HelloWorldController : ControllerBase
{

    [HttpGet]
    public ActionResult<string> HelloWorld()
    {
        return "Hello world from C#";
    }

    [HttpGet("Thankyou")]
    public IActionResult Thankyou(string name)
    {
        return Ok($"Thank you {name}");
    }
}
