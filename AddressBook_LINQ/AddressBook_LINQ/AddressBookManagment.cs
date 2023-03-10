using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
            table.Rows.Add("Shubham", "Singh", "Vanaras", "Lucknow", "UttarPradesh", 222129, 9876543210, "shubham@gmail.com");
            table.Rows.Add("Karan", "Kushwaha", "Gorakhpur", "City", "UttarPradesh", 675432, 8765432190, "karan@gmail.com");
            table.Rows.Add("Irbaz", "Patel", "Bharuch", "Anywhere", "Gujrat", 654328, 6543210987, "irbaz@gmail.com");
            table.Rows.Add("Niraj", "Pal", "Lucknow", "Kanpur", "Delhi", 654354, 6543765098, "np@gmail.com");
        }
        public void DisplayContacts()
        {
            Console.WriteLine("\n~~~~~~~Contacts in DataTable~~~~~~~");
            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine("FirstName :" + row["FirstName"]);
                Console.WriteLine("LastName :" + row["LastName"]);
                Console.WriteLine("Address :" + row["Address"]);
                Console.WriteLine("City :" + row["City"]);
                Console.WriteLine("State :" + row["State"]);
                Console.WriteLine("Zip :" + row["Zip"]);
                Console.WriteLine("PhoneNumber :" + row["PhoneNumber"]);
                Console.WriteLine("Email :" + row["Email"]);
                Console.WriteLine("-------------\n");
            }
        }
        public void EditExistingContact(string firstName, string lastName, string column, string newValue)
        {                                                               //Returns the first element of a sequence, or a default value if the sequence contains no elements. 
            DataRow contact = table.Select("FirstName = '" + firstName + "' and LastName = '" + lastName + "'").FirstOrDefault();
            contact[column] = newValue;
            Console.WriteLine("Record successfully Edited");
            DisplayContacts();
        }
        public void DeleteContact(string firstName, string lastName)
        {
            DataRow contact = table.Select("FirstName = '" + firstName + "' and LastName = '" + lastName + "'").FirstOrDefault();
            table.Rows.Remove(contact);   
            Console.WriteLine("\nRecord Successfully Deleted");
            DisplayContacts();
        }
        public void RetrieveByCity(string city)
        {
            var retrieveData = from records in table.AsEnumerable() where records.Field<string>("City") == city  select records;
            Console.WriteLine("Retrieve contact details by city name ---->");
            foreach (DataRow row in retrieveData)
            {
                Console.WriteLine("FirstName :" + row["FirstName"]);
                Console.WriteLine("LastName :" + row["LastName"]);
                Console.WriteLine("Address :" + row["Address"]);
                Console.WriteLine("City :" + row["City"]);
                Console.WriteLine("State :" + row["State"]);
                Console.WriteLine("Zip :" + row["Zip"]);
                Console.WriteLine("PhoneNumber :" + row["PhoneNumber"]);
                Console.WriteLine("Email :" + row["Email"]);
                Console.WriteLine("-------------\n");
            }
        }
        public void RetrieveByState(string state)
        {
            var retrieveData = from records in table.AsEnumerable() where records.Field<string>("State") == state select records;
            Console.WriteLine("Retrieve contact details by State name ---->");
            foreach (DataRow row in retrieveData)
            {
                Console.WriteLine("FirstName :" + row["FirstName"]);
                Console.WriteLine("LastName :" + row["LastName"]);
                Console.WriteLine("Address :" + row["Address"]);
                Console.WriteLine("City :" + row["City"]);
                Console.WriteLine("State :" + row["State"]);
                Console.WriteLine("Zip :" + row["Zip"]);
                Console.WriteLine("PhoneNumber :" + row["PhoneNumber"]);
                Console.WriteLine("Email :" + row["Email"]);
                Console.WriteLine("-------------\n");
            }
        }
        public void SortedContactsByNameForAgivenCity(string City)
        {
            Console.WriteLine("Sorting by name for City---->");
            var retrievedData = from records in table.AsEnumerable() where records.Field<string>("City") == City orderby records.Field<string>("FirstName") select records;
            foreach (var row in retrievedData)
            {
                Console.WriteLine("FirstName :" + row["FirstName"]);
                Console.WriteLine("LastName :" + row["LastName"]);
                Console.WriteLine("Address :" + row["Address"]);
                Console.WriteLine("City :" + row["City"]);
                Console.WriteLine("State :" + row["State"]);
                Console.WriteLine("Zip :" + row["Zip"]);
                Console.WriteLine("PhoneNumber :" + row["PhoneNumber"]);
                Console.WriteLine("Email :" + row["Email"]);
                Console.WriteLine("-------------\n");
            }
        }
    }
}
