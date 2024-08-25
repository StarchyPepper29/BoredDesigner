namespace BoredDesigner;

public class User
{
    public string UserId { get; set; }
    public string Email { get; set; }
    public ICollection<Moodboard> Moodboards { get; set; }
}

