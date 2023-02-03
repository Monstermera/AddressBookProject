using System;
using System.Collections.ObjectModel;
using System.Linq;
using MVVM.Models;
using Newtonsoft.Json;

namespace MVVM.Services
{
    public class ContactService
    {
        public static ObservableCollection<ContactModel> contacts;
        private static FileService fileService;

        static ContactService()
        {
            fileService= new FileService();
            contacts = fileService.Read();
        }

        public static void Add(ContactModel contact)
        {
            contacts.Add(contact);
            fileService.Save(JsonConvert.SerializeObject(contacts));
        }

        public static void Remove(ContactModel contact)
        {
            contacts.Remove(contact);
            fileService.Save(JsonConvert.SerializeObject(contacts));

        }
        public static void UpdateContactDetails(Guid id, ContactModel contact)
        {
            var existingContact = contacts.FirstOrDefault(c => c.Id == id);
            if (existingContact == null)
            {
                throw new ArgumentException("The specified contact does not exist.");
            }

            var contactIndex = contacts.IndexOf(existingContact);
            contacts[contactIndex] = contact;
            fileService.Save(JsonConvert.SerializeObject(contacts));
        }


        public static ObservableCollection<ContactModel> Contacts()
        {
            return contacts;
        }
    }
}
