using eCommerce.Data.Enums;
using eCommerce.Models;

namespace eCommerce.Data
{
    public class EcomDbInitializer
    {
        public static void Seed(IApplicationBuilder ApplicationBuilder)
        {
            using (var serviceScope = ApplicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<EcomDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://thumbs2.imgbox.com/1a/2b/dk1ZUif4_t.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://thumbs2.imgbox.com/6f/02/HmhtyN38_t.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://thumbs2.imgbox.com/08/ff/9qIl5U9F_t.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://thumbs2.imgbox.com/4c/54/5SAnhujA_t.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "https://thumbs2.imgbox.com/cf/18/1ompSYZW_t.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "GeorgeClooney",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://thumbs2.imgbox.com/9d/a5/GBlfkPPU_t.jpg"

                        },
                        new Actor()
                        {
                            FullName = "JohnnyDepp",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://thumbs2.imgbox.com/5c/6e/pGgezSlE_t.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Margot_Robbie",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://thumbs2.imgbox.com/57/52/Hkpn6bUk_t.jpg"
                        },
                        new Actor()
                        {
                            FullName = "RyanReynolds",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://thumbs2.imgbox.com/e0/0c/v5q3kwnd_t.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Tom Cruise",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://thumbs2.imgbox.com/da/af/kqYcAbP2_t.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Kevin Feige",
                            Bio = "This is the Bio of the first Producer",
                            ProfilePictureURL = "https://thumbs2.imgbox.com/03/65/Ac3Td9ZH_t.jpg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second Produucer",
                            ProfilePictureURL = "https://thumbs2.imgbox.com/af/ce/7eHxvDAy_t.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Spike Lee",
                            Bio = "This is the Bio of the third Producer",
                            ProfilePictureURL = "https://thumbs2.imgbox.com/b0/b8/QFhMzeQw_t.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Kathleen Kennedy",
                            Bio = "This is the Bio of the forth Producer",
                            ProfilePictureURL = "https://thumbs2.imgbox.com/28/39/TGJ6s711_t.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Michael Bay",
                            Bio = "This is the Bio of the fifth pro",
                            ProfilePictureURL = "https://thumbs2.imgbox.com/6b/d4/PuuFmYFV_t.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "GRAN TURISMO",
                            Description = "GRAN TURISMO movie description",
                            Price = 39.50,
                            ImageURL = "https://images.fandango.com/ImageRenderer/200/0/redesign/static/img/default_poster.png/0/images/MasterRepository/fandango/231714/GranTurismo2023.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "BREAK THE SILENCE",
                            Description = "BREAK THE SILENCE description",
                            Price = 29.50,
                            ImageURL = "https://images.fandango.com/ImageRenderer/200/0/redesign/static/img/default_poster.png/0/images/MasterRepository/fandango/223389/BREAK%20THE%20SILENCE_ONE%20SHEET%20ARTWORK_US.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "IMPRACTICAL JOKERS",
                            Description = "IMPRACTICAL JOKERS movie description",
                            Price = 39.50,
                            ImageURL = "https://images.fandango.com/ImageRenderer/200/0/redesign/static/img/default_poster.png/0/images/MasterRepository/fandango/222272/impracticaljokers-Jmovie-300x450.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "THE ANGRY BIRDS",
                            Description = "THE ANGRY BIRDS movie description",
                            Price = 39.50,
                            ImageURL = "https://images.fandango.com/ImageRenderer/200/0/redesign/static/img/default_poster.png/0/images/MasterRepository/fandango/217420/AB2_1SHT_FRNMS_FNL_06.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "THE SHACK",
                            Description = "THE SHACK movie description",
                            Price = 39.50,
                            ImageURL = "https://images.fandango.com/ImageRenderer/200/0/redesign/static/img/default_poster.png/0/images/MasterRepository/fandango/198124/FIN09_TheShack_1Sht_Payoff_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "PALAU",
                            Description = "PALAU movie description",
                            Price = 39.50,
                            ImageURL = "https://images.fandango.com/ImageRenderer/200/0/redesign/static/img/default_poster.png/0/images/MasterRepository/fandango/216749/Palau%20-%20One%20Sheet.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
