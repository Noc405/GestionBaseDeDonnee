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
        /// Check if the user is logged or not
        /// </summary>
        private bool _isLogged;

        public bool IsLogged
        {
            get { return _isLogged; }
            set { _isLogged = value; }
        }

        /// <summary>
        /// Command my sql
        /// </summary>
        MySqlCommand cmd;


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
                _isLogged = true;
                _view.Message("Connexion réussie!");
                return true;
            }
            catch (Exception e)
            {
                _view.Message("oops! une erreur est survenue : \n" + e.ToString());
                return false;
            }
        }

        #endregion

        #region Create database

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
                string createDatabase = "CREATE DATABASE IF NOT EXISTS " + dbName;
                cmd = new MySqlCommand(createDatabase, _model.Conn);
                cmd.ExecuteNonQuery();


                //Write message
                _view.Message("Connexion à la base de donnée...");
                //Connect to db
                string connectDataBase = "USE " + dbName;
                cmd = new MySqlCommand(connectDataBase, _model.Conn);
                cmd.ExecuteNonQuery();

                //Write end message
                _view.Message("Connexion réussie!");
                _model.DBName = dbName;
                _view.ConnectionToDBSucces(_model.DBName);
                return true;
            }
            catch (Exception e)
            {
                _view.Message(e.ToString());
                return false;
            }
        }

        #endregion

        #region Delete Data Base

        public bool DeleteDataBase(string dbName)
        {
            try
            {
                //Write message
                _view.Message("Suppréssion de la base de donnée...");
                //Delete db
                string createDatabase = "DROP DATABASE " + dbName;
                cmd = new MySqlCommand(createDatabase, _model.Conn);
                cmd.ExecuteNonQuery();

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

        #endregion

        #region Login
        /// <summary>
        /// Log the user to a db
        /// </summary>
        /// <param name="dbName">Name of the db</param>
        public void LoginDB(string dbName)
        {
            try
            {
                //Write message
                _view.Message("Connexion à la base de donnée...");
                //Connect to db
                string connectDataBase = "USE " + dbName;
                cmd = new MySqlCommand(connectDataBase, _model.Conn);
                //Execute the command
                cmd.ExecuteNonQuery();
                //Write success message
                _view.Message("Connection réussie!");
                _model.DBName = dbName;
                //If the connecion successed, set the variable
                _view.ConnectionToDBSucces(_model.DBName);
            }
            catch (Exception e)
            {
                _view.Message("oops! une erreur est survenue : \n" + e.Message);
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
                _isLogged = false;
                _model.DBName = "";
            }
            catch (Exception e)
            {
                _view.Message("oops! Une erreur est survenue : \n" + e.Message);
            }
        }
        #endregion

        #region Insert

        /// <summary>
        /// Verif the info that the user entered for create a new user in the db
        /// </summary>
        /// <param name="name">The name of the new user</param>
        /// <param name="firstname">The firstname of the new user</param>
        /// <param name="age">The age of the new user</param>
        /// <returns>If the values are correct</returns>
        public bool VerifInfoUser(TextBox name, TextBox firstname, TextBox age)
        {
            try
            {
                Convert.ToInt32(age.Text);

                if (name.Text != "" && firstname.Text != "" && age.Text != "")
                {
                    _model.NameToInsert = name.Text;
                    _model.FirstnameToInsert = firstname.Text;
                    _model.AgeToInsert = Convert.ToInt32(age.Text);
                    return true;
                }
                else
                {
                    _view.Message("Veuillez entrer toutes les valeures");
                    return false;
                }
            }
            catch (Exception e)
            {
                _view.Message("L'age doit être exprimer avec des chiffres..\n\n" + e.ToString());
                return false;
            }
        }

        /// <summary>
        /// Insert a user into the db if the value are checked
        /// </summary>
        /// <param name="canCreate">TRUE if the values are ready to create a user</param>
        public void InsertUser(bool canCreate)
        {
            if (canCreate)
            {
                try
                {
                    string query = "INSERT INTO users (Name, Surname, Age) VALUES('" + _model.NameToInsert + "', '" + _model.FirstnameToInsert + "', '" + _model.AgeToInsert + "')";

                    //Create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, _model.Conn);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //Show the message that all has been created
                    _view.Message("Votre utilisateur à été ajouter correctement, actualiser votre base de donnée pour verifier les changements");
                }
                catch (Exception e)
                {
                    _view.Message("Une erreur est survenue dans la base de donnée : " + e.ToString());
                }
            }
            else
            {
                _view.Message("Une erreure est survenue lors de la création de votre utilisateur (vous n'avez peut être pas entrer les bonnes valeures)");
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

        #region Delete

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