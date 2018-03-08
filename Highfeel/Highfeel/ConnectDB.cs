﻿using MySql.Data.MySqlClient;
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
                           + "; DATABASE=" + Properties.Resources.database
                           + "; UID=" + Properties.Resources.uid
                           + "; PASSWORD=" + Properties.Resources.password
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
                "' AND userPassword='" + password + "'";

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


        // create a list of all the movies in db
        //public List<Movie> selectAllMovies()
        //{
        //    string sqlSelectAllMovies = "SELECT movieID, movieName FROM movies ORDER BY movieName ASC";

        //    List<Movie> liste = new List<Movie>();

        //    if (OpenConnection())
        //    {
        //        MySqlCommand cmd = new MySqlCommand(sqlSelectAllMovies, this.connection);

        //        MySqlDataReader donnees = cmd.ExecuteReader();

        //        while (donnees.Read())
        //        {
        //            liste.Add(new Movie((int)donnees["movieID"], (string)donnees["movieName"]));
        //        }

        //        // close data
        //        donnees.Close();

        //        CloseConnection();
        //    }

        //    // return list of movies
        //    return liste;
        //}
    }
}