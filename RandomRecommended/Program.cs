using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataLayer;
using DomainClass;

namespace RandomRecommended
{
    class Program
    {
        static readonly Random Rnd = new Random();

        static void Main()
        {
            
            Starting();
        }

        private static void Starting()
        {
            Console.Clear();
            Console.WriteLine("What Is Your LastName?");
      
            var inputUser = Console.ReadLine();
         
            if (inputUser == null || inputUser.Trim().Length == 0)
            {
                Console.Clear();
                Console.WriteLine("InCorrect User");
                Console.ReadKey();
            }
            else
            {
                Database.SetInitializer(new ContextList.MyCustomInitializer());
                var db = new ContextList();
                inputUser = inputUser.ToLower().Trim();
                Console.Clear();
                Console.WriteLine();

                Console.WriteLine("Please Wait...");
                 var movielist = GetMovielist(db.Movies);
               
               
                var user = GetUser(db.Users, inputUser);
                if (user == null)
                {
                    db.Users.Add(TranslateToUserEntity(inputUser));
                    db.SaveChanges();
                }
                user = GetUser(db.Users, inputUser);


                if (user != null)
                {
                    var repeatedRecomanded = db.UserMovieList.Where(x => x.Accepted && x.UserId == user.Id);
                    var nonRepeatedMovies = movielist
                        .Except(movielist.Join(repeatedRecomanded, a => a.Id, b => b.MovieId, (a, b) => a)).ToList();


                    if (nonRepeatedMovies.Count != 0)
                    {
                        int index = Rnd.Next(nonRepeatedMovies.Count);
                        Console.Clear();
                        Console.WriteLine("  The proposed film is : ");
                        Console.WriteLine();
                        Console.WriteLine("       *");
                        Console.WriteLine("       **");
                        Console.WriteLine("       ***");
                        Console.WriteLine("       ****");
                        Console.WriteLine("       *****"); 
                        Console.WriteLine("        " + nonRepeatedMovies[index].LatinName);
                        Console.WriteLine("       *****");
                        Console.WriteLine("       ****");
                        Console.WriteLine("       ***");
                        Console.WriteLine("       **");
                        Console.WriteLine("       *");
                        Console.WriteLine("   its Rate is " +
                                          nonRepeatedMovies[index].Rate);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Do you accept the offer(y/n)? ");
                        var accepted = Console.ReadLine();
                        if (accepted != null)
                        {
                            if (accepted.ToLower() == "y".ToLower() || accepted.ToLower() == "yes".ToLower() ||
                            accepted.ToLower() == "+".ToLower())
                            {
                                db.UserMovieList.Add(
                                    new UserMovie()
                                    {
                                        Id = 1,
                                        MovieId = nonRepeatedMovies[index].Id,
                                        UserId = user.Id,
                                        Accepted = true
                                    });
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("                       This movie has been recorded for you.");
                                db.SaveChanges();
                            }
                            
                        }

                    }
                    else
                    {
                        Console.WriteLine("Dont Exist");
                       
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Data");
                 
                }
                StartAgain();
            }
        }

        private static User TranslateToUserEntity(string inputUser)
        {
            if (inputUser == null)
                return null;
            return new User() { Id = 0, UserName = inputUser, IsActived = true };
        }

        private static void StartAgain()
        {
         Console.Clear();
            Console.WriteLine("Do you do it again(y/n)?");
            var isAgain = Console.ReadLine();
            if (isAgain != null)
            {
                if (isAgain.ToLower() == "y".ToLower() || isAgain.ToLower() == "yes".ToLower() ||
                    isAgain.ToLower() == "+".ToLower())
                {
                   
                    Starting();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Thanks Bye");
                    Console.ReadKey();
                }
            }
        }

        private static User GetUser(DbSet<User> users, string username)
        {
            var user = users.FirstOrDefault(x => x.UserName == username);
            return user;
        }

        private static List<Movie> GetMovielist(DbSet<Movie> dbMovies)
        {
            var movielist = dbMovies.ToList();
            return movielist;
        }

       
    }
}
