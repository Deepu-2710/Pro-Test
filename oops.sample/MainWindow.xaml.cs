using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace oops.sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Utility.UtilityObj.OnNotify += OnSave;
            new ChildOne().Show();
            var child1 = new UtilityWrapper();
            var child2 = new UtilityWrapper();
        }

        private void OnSave()
        {
            MessageBox.Show("Main");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Utility.UtilityObj.ClickOnNotify();
            foreach (var items in Enum.GetValues(typeof(days)))
            {
            }
        }
    }

    enum days
    {
        sunday,
        monday,
        tuesday
    }
}
