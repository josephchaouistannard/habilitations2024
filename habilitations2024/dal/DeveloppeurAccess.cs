using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using habilitations2024.model;
using Habilitations2024;
using MySqlX.XDevAPI.Common;
using System.Security.Cryptography;

namespace habilitations2024.dal
{
    public class DeveloppeurAccess
    {
        private readonly Access access = null;

        public DeveloppeurAccess()
        {
            this.access = Access.GetInstance();
        }

        public bool ControleAuthentification(Admin admin)
        {
            List<Object[]> result = new List<Object[]>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", admin.Nom);
            parameters.Add("@prenom", admin.Prenom);
            parameters.Add("@pwd", HashWithSha256(admin.Pwd));
            try
            {
                result = this.access.Manager.ReqSelect("select * from developpeur where nom = @nom and prenom = @prenom and pwd = @pwd and idprofil = 5", parameters);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (result.Count == 0 || result is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Developpeur> GetLesDeveloppeurs(List<Profil> lesProfils)
        {
            List<Developpeur> lesDevs = new List<Developpeur>();
            List<Object[]> result = new List<Object[]>();

            try
            {
                result = this.access.Manager.ReqSelect("select * from developpeur order by nom asc, prenom asc");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return lesDevs;
            }

            if (!(result is null))
            {
                foreach (Object[] obj in result)
                {
                    try
                    {
                        lesDevs.Add(new Developpeur((int)obj[0], (string)obj[1], (string)obj[2], (string)obj[3], (string)obj[4], (string)obj[5], (Profil)lesProfils[ (int)obj[6] - 1]));
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return lesDevs;
        }

        public void DelDeveloppeur(Developpeur dev)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@iddeveloppeur", dev.Iddeveloppeur);
            this.access.Manager.ReqUpdate("delete from developpeur where iddeveloppeur = @iddeveloppeur", parameters);
        }

        public void AddDeveloppeur(Developpeur dev)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", dev.Nom);
            parameters.Add("@prenom", dev.Prenom);
            parameters.Add("@tel", dev.Tel);
            parameters.Add("@mail", dev.Mail);
            parameters.Add("@pwd", HashWithSha256(dev.Pwd));
            parameters.Add("@idprofil", dev.Profil.Idprofil);
            this.access.Manager.ReqUpdate("insert into developpeur (nom, prenom, tel, mail, pwd, idprofil) values (@nom, @prenom, @tel, @mail, @pwd, @idprofil)", parameters);
        }

        public void UpdateDeveloppeur(Developpeur dev)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@iddeveloppeur", dev.Iddeveloppeur);
            parameters.Add("@nom", dev.Nom);
            parameters.Add("@prenom", dev.Prenom);
            parameters.Add("@tel", dev.Tel);
            parameters.Add("@mail", dev.Mail);
            parameters.Add("@pwd", dev.Pwd);
            parameters.Add("@idprofil", dev.Profil.Idprofil);
            this.access.Manager.ReqUpdate("update developpeur set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, pwd = @pwd, idprofil = @idprofil where iddeveloppeur = @iddeveloppeur", parameters);
        }

        public void UpdatePwd(Developpeur dev)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@iddeveloppeur", dev.Iddeveloppeur);
            parameters.Add("@pwd", HashWithSha256(dev.Pwd));
            this.access.Manager.ReqUpdate("update developpeur set pwd = @pwd where iddeveloppeur = @iddeveloppeur", parameters);
        }

        private string HashWithSha256(string pwdPlain)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] pwdBytes = Encoding.UTF8.GetBytes(pwdPlain);
                byte[] hashBytes = sha256Hash.ComputeHash(pwdBytes);

                StringBuilder hashStringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashStringBuilder.Append(b.ToString("x2"));
                }

                return hashStringBuilder.ToString();
            }
        }
    }
}
