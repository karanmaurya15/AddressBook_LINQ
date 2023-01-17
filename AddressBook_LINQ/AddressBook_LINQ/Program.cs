namespace AddressBook_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book System Using LINQ");
            AddressBookManagment addressBookManagment = new AddressBookManagment();
            addressBookManagment.InsertContactToTable();
            addressBookManagment.DisplayContacts();
            addressBookManagment.EditExistingContact("Karan","Kushwaha", "City", "Lucknow");
            addressBookManagment.DeleteContact("Irbaz", "Patel");
            addressBookManagment.RetrieveByCity("Kanpur");
            addressBookManagment.RetrieveByState("UttarPradesh");
            addressBookManagment.SortedContactsByNameForAgivenCity("Lucknow");
        }
    }
}