using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.SqlClient;


namespace WebApplication1.Controllers
{
    public class HomepagemodelController : Controller
    {             
        [HttpGet]
        public ActionResult homepage()
        {
            
            List<homepagemodel> listid = new List<homepagemodel>();
            using (SqlConnection connection = new SqlConnection("data source= 192.168.42.1,1433; database= MerchandiseDB;  User ID=cpfuser;Password=!Log123#;"))
            {
                connection.Open();
                string query = "select * from Product";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //homepagemodel product = new homepagemodel();
                        while (reader.Read())
                        {
                            homepagemodel product = new homepagemodel();
                            product.Prod_ID =    reader["Prod_ID"].ToString();
                            product.Prod_descr = reader["Prod_descr"].ToString();
                            product.Prod_Name =  reader["Prod_Name"].ToString();
                            product.Prod_Price = Convert.ToInt32(reader["Prod_Price"]);
                            listid.Add(product);
                        }
                    }
                }
            }
  
            return View(listid);
        }
        //[HttpPost]
    }
}