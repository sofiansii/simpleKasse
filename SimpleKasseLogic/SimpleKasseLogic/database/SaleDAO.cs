using SimpleKasseLogic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleKasseLogic.database
{
    public static class SaleDAO
    {
        public static bool AddSale(List<Article> cart)
        {
            try
            {
                foreach (var cartArticle in cart)
                {
                    var DBarticle = ArticleDAO.getArticle(cartArticle.Name);
                    if (DBarticle.Quantity < cartArticle.Quantity)
                    {
                        MessageBox.Show($"Article {cartArticle.Name} quantity is not enough");
                        return false;
                    }

                }
                var comm = DB.newCommand("insert into Sale values(null,@date,@initiator)");
                comm.Parameters.AddWithValue("@date", DateOnly.FromDateTime(DateTime.Now).ToString());
                comm.Parameters.AddWithValue("@initiator", UserDAO.CurrentUser.UserName);
                var res = comm.ExecuteNonQuery();
                comm.Parameters.Clear();
                Int64 saleID;
                if (res == 0)
                {
                    comm.Connection.Close();
                    return false;
                }
                else
                {
                    comm.CommandText = "select max(id) from Sale";
                    saleID = (Int64) comm.ExecuteScalar();
                }
                foreach (var cartArticle in cart)
                {
                    comm.CommandText ="insert into SaleArticle values(@saleID,@article_ref,@quantity,@price)";
                    comm.Parameters.AddWithValue("@saleID", saleID);
                    comm.Parameters.AddWithValue("@article_ref", cartArticle.Name);
                    comm.Parameters.AddWithValue("@quantity", cartArticle.Quantity);
                    comm.Parameters.AddWithValue("@price", cartArticle.Price);
                    res = comm.ExecuteNonQuery();
                    comm.Parameters.Clear();
                    if (res == 0)
                    {
                        comm.CommandText = ("delete from SaleArticle where saleID = " + saleID);
                        comm.ExecuteNonQuery();
                        comm.CommandText = "delete from Sale where id = " + saleID;
                        comm.ExecuteNonQuery();
                        comm.Connection.Close();
                        return false;
                    }
                    ArticleDAO.UpdateQuantity(cartArticle.Name, ArticleDAO.getArticle(cartArticle.Name).Quantity - cartArticle.Quantity);

                }
                comm.Connection.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static List<Sale> GetSales(string initiator)
        {
            try
            {
                var comm = DB.newCommand($"select * from Sale where initiator=@initiator");
                comm.Parameters.AddWithValue("@initiator", initiator);
                var rd = comm.ExecuteReader();
                var Sales = new List<Sale>();
                while (rd.Read())
                {
                    var Sale = new Sale(rd.GetInt64(0), rd.GetString(1), rd.GetString(2),new List<Article>());
                    Sales.Add(Sale);
                }
                rd.Close();
                foreach(Sale sale in Sales)
                {
                    comm.CommandText = "select * from SaleArticle where sale_id=@sale_id";
                    comm.Parameters.AddWithValue("@sale_id", sale.id);
                    rd = comm.ExecuteReader();
                    while (rd.Read())
                        sale.cart.Add(new Article(rd.GetString(1), "", rd.GetInt32(2), rd.GetDouble(3)));
                    rd.Close();
                }
                comm.Connection.Close();
                return Sales;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<Sale>();
            }


        }
        public static List<Sale> GetSales()
        {
            try
            {
                var comm = DB.newCommand($"select * from Sale ");
                var rd = comm.ExecuteReader();
                var Sales = new List<Sale>();
                while (rd.Read())
                {
                    var Sale = new Sale(rd.GetInt64(0), rd.GetString(1), rd.GetString(2), new List<Article>());
                    Sales.Add(Sale);
                }
                rd.Close();
                foreach (Sale sale in Sales)
                {
                    comm.CommandText = "select * from SaleArticle where sale_id=@sale_id";
                    comm.Parameters.AddWithValue("@sale_id", sale.id);
                    rd = comm.ExecuteReader();
                    while (rd.Read())
                        sale.cart.Add(new Article(rd.GetString(1), "", rd.GetInt32(2), rd.GetDouble(3)));
                    rd.Close();
                }
                comm.Connection.Close();
                return Sales;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<Sale>();
            }


        }
    }
}
