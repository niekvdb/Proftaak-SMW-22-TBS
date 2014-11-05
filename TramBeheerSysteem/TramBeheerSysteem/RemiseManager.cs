using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    public static class RemiseManager
    {
        public static List<Remise> Remises;
        public static List<Sector> Sectors; 
        public static List<Spoor> Sporen;

        public static List<Medewerker> Medewerkers; 

        static RemiseManager()
        {
        }

        public static void LaadRemises()
        {
            Remises = new List<Remise>();
            Medewerkers = new List<Medewerker>();

            Remises = DatabaseManager.LaadRemises();
            Medewerkers = DatabaseManager.LaadMedewerkers();
        }

        public static void LaadSporen()
        {
            Sectors = new List<Sector>();
            Sporen = new List<Spoor>();

            Sectors = DatabaseManager.LaadSectoren();
            Sporen = DatabaseManager.LaadSporen();
        }

        public static Remise remiseViaId(int id)
        {
            foreach (Remise remise in Remises)
            {
                if (remise.Id == id) return remise;
            }
            return null;
        }

        public static Spoor spoorViaId(int id)
        {
            foreach (Spoor spoor in Sporen)
            {
                if (spoor.Id == id) return spoor;
            }
            return null;
        }

        public static Sector sectorViaId(int id)
        {
            foreach (Sector sector in Sectors)
            {
                if (sector.Id == id) return sector;
            }
            return null;
        }

        public static Medewerker medewerkerViaId(int id)
        {
            foreach (Medewerker medewerker in Medewerkers)
            {
                if (medewerker.Id == id)return medewerker;
            }
            return null;
        }

        public static Medewerker medewerkerViaNaam(string naam)
        {
            foreach (Medewerker medewerker in Medewerkers)
            {
                if (medewerker.Naam == naam) return medewerker;
            }
            return null;
        }

        public static List<Sector> sectorenVanSpoor(int id)
        {
            List<Sector> sectorenVanSpoor = new List<Sector>();

            foreach (Sector sector in Sectors)
            {
                if(sector.SpoorNummer == id) sectorenVanSpoor.Add(sector);
            }

            return sectorenVanSpoor;
        }
    }
}
