using SimpleKasseLogic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleKasseLogic.database
{
    public static class ArticleDAO
    {
        public static bool AddArticle(Article article)
        {
            try
            {
                var comm = DB.newCommand($"insert into Article values(@name,@description,@stock,@price)");
                comm.Parameters.AddWithValue("@name", article.Name);
                comm.Parameters.AddWithValue("@description", article.Description);
                comm.Parameters.AddWithValue("@stock", article.Quantity);
                comm.Parameters.AddWithValue("@price", article.Price);
                var res = comm.ExecuteNonQuery();
                comm.Connection.Close();
                return res != 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }
        public static bool DeleteArticle(Article article)
        {
            try
            {
                var comm = DB.newCommand($"Delete from Article where  name = @name");
                comm.Parameters.AddWithValue("@username", article.Name);
                var res = comm.ExecuteNonQuery();
                comm.Connection.Close();
                return res != 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }
        public static bool UpdateArticle(Article article)
        {
            try
            {
                var comm = DB.newCommand($"update article set description=@description,stock=@stock,price=@price where name=@name");
                comm.Parameters.AddWithValue("@name", article.Name);
                comm.Parameters.AddWithValue("@description", article.Description);
                comm.Parameters.AddWithValue("@stock", article.Quantity);
                comm.Parameters.AddWithValue("@price", article.Price);
                var res = comm.ExecuteNonQuery();
                comm.Connection.Close();
                return res != 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        public static bool UpdateQuantity(string name,int quantity)
        {
            try
            {
                var comm = DB.newCommand($"update article set stock=@stock where name=@name");
                comm.Parameters.AddWithValue("@name", name);
                comm.Parameters.AddWithValue("@stock", quantity);
                var res = comm.ExecuteNonQuery();
                comm.Connection.Close();
                return res != 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }
        public static Int64 QuantitySold(string name)
        {
            try
            {
                var comm = DB.newCommand($"select sum (quantity) from SaleArticle where article_ref=@name");
                comm.Parameters.AddWithValue("@name", name);
                var res = comm.ExecuteScalar();
                var quantity = res is Int64 ? (Int64) res : 0;
                comm.Connection.Close();
                return quantity;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }

        }
        public static Article getArticle(string name)
        {
            try
            {
                var comm = DB.newCommand($"select * from article where name=@name ");
                comm.Parameters.AddWithValue("@name", name);
                var rd = comm.ExecuteReader();
                if (rd.Read())
                {
                    var article = new Article(rd.GetString(0), rd.GetString(1), rd.GetInt32(2), rd.GetDouble(3));
                    rd.Close();
                    comm.Connection.Close();
                    return article;
                }
                else
                {
                    rd.Close();
                    comm.Connection.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }
        public static List<Article> GetArticles()
        {
            try
            {
                var comm = DB.newCommand($"select * from Article ");
                var rd = comm.ExecuteReader();
                var articles = new List<Article>();
                while (rd.Read())
                {
                    var article = new Article(rd.GetString(0), rd.GetString(1), rd.GetInt32(2), rd.GetDouble(3));
                    articles.Add(article);
                }
                comm.Connection.Close();
                return articles;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<Article>();
            }


        }
       
        
    }
}
