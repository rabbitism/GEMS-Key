using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GEMS_Key
{
    public class Category
    {
        public string CategoryName { get; set; } = "Search";
        public List<ButtonInfo> ButtonList { get; set; } = null;
    }

    public class ButtonInfo
    {
        public string ButtonName { get; set; } = "Search";
        public string Hotkey { get; set; }
        public string Prefix { get; set; } = null;
        public string Suffix { get; set; } = null;
    }

}
