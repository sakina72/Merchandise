using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class Sign_UpController : Controller
    {
        SqlConnection con = new SqlConnection();
        
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Sign_Up
        [HttpGet]
        public ActionResult Sign_Up()
        {
            return View();
        }

        void connectionString()
        {

            con.ConnectionString = "data source= 192.168.42.1,1433; database= MerchandiseDB;  User ID=cpfuser;Password=!Log123#;";
        }

        [HttpPost]

        public ActionResult verify(Sign_Up user)

        {
            connectionString();
            con.Open();
            com.Connection = con;

            com.CommandText = "select * from Customer where Cust_ID='" + user.New_CustID + "' ";
            dr = com.ExecuteReader();
            if (dr.Read())
            {

                con.Close();
                
                
                return RedirectToAction("Login", "Account");
            }
            dr.Close();
            
                com.CommandText = "insert into Customer (Cust_ID, Cust_Name, Cust_Email, Cust_Contact, Cust_Address, Cust_Password) values ('"+user.New_CustID+ "','" + user.New_CustID+"name" + "', '" + user.New_CustID +"@email.com" + "', '" + user.New_Cust_Contact + "', '" +"address"+ "', '" + user.New_Cust_Password + "' )";
                dr = com.ExecuteReader();

                con.Close();
                return RedirectToAction("Login", "Account");



        }
    }
}