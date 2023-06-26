using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //RelationShip with Actor_Movie
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
