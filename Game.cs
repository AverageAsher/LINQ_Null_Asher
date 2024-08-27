using System;
using System.Linq;

// Define the Game class with properties and a constructor
public class Game
{
    // Automatic properties for the Game class
    public string Title { get; set; }
    public char Esrb { get; set; }
    public string Genre { get; set; }

    // Constructor to initialize the properties
    public Game(string title, char esrb, string genre)
    {
        Title = title;
        Esrb = esrb;
        Genre = genre;
    }
}