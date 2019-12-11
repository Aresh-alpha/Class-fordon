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


        public void SetTillverkare(string namn)
        {
            tillverkare = namn;
        }
        public string GetTillverkare()
        {
            return tillverkare;
        }
        public void SetModell(string m)
        {
            modell = m;
        }
        public string GetModell()
        {
            return modell;
        }
        public void SetÅrsmodell(int å)
        {
            årsmodell = å;
        }
        public int GetÅrsmodell()
        {
            return årsmodell;
        }
        public void SetVikt(int v)
        {
            vikt = v;
        }
        public int GetVikt()
        {
            return vikt;
        }
    }
}
