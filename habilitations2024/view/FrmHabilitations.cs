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
using MySql.Data.MySqlClient;

namespace Habilitations2024
{
    public partial class FrmHabilitations: Form
    {
        public FrmHabilitations()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; user id=root; database=chocolatein; SslMode=none";
            BddManager connexion = BddManager.getInstance(connectionString);
            string req = "insert into gamme (id, libelle, picto) values (@id, @libelle, @picto)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", "test1");
            parameters.Add("@libelle", "test1");
            parameters.Add("@picto", "test1");
            connexion.reqUpdate(req, parameters);
        }
    }
}
