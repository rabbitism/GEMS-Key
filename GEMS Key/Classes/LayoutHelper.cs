using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMS_Key
{
    public class LayoutHelper
    {
        public static List<Category> SetLayout()
        {
            List<Category> categoryList = new List<Category>();
            /*
            categoryList.Add(
                new Category()
                {
                    CategoryName = "Part",
                    ButtonList = new List<ButtonInfo>()
                    {
                        new ButtonInfo(){ButtonName = "Released", Prefix="http://www.gems.slb.com/enovia/common/emxNavigator.jsp?Type=Part&Name=", Suffix="&Rev=!"},
                        new ButtonInfo(){ButtonName = "Created"},
                        new ButtonInfo(){ButtonName = "All"}
                    }
                });
            categoryList.Add(
                new Category()
                {
                    CategoryName = "BOM",
                    ButtonList = new List<ButtonInfo>()
                    {
                        new ButtonInfo(){ButtonName = "Released"},
                        new ButtonInfo(){ButtonName = "With Part"},
                        new ButtonInfo(){ButtonName = "Created"},
                        new ButtonInfo(){ButtonName = "With Part"}
                    }
                });
            categoryList.Add(
                new Category()
                {
                    CategoryName = "Document",
                    ButtonList = new List<ButtonInfo>()
                    {
                        new ButtonInfo(){ButtonName = "Released"},
                        new ButtonInfo(){ButtonName = "Created"},
                        new ButtonInfo(){ButtonName = "All"},
                        new ButtonInfo(){ButtonName = "Related"}
                    }
                });
            categoryList.Add(
                new Category()
                {
                    CategoryName = "Drawing",
                    ButtonList = new List<ButtonInfo>()
                    {
                        new ButtonInfo(){ButtonName = "Released"},
                        new ButtonInfo(){ButtonName = "Created"},
                        new ButtonInfo(){ButtonName = "All"},
                        new ButtonInfo(){ButtonName = "Related"}
                    }
                });
            categoryList.Add(
                new Category()
                {
                    CategoryName = "Change",
                    ButtonList = new List<ButtonInfo>()
                    {
                        new ButtonInfo(){ButtonName = "ECO"},
                        new ButtonInfo(){ButtonName = "ECR"}
                    }
                });
            categoryList.Add(
                new Category()
                {
                    CategoryName = "eQuality",
                    ButtonList = new List<ButtonInfo>()
                    {
                        new ButtonInfo(){ButtonName = "IFR"},
                        new ButtonInfo(){ButtonName = "TFL"}
                    }
                });
                */
            categoryList.Add(
                new Category()
                {
                    CategoryName = "Search",
                    ButtonList = new List<ButtonInfo>()
                    {
                        new ButtonInfo(){ButtonName = "Google", Prefix="http://www.google.com/search?q="},
                        new ButtonInfo(){ButtonName = "Baidu", Prefix="https://www.baidu.com/s?wd="},
                        new ButtonInfo(){ButtonName = "Youdao", Prefix="http://www.youdao.com/w/eng/"},
                        new ButtonInfo(){ButtonName = "Wiki", Prefix="https://en.wikipedia.org/wiki/"}
                    }
                });
            return categoryList;
        }
    }
}
