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
using WpfApp5._1.Pages;

namespace WpfApp5._1
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
        private Page[] pages = new Page[]
        {
        new RoutingPage(),
        new AttacheEventsPage(),
        new TextBoxPage(),
        new ValidationInputPage()
        };

        private void PageComboBox_SelectionChanged(object sender,SelectionChangedEventArgs e)
        {

        }
        private void combobox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
