using Ejemplo_en_clase_form.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_en_clase_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvinido a mi App");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Facultad_Click(object sender, EventArgs e)
        {

        }

        private void Facultad_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegi = new FrmRegistro();
            frmRegi.Show();
        }
        private int intentos = 0;
        private void login_Click(object sender, EventArgs e)
        {
            string usr = usu.Text.ToLower();
            string pwd = con.Text.ToLower();

            if (intentos >= 2)
            {
                MessageBox.Show("Ya no tiene mas intentos");
                login.Enabled = false;
            }
            else if (usr.Equals("admin") && pwd.Equals("admin"))
            {
                FrmRegistro fmrReg = new FrmRegistro();
                fmrReg.Show();
            }
            else if (usr == "" || pwd == "")
            {
                MessageBox.Show("no puede dejar en blanco");
            }
            else

                MessageBox.Show("Usuario y contraseña erroneos");
            usu.Clear();
            con.Clear();
            intentos++;
        }
    


private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
