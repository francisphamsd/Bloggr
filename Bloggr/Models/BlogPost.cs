namespace Bloggr.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set;} = DateTime.Now;
    }
}
