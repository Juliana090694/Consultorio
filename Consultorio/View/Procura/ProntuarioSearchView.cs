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
    public partial class ProntuarioSearchView : Form
    {
        public ProntuarioSearchView()
        {
            InitializeComponent();
        }

        //Pega os campos e ativa para edição ou visualização
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != null && dateTimePicker1.Text != "" && objectListView1.SelectedObject != null)
            {
                Prontuario p = ProntuarioController.ProntuarioC.search(((Consulta)objectListView1.SelectedObject).DataConsulta, (string)comboBox1.SelectedValue);

                if (p != null)
                {
                    Program.closeProntuarioSearch();
                    Program.openProntuario(p, checkBox1.Checked);
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

        //limpa os campos
        public void ClearBoxes()
        {
            dateTimePicker1.Value = DateTime.Today;
            objectListView1.SetObjects(null);
        }

        private void ProntuarioSearchView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultoríoDataSet.MedicoSet'. Você pode movê-la ou removê-la conforme necessário.
            this.medicoSetTableAdapter.Fill(this.consultoríoDataSet.MedicoSet);
            dateTimePicker1.Value = DateTime.Today;
        }

        //Quando a data muda, atualiza a lista de consultas de acordo
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null && dateTimePicker1.Value != null)
            {
                objectListView1.SetObjects(ConsultaController.ConsultaC.search(dateTimePicker1.Value, (string)comboBox1.SelectedValue));
            }
        }

        //Quando o medico muda, atualiza a lista de consultas de acordo
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && dateTimePicker1.Value != null)
            {
                objectListView1.SetObjects(ConsultaController.ConsultaC.search(dateTimePicker1.Value, (string)comboBox1.SelectedValue));
            }
        }
    }
}
