using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenForm
{
    public class Vendedor
    {
        protected string nombreVendedor = "Carlos";
        protected string apellidoVendedor = "Mercado";
        protected int codigoVendedor = 00013049;

        public string NombreVen
        {
            set { nombreVendedor = value; }
            get { return nombreVendedor; }
        }
        public string ApellidoVen
        {
            set { apellidoVendedor = value; }
            get { return apellidoVendedor; }
        }
        public int IDVen
        {
            set { codigoVendedor = value; }
            get { return codigoVendedor; }
        }


    }
}
