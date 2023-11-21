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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestão_de_Atendimentos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        

        private void button1Registrar_Click_1(object sender, EventArgs e)
        
        {
            string nome = textBoxNome.Text;
            string empresa = textBoxEmpresa.Text;
            string telefone = textBoxTelefone.Text;
            string solicitacao = textBoxSolicitacao.Text;
            string suporte = textBoxSuporte.Text;

            string registro = $"Nome: {nome}\nEmpresa: {empresa}\nTelefone: {telefone}\nSolicitação: {solicitacao}\nSuporte prestado: {suporte}\n\n";

            Clipboard.SetText(registro);
            File.AppendAllText("registros.txt", registro);

            FormRegistro formRegistro = new FormRegistro();
            formRegistro.Registro += registro;
            FormContatos formcontatos = new FormContatos();
            formcontatos.DgvContatos.Rows.Add(nome, empresa, telefone);




            textBoxNome.Clear();
            textBoxEmpresa.Clear();
            textBoxTelefone.Clear();
            textBoxSolicitacao.Clear();
            textBoxSuporte.Clear();
        }

    }


    public class Atendimento
    {
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public string Telefone { get; set; }
        public string Solicitacao { get; set; }
        public string Suporte { get; set; }

        public static List<Atendimento> ListaAtendimentos = new List<Atendimento>();
    }
}


