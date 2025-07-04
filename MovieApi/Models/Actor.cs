namespace MovieApi.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime BirthYear { get; set; }
    

        public ICollection<Movie> Movie { get; set; } = new List<Movie>();

    }
}
