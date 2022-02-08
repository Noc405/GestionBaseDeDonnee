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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _controler.LogoutServer();
        }

        /// <summary>
        /// Create a db
        /// </summary>
        private void BtnCreateDataBase_Click(object sender, EventArgs e)
        {
            bool connectionSucces = _controler.CreateDataBase(txtBoxTitleDB.Text);

            if (connectionSucces)
            {
                _controler.IsLogged = true;
                txtBoxTitleDB.Text = "";
            }
        }

        private void BtnDeleteDB_Click(object sender, EventArgs e)
        {
            bool deleteSuccess = _controler.DeleteDataBase(txtBoxTitleDB.Text);

            if (deleteSuccess)
            {
                if (txtBoxTitleDB.Text == _controler.getDbName())
                {
                    _controler.IsLogged = false;
                    _controler.setDBName("");
                    lblDBNameConected.Text = "Veuillez vous connecter à une base de donnée";
                }
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
        /// Insert a user
        /// </summary>
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            _controler.InsertUser(_controler.VerifInfoUser(txtBoxCreateName, txtBoxCreateFirstname, txtBoxCreateAge));
            ResetTextBoxInsert();
        }
        
        /// <summary>
        /// Select a user and write it to the screen
        /// </summary>
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            _controler.SelectUsers(_controler.CheckWhatIsSelected(txtBoxSelectName, checkBoxSelectAll));
        }

        /// <summary>
        /// Delete a user
        /// </summary>
        private void BtnDelete_Click(object sender, EventArgs e)
        {

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
            MessageBox.Show(message);
        }

        /// <summary>
        /// Connection to the server success
        /// </summary>
        public void ConnectionSucces()
        {
            pnlConnectedToServer.Visible = true;
            pnlGetConnexionToServer.Visible = false;
        }

        /// <summary>
        /// Set the variables when the user is connected
        /// </summary>
        public void ConnectionToDBSucces(string dbName)
        {
            lblDBNameConected.Text = dbName;
            txtBoxConnectDBName.Text = "";
            lblUsersSelected.Text = "";
            EnableButtons(true);
        }

        /// <summary>
        /// Set the variable when the user is logged out
        /// </summary>
        public void Logout()
        { 
            lblDBNameConected.Text = "Veuillez vous connecter à une base de donnée";
            txtBoxConnectDBName.Text = "";
            lblUsersSelected.Text = "";
            pnlGetConnexionToServer.Visible = true;
            pnlConnectedToServer.Visible = false;
            EnableButtons(false);
        }

        /// <summary>
        /// REset the textbox when the user press the insert button
        /// </summary>
        public void ResetTextBoxInsert()
        {
            txtBoxCreateFirstname.Text = "";
            txtBoxCreateName.Text = "";
            txtBoxCreateAge.Text = "";
            txtBoxCreateName.Select();
        }

        /// <summary>
        /// Enable the buttons and the textbox when the user login and disable it when he logout
        /// </summary>
        public void EnableButtons(bool login)
        {
            if (login)
            {
                btnDelete.Enabled = true;
                btnSelect.Enabled = true;
                btnInsert.Enabled = true;
                txtBoxCreateAge.Enabled = true;
                txtBoxCreateName.Enabled = true;
                txtBoxCreateFirstname.Enabled = true;
                txtBoxDeleteName.Enabled = true;
                txtBoxSelectName.Enabled = true;
                checkBoxSelectAll.Enabled = true;
                btnCreateTable.Enabled = true;
                txtBoxTitleTable.Enabled = true;
                pnlLogedUser.Visible = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnSelect.Enabled = false;
                btnInsert.Enabled = false;
                txtBoxCreateAge.Enabled = false;
                txtBoxCreateName.Enabled = false;
                txtBoxCreateFirstname.Enabled = false;
                txtBoxDeleteName.Enabled = false;
                txtBoxSelectName.Enabled = false;
                checkBoxSelectAll.Enabled = false;
                btnCreateTable.Enabled = false;
                txtBoxTitleTable.Enabled = false;
                pnlLogedUser.Visible = false;
            }
        }

        private void ViewConnexion_Load(object sender, EventArgs e)
        {
            pnlGetConnexionToServer.Location = new Point(0, 0);
        }
    }
}
