namespace Gestion_de_base_de_donnée
{
    partial class ViewConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBoxCreateName = new System.Windows.Forms.TextBox();
            this.lblCreateName = new System.Windows.Forms.Label();
            this.lblCreatePrenom = new System.Windows.Forms.Label();
            this.txtBoxCreateFirstname = new System.Windows.Forms.TextBox();
            this.lblCreateAge = new System.Windows.Forms.Label();
            this.txtBoxCreateAge = new System.Windows.Forms.TextBox();
            this.lblSelectName = new System.Windows.Forms.Label();
            this.txtBoxSelectName = new System.Windows.Forms.TextBox();
            this.lblDeleteName = new System.Windows.Forms.Label();
            this.txtBoxDeleteName = new System.Windows.Forms.TextBox();
            this.lblTitleSelectUser = new System.Windows.Forms.Label();
            this.pnlUsersSelected = new System.Windows.Forms.Panel();
            this.lblUsersSelected = new System.Windows.Forms.Label();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.btnCreateDataBase = new System.Windows.Forms.Button();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.pnlLogedUser = new System.Windows.Forms.Panel();
            this.lblDBName = new System.Windows.Forms.Label();
            this.txtBoxTitleDB = new System.Windows.Forms.TextBox();
            this.txtBoxTitleTable = new System.Windows.Forms.TextBox();
            this.lblTitleNameTable = new System.Windows.Forms.Label();
            this.lblDbNameConnectedTitle = new System.Windows.Forms.Label();
            this.lblDBNameConected = new System.Windows.Forms.Label();
            this.txtBoxConnectDBName = new System.Windows.Forms.TextBox();
            this.lblTitleConnectDBName = new System.Windows.Forms.Label();
            this.pnlConnectedToServer = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlGetConnexionToServer = new System.Windows.Forms.Panel();
            this.txtBoxAdress = new System.Windows.Forms.TextBox();
            this.lblTitleAdresse = new System.Windows.Forms.Label();
            this.txtBoxPort = new System.Windows.Forms.TextBox();
            this.lblTitlePort = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblTitlePassword = new System.Windows.Forms.Label();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.lblTitleUsername = new System.Windows.Forms.Label();
            this.btnConnectServer = new System.Windows.Forms.Button();
            this.btnDeleteDB = new System.Windows.Forms.Button();
            this.pnlUsersSelected.SuspendLayout();
            this.pnlLogedUser.SuspendLayout();
            this.pnlConnectedToServer.SuspendLayout();
            this.pnlGetConnexionToServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(311, 561);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(164, 48);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Se connecter";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(25, 294);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(128, 24);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insérer";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Location = new System.Drawing.Point(307, 294);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(128, 24);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Séléctionner";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(581, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 24);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Effacer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtBoxCreateName
            // 
            this.txtBoxCreateName.Enabled = false;
            this.txtBoxCreateName.Location = new System.Drawing.Point(25, 91);
            this.txtBoxCreateName.Name = "txtBoxCreateName";
            this.txtBoxCreateName.Size = new System.Drawing.Size(128, 20);
            this.txtBoxCreateName.TabIndex = 1;
            // 
            // lblCreateName
            // 
            this.lblCreateName.AutoSize = true;
            this.lblCreateName.Location = new System.Drawing.Point(35, 72);
            this.lblCreateName.Name = "lblCreateName";
            this.lblCreateName.Size = new System.Drawing.Size(29, 13);
            this.lblCreateName.TabIndex = 5;
            this.lblCreateName.Text = "Nom";
            // 
            // lblCreatePrenom
            // 
            this.lblCreatePrenom.AutoSize = true;
            this.lblCreatePrenom.Location = new System.Drawing.Point(35, 142);
            this.lblCreatePrenom.Name = "lblCreatePrenom";
            this.lblCreatePrenom.Size = new System.Drawing.Size(43, 13);
            this.lblCreatePrenom.TabIndex = 7;
            this.lblCreatePrenom.Text = "Prénom";
            // 
            // txtBoxCreateFirstname
            // 
            this.txtBoxCreateFirstname.Enabled = false;
            this.txtBoxCreateFirstname.Location = new System.Drawing.Point(25, 161);
            this.txtBoxCreateFirstname.Name = "txtBoxCreateFirstname";
            this.txtBoxCreateFirstname.Size = new System.Drawing.Size(128, 20);
            this.txtBoxCreateFirstname.TabIndex = 2;
            // 
            // lblCreateAge
            // 
            this.lblCreateAge.AutoSize = true;
            this.lblCreateAge.Location = new System.Drawing.Point(35, 215);
            this.lblCreateAge.Name = "lblCreateAge";
            this.lblCreateAge.Size = new System.Drawing.Size(26, 13);
            this.lblCreateAge.TabIndex = 9;
            this.lblCreateAge.Text = "Age";
            // 
            // txtBoxCreateAge
            // 
            this.txtBoxCreateAge.Enabled = false;
            this.txtBoxCreateAge.Location = new System.Drawing.Point(25, 234);
            this.txtBoxCreateAge.Name = "txtBoxCreateAge";
            this.txtBoxCreateAge.Size = new System.Drawing.Size(128, 20);
            this.txtBoxCreateAge.TabIndex = 3;
            // 
            // lblSelectName
            // 
            this.lblSelectName.AutoSize = true;
            this.lblSelectName.Location = new System.Drawing.Point(322, 215);
            this.lblSelectName.Name = "lblSelectName";
            this.lblSelectName.Size = new System.Drawing.Size(101, 13);
            this.lblSelectName.TabIndex = 11;
            this.lblSelectName.Text = "Comportant le nom :";
            // 
            // txtBoxSelectName
            // 
            this.txtBoxSelectName.Enabled = false;
            this.txtBoxSelectName.Location = new System.Drawing.Point(304, 234);
            this.txtBoxSelectName.Name = "txtBoxSelectName";
            this.txtBoxSelectName.Size = new System.Drawing.Size(131, 20);
            this.txtBoxSelectName.TabIndex = 5;
            // 
            // lblDeleteName
            // 
            this.lblDeleteName.AutoSize = true;
            this.lblDeleteName.Location = new System.Drawing.Point(597, 215);
            this.lblDeleteName.Name = "lblDeleteName";
            this.lblDeleteName.Size = new System.Drawing.Size(101, 13);
            this.lblDeleteName.TabIndex = 13;
            this.lblDeleteName.Text = "Comportant le nom :";
            // 
            // txtBoxDeleteName
            // 
            this.txtBoxDeleteName.Enabled = false;
            this.txtBoxDeleteName.Location = new System.Drawing.Point(581, 234);
            this.txtBoxDeleteName.Name = "txtBoxDeleteName";
            this.txtBoxDeleteName.Size = new System.Drawing.Size(128, 20);
            this.txtBoxDeleteName.TabIndex = 7;
            // 
            // lblTitleSelectUser
            // 
            this.lblTitleSelectUser.AutoSize = true;
            this.lblTitleSelectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSelectUser.Location = new System.Drawing.Point(11, 16);
            this.lblTitleSelectUser.Name = "lblTitleSelectUser";
            this.lblTitleSelectUser.Size = new System.Drawing.Size(275, 24);
            this.lblTitleSelectUser.TabIndex = 14;
            this.lblTitleSelectUser.Text = "Utilisateur(s) séléctionné(s) :";
            // 
            // pnlUsersSelected
            // 
            this.pnlUsersSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsersSelected.Controls.Add(this.lblUsersSelected);
            this.pnlUsersSelected.Controls.Add(this.lblTitleSelectUser);
            this.pnlUsersSelected.Location = new System.Drawing.Point(307, 14);
            this.pnlUsersSelected.Name = "pnlUsersSelected";
            this.pnlUsersSelected.Size = new System.Drawing.Size(402, 178);
            this.pnlUsersSelected.TabIndex = 15;
            // 
            // lblUsersSelected
            // 
            this.lblUsersSelected.AutoSize = true;
            this.lblUsersSelected.Location = new System.Drawing.Point(15, 58);
            this.lblUsersSelected.Name = "lblUsersSelected";
            this.lblUsersSelected.Size = new System.Drawing.Size(0, 13);
            this.lblUsersSelected.TabIndex = 15;
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Enabled = false;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(314, 333);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(108, 17);
            this.checkBoxSelectAll.TabIndex = 16;
            this.checkBoxSelectAll.Text = "Tout séléctionner";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            // 
            // btnCreateDataBase
            // 
            this.btnCreateDataBase.Location = new System.Drawing.Point(33, 551);
            this.btnCreateDataBase.Name = "btnCreateDataBase";
            this.btnCreateDataBase.Size = new System.Drawing.Size(164, 24);
            this.btnCreateDataBase.TabIndex = 2;
            this.btnCreateDataBase.Text = "Créer la base de donnée";
            this.btnCreateDataBase.UseVisualStyleBackColor = true;
            this.btnCreateDataBase.Click += new System.EventHandler(this.BtnCreateDataBase_Click);
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Enabled = false;
            this.btnCreateTable.Location = new System.Drawing.Point(595, 561);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(164, 48);
            this.btnCreateTable.TabIndex = 6;
            this.btnCreateTable.Text = "Créer la table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            // 
            // pnlLogedUser
            // 
            this.pnlLogedUser.Controls.Add(this.btnInsert);
            this.pnlLogedUser.Controls.Add(this.btnSelect);
            this.pnlLogedUser.Controls.Add(this.btnDelete);
            this.pnlLogedUser.Controls.Add(this.checkBoxSelectAll);
            this.pnlLogedUser.Controls.Add(this.txtBoxCreateName);
            this.pnlLogedUser.Controls.Add(this.pnlUsersSelected);
            this.pnlLogedUser.Controls.Add(this.lblCreateName);
            this.pnlLogedUser.Controls.Add(this.lblDeleteName);
            this.pnlLogedUser.Controls.Add(this.txtBoxCreateFirstname);
            this.pnlLogedUser.Controls.Add(this.txtBoxDeleteName);
            this.pnlLogedUser.Controls.Add(this.lblCreatePrenom);
            this.pnlLogedUser.Controls.Add(this.lblSelectName);
            this.pnlLogedUser.Controls.Add(this.txtBoxCreateAge);
            this.pnlLogedUser.Controls.Add(this.txtBoxSelectName);
            this.pnlLogedUser.Controls.Add(this.lblCreateAge);
            this.pnlLogedUser.Location = new System.Drawing.Point(33, 101);
            this.pnlLogedUser.Name = "pnlLogedUser";
            this.pnlLogedUser.Size = new System.Drawing.Size(776, 367);
            this.pnlLogedUser.TabIndex = 19;
            this.pnlLogedUser.Visible = false;
            // 
            // lblDBName
            // 
            this.lblDBName.AutoSize = true;
            this.lblDBName.Location = new System.Drawing.Point(42, 480);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(135, 13);
            this.lblDBName.TabIndex = 20;
            this.lblDBName.Text = "Nom de la base de donnée";
            // 
            // txtBoxTitleDB
            // 
            this.txtBoxTitleDB.Location = new System.Drawing.Point(33, 505);
            this.txtBoxTitleDB.Name = "txtBoxTitleDB";
            this.txtBoxTitleDB.Size = new System.Drawing.Size(164, 20);
            this.txtBoxTitleDB.TabIndex = 1;
            // 
            // txtBoxTitleTable
            // 
            this.txtBoxTitleTable.Enabled = false;
            this.txtBoxTitleTable.Location = new System.Drawing.Point(595, 505);
            this.txtBoxTitleTable.Name = "txtBoxTitleTable";
            this.txtBoxTitleTable.Size = new System.Drawing.Size(164, 20);
            this.txtBoxTitleTable.TabIndex = 5;
            // 
            // lblTitleNameTable
            // 
            this.lblTitleNameTable.AutoSize = true;
            this.lblTitleNameTable.Location = new System.Drawing.Point(635, 480);
            this.lblTitleNameTable.Name = "lblTitleNameTable";
            this.lblTitleNameTable.Size = new System.Drawing.Size(81, 13);
            this.lblTitleNameTable.TabIndex = 22;
            this.lblTitleNameTable.Text = "Nom de la table\r\n";
            // 
            // lblDbNameConnectedTitle
            // 
            this.lblDbNameConnectedTitle.AutoSize = true;
            this.lblDbNameConnectedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbNameConnectedTitle.Location = new System.Drawing.Point(29, 24);
            this.lblDbNameConnectedTitle.Name = "lblDbNameConnectedTitle";
            this.lblDbNameConnectedTitle.Size = new System.Drawing.Size(382, 24);
            this.lblDbNameConnectedTitle.TabIndex = 24;
            this.lblDbNameConnectedTitle.Text = "Nom de la base de donnée connectée :";
            // 
            // lblDBNameConected
            // 
            this.lblDBNameConected.AutoSize = true;
            this.lblDBNameConected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBNameConected.Location = new System.Drawing.Point(33, 63);
            this.lblDBNameConected.Name = "lblDBNameConected";
            this.lblDBNameConected.Size = new System.Drawing.Size(339, 20);
            this.lblDBNameConected.TabIndex = 25;
            this.lblDBNameConected.Text = "Veuillez vous connecter à une base de donnée";
            // 
            // txtBoxConnectDBName
            // 
            this.txtBoxConnectDBName.Location = new System.Drawing.Point(311, 505);
            this.txtBoxConnectDBName.Name = "txtBoxConnectDBName";
            this.txtBoxConnectDBName.Size = new System.Drawing.Size(164, 20);
            this.txtBoxConnectDBName.TabIndex = 3;
            // 
            // lblTitleConnectDBName
            // 
            this.lblTitleConnectDBName.AutoSize = true;
            this.lblTitleConnectDBName.Location = new System.Drawing.Point(288, 480);
            this.lblTitleConnectDBName.Name = "lblTitleConnectDBName";
            this.lblTitleConnectDBName.Size = new System.Drawing.Size(215, 13);
            this.lblTitleConnectDBName.TabIndex = 26;
            this.lblTitleConnectDBName.Text = "Nom de la base de donnée ou se connecter\r\n";
            // 
            // pnlConnectedToServer
            // 
            this.pnlConnectedToServer.Controls.Add(this.btnDeleteDB);
            this.pnlConnectedToServer.Controls.Add(this.btnLogout);
            this.pnlConnectedToServer.Controls.Add(this.btnCreateTable);
            this.pnlConnectedToServer.Controls.Add(this.txtBoxConnectDBName);
            this.pnlConnectedToServer.Controls.Add(this.btnLogin);
            this.pnlConnectedToServer.Controls.Add(this.lblTitleConnectDBName);
            this.pnlConnectedToServer.Controls.Add(this.btnCreateDataBase);
            this.pnlConnectedToServer.Controls.Add(this.lblDBNameConected);
            this.pnlConnectedToServer.Controls.Add(this.pnlLogedUser);
            this.pnlConnectedToServer.Controls.Add(this.lblDbNameConnectedTitle);
            this.pnlConnectedToServer.Controls.Add(this.lblDBName);
            this.pnlConnectedToServer.Controls.Add(this.txtBoxTitleTable);
            this.pnlConnectedToServer.Controls.Add(this.txtBoxTitleDB);
            this.pnlConnectedToServer.Controls.Add(this.lblTitleNameTable);
            this.pnlConnectedToServer.Location = new System.Drawing.Point(0, 0);
            this.pnlConnectedToServer.Name = "pnlConnectedToServer";
            this.pnlConnectedToServer.Size = new System.Drawing.Size(797, 633);
            this.pnlConnectedToServer.TabIndex = 27;
            this.pnlConnectedToServer.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(561, 26);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(164, 24);
            this.btnLogout.TabIndex = 27;
            this.btnLogout.Text = "Quitter le serveur";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlGetConnexionToServer
            // 
            this.pnlGetConnexionToServer.Controls.Add(this.txtBoxAdress);
            this.pnlGetConnexionToServer.Controls.Add(this.lblTitleAdresse);
            this.pnlGetConnexionToServer.Controls.Add(this.txtBoxPort);
            this.pnlGetConnexionToServer.Controls.Add(this.lblTitlePort);
            this.pnlGetConnexionToServer.Controls.Add(this.txtBoxPassword);
            this.pnlGetConnexionToServer.Controls.Add(this.lblTitlePassword);
            this.pnlGetConnexionToServer.Controls.Add(this.txtBoxUserName);
            this.pnlGetConnexionToServer.Controls.Add(this.lblTitleUsername);
            this.pnlGetConnexionToServer.Controls.Add(this.btnConnectServer);
            this.pnlGetConnexionToServer.Location = new System.Drawing.Point(1000, 0);
            this.pnlGetConnexionToServer.Name = "pnlGetConnexionToServer";
            this.pnlGetConnexionToServer.Size = new System.Drawing.Size(797, 633);
            this.pnlGetConnexionToServer.TabIndex = 28;
            // 
            // txtBoxAdress
            // 
            this.txtBoxAdress.Location = new System.Drawing.Point(292, 101);
            this.txtBoxAdress.Name = "txtBoxAdress";
            this.txtBoxAdress.Size = new System.Drawing.Size(221, 20);
            this.txtBoxAdress.TabIndex = 1;
            this.txtBoxAdress.Text = "localhost";
            // 
            // lblTitleAdresse
            // 
            this.lblTitleAdresse.AutoSize = true;
            this.lblTitleAdresse.Location = new System.Drawing.Point(360, 72);
            this.lblTitleAdresse.Name = "lblTitleAdresse";
            this.lblTitleAdresse.Size = new System.Drawing.Size(98, 13);
            this.lblTitleAdresse.TabIndex = 7;
            this.lblTitleAdresse.Text = "Adresse du serveur";
            // 
            // txtBoxPort
            // 
            this.txtBoxPort.Location = new System.Drawing.Point(292, 192);
            this.txtBoxPort.Name = "txtBoxPort";
            this.txtBoxPort.Size = new System.Drawing.Size(221, 20);
            this.txtBoxPort.TabIndex = 2;
            this.txtBoxPort.Text = "3306";
            // 
            // lblTitlePort
            // 
            this.lblTitlePort.AutoSize = true;
            this.lblTitlePort.Location = new System.Drawing.Point(370, 163);
            this.lblTitlePort.Name = "lblTitlePort";
            this.lblTitlePort.Size = new System.Drawing.Size(79, 13);
            this.lblTitlePort.TabIndex = 5;
            this.lblTitlePort.Text = "Port du serveur";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(292, 425);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '•';
            this.txtBoxPassword.Size = new System.Drawing.Size(221, 20);
            this.txtBoxPassword.TabIndex = 4;
            this.txtBoxPassword.Text = "root";
            // 
            // lblTitlePassword
            // 
            this.lblTitlePassword.AutoSize = true;
            this.lblTitlePassword.Location = new System.Drawing.Point(370, 396);
            this.lblTitlePassword.Name = "lblTitlePassword";
            this.lblTitlePassword.Size = new System.Drawing.Size(71, 13);
            this.lblTitlePassword.TabIndex = 3;
            this.lblTitlePassword.Text = "Mot de passe";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(292, 333);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(221, 20);
            this.txtBoxUserName.TabIndex = 3;
            this.txtBoxUserName.Text = "root";
            // 
            // lblTitleUsername
            // 
            this.lblTitleUsername.AutoSize = true;
            this.lblTitleUsername.Location = new System.Drawing.Point(363, 308);
            this.lblTitleUsername.Name = "lblTitleUsername";
            this.lblTitleUsername.Size = new System.Drawing.Size(84, 13);
            this.lblTitleUsername.TabIndex = 1;
            this.lblTitleUsername.Text = "Nom d\'utilisateur";
            // 
            // btnConnectServer
            // 
            this.btnConnectServer.Location = new System.Drawing.Point(292, 491);
            this.btnConnectServer.Name = "btnConnectServer";
            this.btnConnectServer.Size = new System.Drawing.Size(221, 47);
            this.btnConnectServer.TabIndex = 0;
            this.btnConnectServer.Text = " Se connecter";
            this.btnConnectServer.UseVisualStyleBackColor = true;
            this.btnConnectServer.Click += new System.EventHandler(this.btnConnectServer_Click);
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.Location = new System.Drawing.Point(33, 591);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(164, 26);
            this.btnDeleteDB.TabIndex = 28;
            this.btnDeleteDB.Text = "Suprimer la base de donnée";
            this.btnDeleteDB.UseVisualStyleBackColor = true;
            this.btnDeleteDB.Click += new System.EventHandler(this.BtnDeleteDB_Click);
            // 
            // ViewConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 633);
            this.Controls.Add(this.pnlGetConnexionToServer);
            this.Controls.Add(this.pnlConnectedToServer);
            this.Name = "ViewConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de base de donnée";
            this.Load += new System.EventHandler(this.ViewConnexion_Load);
            this.pnlUsersSelected.ResumeLayout(false);
            this.pnlUsersSelected.PerformLayout();
            this.pnlLogedUser.ResumeLayout(false);
            this.pnlLogedUser.PerformLayout();
            this.pnlConnectedToServer.ResumeLayout(false);
            this.pnlConnectedToServer.PerformLayout();
            this.pnlGetConnexionToServer.ResumeLayout(false);
            this.pnlGetConnexionToServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBoxCreateName;
        private System.Windows.Forms.Label lblCreateName;
        private System.Windows.Forms.Label lblCreatePrenom;
        private System.Windows.Forms.TextBox txtBoxCreateFirstname;
        private System.Windows.Forms.Label lblCreateAge;
        private System.Windows.Forms.TextBox txtBoxCreateAge;
        private System.Windows.Forms.Label lblSelectName;
        private System.Windows.Forms.TextBox txtBoxSelectName;
        private System.Windows.Forms.Label lblDeleteName;
        private System.Windows.Forms.TextBox txtBoxDeleteName;
        private System.Windows.Forms.Label lblTitleSelectUser;
        private System.Windows.Forms.Panel pnlUsersSelected;
        private System.Windows.Forms.Label lblUsersSelected;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.Button btnCreateDataBase;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Panel pnlLogedUser;
        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.TextBox txtBoxTitleDB;
        private System.Windows.Forms.TextBox txtBoxTitleTable;
        private System.Windows.Forms.Label lblTitleNameTable;
        private System.Windows.Forms.Label lblDbNameConnectedTitle;
        private System.Windows.Forms.Label lblDBNameConected;
        private System.Windows.Forms.TextBox txtBoxConnectDBName;
        private System.Windows.Forms.Label lblTitleConnectDBName;
        private System.Windows.Forms.Panel pnlConnectedToServer;
        private System.Windows.Forms.Panel pnlGetConnexionToServer;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblTitlePassword;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.Label lblTitleUsername;
        private System.Windows.Forms.Button btnConnectServer;
        private System.Windows.Forms.TextBox txtBoxPort;
        private System.Windows.Forms.Label lblTitlePort;
        private System.Windows.Forms.TextBox txtBoxAdress;
        private System.Windows.Forms.Label lblTitleAdresse;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDeleteDB;
    }
}

