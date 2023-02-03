using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM.Models;

namespace MVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableObject currentViewModel;

        [ObservableProperty]
        private ContactModel selectedContact;

        [ObservableProperty]
        private ObservableCollection<ContactModel> contacts;

        [RelayCommand]
        private void GoToAddContact() => CurrentViewModel = new AddContactViewModel();
        [RelayCommand]
        private void GoToEditContact() => CurrentViewModel = new EditContactViewModel();


        [RelayCommand]
        private void GoToContacts(ContactModel selectedContact)
        {
            CurrentViewModel = new ContactsViewModel();
        }

        public MainViewModel()
        {
            CurrentViewModel = new ContactsViewModel();
        }

    }
}
