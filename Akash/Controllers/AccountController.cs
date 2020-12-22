using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.SqlClient;


namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Login()                 
        {
            return View();
        }
        void connectionString()
        {

            con.ConnectionString = "data source= 192.168.42.1,1433; database= MerchandiseDB;  User ID=cpfuser;Password=!Log123#;";
        }

        [HttpPost]
        public ActionResult verify(Account acc)

        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Customer where Cust_ID='"+acc.Name+"' and Cust_Password='"+ acc.Password+ "'";
            dr = com.ExecuteReader();
            if (dr.Read()) {
        
                con.Close();
                return RedirectToAction("homepage", "homepagemodel");
            }
            else {
                con.Close();
                return View("Login");
            }
            
            
        }
    }
}