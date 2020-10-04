using Inläm2_Enkel_WPF_App.Models;
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

namespace Inläm2_Enkel_WPF_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*
            var menus = new List<string>()
            {
                "Message",
                "Contacts",
                "Calendar",
                "Tasks",
                "Settings"

            };

            foreach (var menu in menus )
            {
                menuList.Children.Add(new Controls.MenuControl() { MenuChoice = menu });
            } */

            
        }
        
        private void btnMessage_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MessageModels();
        }

        private void btnContacts_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ContactModels();
        }

        private void btnCalendar_Click(object sender, RoutedEventArgs e)
        {
            DataContext =  new CalendarModels();
        }

        private void btnTasks_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new TasksModels();
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new SettingsModels();
        }
    }
}
