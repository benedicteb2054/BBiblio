using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBiblio.Models
{
    public class News
    {
        public Int32 news_id;
        private DateTime publication_date;
        private DateTime registration_date;
        private DateTime update_date;
        private String news_text;
        private String image;

        public Int32 News_id
        {
            get { return this.news_id; }
            set { this.news_id = value; }
        }

        public DateTime Publication_date
        {
            get { return this.publication_date; }
            set { this.publication_date = value; }
        }

        public String Registration_date
        {
            get { return this.registration_date; }
            set { this.registration_date = value; }
        }

        public DateTime Update_date
        {
            get { return this.update_date; }
            set { this.update_date = value; }
        }

        public Int32 News_text
        {
            get { return this.news_text; }
            set { this.news_text = value; }
        }

        public String Image
        {
            get { return this.image; }
            set { this.image = value; }
        }

    }
}
