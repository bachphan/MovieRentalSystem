using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace MovieRentalSystem
{
    public class MovieList
    {
        private List<MovieClass> Movie;
        //private int Current;

        public MovieList()
        {
            Movie = new List<MovieClass>();
            //Current = -1;
        }

        public int CountNo
        {
            get { return Movie.Count; }
        }
        public void AddMovie(MovieClass m)
        {
            Movie.Add(m);
        }
        public MovieClass SearchByName(string name)
        {
            foreach (MovieClass Name in Movie)
            {
                if (Name.MovieName == name)
                {
                    return Name;
                }
            }
            return null;
        }
        public MovieClass SearchByActor(string actor)
        {
            foreach (MovieClass Actor in Movie)
            {
                if (Actor.MovieActor == actor)
                {
                    return Actor;
                }
            }
            return null;
        }
        public MovieClass SearchByGenre(string genre)
        {
            foreach (MovieClass Genre in Movie)
            {
                if (Genre.MovieGenre == genre)
                {
                    return Genre;
                }
            }
            return null;
        }
        public MovieClass SearchByYear(int year)
        {
            foreach (MovieClass Year in Movie)
            {
                if (Year.MovieYear == year)
                {
                    return Year;
                }
            }
            return null;
        }

        public bool RemoveMovie(MovieClass m)
        {
            foreach (MovieClass Name in Movie)
            {
                if (m.MovieName == Name.MovieName)
                {
                    Movie.Remove(m);

                    return true;
                }
            }
            return false;
        }

        public bool WriteIntoText()
        {
            try
            {
                //FileStream stream = new FileStream("MovieList.txt", FileMode.Create, FileAccess.Write);
                StreamWriter write = new StreamWriter("MovieList.txt", true);

                foreach (MovieClass MovieInfo in Movie)
                {
                    write.WriteLine(MovieInfo.MovieName + "; " + MovieInfo.MovieGenre
                        + "; " + MovieInfo.MovieActor + "; " + + MovieInfo.MovieYear);
                    //write.WriteLine(MovieInfo.MovieName);
                    //write.WriteLine(MovieInfo.MovieGenre);
                    //write.WriteLine(MovieInfo.MovieActor);
                    //write.WriteLine(MovieInfo.MovieYear);
                }
                write.Close();
                return true;
            }

            catch (Exception e)
            {
                return false; 
            }
        }

        public string ReadFromText()
        {
            
            try
            {
                string line = "";
                //FileStream stomp = new FileStream("MovieList.txt", FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader("MovieList.txt");

                Movie.Clear();

                while (!read.EndOfStream)
                {
                    line = read.ReadToEnd();
                    Console.WriteLine(line);
                }
                read.Close();
                return line;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
                return "False";
            }
        }
    }
}
