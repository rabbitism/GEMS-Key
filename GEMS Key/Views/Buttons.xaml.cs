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
    /// Interaction logic for Buttons.xaml
    /// </summary>
    public partial class Buttons : UserControl
    {
        public Buttons()
        {
            InitializeComponent();
            List<Category> categories = new List<Category>();
            categories.Add(new Category() { CategoryName = "Part" });
            categories.Add(new Category() { CategoryName = "BOM" });
            categories.Add(new Category() { CategoryName = "Document" });
            categories.Add(new Category() { CategoryName = "Drawing" });
            categories.Add(new Category() { CategoryName = "Change" });
            categories.Add(new Category() { CategoryName = "eQuality" });
            categories.Add(new Category() { CategoryName = "eCPU" });
            CategoryList.ItemsSource = categories;
        }
    }

    public class Category
    {
        public string CategoryName { get; set; }
        public List<ButtonInfo> buttons { get; set; } = null;
    }
}
