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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelAjudaSubmenu.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panelAjudaSubmenu.Visible == true)
                panelAjudaSubmenu.Visible = false;
        
        }
        private void showSubmenu(Panel subMenu)
        { 
            if (subMenu.Visible == false) {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        
        }

        private void buttonAtendimentos_Click(object sender, EventArgs e)
        {
            abrirPainelPrincipal(new Form2());

        }

        private void buttonContatos_Click(object sender, EventArgs e)
        {

        }

        private void buttonHistorico_Click(object sender, EventArgs e)
        {

        }
        private void buttonAjuda_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panelAjudaSubmenu);

        }

        private void buttonSolicitarApoio_Click(object sender, EventArgs e)
        {
            
            hideSubmenu();
        }

        private void buttonBasedeConhecimento_Click(object sender, EventArgs e)
        {
            
            hideSubmenu();
        }

        private void buttonPainel_Click(object sender, EventArgs e)
        {
            
            hideSubmenu();
        }

        private Form activeForm = null;
        private void abrirPainelPrincipal(Form PainelPrincipal)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = PainelPrincipal;
            PainelPrincipal.TopLevel = false;
            PainelPrincipal.FormBorderStyle = FormBorderStyle.None;
            PainelPrincipal.Dock = DockStyle.Fill;
            panelPainelPrincipal.Controls.Add(PainelPrincipal);
            panelPainelPrincipal.Tag = activeForm;
            PainelPrincipal.BringToFront();
            PainelPrincipal.Show();


        }

    }
}
