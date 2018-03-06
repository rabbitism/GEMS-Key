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
                CategoryName = "Search",
                ButtonList = new List<ButtonInfo>
                {
                    new ButtonInfo {ButtonName = "Google", Prefix = "http://www.google.com/search?q="},
                    new ButtonInfo {ButtonName = "Baidu", Prefix = "https://www.baidu.com/s?wd="},
                    new ButtonInfo {ButtonName = "Wiki", Prefix = "https://en.wikipedia.org/wiki/"}
                }
            };

            var category2 = new Category
            {
                CategoryName = "Translation",
                ButtonList = new List<ButtonInfo>
                {
                    new ButtonInfo {ButtonName = "Youdao", Prefix = "http://www.youdao.com/w/eng/"},
                    new ButtonInfo {ButtonName = "STS", Prefix = "https://translation.steampowered.com/translate.php?search_input=", Suffix = "&lang=schinese"},
                    new ButtonInfo {ButtonName = "Google", Prefix = "https://translate.google.com/#auto/en/"}

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
        public string Hotkey { get; set; } = null;

        [XmlElement]
        public string Prefix { get; set; } = null;

        [XmlElement]
        public string Suffix { get; set; } = null;
    }

}
