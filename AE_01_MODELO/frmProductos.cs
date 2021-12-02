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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtproducto.Text == "")
            {
                errorProvider1.SetError(txtproducto, "Agrege un producto");
                txtproducto.Focus();
                return;
            }
            errorProvider1.SetError(txtproducto, "");
            string prod = txtproducto.Text;
            lstProductos.Items.Add(prod);
            txtTotal.Text = lstProductos.Items.Count.ToString("n0");

            txtproducto.Clear();
            txtproducto.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstProductos.SelectedIndex == -1)
            {
                errorProvider1.SetError(btnDelete, "Seleccione el producto a eliminar");
                return;
            }
            errorProvider1.SetError(btnDelete, "");
            lstProductos.Items.RemoveAt(lstProductos.SelectedIndex);
            txtTotal.Text = lstProductos.Items.Count.ToString("n0");
            txtproducto.Clear();
            txtproducto.Focus();
        }

        private void txtproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstProductos.Items.Clear();
            txtproducto.Clear();
            txtproducto.Focus();
        }
    }
}
