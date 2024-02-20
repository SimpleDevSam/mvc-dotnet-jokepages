using System.Security.Claims;

namespace mvc_dotnet_jokepages.Services;

public class UserService
{
    public string? GetUserId(ClaimsPrincipal user)
    {
        var userIdClaim = user.Identity as ClaimsIdentity;
        return userIdClaim?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    }

}
