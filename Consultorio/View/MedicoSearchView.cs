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
    public partial class MedicoSearchView : Form
    {
        public MedicoSearchView()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Medico m = MedicoController.MedicoC.search(textBox1.Text);

                if (m != null)
                {
                    Program.closeMedicoSearch();
                    Program.openMedico(m, checkBox1.Checked);
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
