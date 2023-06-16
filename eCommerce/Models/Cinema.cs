using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationship with Movie
        public List<Movie> Movies { get; set; }
    }
}
