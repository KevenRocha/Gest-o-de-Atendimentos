using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Atendimentos
{
    public partial class FormRegistro : Form
    {
        private FormContatos formcontatos = new FormContatos();
        public FormRegistro()
        {
            InitializeComponent();
            if (File.Exists("registros.txt"))
            {
                txtRegistro.Text = File.ReadAllText("registros.txt");
            }
        }
        public string Registro
        {
            get { return txtRegistro.Text; }
            set { txtRegistro.Text += value; }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRegistro.Clear();
        }
    }
}
