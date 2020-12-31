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

namespace Presentacion
{
    public partial class FLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);
        public FLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void TxtUser_Enter(object sender, EventArgs e)              //Evento Enter en el TextBox de Usuario
        {
            if (TxtUser.Text == "Usuario")                                  //Cada que el usuario entre en el TextBox
            {                                                               //y contenga el mensaje "Usuario" 
                TxtUser.Text = "";                                          //este cambiara a espacio en blanco
            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)              //Evento Leave en el TextBox de Usuario
        {
            if (TxtUser.Text == "")                                         //Cada que el usuario salga del TextBox
            {                                                               //y contenga un espacio vacio 
                TxtUser.Text = "Usuario";                                   //este cambiara a el mensaje "Usuario"
            }
        }

        private void TxtPass_Enter(object sender, EventArgs e)              //Evento Enter en el TextBox de Password
        {
            if (TxtPass.Text == "Contraseña")                               //Lo mismo que usuario 
            {
                TxtPass.Text = "";
                TxtPass.UseSystemPasswordChar = true;                       //Oculta la contraseña usando caracteres 
            }                                                               //especiales(bolitas)
        }

        private void TxtPass_Leave(object sender, EventArgs e)              //Evento Leave en el TextBox de Password
        {
            if (TxtPass.Text == "")
            {
                TxtPass.Text = "Contraseña";
                TxtPass.UseSystemPasswordChar = false;
            }
        }

        private void BtClose_Click(object sender, EventArgs e)              //Evento Click en el PictureBox Cerrar
        {
            Application.Exit();                                             //Cierra la ventana
        }

        private void BtMin_Click(object sender, EventArgs e)                //Evento Click en el PictureBox Minimizar
        {
            this.WindowState = FormWindowState.Minimized;                   //Minimiza la ventana
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Login();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]            //<----De aqui
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)           //Se crea el "Evento" MouseDown desde las 
        {                                                                       //propiedades del panel Form1(FLogin) el de abajo 
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }                                                                   //<----Pa' aca, es codigo para mover la ventana

        private void panel1_MouseDown(object sender, MouseEventArgs e)          //Se crea el "Evento" MouseDown desde las 
        {                                                                       //propiedades del panel Form1(FLogin) el de arriba
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtLogin_Click(object sender, EventArgs e)              //Evento Click en el boton Login
        {
            Login();
        }

        private void msgError(string msg)                       //Metodo vacio que sirve para mostrar los mensajes
        {                                                       //de error
            LblError.Text = "       " + msg;
            LblError.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            TxtPass.Text = "Contraseña";
            TxtPass.UseSystemPasswordChar = false;
            TxtUser.Text = "Usuario";
            LblError.Visible = false;
            this.Show();
            BtLogin.Focus();
        }

        private void Login()
        {
            if (TxtUser.Text != "Usuario")                                  //Si el Txt de usuario esta lleno
            {
                if (TxtPass.Text != "Contraseña")                            //Si el Txt de usuario y password esta lleno
                {
                    ModeloUsuario user = new ModeloUsuario();
                    var LoginValido = user.LoginUser(TxtUser.Text, TxtPass.Text);
                    if (LoginValido == true)
                    {
                        FInicio Inicio = new FInicio();
                        Inicio.Show();
                        Inicio.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrectos");
                        TxtPass.Clear();
                        TxtUser.Focus();
                    }
                }
                else                                                        //Si el Txt de usuario esta lleno y
                {                                                           //el de password esta vacio
                    msgError("Ingrese Contraseña");
                }
            }
            else                                                            //Si el Txt de usuario esta vacio
            {
                if (TxtPass.Text != "Contraseña")
                {
                    msgError("Ingrese Usurio");
                }
                else
                {
                    msgError("Ingrese Usurio y Contraseña");
                }
            }
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            //PBG1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
