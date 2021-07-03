using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenForm
{
    public class Prenda
    {
        public enum QA { Standard, Premium };
        protected QA calidadPrenda;
        protected int precioPrenda;
        protected int stockActual;

        public QA CalidadPrenda
        {
            set { calidadPrenda = value; }
            get { return calidadPrenda; }
        }
        public int PrecioPrenda
        {
            set { precioPrenda = value; }
            get { return precioPrenda; }
        }
        public int Stock
        {
            set { stockActual = value; }
            get { return stockActual; }
        }
    }
}
