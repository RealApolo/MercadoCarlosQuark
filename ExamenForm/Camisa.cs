using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenForm
{
    public class Camisa : Prenda
    {
        public enum Manga { Larga , Corta};
        protected Manga largoManga = Manga.Larga;
        protected bool cuelloMao = false;

        public Camisa() { }
        public Camisa(Manga man, bool mao, int cant)
        {
            largoManga = man;
            cuelloMao = mao;
            stockActual = cant;
        }
        public Manga TipoManga
        {
            set { largoManga = value; }
            get { return largoManga; }
        }

        public bool CuelloMao
        {
            set { cuelloMao = value; }
            get { return cuelloMao; }
        }
    }
}
