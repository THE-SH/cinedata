using System.ComponentModel.DataAnnotations;

namespace CineDataAPI.Domain.Entities
{
    public class MovieGenre{
        [Key]
        public int MovieGenreId {get; set;}
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public Movie Movie { get; set; }
        public Genre Genre { get; set; }
    }
}
