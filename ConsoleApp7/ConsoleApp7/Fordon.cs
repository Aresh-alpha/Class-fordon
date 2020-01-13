using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Fordon
    {
        private string tillverkare;
        private string modell;
        private int årsmodell;
        private int vikt;


        public Fordon(string n, string m, int å, int v)
            {
            tillverkare = n;
            modell = m;
            årsmodell = å;
            vikt = v;
            }
        public string Tillverkare
        {
            get { return tillverkare; }
            set { tillverkare = value; }
        }
        public string Modell
        {
            get { return modell; }
            set { modell = value; }
        }
        public int Årsmodell
        {
            get { return årsmodell; }
            set { årsmodell = value; }
        }
        public int Vikt
        {
            get { return vikt; }
            set { vikt = value; }
        }
    }
}
