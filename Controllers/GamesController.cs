using Microsoft.AspNetCore.Mvc;
using PlayFinder.Data;
using PlayFinder.Models;

namespace PlayFinder.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GamesController : ControllerBase
{
    private readonly AppDbContext _context;

    public GamesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<Game>> GetGames()
    {
        var games = _context.Games.ToList();
        return Ok(games);
    }

    [HttpPost]
    public ActionResult<Game> CreateGame(Game game)
    {
        var exists = _context.Games.Any(g => g.Title == game.Title);

        if (exists)
        {
            return BadRequest("Game already exists");
        }

        _context.Games.Add(game);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetGames), new { id = game.Id }, game);
    }
}