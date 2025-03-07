namespace Habilitations2024
{
    partial class FrmHabilitations
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
            this.groupDisplay = new System.Windows.Forms.GroupBox();
            this.btnChangerpwd = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dataDevs = new System.Windows.Forms.DataGridView();
            this.groupAjout = new System.Windows.Forms.GroupBox();
            this.btnAnnulerDev = new System.Windows.Forms.Button();
            this.btnEnregistrerDev = new System.Windows.Forms.Button();
            this.cmbProfil = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupChangement = new System.Windows.Forms.GroupBox();
            this.btnAnnulerPwd = new System.Windows.Forms.Button();
            this.txtEncore = new System.Windows.Forms.TextBox();
            this.btnEnregistrerPwd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDevs)).BeginInit();
            this.groupAjout.SuspendLayout();
            this.groupChangement.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDisplay
            // 
            this.groupDisplay.Controls.Add(this.btnChangerpwd);
            this.groupDisplay.Controls.Add(this.btnSupprimer);
            this.groupDisplay.Controls.Add(this.btnModifier);
            this.groupDisplay.Controls.Add(this.dataDevs);
            this.groupDisplay.Location = new System.Drawing.Point(13, 13);
            this.groupDisplay.Name = "groupDisplay";
            this.groupDisplay.Size = new System.Drawing.Size(664, 258);
            this.groupDisplay.TabIndex = 2;
            this.groupDisplay.TabStop = false;
            this.groupDisplay.Text = "Les développeurs";
            // 
            // btnChangerpwd
            // 
            this.btnChangerpwd.Location = new System.Drawing.Point(199, 221);
            this.btnChangerpwd.Name = "btnChangerpwd";
            this.btnChangerpwd.Size = new System.Drawing.Size(90, 30);
            this.btnChangerpwd.TabIndex = 3;
            this.btnChangerpwd.Text = "Changer pwd";
            this.btnChangerpwd.UseVisualStyleBackColor = true;
            this.btnChangerpwd.Click += new System.EventHandler(this.btnChangerpwd_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(103, 221);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(90, 30);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(7, 221);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(90, 30);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dataDevs
            // 
            this.dataDevs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataDevs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDevs.Location = new System.Drawing.Point(6, 19);
            this.dataDevs.MultiSelect = false;
            this.dataDevs.Name = "dataDevs";
            this.dataDevs.ReadOnly = true;
            this.dataDevs.RowHeadersVisible = false;
            this.dataDevs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDevs.Size = new System.Drawing.Size(652, 196);
            this.dataDevs.TabIndex = 0;
            // 
            // groupAjout
            // 
            this.groupAjout.Controls.Add(this.btnAnnulerDev);
            this.groupAjout.Controls.Add(this.btnEnregistrerDev);
            this.groupAjout.Controls.Add(this.cmbProfil);
            this.groupAjout.Controls.Add(this.label5);
            this.groupAjout.Controls.Add(this.txtTel);
            this.groupAjout.Controls.Add(this.label4);
            this.groupAjout.Controls.Add(this.txtMail);
            this.groupAjout.Controls.Add(this.label3);
            this.groupAjout.Controls.Add(this.txtPrenom);
            this.groupAjout.Controls.Add(this.label2);
            this.groupAjout.Controls.Add(this.txtNom);
            this.groupAjout.Controls.Add(this.label1);
            this.groupAjout.Location = new System.Drawing.Point(13, 278);
            this.groupAjout.Name = "groupAjout";
            this.groupAjout.Size = new System.Drawing.Size(664, 111);
            this.groupAjout.TabIndex = 3;
            this.groupAjout.TabStop = false;
            this.groupAjout.Text = "Ajouter un développeur";
            // 
            // btnAnnulerDev
            // 
            this.btnAnnulerDev.Location = new System.Drawing.Point(106, 71);
            this.btnAnnulerDev.Name = "btnAnnulerDev";
            this.btnAnnulerDev.Size = new System.Drawing.Size(90, 30);
            this.btnAnnulerDev.TabIndex = 4;
            this.btnAnnulerDev.Text = "Annuler";
            this.btnAnnulerDev.UseVisualStyleBackColor = true;
            this.btnAnnulerDev.Click += new System.EventHandler(this.btnAnnulerDev_Click);
            // 
            // btnEnregistrerDev
            // 
            this.btnEnregistrerDev.Location = new System.Drawing.Point(10, 72);
            this.btnEnregistrerDev.Name = "btnEnregistrerDev";
            this.btnEnregistrerDev.Size = new System.Drawing.Size(90, 30);
            this.btnEnregistrerDev.TabIndex = 4;
            this.btnEnregistrerDev.Text = "Enregistrer";
            this.btnEnregistrerDev.UseVisualStyleBackColor = true;
            this.btnEnregistrerDev.Click += new System.EventHandler(this.btnEnregistrerDev_Click);
            // 
            // cmbProfil
            // 
            this.cmbProfil.FormattingEnabled = true;
            this.cmbProfil.Location = new System.Drawing.Point(348, 72);
            this.cmbProfil.Name = "cmbProfil";
            this.cmbProfil.Size = new System.Drawing.Size(185, 21);
            this.cmbProfil.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Profil";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(347, 45);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(186, 20);
            this.txtTel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tel";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(347, 19);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(311, 20);
            this.txtMail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(54, 45);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(246, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(54, 19);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(246, 20);
            this.txtNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // groupChangement
            // 
            this.groupChangement.Controls.Add(this.btnAnnulerPwd);
            this.groupChangement.Controls.Add(this.txtEncore);
            this.groupChangement.Controls.Add(this.btnEnregistrerPwd);
            this.groupChangement.Controls.Add(this.label7);
            this.groupChangement.Controls.Add(this.txtPwd);
            this.groupChangement.Controls.Add(this.label6);
            this.groupChangement.Enabled = false;
            this.groupChangement.Location = new System.Drawing.Point(13, 396);
            this.groupChangement.Name = "groupChangement";
            this.groupChangement.Size = new System.Drawing.Size(664, 84);
            this.groupChangement.TabIndex = 4;
            this.groupChangement.TabStop = false;
            this.groupChangement.Text = "Changer le mot de passe";
            // 
            // btnAnnulerPwd
            // 
            this.btnAnnulerPwd.Location = new System.Drawing.Point(106, 44);
            this.btnAnnulerPwd.Name = "btnAnnulerPwd";
            this.btnAnnulerPwd.Size = new System.Drawing.Size(90, 30);
            this.btnAnnulerPwd.TabIndex = 10;
            this.btnAnnulerPwd.Text = "Annuler";
            this.btnAnnulerPwd.UseVisualStyleBackColor = true;
            this.btnAnnulerPwd.Click += new System.EventHandler(this.btnAnnulerPwd_Click);
            // 
            // txtEncore
            // 
            this.txtEncore.Location = new System.Drawing.Point(379, 19);
            this.txtEncore.Name = "txtEncore";
            this.txtEncore.PasswordChar = '*';
            this.txtEncore.Size = new System.Drawing.Size(246, 20);
            this.txtEncore.TabIndex = 13;
            // 
            // btnEnregistrerPwd
            // 
            this.btnEnregistrerPwd.Location = new System.Drawing.Point(10, 45);
            this.btnEnregistrerPwd.Name = "btnEnregistrerPwd";
            this.btnEnregistrerPwd.Size = new System.Drawing.Size(90, 30);
            this.btnEnregistrerPwd.TabIndex = 11;
            this.btnEnregistrerPwd.Text = "Enregistrer";
            this.btnEnregistrerPwd.UseVisualStyleBackColor = true;
            this.btnEnregistrerPwd.Click += new System.EventHandler(this.btnEnregistrerPwd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Encore";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(54, 19);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(246, 20);
            this.txtPwd.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pwd";
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 597);
            this.Controls.Add(this.groupChangement);
            this.Controls.Add(this.groupAjout);
            this.Controls.Add(this.groupDisplay);
            this.Name = "FrmHabilitations";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHabilitations_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDevs)).EndInit();
            this.groupAjout.ResumeLayout(false);
            this.groupAjout.PerformLayout();
            this.groupChangement.ResumeLayout(false);
            this.groupChangement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupDisplay;
        private System.Windows.Forms.DataGridView dataDevs;
        private System.Windows.Forms.Button btnChangerpwd;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.GroupBox groupAjout;
        private System.Windows.Forms.Button btnAnnulerDev;
        private System.Windows.Forms.Button btnEnregistrerDev;
        private System.Windows.Forms.ComboBox cmbProfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupChangement;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEncore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAnnulerPwd;
        private System.Windows.Forms.Button btnEnregistrerPwd;
    }
}

