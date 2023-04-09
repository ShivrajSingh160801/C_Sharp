using System;
using System.Collections.Generic;

// Base class for all media content
public abstract class Media
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Genre { get; set; }
    public int Rating { get; set; }
}

// Movie class, derived from Media
public class Movie : Media
{
    public void Watch()
    {
        Console.WriteLine($"Now watching {Title}");
    }

    public void Rate(int rating)
    {
        Rating = rating;
        Console.WriteLine($"Rated {Title} with {rating} stars");
    }
}
// Series class, derived from Media
public class Series : Media
{
    public int Episodes { get; set; }

    public void Watch()
    {
        Console.WriteLine($"Now watching {Title}, episode 1");
        // Play all episodes
        for (int i = 2; i <= Episodes; i++)
        {
            Console.WriteLine($"Now watching {Title}, episode {i}");
        }
    }

    public void Rate(int rating)
    {
        Rating = rating;
        Console.WriteLine($"Rated {Title} with {rating} stars");
    }
}
// Playlist class, holds a collection of movies and series
public class Playlist
{
    public string Name { get; set; }
    public List<Movie> Movies { get; set; }
    public List<Series> Series { get; set; }

    public Playlist()
    {
        Movies = new List<Movie>();
        Series = new List<Series>();
    }
    public void AddMovie(Movie movie)
    {
        Movies.Add(movie);
        Console.WriteLine($"Added {movie.Title} to playlist {Name}");
    }
    public void AddSeries(Series series)
    {
        Series.Add(series);
        Console.WriteLine($"Added {series.Title} to playlist {Name}");
    }
    public void RemoveMovie(Movie movie)
    {
        Movies.Remove(movie);
        Console.WriteLine($"Removed {movie.Title} from playlist {Name}");
    }

    public void RemoveSeries(Series series)
    {
        Series.Remove(series);
        Console.WriteLine($"Removed {series.Title} from playlist {Name}");
    }
}
// User class, holds personal information and playlists
public class User
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<Playlist> Playlists { get; set; }

    public User()
    {
        Playlists = new List<Playlist>();
    }

    public void CreatePlaylist(Playlist playlist)
    {
        Playlists.Add(playlist);
        Console.WriteLine($"Created playlist {playlist.Name}");
    }
    public void AddToPlaylist(Playlist playlist, Media media)
    {
        if (media is Movie movie)
        {
            playlist.AddMovie(movie);
        }
        else if (media is Series series)
        {
            playlist.AddSeries(series);
        }
    }
    public List<Movie> SearchMovies(string title)
    {
        Console.WriteLine($"Searching movies with title {title}");
        return new List<Movie>();
    }
    public List<Series> SearchSeries(string title)
    {
        Console.WriteLine($"Searching series with title {title}");
        return new List<Series>();
    }
}


