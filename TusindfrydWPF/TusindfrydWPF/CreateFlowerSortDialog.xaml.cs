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
using System.Windows.Shapes;

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for CreateFlowerSortDialog.xaml
    /// </summary>
    public partial class CreateFlowerSortDialog : Window
    {
        FlowerSort flowerSort = new FlowerSort();
      

        public CreateFlowerSortDialog()
        {
            InitializeComponent();

            


        }



        private void tbNavn_TextChanged(object sender, TextChangedEventArgs e)
        {
            flowerSort.Name = tbNavn.Text;
        }

        private void tbBillede_TextChanged(object sender, TextChangedEventArgs e)
        {
            flowerSort.PicturePath = tbBillede.Text;
            

        }
       

        private void UpdateImage()
        {
            string imagePath = tbBillede.Text;

            if (!string.IsNullOrWhiteSpace(imagePath))
            {
                Uri resourceUri = new Uri(imagePath, UriKind.RelativeOrAbsolute);

                try
                {
                    BitmapImage bitmapImage = new BitmapImage(resourceUri);
                    imgBillede.Source = bitmapImage;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur when loading the image.
                    // You can show an error message or take appropriate action here.
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }
        }


        private void tbStørrelse_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbStørrelse.Text))
            {
                if (int.TryParse(tbStørrelse.Text, out int intStørrelse))
                {
                    flowerSort.Size = intStørrelse;
                }
                else
                {
                    // Handle the case where the input is not a valid integer.
                    // You can show an error message or take appropriate action here.
                }
            }

        }


        private void tbProduktionstid1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string intProduktionstid = tbProduktionstid1.Text;

            if (!string.IsNullOrWhiteSpace(intProduktionstid))
            {
                if (int.TryParse(intProduktionstid, out int parsedValue))
                {
                    flowerSort.ProductionTime = parsedValue;
                }
                else
                {
                    // Handle the case where the input is not a valid integer.
                    // You can show an error message or take appropriate action here.
                }
            }
        }

        private void tbHalveringstid1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string intHalveringstid1 = tbHalveringstid1.Text;

            if (!string.IsNullOrWhiteSpace(intHalveringstid1))
            {
                if (int.TryParse(intHalveringstid1, out int parsedValue))
                {
                    flowerSort.HalfLifeTime = parsedValue;
                }
                else
                {
                    // Handle the case where the input is not a valid integer.
                    // You can show an error message or take appropriate action here.
                }
            }
        }

        private void tbBillede_LostFocus_1(object sender, RoutedEventArgs e)
        {
           
                UpdateImage(); // Call a method to update the Image control
          
        }
       
    }
}
