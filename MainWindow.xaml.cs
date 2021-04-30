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

namespace MyCourseWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Read(object sender, RoutedEventArgs e)
        {
            var result = VigenereDeshifr.Deshifr(WorkWithFile.ReadFile(), "скорпион");
            TextDeshifr.Text = result;
        }

        private void Button_Click_Save1(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TextDeshifr.Text))
            {
                WorkWithFile.SaveFile(TextDeshifr.Text);
                TextDeshifr.Clear();
            }
            else
            {
                MessageBox.Show("Нечего сохранять");
            }
        }
    }
}
