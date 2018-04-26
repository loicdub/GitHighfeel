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

        public void sendMood(string moodRate, string comment, string username, string selectedDate, string moodClan)
        {
            string newMoodId = "";
            string currentUsername = getUserIdByUsername(username);
            string sqlSendComment = "";

            string sqlSendNote = "INSERT INTO `mood`(`moodRate`, `moodDate`) VALUES ('" + moodRate + "', '" + selectedDate + "'); ";

            if (comment != "")
            {
                sqlSendComment = "INSERT INTO `comment`(`commentText`, `commentDate`, `userID`) VALUES ('" + comment + "', '" + selectedDate + "', '" + currentUsername + "');";
            }

            string sqlGetMoodId = "SELECT `moodID` FROM `mood` WHERE `moodID` = (SELECT MAX(`moodID`) FROM `mood`);";

            if (OpenConnection())
            {
                MySqlCommand cmdSendNote = new MySqlCommand(sqlSendNote, this.connection);
                MySqlDataReader dataAddNote = cmdSendNote.ExecuteReader();
                dataAddNote.Close();

                if (comment != "")
                {
                    MySqlCommand cmdSendComment = new MySqlCommand(sqlSendComment, this.connection);
                    MySqlDataReader dataAddComment = cmdSendComment.ExecuteReader();
                    dataAddComment.Close();
                }

                MySqlCommand cmdGetMoodId = new MySqlCommand(sqlGetMoodId, this.connection);
                MySqlDataReader dataGetMoodId = cmdGetMoodId.ExecuteReader();
                while (dataGetMoodId.Read())
                {
                    newMoodId = dataGetMoodId["moodID"].ToString();
                }
                dataGetMoodId.Close();

                /* Add the connected user as the sender of the mood */
                string sqlSendUser = "INSERT INTO `feels`(`userID`, `moodID`, `clanId`) VALUES (" + currentUsername + ", " + newMoodId + ", " + moodClan +");";
                MySqlCommand cmdAttachUser = new MySqlCommand(sqlSendUser, this.connection);
                MySqlDataReader dataAttachUser = cmdAttachUser.ExecuteReader();
                dataAttachUser.Close();

                CloseConnection();
            }
        }

        public string getClanAdmin(string clanId)
        {
            string adminId = "";
            string adminName = "";
            string sqlGetAdminId = "SELECT `clanAdmin` FROM `clan` WHERE `clanId` = " + clanId + ";";

            if (OpenConnection())
            {
                MySqlCommand cmdGetAdminId = new MySqlCommand(sqlGetAdminId, this.connection);
                MySqlDataReader dataGetAdminId = cmdGetAdminId.ExecuteReader();
                while (dataGetAdminId.Read())
                {
                    adminId = dataGetAdminId["clanAdmin"].ToString();
                }
                dataGetAdminId.Close();

                string sqlGetAdminName = "SELECT `userName` FROM `user` WHERE `userId` = '" + adminId + "';";
                MySqlCommand cmdGetAdminName = new MySqlCommand(sqlGetAdminName, this.connection);
                MySqlDataReader dataGetAdminName = cmdGetAdminName.ExecuteReader();
                while (dataGetAdminName.Read())
                {
                    adminName = dataGetAdminName["userName"].ToString();
                }
                dataGetAdminName.Close();

                CloseConnection();
            }

            return adminName;
        }

        public void createUser(string username, string password, string email)
        {
            /* Create a clan with the connected user as the admin*/
            string sqlCreateUser = "INSERT INTO `user`(`userName`, `userPassword`, `userMail`) VALUES ('" + username + "', '" + password + "', '" + email + "')";

            if (OpenConnection())
            {
                MySqlCommand cmdCreateUser = new MySqlCommand(sqlCreateUser, this.connection);
                MySqlDataReader dataCreateUser = cmdCreateUser.ExecuteReader();
                dataCreateUser.Close();
                
                CloseConnection();
            }
        }
    }
}