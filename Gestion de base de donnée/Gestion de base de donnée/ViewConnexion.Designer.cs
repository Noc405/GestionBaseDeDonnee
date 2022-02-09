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
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblSelectName = new System.Windows.Forms.Label();
            this.txtBoxSelectName = new System.Windows.Forms.TextBox();
            this.lblTitleSelectUser = new System.Windows.Forms.Label();
            this.pnlUsersSelected = new System.Windows.Forms.Panel();
            this.lblUsersSelected = new System.Windows.Forms.Label();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.pnlEditTable = new System.Windows.Forms.Panel();
            this.lblDBName = new System.Windows.Forms.Label();
            this.txtBoxTitleDB = new System.Windows.Forms.TextBox();
            this.txtBoxTitleTable = new System.Windows.Forms.TextBox();
            this.lblTitleNameTable = new System.Windows.Forms.Label();
            this.lblDbNameConnectedTitle = new System.Windows.Forms.Label();
            this.lblDBNameConected = new System.Windows.Forms.Label();
            this.txtBoxConnectDBName = new System.Windows.Forms.TextBox();
            this.lblTitleConnectDBName = new System.Windows.Forms.Label();
            this.pnlConnectedToServer = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.checkBoxShowMessages = new System.Windows.Forms.CheckBox();
            this.pnlEditDB = new System.Windows.Forms.Panel();
            this.pnlShowDB = new System.Windows.Forms.Panel();
            this.lblShowDB = new System.Windows.Forms.Label();
            this.lblTitleShowDB = new System.Windows.Forms.Label();
            this.lblTitleGoToTable = new System.Windows.Forms.Label();
            this.txtBoxGoToTable = new System.Windows.Forms.TextBox();
            this.btnGoToTable = new System.Windows.Forms.Button();
            this.btnDeleteDB = new System.Windows.Forms.Button();
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
            this.pnlUsersSelected.SuspendLayout();
            this.pnlEditTable.SuspendLayout();
            this.pnlConnectedToServer.SuspendLayout();
            this.pnlEditDB.SuspendLayout();
            this.pnlShowDB.SuspendLayout();
            this.pnlGetConnexionToServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(37, 376);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(164, 48);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Se connecter";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(106, 184);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(128, 24);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Séléctionner";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // lblSelectName
            // 
            this.lblSelectName.AutoSize = true;
            this.lblSelectName.Location = new System.Drawing.Point(121, 105);
            this.lblSelectName.Name = "lblSelectName";
            this.lblSelectName.Size = new System.Drawing.Size(101, 13);
            this.lblSelectName.TabIndex = 11;
            this.lblSelectName.Text = "Comportant le nom :";
            // 
            // txtBoxSelectName
            // 
            this.txtBoxSelectName.Location = new System.Drawing.Point(103, 124);
            this.txtBoxSelectName.Name = "txtBoxSelectName";
            this.txtBoxSelectName.Size = new System.Drawing.Size(131, 20);
            this.txtBoxSelectName.TabIndex = 5;
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
            this.pnlUsersSelected.Location = new System.Drawing.Point(389, 3);
            this.pnlUsersSelected.Name = "pnlUsersSelected";
            this.pnlUsersSelected.Size = new System.Drawing.Size(402, 361);
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
            this.checkBoxSelectAll.Location = new System.Drawing.Point(113, 223);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(108, 17);
            this.checkBoxSelectAll.TabIndex = 16;
            this.checkBoxSelectAll.Text = "Tout séléctionner";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Location = new System.Drawing.Point(37, 111);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(164, 24);
            this.btnCreateDB.TabIndex = 2;
            this.btnCreateDB.Text = "Créer la base de donnée";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.BtnCreateDataBase_Click);
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(288, 123);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(164, 48);
            this.btnCreateTable.TabIndex = 7;
            this.btnCreateTable.Text = "Créer la table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            // 
            // pnlEditTable
            // 
            this.pnlEditTable.Controls.Add(this.btnSelect);
            this.pnlEditTable.Controls.Add(this.checkBoxSelectAll);
            this.pnlEditTable.Controls.Add(this.pnlUsersSelected);
            this.pnlEditTable.Controls.Add(this.lblSelectName);
            this.pnlEditTable.Controls.Add(this.txtBoxSelectName);
            this.pnlEditTable.Location = new System.Drawing.Point(0, 150);
            this.pnlEditTable.Name = "pnlEditTable";
            this.pnlEditTable.Size = new System.Drawing.Size(797, 367);
            this.pnlEditTable.TabIndex = 19;
            this.pnlEditTable.Visible = false;
            // 
            // lblDBName
            // 
            this.lblDBName.AutoSize = true;
            this.lblDBName.Location = new System.Drawing.Point(46, 40);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(135, 13);
            this.lblDBName.TabIndex = 20;
            this.lblDBName.Text = "Nom de la base de donnée";
            // 
            // txtBoxTitleDB
            // 
            this.txtBoxTitleDB.Location = new System.Drawing.Point(37, 65);
            this.txtBoxTitleDB.Name = "txtBoxTitleDB";
            this.txtBoxTitleDB.Size = new System.Drawing.Size(164, 20);
            this.txtBoxTitleDB.TabIndex = 1;
            // 
            // txtBoxTitleTable
            // 
            this.txtBoxTitleTable.Location = new System.Drawing.Point(288, 65);
            this.txtBoxTitleTable.Name = "txtBoxTitleTable";
            this.txtBoxTitleTable.Size = new System.Drawing.Size(164, 20);
            this.txtBoxTitleTable.TabIndex = 6;
            // 
            // lblTitleNameTable
            // 
            this.lblTitleNameTable.AutoSize = true;
            this.lblTitleNameTable.Location = new System.Drawing.Point(320, 40);
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
            this.txtBoxConnectDBName.Location = new System.Drawing.Point(37, 320);
            this.txtBoxConnectDBName.Name = "txtBoxConnectDBName";
            this.txtBoxConnectDBName.Size = new System.Drawing.Size(164, 20);
            this.txtBoxConnectDBName.TabIndex = 4;
            // 
            // lblTitleConnectDBName
            // 
            this.lblTitleConnectDBName.AutoSize = true;
            this.lblTitleConnectDBName.Location = new System.Drawing.Point(46, 282);
            this.lblTitleConnectDBName.Name = "lblTitleConnectDBName";
            this.lblTitleConnectDBName.Size = new System.Drawing.Size(138, 26);
            this.lblTitleConnectDBName.TabIndex = 26;
            this.lblTitleConnectDBName.Text = "Nom de la base de donnée \r\nà laquelle se connecter\r\n";
            this.lblTitleConnectDBName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlConnectedToServer
            // 
            this.pnlConnectedToServer.Controls.Add(this.btnBack);
            this.pnlConnectedToServer.Controls.Add(this.checkBoxShowMessages);
            this.pnlConnectedToServer.Controls.Add(this.pnlEditDB);
            this.pnlConnectedToServer.Controls.Add(this.btnLogout);
            this.pnlConnectedToServer.Controls.Add(this.lblDBNameConected);
            this.pnlConnectedToServer.Controls.Add(this.pnlEditTable);
            this.pnlConnectedToServer.Controls.Add(this.lblDbNameConnectedTitle);
            this.pnlConnectedToServer.Location = new System.Drawing.Point(0, 0);
            this.pnlConnectedToServer.Name = "pnlConnectedToServer";
            this.pnlConnectedToServer.Size = new System.Drawing.Size(797, 633);
            this.pnlConnectedToServer.TabIndex = 27;
            this.pnlConnectedToServer.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 540);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 34);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "  <-        Retour";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // checkBoxShowMessages
            // 
            this.checkBoxShowMessages.AutoSize = true;
            this.checkBoxShowMessages.Location = new System.Drawing.Point(640, 63);
            this.checkBoxShowMessages.Name = "checkBoxShowMessages";
            this.checkBoxShowMessages.Size = new System.Drawing.Size(128, 17);
            this.checkBoxShowMessages.TabIndex = 30;
            this.checkBoxShowMessages.Text = "Afficher les messages";
            this.checkBoxShowMessages.UseVisualStyleBackColor = true;
            // 
            // pnlEditDB
            // 
            this.pnlEditDB.Controls.Add(this.pnlShowDB);
            this.pnlEditDB.Controls.Add(this.lblTitleGoToTable);
            this.pnlEditDB.Controls.Add(this.txtBoxGoToTable);
            this.pnlEditDB.Controls.Add(this.btnGoToTable);
            this.pnlEditDB.Controls.Add(this.txtBoxTitleDB);
            this.pnlEditDB.Controls.Add(this.btnDeleteDB);
            this.pnlEditDB.Controls.Add(this.lblTitleNameTable);
            this.pnlEditDB.Controls.Add(this.txtBoxTitleTable);
            this.pnlEditDB.Controls.Add(this.btnCreateTable);
            this.pnlEditDB.Controls.Add(this.lblDBName);
            this.pnlEditDB.Controls.Add(this.txtBoxConnectDBName);
            this.pnlEditDB.Controls.Add(this.btnCreateDB);
            this.pnlEditDB.Controls.Add(this.btnLogin);
            this.pnlEditDB.Controls.Add(this.lblTitleConnectDBName);
            this.pnlEditDB.Location = new System.Drawing.Point(12, 111);
            this.pnlEditDB.Name = "pnlEditDB";
            this.pnlEditDB.Size = new System.Drawing.Size(797, 463);
            this.pnlEditDB.TabIndex = 29;
            this.pnlEditDB.Visible = false;
            // 
            // pnlShowDB
            // 
            this.pnlShowDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlShowDB.Controls.Add(this.lblShowDB);
            this.pnlShowDB.Controls.Add(this.lblTitleShowDB);
            this.pnlShowDB.Location = new System.Drawing.Point(469, 13);
            this.pnlShowDB.Name = "pnlShowDB";
            this.pnlShowDB.Size = new System.Drawing.Size(315, 438);
            this.pnlShowDB.TabIndex = 33;
            // 
            // lblShowDB
            // 
            this.lblShowDB.AutoSize = true;
            this.lblShowDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDB.Location = new System.Drawing.Point(7, 58);
            this.lblShowDB.Name = "lblShowDB";
            this.lblShowDB.Size = new System.Drawing.Size(0, 16);
            this.lblShowDB.TabIndex = 1;
            // 
            // lblTitleShowDB
            // 
            this.lblTitleShowDB.AutoSize = true;
            this.lblTitleShowDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleShowDB.Location = new System.Drawing.Point(3, 7);
            this.lblTitleShowDB.Name = "lblTitleShowDB";
            this.lblTitleShowDB.Size = new System.Drawing.Size(309, 24);
            this.lblTitleShowDB.TabIndex = 0;
            this.lblTitleShowDB.Text = "Bases de données disponibles :";
            // 
            // lblTitleGoToTable
            // 
            this.lblTitleGoToTable.AutoSize = true;
            this.lblTitleGoToTable.Location = new System.Drawing.Point(301, 290);
            this.lblTitleGoToTable.Name = "lblTitleGoToTable";
            this.lblTitleGoToTable.Size = new System.Drawing.Size(128, 13);
            this.lblTitleGoToTable.TabIndex = 31;
            this.lblTitleGoToTable.Text = "Nom de la table à afficher";
            // 
            // txtBoxGoToTable
            // 
            this.txtBoxGoToTable.Location = new System.Drawing.Point(288, 320);
            this.txtBoxGoToTable.Name = "txtBoxGoToTable";
            this.txtBoxGoToTable.Size = new System.Drawing.Size(164, 20);
            this.txtBoxGoToTable.TabIndex = 8;
            // 
            // btnGoToTable
            // 
            this.btnGoToTable.Location = new System.Drawing.Point(288, 376);
            this.btnGoToTable.Name = "btnGoToTable";
            this.btnGoToTable.Size = new System.Drawing.Size(164, 48);
            this.btnGoToTable.TabIndex = 9;
            this.btnGoToTable.Text = "Afficher la table";
            this.btnGoToTable.UseVisualStyleBackColor = true;
            this.btnGoToTable.Click += new System.EventHandler(this.BtnGoToTable_Click);
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.Location = new System.Drawing.Point(37, 151);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(164, 26);
            this.btnDeleteDB.TabIndex = 3;
            this.btnDeleteDB.Text = "Suprimer la base de donnée";
            this.btnDeleteDB.UseVisualStyleBackColor = true;
            this.btnDeleteDB.Click += new System.EventHandler(this.BtnDeleteDB_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(618, 26);
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
            this.pnlEditTable.ResumeLayout(false);
            this.pnlEditTable.PerformLayout();
            this.pnlConnectedToServer.ResumeLayout(false);
            this.pnlConnectedToServer.PerformLayout();
            this.pnlEditDB.ResumeLayout(false);
            this.pnlEditDB.PerformLayout();
            this.pnlShowDB.ResumeLayout(false);
            this.pnlShowDB.PerformLayout();
            this.pnlGetConnexionToServer.ResumeLayout(false);
            this.pnlGetConnexionToServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblSelectName;
        private System.Windows.Forms.TextBox txtBoxSelectName;
        private System.Windows.Forms.Label lblTitleSelectUser;
        private System.Windows.Forms.Panel pnlUsersSelected;
        private System.Windows.Forms.Label lblUsersSelected;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Panel pnlEditTable;
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
        private System.Windows.Forms.Panel pnlEditDB;
        private System.Windows.Forms.Label lblTitleGoToTable;
        private System.Windows.Forms.TextBox txtBoxGoToTable;
        private System.Windows.Forms.Button btnGoToTable;
        private System.Windows.Forms.Panel pnlShowDB;
        private System.Windows.Forms.Label lblShowDB;
        private System.Windows.Forms.Label lblTitleShowDB;
        private System.Windows.Forms.CheckBox checkBoxShowMessages;
        private System.Windows.Forms.Button btnBack;
    }
}

