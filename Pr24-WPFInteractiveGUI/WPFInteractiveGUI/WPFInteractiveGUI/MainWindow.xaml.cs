using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WPFInteractiveGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller controller;

        public MainWindow()
        {
            InitializeComponent();
            controller = new Controller();
            UpdateUI();
        }

        private void UpdateUI()
        {
            lblpersonCount.Content = "Person Count: " + controller.PersonCount;
            lblindex.Content = "Index: " + controller.PersonIndex;

            UpdateControlsAvailability();

            if (controller.CurrentPerson != null)
            {
                tbfirstName.Text = controller.CurrentPerson.FirstName;
                tblastName.Text = controller.CurrentPerson.LastName;                
                tbage.Text = controller.CurrentPerson.Age.ToString();
                tbtelephoneNo.Text = controller.CurrentPerson.TelephoneNo;
            }
            else
            {
                ClearPersonDetails();
            }
        }

        private void UpdateControlsAvailability()
        {
            bool hasPersons = controller.PersonCount != 0;

            tbfirstName.IsEnabled = hasPersons;
            tblastName.IsEnabled = hasPersons;
            tbage.IsEnabled = hasPersons;
            tbtelephoneNo.IsEnabled = hasPersons;

            btndeletePerson.IsEnabled = hasPersons;
            btnup.IsEnabled = hasPersons && controller.PersonCount > 1;
            btndown.IsEnabled = hasPersons && controller.PersonCount > 1;
        }

        private void ClearPersonDetails()
        {
            tbfirstName.Text = "";
            tblastName.Text = "";           
            tbage.Text = "";
            tbtelephoneNo.Text = "";
        }

        private void btnnewPerson_Click(object sender, RoutedEventArgs e)
        {
            controller.AddPerson();
            UpdateUI();
            // Opdater alder kun hvis tbage er aktiveret
            
        }

        private void btndeletePerson_Click(object sender, RoutedEventArgs e)
        {
            controller.DeletePerson();
            UpdateUI();
        }

        private void btnup_Click(object sender, RoutedEventArgs e)
        {
            controller.NextPerson();
            // Opdater alder kun hvis tbage er aktiveret
           
            UpdateUI();
        }

        private void btndown_Click(object sender, RoutedEventArgs e)
        {
            controller.PrevPerson();
            // Opdater alder kun hvis tbage er aktiveret
           
            UpdateUI();
        }

        private void tbfirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.FirstName = tbfirstName.Text;
        }

        private void tblastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.LastName = tblastName.Text;
        }

        private void tbage_TextChanged(object sender, TextChangedEventArgs e)
        {
            string intAge = tbage.Text;
            if (int.TryParse(intAge, out int parsedAge))
            {
                controller.CurrentPerson.Age = parsedAge;
            }
            else
            {
                // Behandl ugyldig indtastning her, f.eks. vis en meddelelse til brugeren.
            }
        }

        private void tbtelephoneNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.TelephoneNo = tbtelephoneNo.Text;
        }
    }
}
