using RDA.Task._5.Core;
using RDA.Task._5.View.Pages;
using RDA.Task._5.View.Pages.TaskPages;
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
using System.Windows.Shell;

namespace RDA.Task._5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreNavigate.MyConnection = MainFrame;
            MainFrame.Navigate(new TaskPage());
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2 && this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
                Button.Height = 60;
                Button.Width= 320;
                Button.Margin= new Thickness(15, 0, 0, 260);
                Rectangle.Width = 340;
                Rectangle.Height = 1070;
                StackPanel.Margin= new Thickness(120,140, 0, 0);
                Icon.Margin= new Thickness(545, 0, 0, 470);
            }
            else if (e.ClickCount == 2 && this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                Button.Height = 30;
                Button.Width= 160;
                Button.Margin = new Thickness(0, 0, 0, 0);
                Rectangle.Width= 170;
                Rectangle.Height= 550;
                StackPanel.Height = 90;
                StackPanel.Width= 105;
                StackPanel.HorizontalAlignment = HorizontalAlignment.Left;
                StackPanel.VerticalAlignment = VerticalAlignment.Top;
                StackPanel.Margin = new Thickness(0, 0, 0, 0);
            }
        }
            private void Move_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new TaskPage());
        }
        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task11Page());
        }
        private void BtnTask12_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task12Page());
        }
        private void BtnTask13_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task13Page());
        }
        private void BtnTask14_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task14Page());
        }
    }
}
