namespace PlayFinder.Models;

public class Game
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public int MinPlayers { get; set; }
    public int MaxPlayers { get; set; }

    public bool OnlineCoop { get; set; }
    public bool LocalCoop { get; set; }

    public string Platform { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }

    public string ImageUrl { get; set; } = string.Empty;
}