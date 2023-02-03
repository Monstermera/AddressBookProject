using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM.Models;
using MVVM.Services;

namespace MVVM.ViewModels
{
    public partial class AddContactViewModel : ObservableObject
    {
        
        [ObservableProperty]
        private string title = "Add Contacts";

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


        private bool isFormValid;

        private bool IsFormValid
        {
            get => isFormValid;
            set => SetProperty(ref isFormValid, value);
        }

        private RelayCommand _addCommand;
        public RelayCommand AddContactCommand
        {
            get
            {
                return _addCommand ?? (_addCommand = new RelayCommand(Add, CanAdd));
            }
        }

        private bool CanAdd()
        {
            return !string.IsNullOrWhiteSpace(FirstName)
                && !string.IsNullOrWhiteSpace(LastName)
                && !string.IsNullOrWhiteSpace(Email)
                && !string.IsNullOrWhiteSpace(PhoneNumber)
                && !string.IsNullOrWhiteSpace(ZipCode)
                && !string.IsNullOrWhiteSpace(City);
        }


        [RelayCommand]
        private void Add()
        {

            if (string.IsNullOrWhiteSpace(FirstName))
            {
                MessageBox.Show("First Name is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(LastName))
            {
                MessageBox.Show("Last Name is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("Email is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(PhoneNumber))
            {
                MessageBox.Show("Phone Number is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(StreetName))
            {
                MessageBox.Show("Street Name is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(ZipCode))
            {
                MessageBox.Show("Zip Code is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(City))
            {
                MessageBox.Show("City is required.");
                return;
            }


            ContactService.Add(new ContactModel
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                PhoneNumber = PhoneNumber,
                StreetName = StreetName,
                ZipCode = ZipCode,
                City = City
            });
            ClearForm();
        }

        private void ClearForm()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            PhoneNumber = string.Empty;
            StreetName = string.Empty;
            ZipCode = string.Empty;
            City = string.Empty;
        }

    }
}
