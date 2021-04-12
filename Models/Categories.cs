using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBiblio.Models
{
    public class Categories
    {
        public Int32 category_id;
        private String category_name;
        private String category_description;
        private DateTime category_update;

        public Int32 Category_id
        {
            get { return this.category_id; }
            set { this.category_id = value; }
        }

        public String Category_name
        {
            get { return this.category_name; }
            set { this.category_name = value; }
        }

        public String Category_description
        {
            get { return this.category_description; }
            set { this.category_description= value; }
        }

        public DateTime Category_update
        {
            get { return this.category_update; }
            set { this.category_update = value; }
        }
    }
}
