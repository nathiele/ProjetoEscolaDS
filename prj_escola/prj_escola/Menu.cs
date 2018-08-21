using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_escola
{
    public partial class frmControle : Form
    {
        public frmControle()
        {
            InitializeComponent();
        }


        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlunos frmAlu = new frmAlunos();
            frmAlu.MdiParent = this;
            frmAlu.Show();
        }

        private void frmControle_Load(object sender, EventArgs e)
        {
            lblData.Text = "Data :" + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora :" + DateTime.Now.ToString("HH:mm:ss");
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmDisc frmDisc = new frmDisc();
            frmDisc.MdiParent = this;
            frmDisc.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAlunos frmAlu = new frmAlunos();
            frmAlu.MdiParent = this;
            frmAlu.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmDisc frmDisc = new frmDisc();
            frmDisc.MdiParent = this;
            frmDisc.Show();
        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsCadDisc frmCons = new FrmConsCadDisc();
            frmCons.MdiParent = this;
            frmCons.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsCadAlu frmCons = new FormConsCadAlu();
            frmCons.MdiParent = this;
            frmCons.Show();
        }

       
    }
}
