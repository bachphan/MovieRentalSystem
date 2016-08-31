using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MovieRentalSystem
{
    public class TransactionList
    {
        private List<TransactionClass> Transaction;
        //private int Current;

        public TransactionList()
        {
            Transaction = new List<TransactionClass>();
            //Current = -1;
        }

        public int CountNo
        {
            get { return Transaction.Count; }
        }
        public void AddTransaction(TransactionClass t)
        {
            Transaction.Add(t);
        }

        public void RemoveTransaction(TransactionClass m)
        {
            Transaction.Remove(m);
        }

        public bool WriteCustomerIntoText()
        {
            try
            {
                //FileStream stream = new FileStream("MovieList.txt", FileMode.Create, FileAccess.Write);
                StreamWriter write = new StreamWriter("TransactionList.txt", true);

                foreach (TransactionClass TransactionInfo in Transaction)
                {
                    write.WriteLine(TransactionInfo.customerName + "; "
                        + TransactionInfo.movieRentalName + "; "
                        + TransactionInfo.rentalTime + "; "
                        + TransactionInfo.moviePrice + "; "
                        + TransactionInfo.daysRented + "; "
                        + TransactionInfo.GetCost);
                }
                write.Close();
                return true;
            }

            catch (Exception e)
            {
                return false;
            }
        }
    }
}
