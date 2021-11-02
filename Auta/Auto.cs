using System;
using System.Collections.Generic;
using System.Text;

namespace Auta
{
    public class Auto
    {
        private int naklad;

        public int Naklad { get => naklad; }
        public string Znacka { get; }
        public int Nosnost { get;}


        public Auto(string znacka, int nosnost)
        {
            Znacka = znacka;
            Nosnost = nosnost;
        }

        public int Nalozit(int naklad)
        { //↓↓↓ zjistí se, kolik je tam místa, když by hrozilo přeložení, tak se naloží do plna. S tím, že zbytek se nenaloží ↓↓↓ 
            var misto = Nosnost - Naklad;
             
            if (misto < naklad)
            {
                this.naklad += misto;
                return misto;
            }
            else
            {
                this.naklad += naklad;     
                return naklad;
            }
            
        }

        public int Vylozit(int naklad)
        {

        }
    }
}
