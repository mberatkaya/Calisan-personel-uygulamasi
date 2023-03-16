﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance_uygulama_1
{
    public class Yazilimci : Calisan
    {
        private string diller;

        public Yazilimci(int id, string isim, string soyisim, string diller) : base(id, isim, soyisim)
        {
            this.diller = diller;

        }

        public void formatAt(string isletim_sistemi)
        {
            Console.WriteLine(getIsim() + "şuanda " + " " + isletim_sistemi + "işletim sistemine format atıyor...");
        }
    }
}
