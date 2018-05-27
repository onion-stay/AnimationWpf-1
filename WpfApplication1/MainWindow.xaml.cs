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

namespace WpfApplication1
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

        private void O1_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void O2_MouseEnter(object sender, MouseEventArgs e)
        {
           
        }

        private void O3_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void O4_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void O5_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void O6_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void O7_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void O8_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void DoubleAnimation_Completed(object sender, EventArgs e)
        {
            O8.Content = "E";
        }

        private void DoubleAnimation_Completed_1(object sender, EventArgs e)
        {
            O7.Content = "T";
        }

        private void DoubleAnimation_Completed_2(object sender, EventArgs e)
        {
            O6.Content = "E";
        }

        private void DoubleAnimation_Completed_3(object sender, EventArgs e)
        {
            O5.Content = "L";
        }

        private void DoubleAnimation_Completed_4(object sender, EventArgs e)
        {
            O4.Content = "P";
        }

        private void DoubleAnimation_Completed_5(object sender, EventArgs e)
        {
            O3.Content = "M";
        }

        private void DoubleAnimation_Completed_6(object sender, EventArgs e)
        {
            O2.Content = "O";
        }

        private void DoubleAnimation_Completed_7(object sender, EventArgs e)
        {
            O1.Content = "C";
        }

        private void Close_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Minimized_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Minimized_MouseEnter(object sender, MouseEventArgs e)
        {
            Minimized.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2d3436"));
        }

        private void Close_MouseEnter(object sender, MouseEventArgs e)
        {
            Close.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2d3436"));
        }

        private void Minimized_MouseLeave(object sender, MouseEventArgs e)
        {
         Minimized.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffd63031"));
        }

        private void Close_MouseLeave(object sender, MouseEventArgs e)
        {
         Close.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffd63031"));
        }
        private void MenuHeight_CompleteAnimation(object sender, EventArgs e)
        {
            Menu.Visibility = Visibility.Hidden;
        }

        private void CloseHeight_CompleteAnimation(object sender, EventArgs e)
        {
            Close.Visibility = Visibility.Hidden;
        }

        private void MinimizedHeight_CompleteAnimation(object sender, EventArgs e)
        {
            Minimized.Visibility = Visibility.Hidden;
        }
    }
}
