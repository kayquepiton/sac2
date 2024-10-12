namespace Ca.Backend.Test.Application.Models.Response;

public class UserResponse
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Username { get; set; }
    public IList<string>? Roles { get; set; }
}
