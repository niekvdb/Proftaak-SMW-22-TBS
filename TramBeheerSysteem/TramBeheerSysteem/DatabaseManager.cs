﻿using Oracle.DataAccess.Client;
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
            List<Remise> remises = null;
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
                    remises = new List<Remise>();
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
                OracleCommand command = new OracleCommand("SELECT * FROM SPOOR");
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

        public static List<Tramonderhoud> laadTramonderhoud()
        {
            return null;
        }

        public static void registreerOnderhoud(Tramonderhoud onderhoud)
        {
            //ToDo
        }
    }
}
