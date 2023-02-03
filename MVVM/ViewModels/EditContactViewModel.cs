using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM.Models;
using MVVM.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVM.ViewModels
{
  public partial class EditContactViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = "Edit Contact";

        [ObservableProperty]
        private ObservableCollection<ContactModel> contacts = ContactService.Contacts();

        [ObservableProperty]
        private ContactModel selectedContact = null!;

        [ObservableProperty]
        private string firstName = string.Empty;

        [ObservableProperty]
        private string lastName = string.Empty;

        [ObservableProperty]
        private string email = string.Empty;

        [ObservableProperty]
        private string phoneNumber = string.Empty;

        [ObservableProperty]
        private string streetName = string.Empty;

        [ObservableProperty]
        private string zipCode = string.Empty;

        [ObservableProperty]
        private string city = string.Empty;


        public ICommand EditCommand => new RelayCommand(UpdateContact);

        private void UpdateContact()
        {
            MessageBox.Show($"{SelectedContact.DisplayName} has been updated");
            ContactService.UpdateContactDetails(SelectedContact.Id, SelectedContact);
        }


        [RelayCommand]
        public void Remove()
        {
            var result = MessageBox.Show($"Are you sure you want wo delete {SelectedContact.DisplayName}?", "Delete contact", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                ContactService.Remove(SelectedContact);

            }
        }
    }
}
