using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginEvent(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            String user = "Admin";
            String password = "1234";
            String txtUser = txtUserField.Text;
            String txtPassword = txtPasswordField.Text;
            if (txtUser == user && txtPassword == password)
            {
                MessageBox.Show("Ingreso Exitoso");
                form2.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Inválida");
            }
        }

        private void lblUserField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
