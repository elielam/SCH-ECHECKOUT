using e_checkout.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_checkout
{

    public class Bdd
    {

        private MySqlConnection connection;

        public Bdd()
        {
            this.InitConnexion();
        }

        private void InitConnexion()
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=app_echeckout; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }

        /* LOGIN METHOD */

        public DataSet Login(string anonUsername, string anonPassword)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();
                
                cmd.CommandText = "SELECT COUNT(*) FROM USER WHERE username = @anonLogin AND password = @anonPassword";
                cmd.Parameters.AddWithValue("@anonLogin", anonUsername);
                cmd.Parameters.AddWithValue("@anonPassword", anonPassword);

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        /* USER METHODS */

        // Basics GET methods

        public DataSet SelectAllUser()
        {
            try
            {
                this.connection.Open();
                
                MySqlCommand cmd = this.connection.CreateCommand();
                
                cmd.CommandText = "SELECT * FROM user";

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                
                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        public DataSet GetUserById(int id)
        {
            try
            {
                this.connection.Open();
                
                MySqlCommand cmd = this.connection.CreateCommand();
                
                cmd.CommandText = "SELECT * FROM user WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                
                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        public DataSet GetUserByUsername(string username)
        {
            try
            {
                this.connection.Open();
                
                MySqlCommand cmd = this.connection.CreateCommand();
                
                cmd.CommandText = "SELECT * FROM user WHERE username = @username";
                cmd.Parameters.AddWithValue("@username", username);

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                
                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        // Basics SET methods

        public bool AddUser(User user)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO user (name, lastname, username, password, isAdmin) VALUES (@name, @lastname, @username, @password, @isAdmin)";

                cmd.Parameters.AddWithValue("@name", user.GetName());
                cmd.Parameters.AddWithValue("@lastname", user.GetLastname());
                cmd.Parameters.AddWithValue("@username", user.GetUsername());
                cmd.Parameters.AddWithValue("@password", user.GetPassword());
                cmd.Parameters.AddWithValue("@isAdmin", user.GetIsAdmin());

                cmd.ExecuteNonQuery();

                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        // Update

        public bool UpdateUser (User user)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "UPDATE user SET name = @name, lastname = @lastname, username = @username, password = @password, isAdmin = @isAdmin WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", user.GetId());
                cmd.Parameters.AddWithValue("@name", user.GetName());
                cmd.Parameters.AddWithValue("@lastname", user.GetLastname());
                cmd.Parameters.AddWithValue("@username", user.GetUsername());
                cmd.Parameters.AddWithValue("@password", user.GetPassword());
                cmd.Parameters.AddWithValue("@isAdmin", user.GetIsAdmin());

                cmd.ExecuteNonQuery();

                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        // Delete

        public bool DeleteUser(User user)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "DELETE FROM user WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", user.GetId());

                cmd.ExecuteNonQuery();

                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        /* PRODUCT METHODS */

        // Basics GET methods

        public DataSet SelectAllProduct()
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM product";

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        public DataSet GetProductById(int id)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM product WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        // Basics SET methods

        public bool AddProduct(Product product)
        {
            try
            {



                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        // Update

        public bool UpdateProduct(Product product)
        {
            try
            {



                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        // Delete

        public bool DeleteProduct(Product product)
        {
            try
            {



                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        /* CATEGORY METHODS */

        // Basics GET methods


        public DataSet SelectAllCategory()
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM category";

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        public DataSet GetCategoryById(int id)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM category WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        // Basics SET methods

        public bool AddCategory(Category category)
        {
            try
            {



                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        // Update

        public bool UpdateCategory(Category category)
        {
            try
            {



                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        // Delete

        public bool DeleteCategory(Category category)
        {
            try
            {



                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }


        /* STOCK METHODS */

        // Basics GET methods
        
        public DataSet SelectAllStock()
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM stock";

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        public DataSet GetStockById(int id)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM stock WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        // Basics SET methods

        public bool AddStock(Stock stock)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO stock (idProduct, quantity) VALUES (@idProduct, @quantity)";

                cmd.Parameters.AddWithValue("@idProduct", stock.GetIdProduct());
                cmd.Parameters.AddWithValue("@quantity", stock.GetQuantity());

                cmd.ExecuteNonQuery();

                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        // Update

        public bool UpdateStock(Stock stock)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "UPDATE stock SET idProduct = @idProduct, quantity = @quantity WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", stock.GetId());
                cmd.Parameters.AddWithValue("@idProduct", stock.GetIdProduct());
                cmd.Parameters.AddWithValue("@quantity", stock.GetQuantity());

                cmd.ExecuteNonQuery();

                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        // Delete

        public bool DeleteStock(Stock stock)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "DELETE FROM stock WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", stock.GetId());

                cmd.ExecuteNonQuery();

                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        /* CART METHODS */

        // Basics GET methods

        public DataSet SelectAllCart()
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM cart";

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        public DataSet GetCartById(int id)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM cart WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        // Basics SET methods

        public bool AddCart(Cart cart)
        {
            try
            {



                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        // Update

        public bool UpdateCart(Cart cart)
        {
            try
            {



                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        // Delete

        public bool DeleteCart(Cart cart)
        {
            try
            {



                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }


        /* CART_STORE METHODS */

        // Basics GET methods

        public DataSet SelectAllCartStore()
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM cart_store";

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        public DataSet GetCartStoreById(int id)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM cart_store WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        public DataSet GetAllCartProducts(int id)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM cart_store WHERE idCart = @id";
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        // Basics SET methods

        public bool AddCardStore(CartStore cardStore)
        {
            try
            {



                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        // Update

        public bool UpdateCardStore(CartStore cardStore)
        {
            try
            {



                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        // Delete

        public bool DeleteCardStore(CartStore cardStore)
        {
            try
            {



                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        /* PAYMENT METHODS */

        // Basics GET methods

        public DataSet SelectAllPayment()
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM payment";

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        public DataSet GetPaymentById(int id)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM payment WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adap.Fill(ds);

                this.connection.Close();
                return ds;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
            }
        }

        // Basics SET methods

        public bool AddPayment(Payment payment)
        {
            try
            {



                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        // Update

        public bool UpdatePayment(Payment payment)
        {
            try
            {



                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }

        // Delete

        public bool DeletePayment(Payment payment)
        {
            try
            {



                this.connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return false;
            }
        }


    }
}
