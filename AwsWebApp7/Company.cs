using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace AwsWebApp7
{
    public class Company
    {

            public string id { get; set; }
            public string vat_number { get; set; }
            public string business_name { get; set; }
            public string created_date { get; set; }
            public string last_modified_date { get; set; }
            public string company_type { get; set; }
            public string description { get; set; }
            public string activation_status { get; set; }
            public string stats_hub_activation_status { get; set; }
            public string stats_hub_activation_message { get; set; }
        }



    }














