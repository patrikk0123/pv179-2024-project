using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/")]
[AllowAnonymous]
public class RootController(ILogger<RootController> logger) : ControllerBase
{
    [HttpGet("")]
    public string GetRootStatus()
    {
        logger.LogInformation("Root endpoint is OK");
        logger.LogDebug("Root endpoint is OK");
        return "Hello world!";
    }
}
