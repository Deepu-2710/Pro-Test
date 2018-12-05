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
using System.Windows.Shapes;

namespace oops.sample
{
    /// <summary>
    /// Interaction logic for ChildOne.xaml
    /// </summary>
    public partial class ChildOne : Window
    {
        public ChildOne()
        {
            InitializeComponent();
            Utility.UtilityObj.OnNotify += OnSave;
        }

        private void OnSave()
        {
            MessageBox.Show("Child");
        }
    }
}
