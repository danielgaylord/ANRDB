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

namespace ANRDB
{
    /// <summary>
    /// Interaction logic for CRWindow.xaml
    /// </summary>
    public partial class CRWindow : Window
    {
        private String side = "";

        public CRWindow()
        {
            InitializeComponent();
        }

        private void Corp_Click(object sender, RoutedEventArgs e)
        {
            Corp_Image.Opacity = 1.0;
            Runner_Image.Opacity = 0.5;
            Create_Button.IsEnabled = true;
            Create_Button.Content = "Create a Corp Deck";
            side = "Corp";
        }

        private void Runner_Click(object sender, RoutedEventArgs e)
        {
            Runner_Image.Opacity = 1.0;
            Corp_Image.Opacity = 0.5;
            Create_Button.IsEnabled = true;
            Create_Button.Content = "Create a Runner Deck";
            side = "Runner";
        }

        private void ChooseSide(object sender, RoutedEventArgs e)
        {
            ((MainWindow)this.Owner).Deck();
            this.Hide();
        }

        public String getSide()
        {
            return side;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            side = "";
        }
    }
}
