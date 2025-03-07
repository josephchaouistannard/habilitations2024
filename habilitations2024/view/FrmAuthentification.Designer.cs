namespace habilitations2024.view
{
    partial class FrmAuthentification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(12, 25);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(186, 20);
            this.txtNom.TabIndex = 0;
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(59, 140);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(83, 33);
            this.btnConnecter.TabIndex = 2;
            this.btnConnecter.Text = "Se Connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saisir votre nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saisir votre prenom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(11, 68);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(186, 20);
            this.txtPrenom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Saisir votre mot de passe";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(11, 112);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(186, 20);
            this.txtPwd.TabIndex = 6;
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 183);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.txtNom);
            this.Name = "FrmAuthentification";
            this.Text = "FrmAuthentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPwd;
    }
}