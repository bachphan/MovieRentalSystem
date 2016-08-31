using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace MovieRentalSystem
{
    public class CustomerList
    {
        private List<CustomerClass> Customer;
        //private int Current;

        public CustomerList()
        {
            Customer = new List<CustomerClass>();
            //Current = -1;
        }

        public int CountNo
        {
            get { return Customer.Count; }
        }
        public void AddCustomer(CustomerClass c)
        {
            Customer.Add(c);
        }
        public CustomerClass SearchByName(string name)
        {
            foreach (CustomerClass Name in Customer)
            {
                if (Name.CusName == name)
                {
                    return Name;
                }
            }
            return null;
        }
        
        public CustomerClass SearchBySSN(int year)
        {
            foreach (CustomerClass SSN in Customer)
            {
                if (SSN.CusSSN == year)
                {
                    return SSN;
                }
            }
            return null;
        }

        public bool RemoveCustomer(CustomerClass m)
        {
            foreach (CustomerClass Name in Customer)
            {
                if (m.CusName == Name.CusName)
                {
                    Customer.Remove(m);

                    return true;
                }
            }
            return false;
        }

        public bool WriteCustomerIntoText()
        {
            try
            {
                //FileStream stream = new FileStream("MovieList.txt", FileMode.Create, FileAccess.Write);
                StreamWriter write = new StreamWriter("CustomerList.txt", true);

                foreach (CustomerClass CustomerInfo in Customer)
                {
                    write.WriteLine(CustomerInfo.CusName + "; "
                        + CustomerInfo.CusSSN + "; "
                        + CustomerInfo.CusPhone + "; "
                        + CustomerInfo.CusAge + "; "
                        + CustomerInfo.CusBirth + "; "
                        + CustomerInfo.CusAddress + "; "
                        + CustomerInfo.CusState + "; "
                        + CustomerInfo.CusZip + "\n");

                }
                write.Close();
                return true;
            }

            catch (Exception e)
            {
                return false;
            }
        }

        public string ReadCustomerFromText()
        {

            try
            {
                string line = "";
                //FileStream stomp = new FileStream("MovieList.txt", FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader("CustomerList.txt");

                Customer.Clear();

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
