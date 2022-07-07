using AddressBook.Model;
using AddressBook.Service;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AddressBook.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : ControllerBase
    {
        private IAddressBookService _addressBookService;

        public AddressController(IAddressBookService addressBookService)
        {
            _addressBookService = addressBookService;
        }

        // GET: api/<AddressController>
        [HttpGet]
        public IEnumerable<Address> Get()
        {
            return _addressBookService.GetAddress();
        }

        // POST api/<AddressController>
        [HttpPost]
        public void Post([FromBody] int id, string firstName, string lastName, string addressLine1, string addressLine2, string city, string postCode)
        {
            var newAddress = _addressBookService.CreateAddress(id, firstName, lastName, addressLine1, addressLine2, city, postCode);
            
        }

        // PUT api/<AddressController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string firstName, string lastName, string addressLine1, string addressLine2, string city, string postCode)
        {
            var updateAddress = _addressBookService.UpdateAddress(id, firstName, lastName, addressLine1, addressLine2, city, postCode);
        }

        // DELETE api/<AddressController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _addressBookService.DeleteAddress(id);
        }
    }
}
