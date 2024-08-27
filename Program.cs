public class Program
{
    public static void Main()
    {
        // Initialize an array of Game objects with sample data
        Game[] games = new Game[]
        {
            new Game("Minecraft", 'E', "Sandbox"),
            new Game("Fortnite", 'T', "Battle Royale"),
            new Game("The Witcher 3", 'M', "RPG"),
            new Game("Halo", 'M', "Shooter"),
            new Game("Among Us", 'T', "Party"),
            new Game("Zelda", 'E', "Adventure"),
            new Game("Stardew Valley", 'E', "Simulation"),
            new Game("FIFA 24", 'E', "Sports"),
            new Game("Apex Legends", 'T', "Battle Royale"),
            new Game("Overwatch", 'T', "Shooter")
        };

        // LINQ query to get games with titles less than 9 characters
        var shortGames = from game in games
                         where game.Title.Length < 9
                         select game;

        // Print each short game title in uppercase
        Console.WriteLine("Games with Titles Less Than 9 Characters:");
        foreach (var game in shortGames)
        {
            Console.WriteLine($"Game Title: {game.Title.ToUpper()}");
        }

        // LINQ method query to find the game with title "Minecraft"
        var mineCraft = games.FirstOrDefault(game => game.Title == "Minecraft");

        // Print properties of the game found, if it exists
        if (mineCraft != null)
        {
            Console.WriteLine($"Title: {mineCraft.Title}, ESRB: {mineCraft.Esrb}, Genre: {mineCraft.Genre}");
        }
        else
        {
            Console.WriteLine("Game 'Minecraft' not found.");
        }

        // LINQ method query to select titles where the ESRB rating is 'T'
        var tRated = games.Where(game => game.Esrb == 'T').Select(game => game.Title);

        // Print all T-rated game titles
        Console.WriteLine("T Rated Games:");
        foreach (var title in tRated)
        {
            Console.WriteLine(title);
        }

        // LINQ method query to select titles where ESRB rating is 'E' and genre is "Action"
        var eRatedAction = games.Where(game => game.Esrb == 'E' && game.Genre == "Action").Select(game => game.Title);

        // Print all E-rated action game titles
        Console.WriteLine("E Rated Action Games:");
        foreach (var title in eRatedAction)
        {
            Console.WriteLine(title);
        }
    }
}