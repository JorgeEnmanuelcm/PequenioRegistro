using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace RegistroDeCuentas
{
    public partial class Form1 : Form
    {
        int Cuenta;
        int IdBuscado;
        CuentasRegistro Registro = new CuentasRegistro();

        public Form1()
        {
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            CuentaIdtextBox.Clear();
            DescripcionrichTextBox.Clear();
            BalancetextBox.Clear();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
           int.TryParse(CuentaIdtextBox.Text, out Cuenta);
           Registro.CuentaId = Cuenta;
           if (Registro.Eliminar())
           {
               MessageBox.Show("se eliminaron los datos correctamente");
           }
           else
           {
               MessageBox.Show("no se eliminaron los datos");
           }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(CuentaIdtextBox.Text, out id);
            IdBuscado = id;
            if (Registro.Buscar(IdBuscado))
            {
                Registro.CuentaId = IdBuscado;
                BalancetextBox.Text = Registro.Balance.ToString();
                DescripcionrichTextBox.Text = Registro.Descripcion;
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
           if (CuentaIdtextBox.Text.Length == 0)
           {
                double balance;
                double.TryParse(BalancetextBox.Text, out balance);
                BalancetextBox.Text = balance.ToString();
                Registro.Balance = balance;
                Registro.Descripcion = DescripcionrichTextBox.Text;

               if (Registro.Insertar())
               {
                   MessageBox.Show("se guardaron los datos");
               }
               else
               {
                   MessageBox.Show("no se guardaron los datos");
               }

           }
           else
           {
               Registro.CuentaId = Convert.ToInt32(CuentaIdtextBox.Text);

               Registro.Descripcion = DescripcionrichTextBox.Text;

               Registro.Editar();

               if (Registro.Editar())
               {
                   MessageBox.Show("se actualizaron los datos");
               }
               else
               {
                   MessageBox.Show("no se actualizaron los datos");
               }
           }
        }
    }
}
