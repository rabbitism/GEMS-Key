using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using System.Xml.Serialization;

namespace GEMS_Key
{
    public class Category
    {
        public string CategoryName { get; set; } = "Search";

        public List<ButtonInfo> ButtonList { get; set; } = null;

        public static void SerializeInventory()
        {
            var category1 = new Category
            {
                CategoryName = "Part",
                ButtonList = new List<ButtonInfo>
                {
                    new ButtonInfo {ButtonName = "Released"},
                    new ButtonInfo {ButtonName = "Created"}
                }
            };

            var category2 = new Category
            {
                CategoryName = "BOM",
                ButtonList = new List<ButtonInfo>
                {
                    new ButtonInfo {ButtonName = "Released"},
                    new ButtonInfo {ButtonName = "Created"}
                }
            };

            List<Category> categories = new List<Category>
            {
                category1,
                category2
            };
            using (FileStream stream = File.Create("config.xml"))
            {
                var serializer = new XmlSerializer(typeof(List<Category>));
                serializer.Serialize(stream, categories);
            }

        }

        public static List<Category> DeserializeInventory()
        {
            using (FileStream stream = File.OpenRead("config.xml"))
            {
                var serializer = new XmlSerializer(typeof(List<Category>));
                List<Category> categories = serializer.Deserialize(stream) as List<Category>;
                return categories;
            }
        }
    }

    public class ButtonInfo
    {
        [XmlElement]
        public string ButtonName { get; set; } = "Search";
        [XmlElement]
        public string Hotkey { get; set; }
        [XmlElement]
        public string Prefix { get; set; } = null;
        [XmlElement]
        public string Suffix { get; set; } = null;
    }

}
