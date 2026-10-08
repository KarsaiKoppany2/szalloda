using System;
using System.Collections.Generic;
using System.Text;

namespace szalloda
{
    public class Szoba
    {
        private int ejszakaiAr;
        private int ferohely;
        private static int osszesRegisztraltSzoba = 0;
        public string Szobaszam { get; set; }
        public int Emelet { get; set; }
        public int EjszakaiAr {
            get 
            {
                return ejszakaiAr;
            }
            set 
            {
                if (value < 0) ejszakaiAr = 0;
                else ejszakaiAr = value;
            }
        }
        public int Ferohely
        {
            get
            {
                return ferohely;
            }
            set
            {
                if (value < 1) ferohely = 1;
                else ferohely = value;
            }
        }
        public static int OsszesRegisztraltSzoba 
        { 
            get
            {
                return osszesRegisztraltSzoba;
            }
        }
        public Szoba (string szobaszam, int emelet, int ejszakaiAr) : this(szobaszam, emelet, ejszakaiAr, 2)
        {

        }
        public Szoba (string szobaszam, int emelet, int ejszakaiAr, int ferohely)
        {
            Szobaszam = szobaszam;
            Emelet = emelet;
            EjszakaiAr = ejszakaiAr;
            Ferohely = ferohely;
            osszesRegisztraltSzoba++;
        }
        public override string ToString()
        {
            return $"{Szobaszam} Emelet: {Emelet}. | Férőhely {Ferohely} fő | Ár: {EjszakaiAr} Ft/éj";
        }
        public int FoglalasErtek(int ejszakakSzama)
        {
            return ejszakakSzama * EjszakaiAr;
        }
    }
}
