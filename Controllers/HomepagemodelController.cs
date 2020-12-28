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
        [HttpPost]
        public ActionResult addtocart(string Prod_ID, int Prod_Price)
        {
            
            int Prod_UnitPrice = Prod_Price;
            int Prod_Quantity = 1;
            int Prod_TotalPrice = Prod_Quantity * Prod_UnitPrice;
            string Cart_ID = (string)Session["username"];
            SqlDataReader dr;

            using (SqlConnection connection = new SqlConnection("data source= 192.168.42.1,1433;" +
                                                                " database= MerchandiseDB;  User ID=cpfuser;" +
                                                                "Password=!Log123#;"))
            {
                connection.Open();

                string query = "INSERT INTO CART (Cart_ID, Prod_ID, Prod_UnitPrice, Prod_Quantity, Prod_TotalPrice) values ('" + Cart_ID + "','" + Prod_ID + "','" + Prod_UnitPrice + "','" + Prod_Quantity + "','" + Prod_TotalPrice + "')";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandText = query;
                    dr = command.ExecuteReader();

                    //SqlDataAdapter adapter = new SqlDataAdapter();
                    //adapter.InsertCommand = new SqlCommand(query, connection);  
                    //adapter.InsertCommand.ExecuteNonQuery();

                }

            }
            return new EmptyResult();
            

        }

    }
}
