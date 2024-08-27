namespace BoredDesigner
{
    public class Font
    {
        public string FontName { get; set; }
        public string FontUrl { get; set; } // URL to download or display the font
    }

    public class Color
    {
        
        public string HexCode { get; set; } // Store color as a hex string
    }

    public class Image
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } // Store image URL or path as string
    }

    public class ColorMap
    {
        public int Id { get; set; }
    }
}
