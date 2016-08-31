using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MovieRentalSystem
{
    public class MovieClass
    {
        private string Name;
        private string Genre;
        private string Actor;
        private int Year;


        public MovieClass(string name, string genre, string actor, int year)
        {
            this.Name = name;
            this.Genre = genre;
            this.Actor = actor;
            this.Year = year;
        }

        public string MovieName
        {
            get { return Name; }
            set { Name = value; }
        }
        public string MovieGenre
        {
            get { return Genre; }
            set { Genre = value; }
        }
        public string MovieActor
        {
            get { return Actor; }
            set { Actor = value; }
        }
        public int MovieYear
        {
            get { return Year; }
            set
            {
                if (Year > DateTime.Now.Year && Year < 0)
                    throw new Exception("You have entered invalid number for year");

                else
                {
                    Year = value;
                }
            }
        }
    }
}
