using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    public static class DatabaseManager
    {
        private static OracleConnection connection;

        static DatabaseManager()
        {
            connection = new OracleConnection();
            #region Secret

            #region No really!
            connection.ConnectionString = "User Id=dbi297953;Password=hN0VRtdlS0;Data Source=" + " //192.168.15.50:1521/fhictora" + ";";
            #endregion

            #endregion
        }



        static Tram TramInformatie(int tramnummer)
        {
            Tram tram = null;
            try
            {
                connection.Open();
                OracleCommand command = new OracleCommand("SELECT * FROM TRAM WHERE Tram_ID = " + tramnummer);
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                OracleDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return null;
                else
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Tram_ID"]);
                        Remise remise = null;
                        Tramtype tramtype = (Tramtype) Convert.ToInt32(reader["Tramtype_ID"]);
                        int lengte = Convert.ToInt32(reader["Lengte"]);
                        string status = Convert.ToString(reader["Status"]);
                        bool vervuild = Convert.ToBoolean(reader["Vervuild"]);
                        bool defect = Convert.ToBoolean(reader["Defect"]);
                        bool conducteurGeschikt = Convert.ToBoolean(reader["ConducteurGeschikt"]);
                        bool beschikbaar = Convert.ToBoolean(reader["Beschikbaar"]);
                        Sector sector = null;

                        tram = new Tram(id, remise, tramtype, lengte, status, vervuild, defect, conducteurGeschikt,
                            beschikbaar, sector);

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return tram;
        }
    }
}
