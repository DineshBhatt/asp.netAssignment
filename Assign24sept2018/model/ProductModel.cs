using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assign24sept2018.Repository;
using System.Data.SqlClient;
using System.Data;

namespace Assign24sept2018.model
{
    public class ProductModel : System.Web.UI.Page
    {
        private SqlConnection sqlConnection = null;

        public List<ProductRepository> PrdRepList = new List<ProductRepository>();
        public List<ProductRepository> getProduct()
        {
           
            ProductRepository Prdrep = new ProductRepository();
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                
                string query = "select * from Product";
                SqlCommand myCommad = new SqlCommand(query, ConnectionOpen());
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
        
        public SqlConnection ConnectionOpen()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source = ACUPC_117; Initial Catalog = Auth; Integrated Security = True";
            sqlConnection.Open();
            return sqlConnection;
        }

        internal void UpdateData(string ProductName, string Product, float Price)
        {
            string sql = $"Update Product Set ProductName = '{ProductName}' , Product = '{Product}', Price= '{Price}'  Where ProductName = '{ProductName}'";
            using (SqlCommand command = new SqlCommand(sql, ConnectionOpen()))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Sorry! your data is not deleted!", ex);
                    throw error;
                }
            }

        }

        public void DeleteInDatabase(int id)
        {
            string ProductName = PrdRepList[id].PrdName;
            string sql = $"Delete from Product where ProductName = '{ProductName}'";
            using (SqlCommand cmd = new SqlCommand(sql, ConnectionOpen()))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Sorry! your data is not deleted!", ex);
                    throw error;
                }
            }
        }
        public void insertintoTable(string ProductName, string Product, float Price)
        {
            ////float Price = Convert.ToSingle(Price1);
            //_sqlConnection.ConnectionString = "Data Source=ACUPC_117;Initial Catalog=Auth;Integrated Security=True";
            //_sqlConnection.Open();
            ////Note the "placeholders" in the SQL query.
            string sql = "Insert Into Product" +
                            "(ProductName, Product, Price) Values" +
                            "(@ProductName, @Product, @Price)";

            // This command will have internal parameters.
            using (SqlCommand command = new SqlCommand(sql, ConnectionOpen()))
            {

                // Fill params collection.
                SqlParameter parameter = new SqlParameter

                {
                    ParameterName = "@ProductName",
                    Value = ProductName,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@Product",
                    Value = Product,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@Price",
                    Value = Price,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();
            }


        }
    }
}