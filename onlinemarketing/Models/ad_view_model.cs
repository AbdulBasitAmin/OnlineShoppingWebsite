using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onlinemarketing.Models
{
    public class ad_view_model
    {
        public int pro_id { get; set; }
        public string pro_name { get; set; }
        public string pro_image { get; set; }
        public Nullable<int> pro_price { get; set; }
        public string pro_desc { get; set; }



        public Nullable<int> cat_id_fk { get; set; }
        public Nullable<int> pro_user_id_fk { get; set; }

        public int cat_id { get; set; }
        public string cat_name { get; set; }


        public string u_name { get; set; }

     
    public string u_image { get; set; }

        public string u_contact { get; set; }



    }
}