using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService
{
    internal class InventoryData : DbConnection
    {
        static int s = 1;
        public void Insert(object obj)
        {
            Item itm = (Item)obj;
            try
            {
                // make sure in your table the id in auto-incremented
                string sql = "INSERT INTO ItemTable (Id,Name,Quantity,Price) VALUES (@Id,@name,@quantity,@price)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", s++);
                cmd.Parameters.AddWithValue("@name", itm.Name);
                cmd.Parameters.AddWithValue("@quantity", itm.Quantity);
                cmd.Parameters.AddWithValue("@price", itm.Price);
                conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }


        public object ReadAll()
        {
            List<Item> items = new List<Item>();


            try
            {
                string sql = "SELECT Id,Name,Quantity,Price FROM ItemTable;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    items.Add(new Item(Convert.ToInt32(dr[0]),dr[1].ToString(), Convert.ToInt32(dr[2]), Convert.ToDouble(dr[3])));
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return items;
        }

        public void Update(Item newitem,int ID)
        {
            try
            {
                string sql = "UPDATE ItemTable SET Name = @name,Quantity = @quantity,Price=@price WHERE Id =@id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", newitem.Name);
                cmd.Parameters.AddWithValue("@quantity", newitem.Quantity);
                cmd.Parameters.AddWithValue("@price", newitem.Price);
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void Delete(object obj)
        {
            Item stock = (Item)obj;
            try
            {
                string sql = "DELETE FROM ItemTable WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", stock.Id);


                conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }


    }


}
