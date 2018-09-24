using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assign24sept2018.Repository;
using System.Data.SqlClient;

namespace Assign24sept2018.model
{
    public class ProductModel
    {
        
        public List<ProductRepository> getProduct()
        {
            List<ProductRepository> PrdRepList = new List<ProductRepository>();
            ProductRepository Prdrep = new ProductRepository();
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.Open();
                string query = "select * from Product";
                SqlCommand myCommad = new SqlCommand(query, sqlConnection);
                using (SqlDataReader sqlDataReader = myCommad.ExecuteReader())
                {
                    //while()
                }

            }
            
            return PrdRepList;
        }
    }
}