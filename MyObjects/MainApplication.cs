using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyObjects
{
    public partial class MainApplication : Form
    {
        #region Declaração das variáveis do projeto
        bool objControl = false, pesControl = false, empControl = false, antControl = false, lisControl = false, dasControl = true, conControl = false;
        #endregion

        #region Inicialização dos componentes
        public MainApplication()
        {
            InitializeComponent();
            
            conteudoTab.TabPages.Remove(objetosPage);
            conteudoTab.TabPages.Remove(pessoasPage);
            conteudoTab.TabPages.Remove(emprestimosPage);
            conteudoTab.TabPages.Remove(anotacoesPage);
            conteudoTab.TabPages.Remove(listaPage);
            conteudoTab.TabPages.Remove(configPage);
        }
        #endregion

        #region Botões que abrem as abas
        private void objetosBtn_Click(object sender, EventArgs e)
        {
            
            if (objControl == false) 
            {
                conteudoTab.TabPages.Add(objetosPage);
                conteudoTab.SelectedTab = objetosPage;
                objControl = true;
            }
            else 
            {
                conteudoTab.SelectedTab = objetosPage;
            }
            
        }

        private void pessoasBtn_Click(object sender, EventArgs e)
        {
            if (pesControl == false)
            {
                conteudoTab.TabPages.Add(pessoasPage);
                conteudoTab.SelectedTab = pessoasPage;
                pesControl = true;
            }
            else
            {
                conteudoTab.SelectedTab = pessoasPage;
            }
        }

        private void emprestimosBtn_Click(object sender, EventArgs e)
        {
            if (empControl == false) {
                conteudoTab.TabPages.Add(emprestimosPage);
                conteudoTab.SelectedTab = emprestimosPage;
                empControl = true;
            }
            else 
            {
                conteudoTab.SelectedTab = emprestimosPage;
            }
        }

        private void anotacoesBtn_Click(object sender, EventArgs e)
        {
            if (antControl == false)
            {
                conteudoTab.TabPages.Add(anotacoesPage);
                conteudoTab.SelectedTab = anotacoesPage;
                antControl = true;
            }
            else
            {
                conteudoTab.SelectedTab = anotacoesPage;
            }
        }

        private void listaBtn_Click(object sender, EventArgs e)
        {
            if (lisControl == false)
            {
                conteudoTab.TabPages.Add(listaPage);
                conteudoTab.SelectedTab = listaPage;
                lisControl = true;
            }
            else
            {
                conteudoTab.SelectedTab = listaPage;
            }
        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            if (dasControl == false)
            {
                conteudoTab.TabPages.Add(dashPage);
                conteudoTab.SelectedTab = dashPage;
                dasControl = true;
            }
            else
            {
                conteudoTab.SelectedTab = dashPage;
            }
        }

        private void configuracoesBtn_Click(object sender, EventArgs e)
        {
            if (conControl == false)
            {
                conteudoTab.TabPages.Add(configPage);
                conteudoTab.SelectedTab = configPage;
                conControl = true;
            }
            else
            {
                conteudoTab.SelectedTab = configPage;
            }
        }
        #endregion

        #region Botões que fecham as abas
        private void sairBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fecharDashPage_Click(object sender, EventArgs e)
        {
            conteudoTab.TabPages.Remove(dashPage);
            dasControl = false;
        }

        private void objetosFecharBtn_Click(object sender, EventArgs e)
        {
            conteudoTab.TabPages.Remove(objetosPage);
            objControl = false;
        }

        private void pessoasFecharBtn_Click(object sender, EventArgs e)
        {
            conteudoTab.TabPages.Remove(pessoasPage);
            pesControl = false;
        }

        private void empretimosFecharBtn_Click(object sender, EventArgs e)
        {
            conteudoTab.TabPages.Remove(emprestimosPage);
            empControl = false;
        }

        private void anotacoesFecharBtn_Click(object sender, EventArgs e)
        {
            conteudoTab.TabPages.Remove(anotacoesPage);
            antControl = false;
        }

        private void listaFecharBtn_Click(object sender, EventArgs e)
        {
            conteudoTab.TabPages.Remove(listaPage);
            lisControl = false;
        }

        private void confiFecharBtn_Click(object sender, EventArgs e)
        {
            conteudoTab.TabPages.Remove(configPage);
            conControl = false;
        }
        #endregion
    }
}
