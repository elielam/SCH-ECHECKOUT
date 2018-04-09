using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

        public bool Login(string anonUsername, string anonPassword)
        {
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "SELECT * FROM USER WHERE login = @anonLogin AND password = @anonPassword";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@anonLogin", anonUsername);
                cmd.Parameters.AddWithValue("@anonPassword", anonPassword);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                this.connection.Close();

                return true;
            }
            catch (SqlException e)
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
                Console.Write(e);
                return false;
            }
        }

        /* USER METHODS */

        public bool AddUser(string nomUser, string prenomUser, string login, string password, bool isAdmin)
        {
            try
            {
                this.connection.Open();
                
                MySqlCommand cmd = this.connection.CreateCommand();
                
                cmd.CommandText = "INSERT INTO user (nomUser, prenomUser, login, password, isAdmin) VALUES (@name, @lastname, @login, @password, @isAdmin)";
                
                cmd.Parameters.AddWithValue("@name", nomUser);
                cmd.Parameters.AddWithValue("@lastname", prenomUser);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@isAdmin", isAdmin);
                
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
    }
}
