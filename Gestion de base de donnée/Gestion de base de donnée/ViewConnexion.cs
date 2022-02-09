using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_de_base_de_donnée
{
    public partial class ViewConnexion : Form
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

        public ViewConnexion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Connect the server to the app
        /// </summary>
        private void btnConnectServer_Click(object sender, EventArgs e)
        {
            _controler.ConnectServer(txtBoxAdress.Text, txtBoxPort.Text, txtBoxUserName.Text, txtBoxPassword.Text);
        }

        /// <summary>
        /// Logout the server
        /// </summary>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            _controler.LogoutServer();
            lblUsersSelected.Text = "";
        }

        /// <summary>
        /// Create a db
        /// </summary>
        private void BtnCreateDataBase_Click(object sender, EventArgs e)
        {
            bool connectionSucces = _controler.CreateDataBase(txtBoxTitleDB.Text);

            if (connectionSucces)
            {
                _controler.AddDataBase(txtBoxTitleDB.Text);
                ResetTextBox(txtBoxTitleDB, false);
            }
        }

        /// <summary>
        /// Delete the database
        /// </summary>
        private void BtnDeleteDB_Click(object sender, EventArgs e)
        {
            bool deleteSuccess = _controler.DeleteDataBase(txtBoxTitleDB.Text);

            if (deleteSuccess)
            {
                //Remove db from list of DBnames
                _controler.RemoveDataBase(txtBoxTitleDB.Text);

                //If the user is connected to a db logout him
                if (txtBoxTitleDB.Text == _controler.getDbName())
                {
                    _controler.IsLoggedDB = false;
                    _controler.setDBName("");
                    lblDBNameConected.Text = "Veuillez vous connecter à une base de donnée";
                }

                ResetTextBox(txtBoxTitleDB, false);
            }
        }

        /// <summary>
        /// Click on the login button
        /// </summary>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            _controler.LoginDB(txtBoxConnectDBName.Text);
        }

        /// <summary>
        /// Show the table and the attribute
        /// </summary>
        private void BtnGoToTable_Click(object sender, EventArgs e)
        {
            _controler.GoToTable(txtBoxGoToTable.Text);
        }
        
        /// <summary>
        /// Select a user and write it to the screen
        /// </summary>
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            _controler.SelectUsers(_controler.CheckWhatIsSelected(txtBoxSelectName, checkBoxSelectAll));
            ResetTextBox(txtBoxSelectName, false);
        }

        /// <summary>
        /// Write the db names to the label
        /// </summary>
        /// <param name="DBNames">the list with the db names</param>
        public void WriteDBToScreen(List<string> DBNames)
        {
            foreach (string name in DBNames)
            {
                lblShowDB.Text += name + "\n";
            }
        }

        /// <summary>
        /// Write the infos of the users
        /// </summary>
        /// <param name="users">The list of the users</param>
        public void WriteUsersInfos(List<string>[] users)
        {
            lblUsersSelected.Text = "";

            for (int i = 0; i < users[0].Count; i++)
            {
                for (int ii = 0; ii < users.Length; ii++)
                {
                    lblUsersSelected.Text += users[ii][i] + ", ";
                }
                lblUsersSelected.Text += "\n";
            }
        }

        /// <summary>
        /// Show a message to the screen
        /// </summary>
        /// <param name="message">The message to show</param>
        public void Message(string message)
        {
            if (checkBoxShowMessages.Checked)
            {
                MessageBox.Show(message);
            }
        }

        /// <summary>
        /// Connection to the server success
        /// </summary>
        public void ConnectionSucces()
        {
            pnlConnectedToServer.Visible = true;
            pnlGetConnexionToServer.Visible = false;
            LoginServ(true);
            GoToEditDB(true);
        }

        /// <summary>
        /// Set the variables when the user is connected
        /// </summary>
        public void ConnectionToDBSucces(string dbName)
        {
            lblDBNameConected.Text = dbName;
            txtBoxConnectDBName.Text = "";
            lblUsersSelected.Text = "";
            LoginServ(true);
            GoToEditDB(true);
        }

        /// <summary>
        /// Set the variable when the user is logged out
        /// </summary>
        public void Logout()
        {
            lblDBNameConected.Text = "Veuillez vous connecter à une base de donnée";
            LoginServ(false);
            GoToEditDB(false);
            GoToEditTable(false);
        }

        /// <summary>
        /// Enable the panel when the user log in or log out the server
        /// </summary>
        public void LoginServ(bool login)
        {
            if (login)
            {
                pnlConnectedToServer.Visible = true;
                pnlGetConnexionToServer.Visible = false;
            }
            else
            {
                pnlConnectedToServer.Visible = false;
                pnlGetConnexionToServer.Visible = true;
            }
        }

        /// <summary>
        /// Enable the panel when the user is not connected to a table
        /// </summary>
        public void GoToEditDB(bool login)
        {
            if (login)
            {
                pnlEditDB.Location = new Point(0, 150);
                pnlEditDB.Visible = true;
                pnlConnectedToServer.Visible = true;
                pnlGetConnexionToServer.Visible = false;
            }
            else
            {
                pnlEditDB.Visible = false;
                pnlConnectedToServer.Visible = false;
                pnlGetConnexionToServer.Visible = true;
            }
        }

        /// <summary>
        /// Enable the panel when the user edit a table
        /// </summary>
        public void GoToEditTable(bool login)
        {
            if (login)
            {
                pnlEditTable.Location = new Point(0, 150);
                pnlEditTable.Visible = true;
                btnBack.Visible = true;
            }
            else
            {
                pnlEditTable.Visible = false;
                btnBack.Visible = false;
            }
        }

        /// <summary>
        /// Show the table panel
        /// </summary>
        public void CanSeeTable()
        {
            pnlEditDB.Visible = false;
            GoToEditTable(true);
        }

        /// <summary>
        /// Reset a text box and select it if the user want
        /// </summary>
        /// <param name="txtBoxToReset">Text box to reset and select</param>
        /// <param name="select">True if the user want to select it</param>
        public void ResetTextBox(TextBox txtBoxToReset, bool select)
        {
            txtBoxToReset.Text = "";
            if (select)
            {
                txtBoxToReset.Select();
            }
        }

        /// <summary>
        /// Reset the label of the db name
        /// </summary>
        public void RestLabelDBName()
        {
            lblShowDB.Text = "";
            System.Threading.Thread.Sleep(10);
        }

        private void ViewConnexion_Load(object sender, EventArgs e)
        {
            pnlGetConnexionToServer.Location = new Point(0, 0);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            pnlEditDB.Visible = true;
            GoToEditTable(false);
        }
    }
}
