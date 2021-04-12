using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBiblio.Models
{
    public class Criteria
    {
        public Int32 criterion_id;
        private String criterion_name;
        private String criterion_description;
        private DateTime criterion_update;

        public Int32 Criterion_id
        {
            get { return this.criterion_id; }
            set { this.criterion_id = value; }
        }

        public String Criterion_name
        {
            get { return this.criterion_name; }
            set { this.criterion_name = value; }
        }

        public String Criterion_description
        {
            get { return this.criterion_description; }
            set { this.criterion_description = value; }
        }

        public DateTime Criterion_update
        {
            get { return this.criterion_update; }
            set { this.criterion_update = value; }
        }
    }
}
