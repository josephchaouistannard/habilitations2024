﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Habilitations2024
{
    public sealed class BddManager
    {
        // mise en place de classe singleton
        private static BddManager instance = null;
        private BddManager(string chaineConnection)
        {
            this.connection = new MySqlConnection(chaineConnection);
            this.connection.Open();
        }
        public static BddManager GetInstance(string chaineConnection)
        {
            if (BddManager.instance == null)
            {
                BddManager.instance = new BddManager(chaineConnection);
            }
            return BddManager.instance;
        }

        private readonly MySqlConnection connection;

        public void ReqUpdate(string requete, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(requete, connection);
            if (!(parameters is null))
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            command.Prepare();
            command.ExecuteNonQuery();
        }

        public List<Object[]> ReqSelect(string requete, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(requete, connection);
            if (!(parameters is null))
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            command.Prepare();
            MySqlDataReader curseur = command.ExecuteReader();
            List<Object[]> records = new List<Object[]>();
            int nbCols = curseur.FieldCount;
            bool finCurseur = !curseur.Read();
            while (!finCurseur)
            {
                Object[] attributs = new Object[nbCols];
                curseur.GetValues(attributs);
                records.Add(attributs);
                finCurseur = !curseur.Read();
            }
            
            curseur.Close();
            return records;
        }

    }
}
