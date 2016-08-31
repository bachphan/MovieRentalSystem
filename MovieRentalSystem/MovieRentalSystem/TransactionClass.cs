using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalSystem
{
    public class TransactionClass
    {
        public string customerName;
        public string movieRentalName;
        public int timeAllowed;// the amount of days you have for the rental
        public double moviePrice;
        public double additionalMoviePrice;
        public int rentalTime;
        public int daysRented;

        private double totalCost;
        //public int days; 

        //getter and setter for the customer name
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string MovieRentalName
        {
            get { return movieRentalName; }
            set { movieRentalName = value; }
        }

        public int TimeAllowed
        {
            get { return timeAllowed; }
            set { timeAllowed = value; }
        }

        public double GetCost
        {
            get { return totalCost; }
        }

        public TransactionClass(string movieRentalName) // needs to be the constructor for a  new movie
        {
            this.movieRentalName = movieRentalName;
            timeAllowed = 2;
            moviePrice = 3.99;
            //additionalMoviePrice = 0.00;
            //rentalTime = 0;

        }
        public TransactionClass(string movieRentalName, int rentalTime)
        {
            this.movieRentalName = movieRentalName;
            timeAllowed = 2;
            moviePrice = 3.99;
            additionalMoviePrice = 5.99;
            this.rentalTime = rentalTime;
        }

        //Determines the days of the rentals to calculate the total
        public int DaysForCost(int rentalTime)
        {
            //days = 0;

            if (rentalTime == timeAllowed)
            {
                daysRented = timeAllowed;
                return daysRented;
            }
            else if (rentalTime > 2)
            {
                daysRented = rentalTime;
                return daysRented;       //pay moviePrice + additionalMoviePrice * rentalTime
            }
            return daysRented;
        }

        public double Cost(int daysRented)
        {
            double totalPrice = 0.0;

            double overtime = rentalTime * additionalMoviePrice; // calculates the movie price plus the additional time you want to rent the movie


            if (daysRented == timeAllowed)
            {
                totalPrice = moviePrice;
                //return moviePrice; 
            }
            else if (daysRented > 2)
            {
                totalPrice = overtime;
                //return overtime;
            }

            totalCost = totalPrice;

            return totalPrice;
        }
    }
}
