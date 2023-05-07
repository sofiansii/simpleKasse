using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using SimpleKasseLogic.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SimpleKasseLogic.database
{
    public static class UserDAO
    {
        public static User CurrentUser;
        public static bool AddUser(User user)
        {
            try
            {
                var comm = DB.newCommand($"insert into User values(@username,@password,@lastlog,@role)");
                comm.Parameters.AddWithValue("@username", user.UserName);
                comm.Parameters.AddWithValue("@password", user.Password);
                comm.Parameters.AddWithValue("@lastlog", user.lastlog);
                comm.Parameters.AddWithValue("@role", user.Role);
                var res = comm.ExecuteNonQuery();
                comm.Connection.Close();
                return res != 0;
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
                return false; 
            }
            
        }
        public static bool DeleteUser(string UserName)
        {
            try
            {
                var comm = DB.newCommand($"Delete from user where  username = @username");
                comm.Parameters.AddWithValue("@username", UserName);
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
        public static bool ResetPassword(User user)
        {
            try
            {
                var comm = DB.newCommand($"update user set password=@password where username=@username");
                comm.Parameters.AddWithValue("@username", user.UserName);
                comm.Parameters.AddWithValue("@password", user.Password);
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
        public static User Login(string UserName,string Password)
        {
            try
            {
                var comm = DB.newCommand($"select * from user where password=@password and username=@username");
                comm.Parameters.AddWithValue("@username", UserName);
                comm.Parameters.AddWithValue("@password", Password);
                var rd = comm.ExecuteReader();
                if (rd.Read())
                {
                    var user = new User(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3));
                    rd.Close();
                    comm.Connection.Close();
                    CurrentUser = user;
                    return user;
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
        public static List<User> GetKassiers()
        {
            try
            {
                var comm = DB.newCommand($"select * from user where role='kassier'");
                var rd = comm.ExecuteReader();
                var kassiers = new List<User>();
                while (rd.Read())
                {
                    var user = new User(rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3));
                    kassiers.Add(user);
                }
                comm.Connection.Close();
                return kassiers;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<User>();
            }
            

        }
        public static bool AdminExists()
        {
            try
            {
                var comm = DB.newCommand($"select count(*) from user where role='admin'");
                var exists = (Int64)comm.ExecuteScalar() != 0;
                comm.Connection.Close();
                return exists;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return true;
            }
            
        }
        public static void LastLog(User User)
        {
            try
            {
                var comm = DB.newCommand($"update User set lastlog=@lastlog where username=@username");
                comm.Parameters.AddWithValue("@username", User.UserName);
                comm.Parameters.AddWithValue("@lastlog", DateOnly.FromDateTime(DateTime.Now).ToString());
                comm.ExecuteNonQuery();
                comm.Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
