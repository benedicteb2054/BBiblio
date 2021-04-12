using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBiblio.Models
{
    public class Seasons
    {
        public Int32 season_id;
        private DateTime season_start;
        private DateTime season_end;
        private String update_date;

        public Int32 Season_id
        {
            get { return this.season_id; }
            set { this.season_id = value; }
        }

        public DateTime Season_start
        {
            get { return this.season_start; }
            set { this.season_start = value; }
        }

        public DateTime Season_end
        {
            get { return this.season_end; }
            set { this.season_end = value; }
        }

        public String Update_date
        {
            get { return this.update_date; }
            set { this.update_date = value; }
        }
    }
}