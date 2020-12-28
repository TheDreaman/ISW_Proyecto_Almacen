using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
                                                                   //*Los efectos de colores y transparencias fueron 
namespace Presentacion                                             //agregados desde la ventana de propiedades del Form*
{
    public partial class FInicio : Form
    {
        public FInicio()
        {
            InitializeComponent();
        }

        private void BtCerrar_Click(object sender, EventArgs e)     //Evento Click en el PictureBox Cerrar
        {
            Application.Exit();                                     //Cierra la ventana
        }

        private void BtMax_Click(object sender, EventArgs e)        //Evento Click en el PictureBox Maximizar
        {
            this.WindowState = FormWindowState.Maximized;           //Boton Maximizar
            BtMax.Visible = false;                                  //Oculta el PictureBox de Maximizar
            BtRes.Visible = true;                                   //Hace visible el PictureBox de Restaurar
        }                                                           //NOTA: Ambas imagenes estan encimadas 

        private void BtRes_Click(object sender, EventArgs e)        //Evento Click en el PictureBox Restaurar
        {
            this.WindowState = FormWindowState.Normal;              //Lo mismo que arriba solo que con el PictureBox
            BtMax.Visible = true;                                   //de Restaurar
            BtRes.Visible = false;
        }

        private void BtMin_Click(object sender, EventArgs e)        //Evento Click en el PictureBox Minimizar
        {
            this.WindowState = FormWindowState.Minimized;           //Minimiza la ventana
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]    //<----De aqui
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
                                                                    
        private void TopBarra_MouseDown(object sender, MouseEventArgs e)    //Se crea el "Evento" MouseDown desde las 
        {                                                                   //propiedades del panel TopBarra
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }                                                           //<----Pa' aca, es codigo para mover la ventana
                                                                    //Copie y pegue el codigo nomas xd

        private void BtProductos_Click(object sender, EventArgs e)          //Evento Click en el boton Productos
        {
            if (PSubProductos1.Visible == false)                            //Oculta o muestra el panel del submenu 
            {                                                               //de Productos dependiendo su visibilidad 
                PSubProductos1.Visible = true;
            }
            else
            {
                PSubProductos1.Visible = false;
            }
        }

        private void BtAdministrarPro_Click(object sender, EventArgs e)     //Evento Click en el boton Administrar Productos
        {
            PSubProductos1.Visible = false;                                 //Oculta el panel del submenu de Productos
            LblBienvenido.Visible = false;                                  //Oculta la pantalla de inicio (Imegen y texto)
            ImgLogo.Visible = false;                                            
        }

        private void BtReportes_Click(object sender, EventArgs e)           //Evento Click en el boton Reportes
        {
            if (PSubreportes.Visible == false)                              //Mismo codigo que el panel de productos
            {
                PSubreportes.Visible = true;
            }
            else
            {
                PSubreportes.Visible = false;
            }
        }

        private void BtRepoInv_Click(object sender, EventArgs e)
        {
            PSubreportes.Visible = false;
            LblBienvenido.Visible = false;
            ImgLogo.Visible = false;
        }

        private void BtReporteMov_Click(object sender, EventArgs e)
        {
            PSubreportes.Visible = false;
            LblBienvenido.Visible = false;
            ImgLogo.Visible = false;
        }
                                                                                
    }
}
