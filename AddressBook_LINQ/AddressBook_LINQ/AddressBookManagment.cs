using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_LINQ
{
    internal class AddressBookManagment
    {
        DataTable table = new DataTable();
        public void InsertContactToTable()
        {
            table.Columns.Add("FirstName", typeof(string));  
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(int));
            table.Columns.Add("PhoneNumber", typeof(long));
            table.Columns.Add("Email", typeof(string));
            table.Rows.Add("Shubham", "Singh", "Vanaras", "City", "UttarPradesh", 222129, 9876543210, "shubham@gmail.com");
            table.Rows.Add("Karan", "Kushwaha", "Gorakhpur", "Lucknow", "Uttar Pradesh", 675432, 8765432190, "karan@gmail.com");
            table.Rows.Add("Irbaz", "Patel", "Bharuch", "Anywhere", "Gujrat", 654328, 6543210987, "irbaz@gmail.com.");
        }
    }
}
