using Microsoft.AspNetCore.Identity;

namespace mvc_dotnet_jokepages.Models;

public class Joke
{
    public int Id { get; set; }

    public string JokeQuestion { get; set; } = string.Empty;

    public string JokeAnswer { get; set;} = string.Empty;

    public string UserId { get; set; } = string.Empty;

    public virtual IdentityUser? User { get; set; }
    public Joke()
    {

    }
}
