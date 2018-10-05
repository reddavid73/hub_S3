using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Drawing;
using System.Text;

namespace AwsWebApp7
{
    public partial class Default2 : System.Web.UI.Page
    {

        string connStr = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;



        MySqlDataAdapter da;
        DataSet ds = new DataSet();
        StringBuilder htmlTable = new StringBuilder();
        StringBuilder htmlTable2 = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["RefreshCtr"] == null)
            {
                Session["RefreshCtr"] = 1;
                TxbSESS3.Text = Session["RefreshCtr"].ToString();

                TxbSESS2.Text = Session["RefreshCtr"].ToString();
            }



            if (!IsPostBack)
            {
                //BindData();
                //Select();
            }


        }


        private void BindData()
        {
            String strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(strConnString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM company", con);
            da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            //htmlTable.Append("<table border='1'>");
            //htmlTable.Append("<tr style='background-color:green; color: White;'><th>Customer ID.</th><th>Name</th><th>Address</th><th>Contact No</th></tr>");

            if (!object.Equals(ds.Tables[0], null))
            {
                if (ds.Tables[0].Rows.Count > 0)
                {

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        //htmlTable.Append("<tr style='color: White;'>");
                        htmlTable.Append("<tr>");
                        htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["vat_number"] + "</td>");
                        htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["business_name"] + "</td>");
                        htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["created_date"] + "</td>");
                        htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["activation_status"] + "</td>");
                        htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["stats_hub_activation_message"] + "</td>");
                        htmlTable.Append("</tr>");
                    }
                    htmlTable.Append("</table>");
                    //DBDataPlaceHolder.Controls.Add(new Literal { Text = htmlTable.ToString() });
                }
                else
                {
                    htmlTable.Append("<tr>");
                    htmlTable.Append("<td align='center' colspan='4'>There is no Record.</td>");
                    htmlTable.Append("</tr>");
                }
            }
        }
        public void ConnectDB(string name)
        {
           

            string connStr = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();

            con.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select vat_number,business_name,created_date,last_modified_date,company_type,description,activation_status,stats_hub_activation_status,stats_hub_activation_message WHERE CategoryID =@CategoryID", con);
            dataAdapter.SelectCommand.Parameters.Add("@CategoryID");




            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            //while (dt.Rows.Count > 0)
            //{
            //    TextBox1.Text = dt.Rows[0]["business_name"].ToString();
            //}



            //GridView1.DataSource = ds;
            //GridView1.DataBind();
            //TextBox9.Text = GridView1.Rows.Count.ToString();

        }

        //[System.Web.Services.WebMethod]
        //public static string GetCurrentTime(string name)
        //{
        //    string connStr = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        //    MySqlConnection con = new MySqlConnection(connStr);
        //    con.Open();
        //    MySqlCommand cmd = new MySqlCommand("select * from company where business_name= @business_name", con);
        //    cmd.Parameters.AddWithValue("business_name", name);
        //    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    con.Close();


        //    List<string> list = new List<string>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        string rowAsString = string.Join(", ", dt.Rows[i].ItemArray);
        //        list.Add(rowAsString);
        //    }
        //    string[] array = list.ToArray();



        //    return name;
        //}


        //[System.Web.Services.WebMethod]
        //public static string GetCurrentTime(string name,string output)
        //{
        //    System.IO.StringWriter sw;
        //    //string output;


        //    string connStr = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        //    MySqlConnection con = new MySqlConnection(connStr);
        //    con.Open();
        //    MySqlCommand cmd = new MySqlCommand("select * from company where business_name= @business_name", con);
        //    cmd.Parameters.AddWithValue("business_name", name);
        //    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    con.Close();



        //    // Loop through each row in the table. '
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        sw = new System.IO.StringWriter();
        //        // Loop through each column. '
        //        foreach (DataColumn col in dt.Columns)
        //        {
        //            // Output the value of each column's data.
        //            //sw.Write(row(col).ToString() + ", ");
        //            output = sw.ToString();
        //            // Trim off the trailing ", ", so the output looks correct. '
        //            if (output.Length > 2)
        //                output = output.Substring(0, output.Length - 2);
        //            // Display the row in the console window. '
        //            //Console.WriteLine(output);
        //        }
                
        //    }

        //    return output;
        //}


    //     public static string ConvertDataTableToString(DataTable dt)
    //{









                  [System.Web.Services.WebMethod]
        public static string GetCurrentTime(string name)
        {
            System.IO.StringWriter sw;
            //string output;


            string connStr = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connStr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from company where business_name= @business_name", con);
            cmd.Parameters.AddWithValue("business_name", name);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();


            var output = new StringBuilder();
        var columnsWidths = new int[dt.Columns.Count];

        // Get column widths
        foreach (DataRow row in dt.Rows)
        {
           for(int i = 0; i < dt.Columns.Count; i++)
           {
               var length = row[i].ToString().Length;
               if (columnsWidths[i] < length)
                   columnsWidths[i] = length;
           }     
        }

        // Get Column Titles
        for (int i = 0; i < dt.Columns.Count; i++)
        {
            var length = dt.Columns[i].ColumnName.Length;
               if (columnsWidths[i] < length)
                   columnsWidths[i] = length;
        }

        // Write Column titles
        for (int i = 0; i < dt.Columns.Count; i++)
        {
            var text = dt.Columns[i].ColumnName;
            output.Append("|" + PadCenter(text, columnsWidths[i] + 2));
        }
        //output.Append("|\n" + new string('=', output.Length) + "\n");

        // Write Rows
        foreach (DataRow row in dt.Rows)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                var text = row[i].ToString();
                output.Append("|" + PadCenter(text,columnsWidths[i] + 2));
            }
            output.Append("|\n");
        }
        return output.ToString();
    }


    private static string PadCenter(string text, int maxLength)
    {
        int diff = maxLength - text.Length;
        return new string(' ', diff/2) + text + new string(' ', (int) (diff / 2.0 + 0.5));

    } 












    }
}


    

