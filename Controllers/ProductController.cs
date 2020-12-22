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

        //SqlConnection con = new SqlConnection();
        //SqlCommand com = new SqlCommand();
        //SqlDataReader dr;

        [HttpGet]
        public ActionResult Prod_Descr(string Prod_ID, string Prod_Name, string Prod_Descr,string Prod_Price)
        {

            Product details = new Product();
            details.Prod_ID = Prod_ID;
            details.Prod_Name = Prod_Name;
            details.Prod_Descr = Prod_Descr;
            details.Prod_Price = Prod_Price;
            return View(details);
        }
        //void connectionString()
        //{

        //    con.ConnectionString = "data source= 192.168.42.1,1433; database= MerchandiseDB;  User ID=cpfuser;Password=!Log123#;";
        //}

        
        
        
        // GET: Product
        //[HttpPost]
        
        //public ActionResult Add_to_cart(Product prod)
        //{
        //    if (prod.Order_Amount >= 1)
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        connectionString();
        //        con.Open();
        //        com.Connection = con;
        //        com.CommandText = ""; // Sql to add 1 to order amout
        //        dr = com.ExecuteReader();
        //        return View();
        //    }

        //}

        //public ActionResult Checkout()
        //{
                //for checkout controller
        //}

    }
}