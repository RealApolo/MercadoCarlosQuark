using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenForm
{
    public class Cotizacion
    {
        
        public List<COTIZAR> cotHistorial = new List<COTIZAR>();
        
        public Cotizacion()
        {
            
        }
        
        public void AddDatos(string prenda, string idvendedor, string tienda, string cantidad, string preciofinal)
        {
            cotHistorial.Add(new COTIZAR(prenda, idvendedor, tienda, cantidad, preciofinal));

        }

        public class COTIZAR {

            string idvendedor;
            string tienda;
            string prenda;
            string cantidad;
            string preciofinal;

            public string ID
            {
                set { idvendedor = value; }
                get { return idvendedor; }
            }
            public string TIENDA
            {
                set { tienda = value; }
                get { return tienda; }
            }
            public string PRENDA
            {
                set { prenda = value; }
                get { return prenda; }
            }
            public string CANTIDAD
            {
                set { cantidad = value; }
                get { return cantidad; }
            }
            public string PRECIO
            {
                set { preciofinal = value; }
                get { return preciofinal; }
            }
            public COTIZAR(string ven, string ti, string pre, string cant, string precio)
            {
                idvendedor = ven;
                tienda = ti;
                prenda = pre;
                cantidad = cant;
                preciofinal = precio;

            }
        }
    
    }
}
