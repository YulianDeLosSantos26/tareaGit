using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_de_Acceso_a_datos_20220592;
using CapaPresentacion.Properties;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            if (textuser.Text != "") {
                if (textpass.Text != ""){ 
                    CN_Login user = new CN_Login();
                    var validLogin = user.LoginUser(textuser.Text, textpass.Text);
                    if (validLogin == true)
                    {
                        Form1 Agenda_electronica= new Form1();
                        Agenda_electronica.Show();
                        Agenda_electronica.FormClosed += Logout;
                        this.Hide();
                    } else
                    {
                        msgError("Nombre de usuario o contraseña incorrecta");
                        textpass.Clear();
                        textuser.Focus();

                    }
                }
                else msgError("Porfavor ingrese el password");
            }
            else msgError("Porfavor ingrese su nombre de usuario");

        }
        private void msgError(string msg)
        {
            MensageError.Text = msg;
            MensageError.Visible= true;
        }

        private void textpass_Enter(object sender, EventArgs e)
        {
            textpass.UseSystemPasswordChar = true;
        }

        private void checkBoxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrar.Checked)
            {
                textpass.UseSystemPasswordChar = false;
            }
            else { textpass.UseSystemPasswordChar = true; }
        }
        private void Logout (object sender, FormClosedEventArgs e)
        {
            textpass.Clear();
            textuser.Clear();
            MensageError.Visible=false;
            this.Show();
            textuser.Focus();
        }

    }
}
