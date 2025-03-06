using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Habilitations2024;

namespace habilitations2024.dal
{
    public class Access
    {
        // chaine de connexion à la bdd
        private static readonly string connectionString = "server=localhost; port=3306; user id=habilitations; password='motdepasseuser'; database=habilitations; SslMode=none";
        // instance unique de la classe
        private static Access instance = null;
        // objet d'accès aux données
        public BddManager Manager { get; }

        private Access()
        {
            try
            {
                this.Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        public static Access GetInstance()
        {
            if (Access.instance == null)
            {
                Access.instance = new Access();
            }
            return Access.instance;
        }
    }
}