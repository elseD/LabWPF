using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_DataTemplate
{
    public enum CategoryList { HouseholdAppliances, Food };

    public class Product
    {
        public string ProductName { get; set; }
        public float Price { get; set; }
        public string ImgSource { get; set; }
        public CategoryList ProductCategory { get; set; }
    }
}
