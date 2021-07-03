using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenForm
{
    public partial class Form1 : Form
    {

        Tienda _tienda = new Tienda();
        Vendedor vendedor = new Vendedor();
        Cotizacion _cotizaciones = new Cotizacion();
       

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Cotizar_Click(object sender, EventArgs e)
        {
            if (RB_Camisa.Checked)
            {
                Camisa _camisaCotizar = new Camisa();
                CargarDatosCamisa(_camisaCotizar);
                if (ChequearDatos(_camisaCotizar))
                {
                    lbl_Precio.Text ="$" +  Cotizar(_camisaCotizar).ToString();                    
                    _cotizaciones.AddDatos( vendedor.IDVen.ToString(), _tienda.NombreTienda, "Camisa", num_Cantidad.Value.ToString(), lbl_Precio.Text);
                }
                else
                {
                    lbl_Precio.Text = "NO STOCK";
                }
                
                
            }

            if (RB_Pantalon.Checked)
            {
                Pantalon _pantalonACotizar = new Pantalon();
                CargarDatosPantalon(_pantalonACotizar);
                if (ChequearDatos(_pantalonACotizar))
                {
                    lbl_Precio.Text = "$" + Cotizar(_pantalonACotizar).ToString();
                    _cotizaciones.AddDatos( vendedor.IDVen.ToString(), _tienda.NombreTienda, "Pantalon", num_Cantidad.Value.ToString(), lbl_Precio.Text);
                }
                else
                {
                    lbl_Precio.Text = "NO STOCK";
                }
                
            }
            

        }
        bool ChequearDatos(Camisa cam)
        {
                Camisa.Manga MAN = cam.TipoManga;
                bool MAO = cam.CuelloMao;
                int CANT = Convert.ToInt32(num_Cantidad.Value);
                foreach (Camisa c in _tienda.camisasAvender)
                {
                    Camisa.Manga LISTMAN = c.TipoManga;
                    bool LISTMAO = c.CuelloMao;
                    int STCK = c.Stock;
                    if (MAN == LISTMAN 
                        && MAO == LISTMAO)                    
                    {
                        if ( CANT <= STCK)
                        {
                            
                            return true;
                        }
                    
                    }
                }
                return false;
        }
        bool ChequearDatos(Pantalon pant)
        {
           
            bool CHUP = pant.Chupin;
            int CANT = Convert.ToInt32(num_Cantidad.Value);
            foreach (Pantalon c in _tienda.pantalonesAVender)
            {
                
                bool LISTMAO = c.Chupin;
                int STCK = c.Stock;
                if (CHUP == LISTMAO)
                {
                    if (CANT <= STCK)
                    {
                        
                        return true;
                    }

                }
            }
            

            return false;

        }
        void CargarDatosCamisa(Camisa cam)
        {

            if (RB_Premium.Checked)
            {
                cam.CalidadPrenda = Prenda.QA.Premium;
            }
            if (RB_Standard.Checked)
            {
                cam.CalidadPrenda = Prenda.QA.Standard;
            }

            if (CB_MangaCorta.Checked)
            {
                cam.TipoManga = Camisa.Manga.Corta;
            }
            if (CB_Mao.Checked)
            {
                cam.CuelloMao = true;
            }

            cam.PrecioPrenda = Convert.ToInt32( num_Precio.Value);
        }
        void CargarDatosPantalon(Pantalon pant)
        {
            if (RB_Premium.Checked)
            {
                pant.CalidadPrenda = Prenda.QA.Premium;
            }
            if (CB_Chupin.Checked)
            {
                pant.Chupin = true;
            }
            pant.PrecioPrenda = Convert.ToInt32(num_Precio.Value);
        }
        float Cotizar(Camisa cam)
        {
            float precioFinal =  cam.PrecioPrenda;
            float precio = precioFinal;
            int cantidad = Convert.ToInt32( num_Cantidad.Value);
            
            lbl_Precio.Text = cam.PrecioPrenda.ToString();
            if (cam.TipoManga == Camisa.Manga.Corta)
            {
                precioFinal += precio * -0.1f;
                
            }
            if (cam.CuelloMao == true)
            {
                precioFinal += precio * 0.03f;
                
            }
            if (cam.CalidadPrenda == Prenda.QA.Premium)
            {
                precioFinal += precio * 0.3f;                
            }
            precioFinal = precioFinal * cantidad;
            
            return precioFinal;

        }
        float Cotizar(Pantalon pant)
        {
            float precioFinal = pant.PrecioPrenda;
            float precio = precioFinal;
            if (pant.Chupin)
            {
                precioFinal += precio * -0.12f;
            }
            if (pant.CalidadPrenda == Prenda.QA.Premium)
            {
                precioFinal += precio * 0.3f;
            }
            return precioFinal;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Tienda.Text = _tienda.NombreTienda;
            lbl_Vendedor.Text = "#" + vendedor.IDVen + " " + vendedor.ApellidoVen + ", " + vendedor.NombreVen;
            _tienda.AñadirCamisas();
            _tienda.AñadirPantalones();
            
           
            

        }

        private void BTN_Historial_Click(object sender, EventArgs e)
        {
            lista_His.Items.Clear();
            foreach (Cotizacion.COTIZAR c in _cotizaciones.cotHistorial)
            {
                string[] f = new string[5];
                f[0] = c.ID;
                f[1] = c.TIENDA;
                f[2] = c.PRENDA;
                f[3] = c.CANTIDAD;
                f[4] = c.PRECIO;
                lista_His.Items.Add(new ListViewItem(f));
            }
        }
    }
}
