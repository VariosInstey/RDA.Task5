using RDA.Task._5.Core;
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

namespace RDA.Task._5.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        public TaskPage()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
                CoreNavigate.MyConnection?.Navigate(new Task1Page());
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task2Page());
        }
        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task3Page());
        }
        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task4Page());
        }
        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task5Page());
        }
        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task6Page());
        }
        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task7Page());
        }
        private void BtnTask8_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task8Page());
        }
        private void BtnTask9_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task9Page());
        }
        private void BtnTask10_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task10Page());
        }
    }
}
