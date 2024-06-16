namespace Reddit.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public string Contenido { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Deleted { get; set; }
        public DateTime? Updated { get; set; }
    }
}
