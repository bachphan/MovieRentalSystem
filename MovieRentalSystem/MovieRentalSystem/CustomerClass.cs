using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalSystem
{
    public class CustomerClass
    {
        private string Name;
        private long SSN;
        private long PhoneNum;
        private int Age;
        private DateTime Birthday;
        private string Address;
        private string State;
        private int ZipCode;

        public CustomerClass(string name, long ssn, long phone,  DateTime birthday, string address,
            string state, int zip)
        {
            this.Name = name;
            this.SSN = ssn;
            this.PhoneNum = phone;
            this.Birthday = birthday;
            this.Address = address;
            this.State = state;
            this.ZipCode = zip;
            Age = 0;
        }

        public string CusName
        {
            get { return Name; }
            set { Name = value; }
        }
        public long CusSSN
        {
            get { return SSN; }
            set { SSN = value; }
        }
        public long CusPhone
        {
            get { return PhoneNum; }
            set
            {
                if (PhoneNum > 9999999999 && PhoneNum < 1000000000)
                    throw new Exception("You have entered invalid number");

                else
                {
                    PhoneNum = value;
                }
            }
        }
        public int CusAge
        {
            get { return Age; }
            set { Age = RealAge(); }
        }
        public string CusAddress
        {
            get { return Address; }
            set { Address = value; }
        }
        public string CusState
        {
            get { return State; }
            set { State = value; }
        }
        public int CusZip
        {
            get { return ZipCode; }
            set { ZipCode = value; }
        }
        public DateTime CusBirth
        {
            get { return new DateTime(Birthday.Year, Birthday.Month, Birthday.Day); }
            set
            {
                if (value > DateTime.Now)
                    throw new Exception("You have entered wrong date of birth");
                if (value != null)
                {
                    Birthday = value;
                    Age = RealAge();
                }
            }
        }

        public int RealAge()
        {
            int year = 0;
            year = DateTime.Now.Year - Birthday.Year;
            return year;
        }
    }
}
