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
        public static List<ProductRepository> PrdRepList = new List<ProductRepository>();
        public List<ProductRepository> getProduct()
        {
           
            ProductRepository Prdrep = new ProductRepository();
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = "Data Source = ACUPC_117; Initial Catalog = Auth; Integrated Security = True";
                sqlConnection.Open();
                string query = "select * from Product";
                SqlCommand myCommad = new SqlCommand(query, sqlConnection);
                using (SqlDataReader sqlDataReader = myCommad.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        PrdRepList.Add(new ProductRepository()
                        {
                            PrdName = sqlDataReader["ProductName"].ToString(),
                            ProductPrice = Convert.ToSingle(sqlDataReader["Price"].ToString()),
                            ImageUrl = sqlDataReader["Product"].ToString(),
                            prdID = Convert.ToInt32(sqlDataReader["ProductID"].ToString())

                        });
                    }
                }

            }
            
            return PrdRepList;
        }
    }
}