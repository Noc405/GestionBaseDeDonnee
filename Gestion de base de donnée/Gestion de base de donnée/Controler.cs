using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_de_base_de_donnée
{
    public class Controler
    {
        /// <summary>
        /// View of the app
        /// </summary>
        private ViewConnexion _view;

        public ViewConnexion View
        {
            get { return _view; }
        }

        /// <summary>
        /// Model of the app
        /// </summary>
        private Model _model;

        public Model Model
        {
            get { return _model; }
        }

        /// <summary>
        /// Check if the user is logged to the server or not
        /// </summary>
        private bool _isLoggedServ = false;

        public bool IsLoggedServ
        {
            get { return _isLoggedServ; }
            set { _isLoggedServ = value; }
        }

        /// <summary>
        /// Check if the user is loggedto a db or not
        /// </summary>
        private bool _isLoggedDB = false;

        public bool IsLoggedDB
        {
            get { return _isLoggedDB; }
            set { _isLoggedDB = value; }
        }

        /// <summary>
        /// Constructor of the controler
        /// </summary>
        /// <param name="view">View of the app</param>
        /// <param name="model">Model of the app</param>
        public Controler(ViewConnexion view, Model model)
        {
            _view = view;
            _model = model;
            _view.Controler = this;
            _model.Controler = this;
        }

        #region Connect to the server

        /// <summary>
        /// Connect the app to the serveur
        /// </summary>
        /// <param name="hostname">Hostname of the server</param>
        /// <param name="port">Port of the server</param>
        /// <param name="username">Username of the account</param>
        /// <param name="password">Password of the account</param>
        /// <returns></returns>
        public bool ConnectServer(string hostname, string port, string username, string password)
        {
            int _port = 0;
            try
            {
                if (port != "")
                {
                    _port = Convert.ToInt32(port);
                }
            }
            catch (Exception)
            {
                _view.Message("Veuillez entrer un port valide..");
                return false;
            }

            try
            {
                _view.Message("Obtention de la connexion..");
                _model.ConnectToServer(hostname, _port, username, password);
                _model.Conn.Open();
                _view.ConnectionSucces();
                _isLoggedServ = true;
                ShowDB();
                _view.Message("Connexion réussie!");
                return true;
            }
            catch (Exception e)
            {
                _view.Message("oops! une erreur est survenue : \n" + e.ToString());
                return false;
            }
        }

        /// <summary>
        /// Logout the user of the db
        /// </summary>
        public void LogoutServer()
        {
            try
            {
                _view.Message("Deconnexion en cours...");
                _model.Conn.Close();
                _view.Message("Deconnexion réussie!");
                //If the user is logged out, set the variable
                _view.Logout();
                _isLoggedServ = false;
                _model.DBName = "";
            }
            catch (Exception e)
            {
                _view.Message("oops! Une erreur est survenue : \n" + e.Message);
            }
        }

        #endregion

        #region DataBase Gestion

        /// <summary>
        /// Show the db and write it to the screen
        /// </summary>
        public void ShowDB()
        {
            _view.RestLabelDBName();
            try
            {
                _model.GetDatabases();
                _view.WriteDBToScreen(_model.DatabasesName);
            }
            catch (Exception e)
            {
                _view.Message("oops! une erreur est survenue lors de la selection des bases de données : \n" + e.Message);
            }
        }

        /// <summary>
        /// Remove a db from the list
        /// </summary>
        /// <param name="DBNameToRemove">Name of the db to remove</param>
        public void RemoveDataBase(string DBNameToRemove)
        {
            ShowDB();
        }

        /// <summary>
        /// Add a db name to the list
        /// </summary>
        /// <param name="DBNameToRemove">Name of the db to add</param>
        public void AddDataBase(string DBNameToRemove)
        {
            ShowDB();
        }


        /// <summary>
        /// Create a db and connect it
        /// </summary>
        /// <param name="dbName">The name of the db</param>
        /// <returns>If the connection is succes</returns>
        public bool CreateDataBase(string dbName)
        {
            try
            {
                //Write message
                _view.Message("Créeation de la base de donnée...");
                //Create db
                _model.QueryCMD("CREATE DATABASE IF NOT EXISTS " + dbName);


                //Write message
                _view.Message("Connexion à la base de donnée...");
                //Connect to db
                _model.QueryCMD("USE " + dbName);

                //Write end message
                _view.Message("Connexion réussie!");
                _model.DBName = dbName;
                _view.ConnectionToDBSucces(_model.DBName);
                _model.GetTable();
                IsLoggedDB = true;
                return true;
            }
            catch (Exception e)
            {
                _view.Message(e.ToString());
                return false;
            }
        }

        public bool DeleteDataBase(string dbName)
        {
            try
            {
                //Write message
                _view.Message("Suppréssion de la base de donnée...");
                //Delete db
                _model.QueryCMD("DROP DATABASE " + dbName);

                //Write end message
                _view.Message("Suppression réussie!");
                return true;
            }
            catch (Exception e)
            {
                _view.Message(e.ToString());
                return false;
            }
        }

        /// <summary>
        /// Log the user to a db
        /// </summary>
        /// <param name="dbName">Name of the db</param>
        public bool LoginDB(string dbName)
        {
            try
            {
                //Write message
                _view.Message("Connexion à la base de donnée...");
                //Connect to db
                _model.QueryCMD("USE " + dbName);
                //Write success message
                _view.Message("Connection réussie!");
                _model.DBName = dbName;
                //If the connecion successed, set the variable
                _view.ConnectionToDBSucces(_model.DBName);
                _model.GetTable();
                IsLoggedDB = true;
                return true;
            }
            catch (Exception e)
            {
                _view.Message("oops! une erreur est survenue : \n" + e.Message);
                return false;
            }
        }

        #endregion

        #region Table

        /// <summary>
        /// Check if the user is connected to a db and if the table exists, then connect to the table for show it
        /// </summary>
        /// <param name="tableName">Name of the table</param>
        public void GoToTable(string tableName)
        {
            if (IsLoggedDB)
            {
                if (tableName != "")
                {
                    foreach (string nameOfTable in _model.TablesInDB)
                    {
                        if (tableName == nameOfTable)
                        {
                            _view.CanSeeTable();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vous devez entrer un nom de table", "Une erreur est survenue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vous devez Vous connecter à une base de donnée", "Une erreur est survenue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Select

        /// <summary>
        /// Check if the values enterd are correct
        /// </summary>
        /// <param name="nameToSelect">The value for select the name</param>
        /// <returns>TRUE if the values are correct</returns>
        public int CheckWhatIsSelected(TextBox nameToSelect, CheckBox checkBoxSelectAll)
        {
            if (checkBoxSelectAll.Checked == true)
            {
                return 1;
            }
            else
            {
                if (nameToSelect.Text != "")
                {
                    _model.NameToSelect = nameToSelect.Text;
                    return 2;
                }
                else
                {
                    _view.Message("Les valeures entrées ne sont pas correctes..");
                    return 0;
                }
            }
        }

        /// <summary>
        /// Select the users
        /// </summary>
        /// <param name="wichSelect">If the user can select a user</param>
        public void SelectUsers(int wichSelect)
        {
            if (wichSelect == 1)
            {
                string query = "SELECT * FROM users";

                //Create a list to store the result
                _model.Users = new List<string>[3];
                _model.Users[0] = new List<string>();
                _model.Users[1] = new List<string>();
                _model.Users[2] = new List<string>();

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, _model.Conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    _model.Users[0].Add(dataReader["Name"] + "");
                    _model.Users[1].Add(dataReader["Surname"] + "");
                    _model.Users[2].Add(dataReader["Age"] + "");
                }

                _view.WriteUsersInfos(_model.Users);

                //close Data Reader
                dataReader.Close();
            }
            if (wichSelect == 2)
            {
                string query = "SELECT * FROM users WHERE Name=\"" + _model.NameToSelect + "\"";

                //Create a list to store the result
                _model.Users = new List<string>[3];
                _model.Users[0] = new List<string>();
                _model.Users[1] = new List<string>();
                _model.Users[2] = new List<string>();

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, _model.Conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    _model.Users[0].Add(dataReader["Name"] + "");
                    _model.Users[1].Add(dataReader["Surname"] + "");
                    _model.Users[2].Add(dataReader["Age"] + "");
                }

                _view.WriteUsersInfos(_model.Users);

                //close Data Reader
                dataReader.Close();
            }
        }

        #endregion

        /// <summary>
        /// Get the name of the database
        /// </summary>
        /// <returns>The name of the database</returns>
        public string getDbName()
        {
            return _model.DBName;
        }

        /// <summary>
        /// Set the name of the database
        /// </summary>
        /// <param name="name">The new name of the database</param>
        public void setDBName(string name)
        {
            _model.DBName = name;
        }
    }
}