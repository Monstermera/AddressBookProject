using MVVM.Models;
using MVVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVM.Views
{
    /// <summary>
    /// Interaction logic for EditContactView.xaml
    /// </summary>
    public partial class EditContactView : UserControl
    {
        public EditContactView()
        {
            InitializeComponent();
        }

        



        //private void Btn_Remove_Click(object sender, RoutedEventArgs e)
        //{
        //    var button = (Button)sender;
        //    var contact = (ContactModel)button.DataContext;

        //    var result = MessageBox.Show($"Are you sure you want wo delete {selectedContact.DisplayName}?", "Delete contact", MessageBoxButton.YesNo);
        //    if(result == MessageBoxResult.Yes)
        //    {
        //        ContactService.Remove(contact);

        //    }

        //}
    }
}
