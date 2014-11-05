using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    public static class TramManager
    {
        public static List<Tram> Trams = new List<Tram>();

        static TramManager()
        {

        }

        public static List<Tram> LaadTrams()
        {
            Trams = DatabaseManager.LaadTrams();
            return Trams;
        }

        public static Tram tramViaId(int id)
        {
            foreach (Tram tram in Trams)
            {
                if (tram.Id == id) return tram;
            }

            return null;
        }
    }
}
