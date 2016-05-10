using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC.Telas;

namespace MVC
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(panPesquisa.Visible)
            {
                panPesquisa.Visible = false;
                panCadastrar.Visible = true;
            }else
            {
                panCadastrar.Visible = true;
            }
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (panCadastrar.Visible)
            {
                panCadastrar.Visible = false;
                panPesquisa.Visible = true;
            }
            else
            {
                panPesquisa.Visible = true;
            }
            
        }

        private void btnProfessoresC_Click(object sender, EventArgs e)
        {
            Telas.frmProfessorIns FormProfessor = new Telas.frmProfessorIns();
            FormProfessor.ShowDialog();
        }

        private void btnProfessoresP_Click(object sender, EventArgs e)
        {
            frmProfessorPsq FormProfessorPsq = new frmProfessorPsq();
            FormProfessorPsq.ShowDialog();
        }

        private void btnAreasC_Click(object sender, EventArgs e)
        {
            frmAreaIns FormAreaIns = new frmAreaIns();
            FormAreaIns.ShowDialog();
        }

        private void btnAssuntosC_Click(object sender, EventArgs e)
        {
            frmAssuntoIns FormAssuntoIns = new frmAssuntoIns();
            FormAssuntoIns.ShowDialog();
        }

        private void btnAreasP_Click(object sender, EventArgs e)
        {
            frmAreaPsq FormAreaPsq = new frmAreaPsq();
            FormAreaPsq.ShowDialog();
        }

        private void btnAssuntoP_Click(object sender, EventArgs e)
        {
            frmAssuntoPsq FormAssuntoPsq = new frmAssuntoPsq();
            FormAssuntoPsq.ShowDialog();
        }
    }
}
;