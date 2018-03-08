using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highfeel
{
    class ConnectDB
    {
        #region Connection settings
        private MySqlConnection connection;
        public ConnectDB()
        {
            this.InitConnexion();
        }
        private void InitConnexion()
        {
            // create connection string
            string connectionString;

            connectionString = "SERVER=" + Properties.Resources.server
                           + "; DATABASE=" + Properties.Resources.db
                           + "; UID=" + Properties.Resources.id
                           + "; PASSWORD=" + Properties.Resources.pwd
                           + ";";

            this.connection = new MySqlConnection(connectionString);
        }
        //open connection to database
        private bool OpenConnection()
        {
            if (this.connection.State != System.Data.ConnectionState.Open)
            {
                this.connection.Open();
                return true;
            }
            else
            {
                return true;
            }
        }

        // close connection
        private bool CloseConnection()
        {
            if (this.connection.State != System.Data.ConnectionState.Closed)
            {
                this.connection.Close();
                return true;
            }
            else
            {
                return true;
            }
        }
        #endregion

        /// <summary>
        /// connexion à un compte enregistré sur la base de données
        /// </summary>
        /// <param name="username">Nom d'utilisateur</param>
        /// <param name="password">Mot-de-passe</param>
        /// <returns></returns>
        public bool loginsql(string username, string password)
        {
            bool loginOK = false;

            string loginStr = "SELECT COUNT(*) FROM user WHERE userName='" + username +
                "' AND userPassword='" + password;

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(loginStr, this.connection);
                Int32 countRes = Convert.ToInt32(cmd.ExecuteScalar());

                if (countRes == 1)
                {
                    loginOK = true;
                }
                else
                {
                    loginOK = false;
                }
                CloseConnection();
            }
            return loginOK;
        }
    }
}
