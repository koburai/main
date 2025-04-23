using Microsoft.AspNetCore.Mvc;
using System.Linq;

[Route("api/[controller]")] // which here is api/states
[ApiController]
public class StateController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public StateController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetStates()
    {
        var states = _context.States.ToList();
        return Ok(states);
    }
}