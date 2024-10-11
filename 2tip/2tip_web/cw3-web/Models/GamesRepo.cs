using System;

namespace cw3_web.Models;

public class GamesRepo
{
    public static List<Game> GamesList()
    {
        List<Game> games = new List<Game> {
            new Game { Id = 1, Name = "Skyward Sword", Description = "An action-adventure game with puzzle-solving elements.", ReleaseDate = new DateOnly(2011, 11, 18), Genre = "Action-adventure" },
            new Game { Id = 2, Name = "The Witcher 3", Description = "An open-world RPG set in a dark fantasy universe.", ReleaseDate = new DateOnly(2015, 5, 19), Genre = "RPG" },
            new Game { Id = 3, Name = "Stardew Valley", Description = "A farming simulator where you build your farm and interact with villagers.", ReleaseDate = new DateOnly(2016, 2, 26), Genre = "Simulation" },
            new Game { Id = 4, Name = "Cyberpunk 2077", Description = "A futuristic RPG set in a dystopian city.", ReleaseDate = new DateOnly(2020, 12, 10), Genre = "RPG" },
            new Game { Id = 5, Name = "Minecraft", Description = "A sandbox game where players build and explore blocky worlds.", ReleaseDate = new DateOnly(2011, 11, 18), Genre = "Sandbox" },
            new Game { Id = 6, Name = "Hades", Description = "A roguelike action game where you battle through the underworld.", ReleaseDate = new DateOnly(2020, 9, 17), Genre = "Action" },
            new Game { Id = 7, Name = "Celeste", Description = "A platformer where you help a girl climb a mountain.", ReleaseDate = new DateOnly(2018, 1, 25), Genre = "Platformer" },
            new Game { Id = 8, Name = "Animal Crossing: New Horizons", Description = "A life simulation game where you manage an island village.", ReleaseDate = new DateOnly(2020, 3, 20), Genre = "Simulation" },
            new Game { Id = 9, Name = "Doom Eternal", Description = "A fast-paced first-person shooter where you battle demons.", ReleaseDate = new DateOnly(2020, 3, 20), Genre = "FPS" },
            new Game { Id = 10, Name = "Hollow Knight", Description = "A metroidvania game with exploration and combat in an insect-filled world.", ReleaseDate = new DateOnly(2017, 2, 24), Genre = "Metroidvania" }
        };
        return games;
    }

}
