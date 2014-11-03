using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace TramBeheerSysteem
{
    class DatabaseManager
    {
        private OracleConnection connection = new OracleConnection();
        public string Pcn { get; private set; }
        public string Password { get; private set; } //hmm, get set?
        /// <summary>
        /// Database verbinding werkt. Denk aan VPN (handleiding op portal).
        /// In het SELECT-statement moeten er quotes ("") om de kolomnaam. Bij het uitlezen van de kolommen moeten er geen quotes om de naam van de kolom.
        /// </summary>
        public DatabaseManager()
        {
            Pcn = "dbi297953";
            Password = "hN0VRtdlS0";
            connection.ConnectionString = "User Id=" + Pcn + ";Password=" + Password + ";Data Source=" + " //192.168.15.50:1521/fhictora" + ";";
        }

        public string KrijgFunctie(string naam)
        {

            connection.Open();

            string functie = string.Empty;

            string query = @"SELECT ""Naam"" FROM FUNCTIE WHERE ID =  (SELECT ID FROM MEDEWERKER WHERE ""Naam""='" + naam + "')";

            OracleCommand command = new OracleCommand(query, connection);
            command.CommandType = CommandType.Text;
            OracleDataReader dataReader;

            try
            {
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    functie = Convert.ToString(dataReader["Naam"]);
                }

                dataReader.Close();
            }
            catch(Exception ex)
            {
                functie = ex.ToString();
            }

            connection.Close();
                return functie;

            }
    }
}
