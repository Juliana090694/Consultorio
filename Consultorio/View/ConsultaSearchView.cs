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
    public partial class ConsultaSearchView : Form
    {
        public ConsultaSearchView()
        {
            InitializeComponent();
        }

        private void ConsultaSearchView_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
        }

        public void ClearBoxes()
        {
            dateTimePicker1.Value = DateTime.Today;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != null && dateTimePicker1.Text != "")
            {
                Consulta c = ConsultaController.ConsultaC.search(dateTimePicker1.Value);

                if (c != null)
                {
                    Program.closeConsultaSearch();
                    Program.openConsulta(c, checkBox1.Checked);
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
    }
}
