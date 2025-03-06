using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using habilitations2024.model;

namespace habilitations2024.dal
{
    public class ProfilAccess
    {
        // Instance unique de l'accès aux données
        private readonly Access access = null;

        // Constructeur pour créer l'accès aux données
        public ProfilAccess()
        {
            this.access = Access.GetInstance();
        }

        // Récupère et retourne les profils
        public List<Profil> GetLesProfils()
        {
            List<Profil> lesProfils = new List<Profil>();
            List<Object[]> result = new List<Object[]>();

            try
            {
                result = this.access.Manager.ReqSelect("select * from profil");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return lesProfils;
            }

            if (!(result is null))
            {
                foreach (Object[] obj in result)
                {
                    lesProfils.Add(new Profil( (int)obj[0], (string)obj[1] ));
                }
            }

            return lesProfils;
        }
    }
}
