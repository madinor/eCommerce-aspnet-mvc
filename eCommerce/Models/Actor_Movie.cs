namespace eCommerce.Models
{
    public class Actor_Movie
    {
        public int ActorId { get; set; }
        //RelationShip with Actor
        public Actor Actor { get; set; }

        public int MovieId { get; set; }
        //RelationShip with Movie
        public Movie Movie { get; set; }  
    }
}
