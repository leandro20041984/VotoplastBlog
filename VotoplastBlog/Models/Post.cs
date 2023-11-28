namespace VotoplastBlog.Models
{
    public class Post
    {
        public int IdyProperty { get; set; }
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }

        //Relation
        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public DateTime? CreatedDate { get; set;} = DateTime.Now;
        public  string? Description { get; set; }
        public string? Slug { get; set; }
    }
}
