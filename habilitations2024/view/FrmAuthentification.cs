using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using habilitations2024.controller;
using habilitations2024.model;
using Habilitations2024;

namespace habilitations2024.view
{
    public partial class FrmAuthentification: Form
    {
        FrmAuthentificationController control;
        public FrmAuthentification()
        {
            InitializeComponent();
            control = new FrmAuthentificationController();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNom.Text) &&
                !String.IsNullOrWhiteSpace(txtPrenom.Text) &&
                !String.IsNullOrWhiteSpace(txtPwd.Text))
            {
                Admin admin = new Admin(txtNom.Text, txtPrenom.Text, txtPwd.Text);
                if (control.ControleAuthenitifcation(admin))
                {
                    Form main = new FrmHabilitations();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Vous n'êtes pas authorisé");
                }
            }
            else
            {
                MessageBox.Show("Il faut remplir tous les champs");
            }
        }
    }
}
