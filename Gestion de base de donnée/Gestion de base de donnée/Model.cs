using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestion_de_base_de_donnée
{
    public class Model
    {
        /// <summary>
        /// Controler of the app
        /// </summary>
        private Controler _controler;

        public Controler Controler
        {
            get { return _controler; }
            set { _controler = value; }
        }

        /// <summary>
        /// Hostname of the db
        /// </summary>
        private string _host;

        public string Host
        {
            get { return _host; }
        }

        /// <summary>
        /// Port of the db
        /// </summary>
        private int _port;

        public int Port
        {
            get { return _port; }
        }

        /// <summary>
        /// Username of the db
        /// </summary>
        private string _username;

        public string Username
        {
            get { return _username; }
        }

        /// <summary>
        /// Password of the db
        /// </summary>
        private string _password;

        public string Password
        {
            get { return _password; }
        }

        private string _dbName;

        public string DBName
        {
            get { return _dbName; }
            set { _dbName = value; }
        }


        public string NameToInsert;
        public string FirstnameToInsert;
        public int AgeToInsert;

        public string NameToSelect;

        /// <summary>
        /// The database
        /// </summary>
        private MySqlConnection conn;
        
        public MySqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        /// <summary>
        /// Command my sql
        /// </summary>
        MySqlCommand cmd;

        //Array of list
        public List<string>[] Users;

        /// <summary>
        /// List of the name of databases on the server
        /// </summary>
        public List<string> DatabasesName = new List<string>();

        /// <summary>
        /// List of the name of databases on the server
        /// </summary>
        public List<string> TablesInDB = new List<string>();

        /// <summary>
        /// Connect the server on the app
        /// </summary>
        /// <param name="host">The hostname</param>
        /// <param name="port">The port of the server</param>
        /// <param name="username">The username of the account</param>
        /// <param name="password">The password of the account</param>
        public bool ConnectToServer(string host, int port, string username, string password)
        {
            // Connection String.
            String connString = "server=" + host + ";port=" + port + ";user=" + username + ";password=" + password + ";";

            try
            {
                conn = new MySqlConnection(connString);
                //Set the variables
                _host = host;
                _port = port;
                _username = username;
                _password = password;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Get the databases name
        /// </summary>
        public void GetDatabases()
        {
            DatabasesName.Clear();

            string query = "SHOW DATABASES";
            //Create Command
            cmd = new MySqlCommand(query, conn);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                DatabasesName.Add(Convert.ToString(dataReader["Database"]));
            }

            //Close reader
            dataReader.Close();
        }
        
        /// <summary>
        /// Get the tables that exists in the db
        /// </summary>
        public void GetTable()
        {
            TablesInDB.Clear();

            string query = "SHOW TABLES";
            //Create Command
            cmd = new MySqlCommand(query, conn);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                TablesInDB.Add(Convert.ToString(dataReader["Database"]));
            }

            //Close reader
            dataReader.Close();
        }

        /// <summary>
        /// Execute a non query command
        /// </summary>
        /// <param name="query">The query command</param>
        public void QueryCMD(string query)
        {
            cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
