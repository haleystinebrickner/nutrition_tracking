using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }

        public string Category { get; set; }

        public string User {  get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
