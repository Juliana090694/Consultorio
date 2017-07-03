using BrightIdeasSoftware;
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

        //roda quanso a tela carrega pela primeira vez
        private void ConsultaSearchView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultoríoDataSet.MedicoSet'. Você pode movê-la ou removê-la conforme necessário.
            this.medicoSetTableAdapter.Fill(this.consultoríoDataSet.MedicoSet);
            dateTimePicker1.Value = DateTime.Today;
        }

        //limpa as caixas
        public void ClearBoxes()
        {
            dateTimePicker1.Value = DateTime.Today;
            objectListView1.SetObjects(null);
        }

        //pega os campos preenchidos e procura no banco algo que bata com o procurado
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != null && dateTimePicker1.Text != "" && objectListView1.SelectedObject != null)
            {
                Consulta c = (Consulta) objectListView1.SelectedObject;

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

        //atualiza a lista quando muda o calendario
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null && dateTimePicker1.Value != null)
            {
                objectListView1.SetObjects(ConsultaController.ConsultaC.search(dateTimePicker1.Value, (string)comboBox1.SelectedValue));
            }
        }

        //atualiza a lista quando muda o medico
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && dateTimePicker1.Value != null)
            {
                objectListView1.SetObjects(ConsultaController.ConsultaC.search(dateTimePicker1.Value, (string)comboBox1.SelectedValue));
            }
        }

    }
}
