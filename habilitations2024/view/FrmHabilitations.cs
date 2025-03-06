using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using habilitations2024.dal;
using habilitations2024.model;
using habilitations2024;
using habilitations2024.controller;
using MySql.Data.MySqlClient;

namespace Habilitations2024
{
    public partial class FrmHabilitations : Form
    {
        private FrmHabilitationsController control;
        private List<Profil> lesProfils;
        private List<Developpeur> lesDevs;
        private BindingSource devBindingSource;
        private BindingSource profilBindingSource;
        private bool modification;

        public FrmHabilitations()
        {
            InitializeComponent();            
        }

        public void RefreshData()
        {
            lesDevs = control.GetLesDeveloppeurs(lesProfils);
            lesProfils = control.GetLesProfils();
            devBindingSource.DataSource = lesDevs;
            profilBindingSource.DataSource = lesProfils;
            devBindingSource.ResetBindings(false);
            profilBindingSource.ResetBindings(false);
        }

        public void ResetDisplay()
        {
            groupAjout.Enabled = true;
            groupAjout.Text = "Ajouter un développeur";
            groupChangement.Enabled = false;
            groupDisplay.Enabled = true;
            ClearFields();
            RefreshData();
        }

        public void ClearFields()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtMail.Text = "";
            txtTel.Text = "";
            txtPwd.Text = "";
            txtEncore.Text = "";
        }

        public void StartModification()
        {
            modification = true;
            groupAjout.Text = "Modifier un développeur";
            groupDisplay.Enabled = false;
            Developpeur devAModifier = lesDevs[dataDevs.CurrentRow.Index];
            txtNom.Text = devAModifier.Nom;
            txtPrenom.Text = devAModifier.Prenom;
            txtMail.Text = devAModifier.Mail;
            txtTel.Text = devAModifier.Tel;
            cmbProfil.SelectedItem = devAModifier.Profil;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            control = new FrmHabilitationsController();
            devBindingSource = new BindingSource();
            profilBindingSource = new BindingSource();
            modification = false;

            lesProfils = control.GetLesProfils();
            lesDevs = control.GetLesDeveloppeurs(lesProfils);
            devBindingSource.DataSource = lesDevs;
            dataDevs.DataSource = devBindingSource;
            dataDevs.Columns["iddeveloppeur"].Visible = false;
            dataDevs.Columns["pwd"].Visible = false;
            profilBindingSource.DataSource = lesProfils;
            cmbProfil.DataSource = profilBindingSource;
        }

        private void btnEnregistrerDev_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNom.Text) &&
                !String.IsNullOrWhiteSpace(txtPrenom.Text) &&
                !String.IsNullOrWhiteSpace(txtMail.Text) &&
                !String.IsNullOrWhiteSpace(txtTel.Text) &&
                cmbProfil.SelectedIndex != -1)
            {
                if (modification)
                {
                    Developpeur devAModifier = lesDevs[dataDevs.CurrentRow.Index];
                    devAModifier.Nom = txtNom.Text;
                    devAModifier.Prenom = txtPrenom.Text;
                    devAModifier.Mail = txtMail.Text;
                    devAModifier.Tel = txtTel.Text;
                    devAModifier.Profil = (Profil)cmbProfil.SelectedItem;
                    control.UpdateDeveloppeur(devAModifier);
                    modification = false;
                }
                else
                {
                    Developpeur devAAjouter = new Developpeur(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, "motdepasse", (Profil)cmbProfil.SelectedItem);
                    control.AddDeveloppeur(devAAjouter);
                }
                ResetDisplay();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (!(dataDevs.SelectedRows is null))
            {
                Developpeur devASupprimer = lesDevs[dataDevs.CurrentRow.Index];
                DialogResult result = MessageBox.Show(
                    "Confirmer la suppression ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    control.DelDeveloppeur(devASupprimer);
                    ResetDisplay();
                }
                
            }
            else
            {
                MessageBox.Show("Selectionner une ligne avant");
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (!(dataDevs.SelectedRows is null))
            {
                StartModification();
            }
            else
            {
                MessageBox.Show("Selectionner une ligne avant");
            }
        }

        private void btnChangerpwd_Click(object sender, EventArgs e)
        {
            if (!(dataDevs.SelectedRows is null))
            {
                groupAjout.Enabled = false;
                groupDisplay.Enabled = false;
                groupChangement.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selectionner une ligne avant");
            }
        }

        private void btnAnnulerDev_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Vous voulez annulez ?",
            "Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ResetDisplay();
            }
        }

        private void btnEnregistrerPwd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtPwd.Text) && txtPwd.Text.Equals(txtEncore.Text))
            {
                Developpeur devAModifier = lesDevs[dataDevs.CurrentRow.Index];
                devAModifier.Pwd = txtPwd.Text;
                control.UpdatePwd(devAModifier);
                ResetDisplay();
            }
            else
            {
                MessageBox.Show("Il faut saisir deux mots de passe identiques");
            }
        }

        private void btnAnnulerPwd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Vous voulez annulez ?",
            "Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ResetDisplay();
            }
        }
    }
}
