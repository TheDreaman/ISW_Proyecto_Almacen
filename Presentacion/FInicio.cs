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
using Dominio;
using Auxiliar.Cache;
                                                                   //*Los efectos de colores y transparencias fueron 
namespace Presentacion                                             //agregados desde la ventana de propiedades del Form*
{
    public partial class FInicio : Form
    {
        public FInicio()
        {
            InitializeComponent();
            AbrirPestana(new Bienvenida());
            VerIMGPerfil(ImgUser);
            MsgRol();
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
            if (ArrowProd.Visible == false)                              //Mismo codigo que el panel de productos
            {
                ArrowProd.Visible = true;
                ArrowAdminUser.Visible = false;
                ArrowRepomov.Visible = false;
                ArrowRepo.Visible = false;
            }
            AbrirPestana(new ProdAdministrar());
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
            if (ArrowRepo.Visible == false)                              //Mismo codigo que el panel de productos
            {
                ArrowRepo.Visible = true;
                ArrowAdminUser.Visible = false;
                ArrowProd.Visible = false;
                ArrowRepomov.Visible = false;
            }
            AbrirPestana(new ReporteInventario());
        }

        private void BtReporteMov_Click(object sender, EventArgs e)
        {
            AbrirPestana(new ReporteMovimientos());
            if (ArrowRepomov.Visible == false)                              //Mismo codigo que el panel de productos
            {
                ArrowRepomov.Visible = true;
                ArrowAdminUser.Visible = false;
                ArrowRepo.Visible = false;
                ArrowProd.Visible = false;
                
            }
        }

        private void AbrirPestana(object WinForm)
        {
            if(this.Contenido.Controls.Count>0)
            {
                this.Contenido.Controls.RemoveAt(0);
            }
            Form Newform = WinForm as Form;
            Newform.TopLevel = false;
            Newform.Dock = DockStyle.Fill;
            this.Contenido.Controls.Add(Newform);
            this.Contenido.Tag = Newform;
            Newform.Show();
        }

        private void ImgUser_Click(object sender, EventArgs e)
        {
            AbrirPestana(new Bienvenida());
            ArrowAdminUser.Visible = false;
            ArrowRepomov.Visible = false;
            ArrowRepo.Visible = false;
            ArrowProd.Visible = false;
        }

        private void BtLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void VerIMGPerfil(PictureBox Pic)
        {
            ModeloUsuario user = new ModeloUsuario();
            user.ConsultaIMG(LoginCache.ID);
            System.IO.MemoryStream MStream = new System.IO.MemoryStream(LoginCache.Picture);
            Pic.Image = System.Drawing.Bitmap.FromStream(MStream);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirPestana(new AdministrarUsuarios());
            if (ArrowAdminUser.Visible == false)                            //Oculta o muestra el panel del submenu 
            {                                                               //de Productos dependiendo su visibilidad 
                ArrowAdminUser.Visible = true;
                ArrowRepomov.Visible = false;
                ArrowRepo.Visible = false;
                ArrowProd.Visible = false;
            }
        }

        private void MsgRol()
        {
            TxtRol.Text = LoginCache.Rol;
        }
    }

    
}
