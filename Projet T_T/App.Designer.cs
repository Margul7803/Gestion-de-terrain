using Projet_TT;
using System;

namespace Projet_T_T
{
    partial class App
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.userRole = new System.Windows.Forms.Label();
            this.userPrenom = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.tournoiButton = new System.Windows.Forms.Button();
            this.espaceEncadrantButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mesInscriptionButton = new System.Windows.Forms.Button();
            this.inscriptionPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reservationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.terrainComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.espaceEncadrantPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.finAbonnementDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFinAboUpdateButton = new System.Windows.Forms.Button();
            this.deleteVacancier = new System.Windows.Forms.Button();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.researchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reservationListBox = new System.Windows.Forms.ListBox();
            this.ResearchTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.createUserButton = new System.Windows.Forms.Button();
            this.dateNDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mesInscriptionPanel = new System.Windows.Forms.Panel();
            this.annuleResButton = new System.Windows.Forms.Button();
            this.userReservationListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.inscriptionPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.espaceEncadrantPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mesInscriptionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.disconnectButton);
            this.buttonsPanel.Controls.Add(this.pictureBox5);
            this.buttonsPanel.Controls.Add(this.pictureBox4);
            this.buttonsPanel.Controls.Add(this.userRole);
            this.buttonsPanel.Controls.Add(this.userPrenom);
            this.buttonsPanel.Controls.Add(this.userNameLabel);
            this.buttonsPanel.Controls.Add(this.tournoiButton);
            this.buttonsPanel.Controls.Add(this.espaceEncadrantButton);
            this.buttonsPanel.Controls.Add(this.pictureBox3);
            this.buttonsPanel.Controls.Add(this.pictureBox2);
            this.buttonsPanel.Controls.Add(this.mesInscriptionButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(249, 720);
            this.buttonsPanel.TabIndex = 1;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.disconnectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.disconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectButton.Image = global::Projet_T_T.Properties.Resources.tennis_logo;
            this.disconnectButton.Location = new System.Drawing.Point(48, 655);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(178, 41);
            this.disconnectButton.TabIndex = 12;
            this.disconnectButton.Text = "Déconnexion";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(0)))), ((int)(((byte)(136)))));
            this.pictureBox5.Location = new System.Drawing.Point(32, 585);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 41);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(0)))), ((int)(((byte)(136)))));
            this.pictureBox4.Location = new System.Drawing.Point(32, 180);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 41);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRole.Location = new System.Drawing.Point(26, 96);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(64, 25);
            this.userRole.TabIndex = 10;
            this.userRole.Text = "label2";
            // 
            // userPrenom
            // 
            this.userPrenom.AutoSize = true;
            this.userPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPrenom.Location = new System.Drawing.Point(26, 59);
            this.userPrenom.Name = "userPrenom";
            this.userPrenom.Size = new System.Drawing.Size(64, 25);
            this.userPrenom.TabIndex = 9;
            this.userPrenom.Text = "label2";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(26, 23);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(64, 25);
            this.userNameLabel.TabIndex = 8;
            this.userNameLabel.Text = "label2";
            // 
            // tournoiButton
            // 
            this.tournoiButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tournoiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tournoiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tournoiButton.Image = global::Projet_T_T.Properties.Resources.tennis_logo;
            this.tournoiButton.Location = new System.Drawing.Point(48, 180);
            this.tournoiButton.Name = "tournoiButton";
            this.tournoiButton.Size = new System.Drawing.Size(178, 41);
            this.tournoiButton.TabIndex = 2;
            this.tournoiButton.Text = "Réserver un terrain";
            this.tournoiButton.UseVisualStyleBackColor = true;
            this.tournoiButton.Click += new System.EventHandler(this.tournoiButton_Click);
            // 
            // espaceEncadrantButton
            // 
            this.espaceEncadrantButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.espaceEncadrantButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.espaceEncadrantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.espaceEncadrantButton.Image = global::Projet_T_T.Properties.Resources.tennis_logo;
            this.espaceEncadrantButton.Location = new System.Drawing.Point(48, 585);
            this.espaceEncadrantButton.Name = "espaceEncadrantButton";
            this.espaceEncadrantButton.Size = new System.Drawing.Size(178, 41);
            this.espaceEncadrantButton.TabIndex = 6;
            this.espaceEncadrantButton.Text = "Espace Encadrant";
            this.espaceEncadrantButton.UseVisualStyleBackColor = true;
            this.espaceEncadrantButton.Click += new System.EventHandler(this.espaceEncadrantButton_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(0)))), ((int)(((byte)(136)))));
            this.pictureBox3.Location = new System.Drawing.Point(32, 655);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 41);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(0)))), ((int)(((byte)(136)))));
            this.pictureBox2.Location = new System.Drawing.Point(32, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 41);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // mesInscriptionButton
            // 
            this.mesInscriptionButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mesInscriptionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mesInscriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mesInscriptionButton.Image = global::Projet_T_T.Properties.Resources.tennis_logo;
            this.mesInscriptionButton.Location = new System.Drawing.Point(48, 251);
            this.mesInscriptionButton.Name = "mesInscriptionButton";
            this.mesInscriptionButton.Size = new System.Drawing.Size(178, 41);
            this.mesInscriptionButton.TabIndex = 4;
            this.mesInscriptionButton.Text = "Mes réservations";
            this.mesInscriptionButton.UseVisualStyleBackColor = true;
            this.mesInscriptionButton.Click += new System.EventHandler(this.mesInscriptionButton_Click_1);
            // 
            // inscriptionPanel
            // 
            this.inscriptionPanel.Controls.Add(this.panel2);
            this.inscriptionPanel.Controls.Add(this.button4);
            this.inscriptionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inscriptionPanel.Location = new System.Drawing.Point(260, 0);
            this.inscriptionPanel.Name = "inscriptionPanel";
            this.inscriptionPanel.Size = new System.Drawing.Size(1020, 720);
            this.inscriptionPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.reservationDateTimePicker);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.terrainComboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 561);
            this.panel2.TabIndex = 16;
            // 
            // reservationDateTimePicker
            // 
            this.reservationDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reservationDateTimePicker.CustomFormat = "HH:00";
            this.reservationDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reservationDateTimePicker.Location = new System.Drawing.Point(433, 248);
            this.reservationDateTimePicker.Name = "reservationDateTimePicker";
            this.reservationDateTimePicker.ShowUpDown = true;
            this.reservationDateTimePicker.Size = new System.Drawing.Size(147, 30);
            this.reservationDateTimePicker.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Choisir le terrain";
            // 
            // terrainComboBox
            // 
            this.terrainComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.terrainComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terrainComboBox.FormattingEnabled = true;
            //this.terrainComboBox.Items.AddRange(new object[] {
            //Projet_TT.Terrain.Terrain_1,
            //Projet_TT.Terrain.Terrain_2,
            //Projet_TT.Terrain.Terrain_3});
            this.terrainComboBox.Location = new System.Drawing.Point(405, 309);
            this.terrainComboBox.Name = "terrainComboBox";
            this.terrainComboBox.Size = new System.Drawing.Size(200, 33);
            this.terrainComboBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chosir une heure";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Projet_T_T.Properties.Resources.tennis_logo;
            this.button4.Location = new System.Drawing.Point(73, 655);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(869, 53);
            this.button4.TabIndex = 13;
            this.button4.Text = "Réserver le terrain";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // espaceEncadrantPanel
            // 
            this.espaceEncadrantPanel.BackColor = System.Drawing.SystemColors.Window;
            this.espaceEncadrantPanel.Controls.Add(this.tabControl1);
            this.espaceEncadrantPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.espaceEncadrantPanel.Location = new System.Drawing.Point(260, 0);
            this.espaceEncadrantPanel.Name = "espaceEncadrantPanel";
            this.espaceEncadrantPanel.Size = new System.Drawing.Size(1020, 720);
            this.espaceEncadrantPanel.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 720);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1012, 691);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion utilisateurs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.finAbonnementDateTimePicker);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dateFinAboUpdateButton);
            this.panel3.Controls.Add(this.deleteVacancier);
            this.panel3.Controls.Add(this.userListBox);
            this.panel3.Controls.Add(this.researchButton);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.reservationListBox);
            this.panel3.Controls.Add(this.ResearchTextBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1006, 685);
            this.panel3.TabIndex = 7;
            // 
            // finAbonnementDateTimePicker
            // 
            this.finAbonnementDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.finAbonnementDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finAbonnementDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.finAbonnementDateTimePicker.Location = new System.Drawing.Point(662, 272);
            this.finAbonnementDateTimePicker.Name = "finAbonnementDateTimePicker";
            this.finAbonnementDateTimePicker.Size = new System.Drawing.Size(139, 30);
            this.finAbonnementDateTimePicker.TabIndex = 18;
            this.finAbonnementDateTimePicker.Value = new System.DateTime(2023, 3, 22, 13, 44, 25, 991);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Date fin de l\'abonnement:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateFinAboUpdateButton
            // 
            this.dateFinAboUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFinAboUpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dateFinAboUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateFinAboUpdateButton.Image = global::Projet_T_T.Properties.Resources.tennis_logo;
            this.dateFinAboUpdateButton.Location = new System.Drawing.Point(807, 266);
            this.dateFinAboUpdateButton.Name = "dateFinAboUpdateButton";
            this.dateFinAboUpdateButton.Size = new System.Drawing.Size(178, 41);
            this.dateFinAboUpdateButton.TabIndex = 15;
            this.dateFinAboUpdateButton.Text = "Modifier l\'abonnement";
            this.dateFinAboUpdateButton.UseVisualStyleBackColor = true;
            this.dateFinAboUpdateButton.Click += new System.EventHandler(this.dateFinAboUpdateButton_Click);
            // 
            // deleteVacancier
            // 
            this.deleteVacancier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteVacancier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteVacancier.Image = global::Projet_T_T.Properties.Resources.tennis_logo;
            this.deleteVacancier.Location = new System.Drawing.Point(25, 266);
            this.deleteVacancier.Name = "deleteVacancier";
            this.deleteVacancier.Size = new System.Drawing.Size(178, 41);
            this.deleteVacancier.TabIndex = 14;
            this.deleteVacancier.Text = "Supprimer un vacancier";
            this.deleteVacancier.UseVisualStyleBackColor = true;
            this.deleteVacancier.Click += new System.EventHandler(this.deleteVacancier_Click);
            // 
            // userListBox
            // 
            this.userListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 20;
            this.userListBox.Location = new System.Drawing.Point(25, 101);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(961, 84);
            this.userListBox.TabIndex = 2;
            this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
            // 
            // researchButton
            // 
            this.researchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.researchButton.BackgroundImage = global::Projet_T_T.Properties.Resources.icons8_rechercher_un_client_96;
            this.researchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.researchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.researchButton.Location = new System.Drawing.Point(624, 33);
            this.researchButton.Name = "researchButton";
            this.researchButton.Size = new System.Drawing.Size(31, 30);
            this.researchButton.TabIndex = 6;
            this.researchButton.UseVisualStyleBackColor = true;
            this.researchButton.Click += new System.EventHandler(this.researchButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Recherche";
            // 
            // reservationListBox
            // 
            this.reservationListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationListBox.FormattingEnabled = true;
            this.reservationListBox.ItemHeight = 20;
            this.reservationListBox.Location = new System.Drawing.Point(24, 369);
            this.reservationListBox.Name = "reservationListBox";
            this.reservationListBox.Size = new System.Drawing.Size(961, 304);
            this.reservationListBox.TabIndex = 5;
            // 
            // ResearchTextBox
            // 
            this.ResearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResearchTextBox.Location = new System.Drawing.Point(371, 33);
            this.ResearchTextBox.Name = "ResearchTextBox";
            this.ResearchTextBox.Size = new System.Drawing.Size(247, 30);
            this.ResearchTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(393, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Historique de réservation";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Choisir un utilisateur";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1012, 691);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ajouter un utilisateur";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.passTextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.roleComboBox);
            this.groupBox1.Controls.Add(this.createUserButton);
            this.groupBox1.Controls.Add(this.dateNDateTimePicker);
            this.groupBox1.Controls.Add(this.prenomTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.mailTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(304, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 373);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un utilisateur";
            // 
            // passTextBox
            // 
            this.passTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.Location = new System.Drawing.Point(165, 263);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(186, 30);
            this.passTextBox.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Mot de passe";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Role:";
            // 
            // roleComboBox
            // 
            this.roleComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            Projet_T_T.Role.Vacancier,
            Projet_T_T.Role.Encadrant});
            this.roleComboBox.Location = new System.Drawing.Point(97, 54);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(254, 33);
            this.roleComboBox.TabIndex = 21;
            // 
            // createUserButton
            // 
            this.createUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserButton.Image = global::Projet_T_T.Properties.Resources.tennis_logo;
            this.createUserButton.Location = new System.Drawing.Point(102, 315);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(178, 41);
            this.createUserButton.TabIndex = 20;
            this.createUserButton.Text = "Ajouter";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // dateNDateTimePicker
            // 
            this.dateNDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateNDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNDateTimePicker.Location = new System.Drawing.Point(215, 221);
            this.dateNDateTimePicker.Name = "dateNDateTimePicker";
            this.dateNDateTimePicker.Size = new System.Drawing.Size(136, 30);
            this.dateNDateTimePicker.TabIndex = 19;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prenomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomTextBox.Location = new System.Drawing.Point(121, 179);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(230, 30);
            this.prenomTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(97, 137);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(254, 30);
            this.nameTextBox.TabIndex = 6;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTextBox.Location = new System.Drawing.Point(97, 98);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(254, 30);
            this.mailTextBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Prénom:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Date de naissance:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mail:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nom:";
            // 
            // mesInscriptionPanel
            // 
            this.mesInscriptionPanel.BackColor = System.Drawing.SystemColors.Window;
            this.mesInscriptionPanel.Controls.Add(this.annuleResButton);
            this.mesInscriptionPanel.Controls.Add(this.userReservationListBox);
            this.mesInscriptionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesInscriptionPanel.Location = new System.Drawing.Point(260, 0);
            this.mesInscriptionPanel.Name = "mesInscriptionPanel";
            this.mesInscriptionPanel.Size = new System.Drawing.Size(1020, 720);
            this.mesInscriptionPanel.TabIndex = 7;
            // 
            // annuleResButton
            // 
            this.annuleResButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.annuleResButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.annuleResButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annuleResButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuleResButton.Image = global::Projet_T_T.Properties.Resources.tennis_logo;
            this.annuleResButton.Location = new System.Drawing.Point(73, 625);
            this.annuleResButton.Name = "annuleResButton";
            this.annuleResButton.Size = new System.Drawing.Size(869, 53);
            this.annuleResButton.TabIndex = 3;
            this.annuleResButton.Text = "Annuler une réservation";
            this.annuleResButton.UseVisualStyleBackColor = true;
            this.annuleResButton.Click += new System.EventHandler(this.annuleResButton_Click);
            // 
            // userReservationListBox
            // 
            this.userReservationListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userReservationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userReservationListBox.FormattingEnabled = true;
            this.userReservationListBox.ItemHeight = 20;
            this.userReservationListBox.Location = new System.Drawing.Point(73, 26);
            this.userReservationListBox.Name = "userReservationListBox";
            this.userReservationListBox.Size = new System.Drawing.Size(869, 564);
            this.userReservationListBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonsPanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 720);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(0)))), ((int)(((byte)(136)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 720);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mesInscriptionPanel);
            this.Controls.Add(this.espaceEncadrantPanel);
            this.Controls.Add(this.inscriptionPanel);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(356, 640);
            this.Name = "App";
            this.Size = new System.Drawing.Size(1280, 720);
            this.buttonsPanel.ResumeLayout(false);
            this.buttonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.inscriptionPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.espaceEncadrantPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mesInscriptionPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label userPrenom;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button tournoiButton;
        private System.Windows.Forms.Button espaceEncadrantButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button mesInscriptionButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel inscriptionPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker reservationDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox terrainComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel espaceEncadrantPanel;
        private System.Windows.Forms.Button researchButton;
        private System.Windows.Forms.ListBox reservationListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.TextBox ResearchTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel mesInscriptionPanel;
        private System.Windows.Forms.Button annuleResButton;
        private System.Windows.Forms.ListBox userReservationListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DateTimePicker finAbonnementDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dateFinAboUpdateButton;
        private System.Windows.Forms.Button deleteVacancier;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.DateTimePicker dateNDateTimePicker;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label12;
    }
}
