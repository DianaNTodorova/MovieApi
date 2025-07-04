namespace MovieApi.Models.DTOs
{
    public class MovieUpdateDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Duration { get; set; }
        public string Genre { get; set; } = string.Empty;
        public List<int> ActorIds { get; set; } = new List<int>();

    }
}
