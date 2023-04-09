using System;
using System.Collections.Generic;

class User
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public int Age { get; set; }
    public string Gender { get; set; }
    public string Religion { get; set; }
    public List<string> Interests { get; set; }

    public List<User> Matches { get; set; }

    public void SearchMatches()
    {
        // Implementation of search algorithm
    }

    public void SendMatchRequest(User match)
    {
        Matches.Add(match);
        match.Matches.Add(this);
    }

    public void AcceptMatch(User match)
    {
        // Implementation of accepting a match
    }

    public void RejectMatch(User match)
    {
        // Implementation of rejecting a match
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage:

        User john = new User { Name = "John", Id = 1, Email = "john@example.com", Password = "password", Age = 30, Gender = "Male", Religion = "Christian", Interests = new List<string> { "Reading", "Hiking" }, Matches = new List<User>() };
        User jane = new User { Name = "Jane", Id = 2, Email = "jane@example.com", Password = "password", Age = 28, Gender = "Female", Religion = "Muslim", Interests = new List<string> { "Cooking", "Traveling" }, Matches = new List<User>() };

        john.SendMatchRequest(jane);
        jane.AcceptMatch(john);
    }
}
