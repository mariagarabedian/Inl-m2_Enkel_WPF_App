using Inläm2_Enkel_WPF_App.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Inläm2_Enkel_WPF_App.Views
{
    /// <summary>
    /// Interaction logic for ContactViewModels.xaml
    /// </summary>
    public partial class ContactViewModels : UserControl
    {
        public ContactViewModels()
        {
            InitializeComponent();

            /*
           var contact = new List<string>()
           {
               "Anna Andersson",
               "Carl Haraldsson",
               "Tina Persson",
              

           };

           foreach (var contact in contacts )
           {
               contactList.Children.Add(new Controls.ContactControl() { Contacts = contact });
           } */
        }

        private void btncontact1_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ContactModels();
        }

        private void btnContact2_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ContactModels();
        }

        private void btnContact3_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ContactModels();
        }
    }
}
