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
        /// <param name="password">Mot de passe</param>
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

        public string getUserIdByUsername(string username)
        {
            string userId = "";

            string sqlGetUserId = "SELECT `userId` FROM `user` WHERE `userName` = '" + username + "'";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sqlGetUserId, this.connection);

                MySqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    userId = data["userId"].ToString();
                }

                data.Close();

                CloseConnection();
            }

            return userId;
        }

        public void createClan(string clanName, string connectedUserId)
        {
            string currentClanId = "";

            /* Create a clan with the connected user as the admin*/
            string sqlCreateClan = "INSERT INTO `highfeel`.`clan` (`clanName`, `clanAdmin`) VALUES ('" + clanName + "', '" + connectedUserId + "');";

            /* Get the clanId of the created clan */
            string sqlGetClanId = "SELECT `clanId` FROM `clan` WHERE `clanName` = '" + clanName + "';";



            if (OpenConnection())
            {
                MySqlCommand cmdCreateClan = new MySqlCommand(sqlCreateClan, this.connection);
                MySqlDataReader dataCreateClan = cmdCreateClan.ExecuteReader();
                dataCreateClan.Close();

                MySqlCommand cmdGetClanId = new MySqlCommand(sqlGetClanId, this.connection);
                MySqlDataReader dataGetClanId = cmdGetClanId.ExecuteReader();
                while (dataGetClanId.Read())
                {
                    currentClanId = dataGetClanId["clanId"].ToString();
                }

                dataGetClanId.Close();

                /* Add the connected user as member of new clan */
                string sqlAddUser = "INSERT INTO `highfeel`.`belongs` (`clanId`, `userId`) VALUES('" + currentClanId + "', '" + connectedUserId + "');";
                MySqlCommand cmdAddUser = new MySqlCommand(sqlAddUser, this.connection);
                MySqlDataReader dataAddUser = cmdAddUser.ExecuteReader();
                dataAddUser.Close();

                CloseConnection();
            }
        }

        public List<Clan> getAllClanByUser(string connectedUserId)
        {
            List<Clan> list = new List<Clan>();

            string sqlgetAllClan = "SELECT DISTINCT `clan`.`clanId`, `clan`.`clanName`, `clan`.`clanAdmin` FROM `clan`, `user`, `belongs` WHERE `clan`.`clanId` = `belongs`.`clanId` AND `belongs`.`userId` = '" + connectedUserId + "' ORDER BY `clan`.`clanName`;";

            if (OpenConnection())
            {
                MySqlCommand cmdCreateClan = new MySqlCommand(sqlgetAllClan, this.connection);
                MySqlDataReader data = cmdCreateClan.ExecuteReader();

                while (data.Read())
                {
                    list.Add(new Clan((int)data["clanId"], (string)data["clanName"], (int)data["clanAdmin"]));
                }

                data.Close();

                CloseConnection();
            }

            return list;
        }

        public List<string> getAllUsersByClan(string clanId)
        {
            List<string> list = new List<string>();

            string sqlGetAllUsersByClan = "SELECT DISTINCT `user`.`userName` FROM `user`, `clan`, `belongs` WHERE `user`.`userId` = `belongs`.`userId` AND `belongs`.`clanId` = '" + clanId + "'";

            if (OpenConnection())
            {
                MySqlCommand cmdGetUserByClan = new MySqlCommand(sqlGetAllUsersByClan, this.connection);
                MySqlDataReader data = cmdGetUserByClan.ExecuteReader();

                while (data.Read())
                {
                    list.Add((string)data["userName"]);
                }

                data.Close();

                CloseConnection();
            }

            return list;
        }

        public List<string> getAllUsers()
        {
            List<string> list = new List<string>();
            string sqlGetAllUsersByClan = "SELECT `user`.`userName` FROM `user`";

            if (OpenConnection())
            {
                MySqlCommand cmdGetAllUsers = new MySqlCommand(sqlGetAllUsersByClan, this.connection);
                MySqlDataReader data = cmdGetAllUsers.ExecuteReader();

                while (data.Read())
                {
                    list.Add((string)data["userName"]);
                }

                data.Close();

                CloseConnection();
            }

            return list;
        }

        public void addMember(string clanId, string username)
        {
            string sqlAddMember = "INSERT INTO `highfeel`.`belongs` (`clanId`, `userID`) VALUES ('" + clanId + "', '" + getUserIdByUsername(username) + "');";

            if (OpenConnection())
            {
                MySqlCommand cmdAddUser = new MySqlCommand(sqlAddMember, this.connection);
                MySqlDataReader data = cmdAddUser.ExecuteReader();

                data.Close();

                CloseConnection();
            }
        }
    }
}