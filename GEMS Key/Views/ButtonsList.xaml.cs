using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace GEMS_Key
{
    /// <summary>
    /// Interaction logic for ButtonsCategory.xaml
    /// </summary>
    public partial class ButtonsList : UserControl
    {
        public ButtonsList()
        {
            InitializeComponent();
        }

        public string CategoryName
        {
            get { return (string)GetValue(CategoryNameProperty); }
            set { SetValue(CategoryNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CategoryName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CategoryNameProperty =
            DependencyProperty.Register("CategoryName", typeof(string), typeof(ButtonsList), new PropertyMetadata("Default"));


        public List<ButtonInfo> List
        {
            get { return (List<ButtonInfo>)GetValue(ListProperty); }
            set { SetValue(ListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for list.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ListProperty =
            DependencyProperty.Register("List", typeof(List<ButtonInfo>), typeof(ButtonsList), new PropertyMetadata(null));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Process.Start("https://www.google.com/search?q=");
        }
    }

    
}
