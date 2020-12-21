using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.SqlClient;



namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        [HttpGet]
        public ActionResult Prod_Descr(int id=1)
        {

            Product xx = new Product();
            xx.kkkk = xx.Table();
            xx.Product_of_ID = id;
            return View(xx);
        }
        void connectionString()
        {

            con.ConnectionString = "data source= 192.168.42.1,1433; database= MerchandiseDB;  User ID=cpfuser;Password=!Log123#;";
        }

        
        
        
        // GET: Product
        [HttpPost]
        
        public ActionResult Add_to_cart(Product prod)
        {
            if (prod.Order_Amount >= 1)
            {
                return View();
            }
            else
            {
                connectionString();
                con.Open();
                com.Connection = con;
                com.CommandText = ""; // Sql to add 1 to order amout
                dr = com.ExecuteReader();
                return View();
            }

        }

        //public ActionResult Checkout()
        //{
                //for checkout controller
        //}

    }
}