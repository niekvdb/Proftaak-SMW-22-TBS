using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    public static class RemiseManager
    {
        public static List<Remise> Remises = new List<Remise>();
        public static List<Sector> Sectors = new List<Sector>(); 

        static RemiseManager()
        {
            Remises = DatabaseManager.LaadRemises();
        }

        public static Remise remiseViaId(int id)
        {
            foreach (Remise remise in Remises)
            {
                if (remise.Id == id)
                {
                    return remise;
                }
            }
        }
    }
}
