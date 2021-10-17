using DataService.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService
{
    class DB
    {
        public void AddProduct(List<Products> products)
        {


            try
            {
                string connectionString = "Server=DESKTOP-R3MPILK;Database=PMS;Trusted_Connection=True;MultipleActiveResultSets=true";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    foreach (Products p in products)
                    {
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO[dbo].[Products] (Title,Price,Description,Category,Image,Rate,Count) VALUES (" +
                           "@Title,@Price,@Description,@Category,@Image,@Rate,@Count)", conn))
                        {

                            cmd.Parameters.AddWithValue("@Title", p.Title);
                            cmd.Parameters.AddWithValue("@Price", float.Parse(p.Price));
                            cmd.Parameters.AddWithValue("@Description", p.Description);
                            cmd.Parameters.AddWithValue("@Category", p.Category);
                            cmd.Parameters.AddWithValue("@Image", p.Image);
                            cmd.Parameters.AddWithValue("@Rate", p.rating.Rate);
                            cmd.Parameters.AddWithValue("@Count", p.rating.Count);

                            int rows = cmd.ExecuteNonQuery();
                       
                        //rows number of record got inserted
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                //Log exception
                //Display Error message
            }
        }
    }
}
