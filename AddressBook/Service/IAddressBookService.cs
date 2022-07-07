using AddressBook.Model;

namespace AddressBook.Service
{
    public interface IAddressBookService
    {
        Address CreateAddress(int id, string firstName, string lastName, string addressLine1, string addressLine2, string city, string postCode);
        void DeleteAddress(int id);
        IList<Address> GetAddress();
        Address UpdateAddress(int id, string firstName, string lastName, string addressLine1, string addressLine2, string city, string postCode);
    }
}