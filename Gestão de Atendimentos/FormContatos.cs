using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Atendimentos
{
    public partial class FormContatos : Form
    {
        public FormContatos()
        {
            InitializeComponent();
            dgvContatos.Columns.Add("Nome", "Nome");
            dgvContatos.Columns.Add("Empresa", "Empresa");
            dgvContatos.Columns.Add("Telefone", "Telefone");
            this.dgvContatos = new System.Windows.Forms.DataGridView();
        }
        public DataGridView DgvContatos
        {
            get { return dgvContatos; }
        }

    }
}
