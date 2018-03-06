using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMS_Key
{
    public class LayoutHelper
    {
        public static List<Category> SetLayout()
        {
            if (!File.Exists("config.xml"))
            {
                Category.SerializeInventory();
            }
            List<Category> categoryList = Category.DeserializeInventory();
            return categoryList;
        }
    }
}
