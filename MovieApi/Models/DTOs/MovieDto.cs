namespace MovieApi.Models.DTOs
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime Year { get; set; }
        public string Genre { get; set; } = string.Empty;
        public int Duration { get; set; }

        public MovieDetails MovieDetails { get; set; } = null!;

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
   
        public ICollection<Actor> Actor { get; set; } = new List<Actor>();
    }
}
