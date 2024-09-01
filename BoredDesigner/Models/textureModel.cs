namespace BoredDesigner.Models

{
    public class Texture
    {
        public int Id { get; set; }
        public string Title { get; set; }

        // Foreign key property
        public string UserId { get; set; }

        // Navigation property
        public User User { get; set; }
    }
}