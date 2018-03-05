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
            categoryList.Add(
                new Category()
                {
                    CategoryName = "Part",
                    ButtonList = new List<ButtonInfo>()
                    {
                        new ButtonInfo(){ButtonName = "Released"},
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
                        new ButtonInfo(){ButtonName = "With Parttttttttttttt"},
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
            categoryList.Add(
                new Category()
                {
                    CategoryName = "Search",
                    ButtonList = new List<ButtonInfo>()
                    {
                        new ButtonInfo(){ButtonName = "Google"},
                        new ButtonInfo(){ButtonName = "Baidu"},
                        new ButtonInfo(){ButtonName = "Youdao"},
                        new ButtonInfo(){ButtonName = "Wiki"}
                    }
                });
            return categoryList;
        }
    }
}
