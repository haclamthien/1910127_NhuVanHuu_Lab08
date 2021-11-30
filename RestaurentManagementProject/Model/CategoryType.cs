using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurentManagementProject.Model
{
    public class CategoryType
    {
        public String Name { get; set; }
        public int Value { get; set; }

        public CategoryType(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
