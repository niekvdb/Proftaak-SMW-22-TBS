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

        public static List<Remise> LaadRemises()
        {
            List<Remise> remises = new List<Remise>();
            try
            {
                connection.Open();
                OracleCommand command = new OracleCommand("SELECT * FROM REMISE");
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                OracleDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return null;
                else
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        string naam = Convert.ToString(reader["Naam"]);
                        int groteServiceBeurtenPerDag = Convert.ToInt32(reader["GroteServiceBeurtenPerDag"]);
                        int kleineServiceBeurtenPerDag = Convert.ToInt32(reader["KleineServiceBeurtenPerDag"]);
                        int groteSchoonmaakBeurtenPerDag = Convert.ToInt32(reader["GroteSchoonmaakBeurtenPerDag"]);
                        int kleineSchoonmaakBeurtenPerDag = Convert.ToInt32(reader["KleineSchoonmaakBeurtenPerDag"]);

                        remises.Add(new Remise(id,naam,groteServiceBeurtenPerDag,kleineServiceBeurtenPerDag,groteSchoonmaakBeurtenPerDag,kleineSchoonmaakBeurtenPerDag));
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
            return remises;
        }

        public static List<Sector> LaadSectoren()
        {
            List<Sector> sectoren = null;
            try
            {
                connection.Open();
                OracleCommand command = new OracleCommand("SELECT * FROM SECTOR");
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                OracleDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return null;
                else
                {
                    sectoren = new List<Sector>();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        int spoorNummer = Convert.ToInt32(reader["Spoor_ID"]);
                        Tram tram = TramManager.tramViaId(Convert.ToInt32(reader["Tram_ID"]));
                        int nummer = Convert.ToInt32(reader["Nummer"]);
                        bool beschikbaar = Convert.ToBoolean(reader["Beschikbaar"]);
                        bool blokkade = Convert.ToBoolean(reader["Blokkade"]);

                        sectoren.Add(new Sector(id, spoorNummer, tram, nummer, beschikbaar, blokkade));
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
            return sectoren;
        }

        public static List<Spoor> LaadSporen()
        {
            List<Spoor> sporen = null;
            try
            {
                connection.Open();
                OracleCommand command = new OracleCommand("SELECT * FROM SPOOR");
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                OracleDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return null;
                else
                {
                    sporen = new List<Spoor>();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        Remise remise = RemiseManager.remiseViaId(Convert.ToInt32(reader["Remise_ID"]));
                        int nummer = Convert.ToInt32(reader["Nummer"]);
                        int lengte = Convert.ToInt32(reader["Lengte"]);
                        bool beschikbaar = Convert.ToBoolean(reader["Beschikbaar"]);
                        bool inUitrijSpoor = Convert.ToBoolean(reader["InUitRijspoor"]);

                        sporen.Add(new Spoor(id, remise, nummer, lengte, beschikbaar, inUitrijSpoor, RemiseManager.sectorenVanSpoor(id)));
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
            return sporen;
        }

        public static List<Tram> LaadTrams()
        {
            List<Tram> trams = null;
            try
            {
                connection.Open();
                OracleCommand command = new OracleCommand("SELECT * FROM TRAM");
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                OracleDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return null;
                else
                {
                    trams = new List<Tram>();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        Tramtype tramtype = (Tramtype) Convert.ToInt32(reader["Tramtype_ID"]);
                        int lengte = Convert.ToInt32(reader["Lengte"]);
                        string status = Convert.ToString(reader["Status"]);
                        Remise remise = RemiseManager.remiseViaId(Convert.ToInt32(reader["Remise_ID"]));
                        bool vervuild = Convert.ToBoolean(reader["Vervuild"]);
                        bool defect = Convert.ToBoolean(reader["Defect"]);
                        bool conducteurGeschikt = Convert.ToBoolean(reader["ConducteurGeschikt"]);
                        bool beschikbaar = Convert.ToBoolean(reader["Beschikbaar"]);

                        trams.Add(new Tram(id, tramtype, lengte, status, remise, vervuild, defect, conducteurGeschikt, beschikbaar));
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
            return trams;
        }

        public static List<Tramonderhoud> LaadTramonderhoud()
        {
            List<Tramonderhoud> onderhoudsBeurten = null;
            try
            {
                connection.Open();
                OracleCommand command = new OracleCommand("SELECT * FROM TRAM_ONDERHOUD");
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                OracleDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return null;
                else
                {
                    onderhoudsBeurten = new List<Tramonderhoud>();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        Medewerker medewerker = RemiseManager.medewerkerViaId(Convert.ToInt32(reader["Medewerker_ID"]));
                        Tram tram = TramManager.tramViaId(Convert.ToInt32(reader["Tram_ID"]));
                        DateTime beschikbaarDatum = Convert.ToDateTime(reader["DatumBeschikbaar"]);
                        DateTime datumTijd = Convert.ToDateTime(reader["DatumTijdStip"]);
                        TypeOnderhoud typeOnderhoud = (TypeOnderhoud) Convert.ToInt32(reader["TypeOnderhoud"]);
                        string opmerking = Convert.ToString(reader["Notitie"]);

                        onderhoudsBeurten.Add(new Tramonderhoud(id, medewerker, tram, beschikbaarDatum, datumTijd, typeOnderhoud, opmerking));
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
            return onderhoudsBeurten;
        }

        public static List<Medewerker> LaadMedewerkers()
        {
            List<Medewerker> medewerkers = null;
            try
            {
                connection.Open();
                OracleCommand command = new OracleCommand("SELECT * FROM MEDEWERKER");
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                OracleDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return null;
                else
                {
                    medewerkers = new List<Medewerker>();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        Functie functie = (Functie) Convert.ToInt32(reader["Functie_ID"]);
                        string naam = Convert.ToString(reader["Naam"]);

                        medewerkers.Add(new Medewerker(id, functie, naam));
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
            return medewerkers;
        }

        public static void registreerOnderhoud(Tramonderhoud onderhoud)
        {
            try
            {
                connection.Open();

                OracleCommand command = new OracleCommand("INSERT INTO TRAM_ONDERHOUD(Medewerker_ID, Tram_ID, DatumTijdStip, DatumBeschikbaar, TypeOnderhoud, Notitie)" +
                                                            "VALUES (:medewerker_ID, :tram_ID, :datumTijdstip, :datumBeschikbaar, :typeOnderhoud, :notitie)");
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                command.Parameters.Add(":medewerker_ID", onderhoud.Medewerker.Id);
                command.Parameters.Add(":tram_ID", onderhoud.Tram.Id);
                command.Parameters.Add(":datumTijdstip", onderhoud.DatumTijdstip);
                command.Parameters.Add(":datumBeschikbaar", onderhoud.BeschikbaarDatum);
                command.Parameters.Add(":typeOnderhoud", onderhoud.TypeOnderhoud);
                command.Parameters.Add(":notitie", onderhoud.Opmerking);

                command.ExecuteNonQuery();
            }
            catch (OracleException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
