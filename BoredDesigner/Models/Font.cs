namespace FontApi.Models
{
    public class WebFont
    {
        public string Kind { get; set; }
        public string Family { get; set; }
        public string Category { get; set; }
        public List<string> Variants { get; set; }
        public List<string> Subsets { get; set; }
        public string Version { get; set; }
        public string LastModified { get; set; }
        public Dictionary<string, string> Files { get; set; }
    }

    public class WebFontList
    {
        public string Kind { get; set; }
        public List<WebFont> Items { get; set; }
    }
}