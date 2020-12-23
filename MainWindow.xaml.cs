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

namespace Рейс
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Reis reis = new Reis();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                reis.Pnazn = Pnazn.Text;
                reis.Data = Data.SelectedDate.Value.ToLongTimeString();
                reis.Number = Number.Text;
                reis.Tips = Tips.Text;
                reis.WeekDay = WeekDay.Text;
                reis.TimeStart = TimeStart.Text;
                MessageBox.Show("Объект создан");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            lablSpisok.Content += reis.Print() + "\n";
        }
    }
}
