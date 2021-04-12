using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBiblio.Models
{
    public class Bbiblio
    {
        public Int32 bbiblio_id;
        private String bbiblio_adress;
        private String bbiblio_president_name;
        private String bbiblio_name;
        private String RCS;
        public Int32 Bbbilio_id
        {
            get { return this.bbiblio_id; }
            set { this.bbiblio_id = value; }
        }

        public String Bbiblio_adress
        {
            get { return this.bbiblio_adress;}
             set { this.bbiblio_adress = value; }
        }

        public String Bbiblio_president_name
        {
            get { return this.bbiblio_president_name; }
            set { this.bbiblio_president_name = value; }
        }

        public String Bbiblio_name
        {
            get { return this.bbiblio_name; }
            set { this.bbiblio_name = value; }
        }

        public String Rcs
        {
            get { return this.Rcs; }
            set { this.Rcs = value; }
        }
    }
    
   
}
