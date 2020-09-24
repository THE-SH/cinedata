using System.ComponentModel.DataAnnotations;

namespace CineDataAPI.Domain.Entities
{
    public class Movie{
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}