using AddressBook.Model;
using System.Linq;

namespace AddressBook.Service
{
    public class AddressBookService : IAddressBookService
    {
        private List<Address> addresses = new List<Address>();

        public Address CreateAddress(int id, string firstName, string lastName, string addressLine1, string addressLine2, string city, string postCode)
        {
            var address = new Address()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                AddressLine1 = addressLine1,
                AddressLine2 = addressLine2,
                City = city,
                Postcode = postCode
            };

            addresses.Add(address);

            return address;
        }

        public IList<Address> GetAddress()
        {
            return addresses;
        }

        public void DeleteAddress(int id)
        {
            var address = addresses.FirstOrDefault(x => x.Id == id);
            if (address == null)
            {
                throw new ArgumentException("Address not found");
            }
            addresses.Remove(address);
        }

        public Address UpdateAddress(int id, string firstName, string lastName, string addressLine1, string addressLine2, string city, string postCode)
        {
            var existingAddress = addresses.FirstOrDefault(x => x.Id == id);
            if (existingAddress == null)
            {
                throw new ArgumentException("Address not found");
            }
            existingAddress.FirstName = firstName;
            existingAddress.LastName = lastName;
            existingAddress.AddressLine1 = addressLine1;
            existingAddress.AddressLine2 = addressLine2;
            existingAddress.City = city;
            existingAddress.Postcode = postCode;

            return existingAddress;
        }
    }
}
