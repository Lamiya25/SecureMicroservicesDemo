using Movies.API.Model;

namespace Movies.API.Data
{
    public class MoviesContextSeed
    {
        public static void SeedAsync(MoviesAPIContext context)
        {
            if (!context.Movie.Any())
            {
                var movies = new List<Movie>
                {
                    new Movie
                    {
                        Id = 1,
                        Genre="Drama",
                        Title="The Shwashank Redemption",
                        Rating="9.3",
                        ImageUrl="images/src",
                        ReleaseDate= new DateTime(1994, 5,5),
                        Owner="alice"
                    },
               new Movie
                    {
                        Id = 2,
                        Genre="Drama",
                        Title="The Shwashank Redemption",
                        Rating="9.3",
                        ImageUrl="images/src",
                        ReleaseDate= new DateTime(1994, 5,5),
                        Owner="alice"
                    },
                new Movie
                    {
                        Id = 3,
                        Genre="Drama",
                        Title="The Shwashank Redemption",
                        Rating="9.3",
                        ImageUrl="images/src",
                        ReleaseDate= new DateTime(1994, 5,5),
                        Owner="alice"
                    },
                 new Movie
                    {
                        Id = 4,
                        Genre="Drama",
                        Title="The Shwashank Redemption",
                        Rating="9.3",
                        ImageUrl="images/src",
                        ReleaseDate= new DateTime(1994, 5,5),
                        Owner="alice"
                    }
                };

                context.Movie.AddRange(movies);
                context.SaveChanges();
            }
        }
    }
}
