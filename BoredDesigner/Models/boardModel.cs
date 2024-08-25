namespace BoredDesigner;

public class Moodboard
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string BackgroundColorHex { get; set; } // Store color as a hex string
    public string ThumbnailUrl { get; set; } // Store image URL or path as string
    
    // Foreign key property
    public string UserId { get; set; }
    
    // Navigation property
    public User User { get; set; }
}

