using System;

namespace Movie_Database
{
    class Program
    {
        static void Main(string[] args)
        {

            Movie theLionKing = new Movie("The Lion King", "Animated");
            Movie theGodfather = new Movie("The Godfather", "Drama");
            Movie theDarkKnight = new Movie("The Dark Knight", "Action");
            Movie shrek = new Movie("Shrek", "Animated");
            Movie fightClub = new Movie("Fight Club", "Drama");
            Movie endGame = new Movie("The Avengers: End Game", "Action");
            Movie toyStory = new Movie("Toy Story", "Animated");
            Movie braveHeart = new Movie("Braveheart", "Drama");
            Movie gladiator = new Movie("Gladiator", "Action");
            Movie findingNemo = new Movie("Finding Nemo", "Animated");

            List<Movie> movieList = new List<Movie>()
            { theLionKing, theGodfather, theDarkKnight, shrek, fightClub, endGame, toyStory, braveHeart, gladiator, findingNemo };

            Console.WriteLine("Please pick a category of movie you would like to watch:");

            string answer;

            do
            {
                Console.WriteLine("The categories are: Animated, Drama, or Action");
                var userInput = Console.ReadLine().ToLower();

                if (userInput == "animated")
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.category.Contains("Animated"))
                        {
                            Console.WriteLine();
                            Console.WriteLine(movie.title);
                        }
                    }
                }

                else if (userInput == "drama")
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.category.Contains("Drama"))
                        {
                            Console.WriteLine();
                            Console.WriteLine(movie.title);
                        }
                    }
                }

                else if (userInput == "action")
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.category.Contains("Action"))
                        {
                            Console.WriteLine();
                            Console.WriteLine(movie.title);
                        }
                    }
                }

                else
                {
                    Console.WriteLine("That is not a valid category");
                }

                Console.WriteLine("Would you like to pick another category?");
                answer = Console.ReadLine().ToLower();

            }

            while (answer == "yes" || answer == "y");
            Console.WriteLine("Thank you for using the Movie Database!");
        }
    }
}