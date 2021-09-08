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

namespace Notification
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static int windowToClose = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AlertForm alertForm = new AlertForm();
            alertForm.Show();
            AlertForm.pressPoition += 145;
            AlertForm.pressNumber+= 1;

            if (AlertForm.pressNumber % 4 == 0)
            {
                windowToClose = AlertForm.pressNumber / 4;
            }
            if (AlertForm.pressNumber == 4)
            {
                AlertForm.pressPoition = 0;
                AlertForm.pressNumber = 0;
            }
            
        }

      
    }
}
