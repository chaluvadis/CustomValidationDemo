using Microsoft.AspNetCore.Mvc;
using CustomValidationDemo.Models;

namespace CustomValidationDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : Controller
{
    // POST api/values
    [HttpPost]
    public IActionResult Post([FromBody] User user) => Ok(user);
}

