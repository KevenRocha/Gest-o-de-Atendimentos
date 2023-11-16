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
    public partial class Form2 : Form
    {
        // Criar um campo para armazenar o caminho do arquivo de texto
        private string filePath = @"C:\Atendimentos.txt";
        private TextBox txtNome;
        private TextBox txtEmpresa;
        private TextBox txtTelefone;
        private TextBox txtSolicitacao;
        private TextBox txtSuporte;
        private Button btnRegistrar;
        public Form2()
        {
            InitializeComponent();
        }
        // Criar um método para validar os dados do formulário
        private bool ValidateData()
        {
            // Verificar se os campos estão preenchidos
            if (string.IsNullOrEmpty(txtNome.Text) ||
                string.IsNullOrEmpty(txtEmpresa.Text) ||
                string.IsNullOrEmpty(txtTelefone.Text)||
                string.IsNullOrEmpty(txtSolicitacao.Text)||
                string.IsNullOrEmpty(txtSuporte.Text))
            {
                // Exibir uma mensagem de erro
                MessageBox.Show("Por favor, preencha os campos NOME, EMPRESA e TELEFONE.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                // Retornar verdadeiro se os dados são válidos
                return true;
            }


        }
        private void SaveData()
        {
            // Criar uma variável para armazenar os dados do formulário
            string data = $"Nome do Cliente: {Nome.Text}\r\n" +
                          $"Empresa: {Empresa.Text}\r\n" +
                          $"Telefone: {Telefone.Text}\r\n" +
                          $"Solicitação: {Solicitacao.Text}\r\n" +
                          $"Solução: {Suporte.Text}\r\n" +
                          $"Data e Hora: {DateTime.Now}\r\n" +
                          $"----------------------------------------\r\n";
            // Tentar salvar os dados no arquivo de texto
            try
            {
                // Abrir o arquivo em modo de anexação
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    // Escrever os dados no arquivo
                    sw.Write(data);
                }
                // Exibir uma mensagem de sucesso
                MessageBox.Show("Dados salvos com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Exibir uma mensagem de erro
                MessageBox.Show($"Ocorreu um erro ao salvar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void ShowData()
        {
            // Criar uma variável para armazenar os dados do formulário
            string data = $"Nome do Cliente: {Nome.Text}\r\n" +
                          $"Empresa: {Empresa.Text}\r\n" +
                          $"Telefone: {Telefone.Text}\r\n" +
                          $"Solicitação: {Solicitacao.Text}\r\n" +
                          $"Solução: {Suporte.Text}\r\n" +
                          $"Data e Hora: {DateTime.Now}\r\n" +
                          $"----------------------------------------\r\n";

            // Adicionar os dados à caixa de histórico usando o método AppendText
            rtbHistorico.AppendText(data);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                SaveData();
            }
        }
    }
}
