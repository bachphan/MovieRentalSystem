using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MovieRentalSystem
{
    public partial class EmployeeForm : Form
    {
        //Read the code before you run it


        MovieList movieLists = new MovieList();
        MovieClass moviefun;

        CustomerList CusList = new CustomerList();
        CustomerClass Cusfun;


        public EmployeeForm()
        {
            InitializeComponent();
        }


        //Add the movie - with input validation

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //If the user left it blank => Inform to enter all the value

            if (string.IsNullOrWhiteSpace(txtNameMovie.Text) ||
                string.IsNullOrWhiteSpace(txtNameActor.Text) ||
                string.IsNullOrWhiteSpace(txtYear.Text) ||
                string.IsNullOrWhiteSpace(cmbGenre.Text))
            {
                MessageBox.Show("Please enter all the value", "Error");
            }
            else
            {
                if (Convert.ToInt32(txtYear.Text) > 2016 || Convert.ToInt32(txtYear.Text) < 1900)
                {
                    MessageBox.Show("Please enter a correct year", "Error");             //Input validation for year of the movie
                }
                else
                {
                    moviefun = new MovieClass(txtNameMovie.Text,
                                              cmbGenre.Text,
                                              txtNameActor.Text,
                                              Convert.ToInt32(txtYear.Text));

                    //Add movie into collection (temporary) - Close and that's it
                    movieLists.AddMovie(moviefun);
                    txtNameActor.Text = "";
                    txtNameMovie.Text = "";
                    txtYear.Text = "";

                    //Write the movie into the text file. Case sensitive
                    bool success = movieLists.WriteIntoText();
                    if (success)
                    {
                        MessageBox.Show("Successed", "Result");
                    }
                    else
                    {
                        MessageBox.Show("Failed", "Result");
                    }
                }
            }
        }


        //Remove Movie out of text file (by include '//' into the line)

        private void btnRemoveMovie_Click(object sender, EventArgs e)
        {
            //When delete a movie, you need to enter name of the movie and the main actor of the movie

            if (string.IsNullOrWhiteSpace(txtNameMovie.Text) || string.IsNullOrWhiteSpace(txtNameActor.Text))
            {
                MessageBox.Show("Please enter the name of the movie, and the actor in that movie that you want to remove", "Error");
            }
            else
            {
                //Mark as delete - Need to have name of the movie and the name of the actor => prevent the situation
                // where there are 2 similar movies name

                string MovieDelete = File.ReadAllText("MovieList.txt");
                if (MovieDelete.Contains(txtNameMovie.Text) && MovieDelete.Contains(txtNameActor.Text))
                {
                    MovieDelete = MovieDelete.Replace(txtNameMovie.Text, "//" + txtNameMovie.Text);
                    File.WriteAllText("MovieList.txt", MovieDelete);
                    MessageBox.Show("Succeed", "Result");
                }
                else
                {
                    MessageBox.Show("Can't find the movie you were asking for", "Result");
                }

            }
        }




        // Search Movie

        private void btnSearchMovie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchMovie.Text))
            {
                MessageBox.Show("Please enter a value please", "Error");
            }

            else
            {

                string line;
                StringBuilder sb = new StringBuilder();


                // Read the file and display it line by line.              
                using (StreamReader Moviefile = new StreamReader("MovieList.txt"))
                {
                    while ((line = Moviefile.ReadLine()) != null)
                    {
                        if (line.Contains(txtSearchMovie.Text) && !line.Contains("//"))
                        {
                            // This append the text and a newline into the StringBuilder buffer       
                            sb.AppendLine(line.ToString());
                        }
                    }

                    MessageBox.Show(sb.ToString(), "Result");     //Show all the movie name that has the same word to message box

                }
            }
        }




        //Add Customers - input validation

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {


            //If the user left it blank => Inform to enter all the value

            if (string.IsNullOrWhiteSpace(txtCusName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtSSN.Text) ||
                string.IsNullOrWhiteSpace(txtState.Text) ||
                string.IsNullOrWhiteSpace(txtZip.Text))
            {
                MessageBox.Show("Please enter all the information please", "Error");
            }
            else
            {
                if (Convert.ToInt64(txtPhone.Text) > 9999999999 || Convert.ToInt64(txtPhone.Text) < 1000000000)
                {
                    MessageBox.Show("Please enter a correct phone number", "Error");   //input validation for phone number
                }
                else if (dateTime1.Value.Year > DateTime.Now.Year || dateTime1.Value.Year < DateTime.MinValue.Year)
                {
                    MessageBox.Show("Please enter a correct birth year", "Error");       //input validation for birth year
                }
                else
                {

                    Cusfun = new CustomerClass(
                        txtCusName.Text,
                        Convert.ToInt64(txtSSN.Text),
                        Convert.ToInt64(txtPhone.Text),
                        dateTime1.Value,
                        txtAddress.Text,
                        txtState.Text,
                        Convert.ToInt32(txtZip.Text)
                        );

                    Cusfun.CusAge = DateTime.Now.Year - dateTime1.Value.Year;

                    string s = "We have " + Cusfun.CusAge;

                    CusList.AddCustomer(Cusfun);
                    txtCusName.Text = "";
                    txtSSN.Text = "";
                    txtPhone.Text = "";
                    txtAddress.Text = "";
                    txtState.Text = "";
                    txtZip.Text = "";

                    bool successCus = CusList.WriteCustomerIntoText();
                    if (successCus)
                    {
                        MessageBox.Show("Successed", "Result");
                    }
                    else
                    {
                        MessageBox.Show("Failed", "Result");
                    }
                }
            }
        }


        //Remove Customer - Works ok

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            //When you remove a customer, you need to have a name of the customer and the SSN of the customer

            if (string.IsNullOrWhiteSpace(txtCusName.Text) || string.IsNullOrWhiteSpace(txtSSN.Text))
            {
                MessageBox.Show("Please enter customer's name and social security number", "Error");
            }
            else
            {
                //Mark as delete

                string CusDelete = File.ReadAllText("CustomerList.txt");
                if (CusDelete.Contains(txtCusName.Text) && CusDelete.Contains(txtSSN.Text))
                {
                    CusDelete = CusDelete.Replace(txtCusName.Text, "//" + txtCusName.Text);
                    File.WriteAllText("CustomerList.txt", CusDelete);
                    MessageBox.Show("Succeed", "Result");
                }
                else
                {
                    MessageBox.Show("Can't find the customer you were searching for", "Result");
                }

            }
        }




        //Search for customer 

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchCustomer.Text))
            {
                MessageBox.Show("Please enter the value  in the text box", "Error");
            }
            else
            {
                string line;
                StringBuilder sb = new StringBuilder();


                // Read the file and display it line by line.              
                using (StreamReader Customerfile = new StreamReader("CustomerList.txt"))
                {
                    while ((line = Customerfile.ReadLine()) != null)
                    {
                        if (line.Contains(txtSearchCustomer.Text) && !line.Contains("//"))
                        {
                            // This append the text and a newline into the StringBuilder buffer       
                            sb.AppendLine(line.ToString());
                        }
                    }
                    MessageBox.Show(sb.ToString(), "Result");   //Show the info of the movie
                }
            }
        }

        //Input Validation - Keep it

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 57 && e.KeyChar >= 48) || e.KeyChar == 13 || e.KeyChar == 8 || e.KeyChar == 46)
            {
                //ASCII Code 48 - 57 represent from 0 - 9 | 8 represent Backspace | 13 represent Enter | 46 represent '.'
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 57 && e.KeyChar >= 48) || e.KeyChar == 13 || e.KeyChar == 8 || e.KeyChar == 46)
            {
                //ASCII Code 48 - 57 represent from 0 - 9 | 8 represent Backspace | 13 represent Enter | 46 represent '.'
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 57 && e.KeyChar >= 48) || e.KeyChar == 13 || e.KeyChar == 8 || e.KeyChar == 46)
            {
                //ASCII Code 48 - 57 represent from 0 - 9 | 8 represent Backspace | 13 represent Enter | 46 represent '.'
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 57 && e.KeyChar >= 48) || e.KeyChar == 13 || e.KeyChar == 8 || e.KeyChar == 46)
            {
                //ASCII Code 48 - 57 represent from 0 - 9 | 8 represent Backspace | 13 represent Enter | 46 represent '.'
            }
            else
            {
                e.Handled = true;
            }
        }



        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            int days = Convert.ToInt16(txtboxRentalDays.Text);
            string moviename = txtboxMovieName.Text;

            TransactionClass t1 = new TransactionClass(moviename, days);

            int i = t1.DaysForCost(days);
            double h = t1.Cost(i);

            MessageBox.Show(h.ToString());
        }

        private void btnShowMovieList_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            StreamReader file = new StreamReader("MovieList.txt");

            List<string> listOfMovies = new List<string>();

            while ((line = file.ReadLine()) != null)
            {
                lstboxMovie.Items.Add(line);
                listOfMovies.Add(line);
                counter++;
            }

            string[] movieArr = listOfMovies.ToArray();
            Array.Sort(movieArr);

            foreach (string item in movieArr)
            {
                lstboxMovie.Items.Add(item);
            }


        }

        //What is this?

        private void btnShowCustomerList_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            StreamReader file2 = new StreamReader("CustomerList.txt");

            List<string> listOfCustomers = new List<string>();

            while ((line = file2.ReadLine()) != null)
            {
                lstboxCustomers.Items.Add(line);
                listOfCustomers.Add(line);
                counter++;
            }

            string[] customerArr = listOfCustomers.ToArray();
            Array.Sort(customerArr);

            foreach (string item in customerArr)
            {
                lstboxCustomers.Items.Add(item);
            }
        }

        private void btnSelectMovie_Click(object sender, EventArgs e)
        {
            //string currentItem = lstboxMovie.SelectedIndex.ToString();
            string currentItem = lstboxMovie.SelectedItem.ToString();
            
            MessageBox.Show("You have selected " + currentItem);

            //string movieSelected = " ";

            //if (movieSelected == currentItem)
            //{
            //    lstboxMovie
            //}
           
        
        }

        private void txtboxRentalDays_KeyPress(object sender, KeyPressEventArgs e)
        {
                char onlyNum = e.KeyChar; //only accepts char thats a digit

                //doesnt allow user to enter letters only numbers
                //the backspace, thats where the 8 comes from that the key enum
                //and the delete, thats where the 46 comes from thats the key enum
                if (!Char.IsDigit(onlyNum) && onlyNum != 8 && onlyNum != 46)
                {
                    e.Handled = true;
                }
            }

        private void txtboxCalculateTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char onlyNum = e.KeyChar; //only accepts char thats a digit

            //doesnt allow user to enter letters only numbers
            if (!Char.IsDigit(onlyNum) && onlyNum != 8 && onlyNum != 46)
            {
                e.Handled = true;
            }
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
           
            string currentItem = lstboxCustomers.SelectedItem.ToString();
            MessageBox.Show("You have selected " + currentItem);

        }

        
    }

}


