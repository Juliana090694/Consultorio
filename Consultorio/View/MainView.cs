﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class Form1 : Form
    {
        //Essa classe é responsável por chamaar as coisas no menu principal
        public Form1()
        {
            InitializeComponent();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.openPaciente();
        }

        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.openMedico();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.openConsulta();
        }

        private void prontuárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Program.openProntuario();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.openConsultaSearch();
        }

        private void médicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.openMedicoSearch();
        }

        private void pacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.openPacienteSearch();
        }

        private void prontuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.openProntuarioSearch();
        }

        private void pacienteLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.openListaPaciente();
        }

        private void medicoLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.openListaMedico();
        }

        private void consultaLToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Program.openListaConsulta();
        }

        private void prontuarioLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.openListaProntuario();
        }
    }
}
