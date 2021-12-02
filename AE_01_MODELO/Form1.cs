using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AE_01_MODELO
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        //Variables para controlar los intentos
        int intentos = 3;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            string usu = txtUsuario.Text.ToUpper();
            string cla = txtClave.Text.ToUpper();
            if (usu=="GRUPO1" && cla=="12345")
            {                
                frmProductos frm = new frmProductos();                
                frm.Show();
                this.Hide();                
            }
            else
            {
                intentos--;
                MessageBox.Show("Usuario o Clave Incorrecta \nTe quedan "+intentos+" intentos","AVISO");
                txtUsuario.Clear();
                txtClave.Clear();
                txtUsuario.Focus();                
            }
            if (intentos==0)
            {
                MessageBox.Show("Fueron demasiados intentos","AVISO");
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
