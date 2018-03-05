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

namespace GEMS_Key
{
    /// <summary>
    /// Interaction logic for ButtonsCategory.xaml
    /// </summary>
    public partial class ButtonsCategory : UserControl
    {
        public ButtonsCategory()
        {
            InitializeComponent();
            List<ButtonInfo> buttons = new List<ButtonInfo>();
            buttons.Add(new ButtonInfo() { ButtonName = "Released" });
            buttons.Add(new ButtonInfo() { ButtonName = "Created" });
            buttons.Add(new ButtonInfo() { ButtonName = "All Rev" });
            ButtonList.ItemsSource = buttons;
        }

        public string CategoryName
        {
            get { return (string)GetValue(CategoryNameProperty); }
            set { SetValue(CategoryNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CategoryName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CategoryNameProperty =
            DependencyProperty.Register("CategoryName", typeof(string), typeof(ButtonsCategory), new PropertyMetadata("Default"));

    }

    public class ButtonInfo
    {
        public string ButtonName { get; set; }
    }
}
