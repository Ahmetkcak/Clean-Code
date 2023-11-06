using PrototypePattern;

Game game1 = new Game(3, "Oyun Adı", "Oyun Türü", true);
Game game2 = (Game)game1.Clone();

if (game1.Equals(game2))
{
    Console.WriteLine("Equals");
}
else
{
    Console.WriteLine("Difference");
}