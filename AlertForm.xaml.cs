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
using System.Windows.Threading;

namespace Notification
{
    /// <summary>
    /// Interaction logic for AlertForm.xaml
    /// </summary>



    public partial class AlertForm : Window
    {
        public static int pressNumber = 0;
        public static int pressPoition = 0;

        public AlertForm()
        {


            InitializeComponent();

            //var desktopWorkingArea = System.Windows.SystemParameters.WorkArea;
            //this.Left = desktopWorkingArea.Right - this.Width;
            //this.Top = desktopWorkingArea.Bottom - this.Height;

            SizeChanged += (o, e) =>
            {

                var r = SystemParameters.WorkArea;
                Left = r.Right - ActualWidth;
                Top = (r.Bottom - pressPoition) - ActualHeight;
            };

            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 3);
            dispatcherTimer.Start();


            


        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
