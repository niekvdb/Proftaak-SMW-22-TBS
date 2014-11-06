using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    public static class TramManager
    {
        public static List<Tram> Trams;
        public static List<Tramonderhoud> onderhoudsBeurten; 

        static TramManager()
        {
            Trams = new List<Tram>();
            onderhoudsBeurten = new List<Tramonderhoud>();
        }

        public static void LaadTrams()
        {
            Trams = DatabaseManager.LaadTrams();
            onderhoudsBeurten = DatabaseManager.LaadTramonderhoud();
        }

        public static Tram tramViaId(int id)
        {
            foreach (Tram tram in Trams)
            {
                if (tram.Id == id) return tram;
            }

            return null;
        }

        public static Tram tramViaNummer(int nummer)
        {
            foreach (Tram tram in Trams)
            {
                if (tram.nummer == nummer) return tram;
            }
            return null;
        }
    }
}
