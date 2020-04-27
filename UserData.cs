using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    class UserData
    {

        private String ConnectionString = string.Empty;

        public UserData()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        }

        
        public int InsertNewUser(User user)
        {


            //Create SQL QUERY FOR INSERTING A User

        string sqlQuery = String.Format("Insert into Users(Username,Firstname,Lastname,Email,Phonenumber,Password)Values('{0}','{1}','{2}','{3}','{4}','{5}');"
                        + "Select @@Identity",user.Username,user.Firstname, user.Lastname,user.Email, user.Phonenumber, user.Password);

            //Create and open a connection to SQL Server

            SqlConnection connection = new SqlConnection(ConnectionString);

            connection.Open();

            //Create a command object

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Execute the command to sql server and return the newly created id

            int newUserID = Convert.ToInt32((decimal)command.ExecuteScalar());

            //Close and dispose

            command.Dispose();
            connection.Close();
            connection.Dispose();

            //Set return Value

            return newUserID;
        }


        public int InsertNewAdmin(User user)
        {


            //Create SQL QUERY FOR INSERTING A User

            string sqlQuery = String.Format("Insert into AdminUsers(Username,Firstname,Lastname,Email,Phonenumber,Password)Values('{0}','{1}','{2}','{3}','{4}','{5}');"
                            + "Select @@Identity", user.Username, user.Firstname, user.Lastname, user.Email, user.Phonenumber, user.Password);

            //Create and open a connection to SQL Server

            SqlConnection connection = new SqlConnection(ConnectionString);

            connection.Open();

            //Create a command object

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Execute the command to sql server and return the newly created id

            int newUserID = Convert.ToInt32((decimal)command.ExecuteScalar());

            //Close and dispose

            command.Dispose();
            connection.Close();
            connection.Dispose();

            //Set return Value

            return newUserID;
        }

        

        public bool CheckingExistingUsername(String username)
        {
            bool result;

            //Create the SQL Query for deleting an article

            String SqlQuery = String.Format("Select Username from Users Where Username = '{0}'", username);

            //Create and open a connection to SQL Server

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            //Create a Command object

            SqlCommand command = new SqlCommand(SqlQuery, connection);

            //Execute the command

            int row = command.ExecuteNonQuery();

            if (row == 0)
            {
                result = false;
            }
            else
            {
                result = true ;
            }

            //Close and dispose 
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return result;
        }

        public bool CheckingExistingEmail(String email)
        {
            bool result;

            //Create the SQL Query for deleting an article

            String SqlQuery = String.Format("Select Email from Users Where Email = '{0}'", email);

            //Create and open a connection to SQL Server

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            //Create a Command object

            SqlCommand command = new SqlCommand(SqlQuery, connection);

            //Execute the command

            int row = command.ExecuteNonQuery();

            if (row == 0) 
            {
                result = false;
            }
            else
            {
                result = true;
            }

            //Close and dispose 
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return result;
        }
     
        /*
        //Logging in customer method
        public bool LoggingIn(String user,String pass) 
        {
            bool result;

            //Create the SQL Query for deleting an article

            String SqlQuery = String.Format("Select * from Users Where Username = '{0}' AND Passwords = '{1}'", user,pass);

            //Create and open a connection to SQL Server

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            //Create a Command object

            SqlCommand command = new SqlCommand(SqlQuery, connection);

            //Execute the command

            SqlDataReader dataReader = command.ExecuteReader();


            if (dataReader.HasRows)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            //Close and dispose 
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return result; 
        }

        //Logging in Admin method
        public bool AdminLoggingIn(String user, String pass)
        {
            bool result;

            //Create the SQL Query for deleting an article

            String SqlQuery = String.Format("Select * from AdminUsers Where Username = '{0}' AND Passwords = '{1}'", user, pass);

            //Create and open a connection to SQL Server

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            //Create a Command object

            SqlCommand command = new SqlCommand(SqlQuery, connection);

            //Execute the command

            SqlDataReader dataReader = command.ExecuteReader();


            if (dataReader.HasRows)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            //Close and dispose 
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return result;
        }
        */

        //CHECKING IF  THE EMAIL ENTERED IS VALID
        public bool IsValidEmail(string email)
        {


            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /*
        public int GetCustomerId(string userName)
        {
            int cusId;
            
            //Create the SQL Query for returning an article category based on its primary key

            string sqlQuery = String.Format("select * from User where UserName='{0}'", userName);

            //Create and open a connection to SQL SERVEr

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            //load into result object the returned row from the database

            if (dataReader.HasRows)
            {

                while (dataReader.Read())
                {
                    

                    cusId = Convert.ToInt32(dataReader["UserId"].ToString());
                    
                }
            }


            return cusId;
        }
        */

        public int newOrder(String user, string list, double totalPrice, DateTime date)
        {
            
            string sqlQuery = String.Format("Insert into OrderTable (CustomerUserName,OrderItem,TotalPrice,DateandTime)Values('{0}','{1}','{2}','{3}');"
                            + "Select @@Identity",user,list,totalPrice,date.ToString("MM/dd/yyyy hh:mm:ss"));

            //Create and open a connection to SQL Server

            SqlConnection connection = new SqlConnection(ConnectionString);

            connection.Open();

            //Create a command object

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Execute the command to sql server and return the newly created id

            int newUserID = Convert.ToInt32((decimal)command.ExecuteScalar());

            //Close and dispose

            command.Dispose();
            connection.Close();
            connection.Dispose();

            //Set return Value

            return newUserID;
        }

        public void orderReady(int orderid)
        {
            //selecting the record for the completed order from the temp table


            string sqlQuerySelect = String.Format("select * from OrderTable where OrderId = {0}", orderid);

            //Create and open a connection to SQL SERVEr

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(sqlQuerySelect, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            //load into result object the returned row from the database


            
            string username="";
            string Orderitem = "";
            DateTime date = new DateTime();
            double totalPrice = 0.0;


            if (dataReader.HasRows)
            {

                while (dataReader.Read())
                {
                    
                     orderid = int.Parse(dataReader["OrderId"].ToString());//   Convert.ToInt32(dataReader["ArticleID"]);
                     username = dataReader["CustomerUserName"].ToString();
                     Orderitem = dataReader["Orderitem"].ToString();
                     date = Convert.ToDateTime(dataReader["DateandTime"]);
                     totalPrice = double.Parse(dataReader["TotalPrice"].ToString());

                }
            }

            command.Dispose();
            connection.Close();
            connection.Dispose();

            DateTime today = new DateTime();
            today = DateTime.Now;

            // inserting the ready order in to another table

            string sqlQuery = String.Format("Insert into OrderTable_ReadyOrder (OrderId,CustomerUserName,OrderItem,TotalPrice,DateandTime_ordered,DateandTime_ready)Values('{0}','{1}','{2}','{3}','{4}','{5}')",
                + orderid, username, Orderitem, totalPrice, date.ToString("MM/dd/yyyy hh:mm:ss"),today.ToString("MM/dd/yyyy hh:mm:ss"));

            //Create and open a connection to SQL Server

            connection = new SqlConnection(ConnectionString);

            connection.Open();

            //Create a command object

            command = new SqlCommand(sqlQuery, connection);

            //Execute the command to sql server and return the newly created id

           // int newUserID = Convert.ToInt32((decimal)command.ExecuteScalar());

            //Close and dispose

            command.Dispose();
            connection.Close();
            connection.Dispose();





           

            //Create the SQL Query for deleting an article

            String SqlQuery = String.Format("delete from OrderTable Where OrderId = {0}", orderid);

            //Create and open a connection to SQL Server

            connection = new SqlConnection(ConnectionString);
            connection.Open();

            //Create a Command object

            command = new SqlCommand(SqlQuery, connection);

            //Execute the command

            int rowsDeletedCount = command.ExecuteNonQuery();

            
            //Close and dispose 
            command.Dispose();
            connection.Close();
            connection.Dispose();

            //return result;
        }


        // new user with hashed password
        public int InsertNewUser_TestingHash(User user)
        {

            String salt = CreateSalt(16);

            String hashedPassword = GenerateSHA256Hash(user.Password,salt);

            //Create SQL QUERY FOR INSERTING A User

            string sqlQuery = String.Format("Insert into Users(Username,Firstname,Lastname,Email,Phonenumber,Passwords,Salt)Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}');"
                            + "Select @@Identity", user.Username, user.Firstname, user.Lastname, user.Email, user.Phonenumber, hashedPassword,salt);

            //Create and open a connection to SQL Server

            SqlConnection connection = new SqlConnection(ConnectionString);

            connection.Open();

            //Create a command object

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Execute the command to sql server and return the newly created id

            int newUserID = Convert.ToInt32((decimal)command.ExecuteScalar());

            //Close and dispose

            command.Dispose();
            connection.Close();
            connection.Dispose();

            //Set return Value

            return newUserID;
        }

        public String Salt(string user)
        {
            String salt;
            
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            salt = String.Format("Select Salt from Users Where Username = '{0}'", user);

            SqlCommand command = new SqlCommand(salt, connection);

            SqlDataReader dataReader = command.ExecuteReader();


            if (dataReader.HasRows)
            {

                while (dataReader.Read())
                {
                    salt = dataReader["Salt"].ToString();


                }

            }
           
            

            command.Dispose();
            connection.Close();
            connection.Dispose();
            return salt;
        }
        //logging in with hashed password
        public bool LoggingIn(String user, String pass)
        {
            bool result;

            //Create and open a connection to SQL Server

            String salt = Salt(user);

            String hashpass = GenerateSHA256Hash(pass,salt);
            //Create the SQL Query for deleting an article

            String SqlQuery = String.Format("Select * from Users Where Username = '{0}' AND Passwords = '{1}'", user, hashpass);

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            //Create a Command object

           SqlCommand command = new SqlCommand(SqlQuery, connection);

            //Execute the command

           SqlDataReader dataReader = command.ExecuteReader();


            if (dataReader.HasRows)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            //Close and dispose 
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return result;
        }

        //Logging in Admin method
        public bool AdminLoggingIn(String user, String pass)
        {
            bool result;

            //Create the SQL Query for deleting an article

            String SqlQuery = String.Format("Select * from AdminUsers Where Username = '{0}' AND Passwords = '{1}'", user, pass);

            //Create and open a connection to SQL Server

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            //Create a Command object

            SqlCommand command = new SqlCommand(SqlQuery, connection);

            //Execute the command

            SqlDataReader dataReader = command.ExecuteReader();


            if (dataReader.HasRows)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            //Close and dispose 
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return result;
        }



        public void editDatabase(String table,string itemName, int quantity)
        {
            

            //Create and open a connection to SQL Server
                        
            String SqlQuery = String.Format("Select * from {0} Where Items = '{1}'",table,itemName);

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            //Create a Command object

            SqlCommand command = new SqlCommand(SqlQuery, connection);

            //Execute the command

            SqlDataReader dataReader = command.ExecuteReader();

            
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    
                    quantity = Convert.ToInt32(dataReader["AmountAvailabe"]) - quantity;
                    
                }
            }

            dataReader.Close();
            //Close and dispose 
            command.Dispose();
            //connection.Close();
            //connection.Dispose();







            
            //Create the SQL Query for deleting an article

            String SqlQueryUpdate = String.Format("UPDATE {0} SET AmountAvailabe = '{1}' WHERE Items = '{2}' ", table,quantity, itemName);

            //Create and open a connection to SQL Server

            //SqlConnection connection = new SqlConnection(ConnectionString);
           
            //SqlConnection connection = new SqlConnection(ConnectionString);
            //connection.Open();

            //Create a Command object

            command = new SqlCommand(SqlQueryUpdate, connection);

            //Execute the command

            command.ExecuteNonQuery();
            
            
            //Close and dispose 
            command.Dispose();
            connection.Close();
            connection.Dispose();
            
            
        }

        public static string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        public String CreateSalt(int size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);

            return Convert.ToBase64String(buff);
        }

      
        public String GenerateSHA256Hash(String input, String salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            System.Security.Cryptography.SHA256Managed sha256hashstring = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);

            return ByteArrayToHexString(hash);
        }




    }
}
