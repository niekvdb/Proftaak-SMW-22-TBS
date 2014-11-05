﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramBeheerSysteem
{
    public class Tramonderhoud
    {
        public int Id { get; private set; }
        public Medewerker Medewerker { get; private set; }
        public Tram Tram { get; private set; }
        public DateTime DatumTijdstip { get; private set; }
        public TypeOnderhoud TypeOnderhoud { get; private set; }
        public string Opmerking { get; private set; }


        public Tramonderhoud(int id, Medewerker medewerker, Tram tram, DateTime beschikbaarDatum, TypeOnderhoud typeOnderhoud, string opmerking)
        {
            Id = id;
            Medewerker = medewerker;
            Tram = tram;
            DatumTijdstip = beschikbaarDatum;
            TypeOnderhoud = typeOnderhoud;
            Opmerking = opmerking;
        }

        public Tramonderhoud(Medewerker medewerker, Tram tram, DateTime beschikbaarDatum, TypeOnderhoud typeOnderhoud, string opmerking)
        {
            Medewerker = medewerker;
            Tram = tram;
            DatumTijdstip = beschikbaarDatum;
            TypeOnderhoud = typeOnderhoud;
            Opmerking = opmerking;
        }

        public void OnderhoudKlaar()
        {
            //ToDo
        }
    }
}
