using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenForm
{
    public class Pantalon :Prenda
    {
        protected bool chupin;

        public Pantalon() { }
        public Pantalon(bool chup, int cant)
        {
            chupin = chup;
            stockActual = cant;
        }
        public bool Chupin
        {
            set { chupin = value; }
            get { return chupin; }
        }
    }
}
