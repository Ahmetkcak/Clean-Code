
namespace PrototypePattern;

public class Game : PrototypeGame
{
    public int GameId { get; set; }
    public string GameName { get; set; }
    public string GameType { get; set; }
    public bool Status { get; set; }
    public Game(int gameId, string gameName, string gameType, bool status)
    {
        GameId = gameId;
        GameName = gameName;
        GameType = gameType;
        Status = status;
    }

    public override PrototypeGame Clone()
    {
        return MemberwiseClone() as PrototypeGame;
    }
}
