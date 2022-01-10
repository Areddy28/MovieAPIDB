using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper; 
using System.Threading.Tasks;

namespace MoviesAPIDB
{
    public class MoiveDAL
    {
        public List<Movie> GetAllMovies()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                var sql = "select * from movie";
                connect.Open();
                List<Movie> movies = connect.Query<Movie>(sql).ToList();
                connect.Close();

                return movies;
            }

        }

        public List<Movie> GetMoviesByGenre(string genre)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"select * from movies where genre = '{genre}'";
                try
                {

                    connect.Open();
                    List<Movie> c = connect.Query<Movie>(sql).ToList();
                    connect.Close();
                    return c;

                }
                catch
                {
                    List<Movie> error = new List<Movie>();
                    error.Add(new Movie());
                   
                    error[0].Title = $"No movie found at '{genre}.' ";
                    return error;
                }
            }
        }

        public Movie GetRandomMovie()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                var sql = "select * from movie";
                connect.Open();
                List<Movie> movies = connect.Query<Movie>(sql).ToList();
                
                Random rnd = new Random();
                int randonmNum = rnd.Next(0, movies.Count);
                connect.Close();

                return movies[randonmNum];
            }

        }

        public Movie GetRandomByGenre(string genre)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                var sql = $"select * from movie where genre = '{genre}'";
                
                connect.Open();
                List<Movie> movies = connect.Query<Movie>(sql).ToList();

                Random rnd = new Random();
                int randonmNum = rnd.Next(0, movies.Count);
                connect.Close();

                return movies[randonmNum];
            }

        }

        public List<Movie> GetMoviesByAmount(int num)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                var sql = $"select * from movie";

                connect.Open();
                List<Movie> movies = connect.Query<Movie>(sql).ToList();

                Random rnd = new Random();
                int randonmNum = rnd.Next(0, movies.Count);
                connect.Close();

                List<Movie> randomMovies = new List<Movie>();
                for(int i = 0; i < num; i++)
                {
                    if (randomMovies.Contains(movies[i]));
                }
                return randomMovies; 
            }

        }

    }
}
