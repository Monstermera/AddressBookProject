using Console_Book.Models;
using Console_Book.Services;

namespace Console_Book.Tests
{
    public class Contact_Test
    {
        private AddressBookService addressBookService;
        Contact contact;

        public Contact_Test()
        {
            addressBookService = new AddressBookService();
            contact = new Contact();
        }
        [Fact]
        public void Should_Add_Contact_To_List()
        {
            addressBookService.ContactList.Add(contact);

            Assert.Single(addressBookService.ContactList);
        }
    }
}