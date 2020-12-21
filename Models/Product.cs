using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebApplication1.Models
{
    public class Product:homepagemodel
    {
        public DataTable kkkk= new DataTable();

        public int Product_of_ID { get; set; }

        public DataTable Table()
        {
            // Create a new DataTable.
            DataTable table = new DataTable("Product Details");
            // Declare variables for DataColumn and DataRow objects.
            //DataColumn column;
            

            table.Columns.Add("Prod_ID");
            table.Columns.Add("Prod_Name");
            table.Columns.Add("Prod_Price");
            table.Columns.Add("Prod_Descr");
            int c=10;
            for (c=1; c<=10; c++) {
                DataRow row = table.NewRow();
                row["Prod_ID"] = "Product_ID "+c;
                row["Prod_Name"] = "Produc_tName "+c;
                row["Prod_Price"] = "Product_price "+c;
                row["Prod_Descr"] = "Product_Details "+c ;

                table.Rows.Add(row);
            }
            
            return table;
        }

        
    }
    
}