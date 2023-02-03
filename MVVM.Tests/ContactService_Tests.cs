using FluentAssertions;
using MVVM.Models;
using MVVM.Services;
using System.Collections.ObjectModel;

namespace MVVM.Tests
{
    public class ContactService_Tests
    {
       
        [Fact]
        public void Should_Add_Contact_To_List()
        {
            ContactModel contact = new ContactModel { FirstName = "Hawa", LastName = "Abukar" };
            ContactService.contacts.Add(contact);


            ContactService.contacts.Should().BeOfType<ObservableCollection<ContactModel>>();
            ContactService.contacts.Should().Contain(contact);
        }
    }
}