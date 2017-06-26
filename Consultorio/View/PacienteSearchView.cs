using Consultorio.Controller;
using Consultorio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio.View
{
    public partial class PacienteSearchView : Form
    {
        public PacienteSearchView()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Paciente p = PacienteController.PacienteC.search(textBox1.Text);

                if (p != null)
                {
                    Program.closePacienteSearch();
                    Program.openPaciente(p, checkBox1.Checked);
                    ClearBoxes();
                }
                else
                {
                    MessageBox.Show("Registro não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearBoxes()
        {
            textBox1.Text = "";
        }
    }
}
