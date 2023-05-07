using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleKasseLogic.database
{
    public static class DB
    {
        private static string DataSource = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\SimpleKasse\\database.sqlite";
        public static void init()
        {
            if (!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\SimpleKasse"))
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\SimpleKasse");
            if (!File.Exists(DataSource))
            {

                var f = File.Create(DataSource);
                f.Close();
                var conn = new SQLiteConnection($"Data Source={DataSource}");
                conn.Open();
                var comm = new SQLiteCommand(@"create table User (
	                                            UserName varchar(20) primary key,
  	                                            password varchar(60),
                                                lastlog date,
  	                                            role varchar(10)
                                            );
                                            create table Article (
  	                                            name varchar(10) primary key,
  	                                            description text,
  	                                            stock int,
                                                price float
                                            );
                                            create table Sale (
	                                            id integer primary key AUTOINCREMENT,
  	                                            date date,
  	                                            initiator varchar(20),
  	                                            FOREIGN key(initiator) REFERENCES User(UserName)
                                            );
                                            create table SaleArticle (
                                              sale_id int ,
                                              article_ref varchar(10) ,
                                              quantity int,
                                              price float,
                                              FOREIGN key(article_ref) REFERENCES Artice(ref),
                                              FOREIGN key(sale_id) REFERENCES Shoping(id),
                                              primary key (sale_id,article_ref)
                                              );", conn);
                var res = comm.ExecuteNonQuery();
                conn.Close();

            }
        }
        public static SQLiteCommand newCommand(string query)
        {
            init();
            var conn = new SQLiteConnection($"Data Source={DataSource}");
            conn.Open();
            return new SQLiteCommand(query,conn);
        }
    }
}
