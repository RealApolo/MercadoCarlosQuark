using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenForm
{
    public class Tienda
    {
        protected string nombreTienda = "NAIK";
        protected string direccionTienda = "Siempreviva 742";
        public List<Camisa> camisasAvender = new List<Camisa>();
        public List<Pantalon> pantalonesAVender = new List<Pantalon>();

        public void AñadirCamisas()
        {
            camisasAvender.Add(new Camisa(Camisa.Manga.Corta, true, 200));
            camisasAvender.Add(new Camisa(Camisa.Manga.Corta, false, 300));
            camisasAvender.Add(new Camisa(Camisa.Manga.Larga, true, 150));
            camisasAvender.Add(new Camisa(Camisa.Manga.Larga, false, 350));

        }

        public void AñadirPantalones()
        {
            pantalonesAVender.Add(new Pantalon(true, 1500));
            pantalonesAVender.Add(new Pantalon(false, 500));
        }
        public string NombreTienda
        {
            set { nombreTienda = value; }
            get { return nombreTienda; }
        }
        public string DireccionTienda
        {
            set { direccionTienda = value; }
            get { return direccionTienda; }
        }
    }
}
