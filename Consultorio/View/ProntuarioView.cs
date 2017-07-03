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
    public partial class ProntuarioView : Form
    {
        private Prontuario prontuario;

        private Medico medico;
        private Paciente paciente;
        private Consulta consulta;

        public bool isEditable = true;
        public bool isUpdating = false;

        public ProntuarioView()
        {
            InitializeComponent();
        }

        //Seta os componentes para novo registro
        public void setComponents()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = false;
                }
            }
            dateTimePicker1.Enabled = true;
            button2.Enabled = true;
            textBox2.Enabled = true;
            button3.Enabled = true;
            objectListView1.Enabled = true;

            prontuario = new Prontuario();
        }

        //Seta os campos de acordo e ativa para edição ou visualização
        public void setComponents(Prontuario prontuario, bool isEditable)
        {
            dateTimePicker1.Value = prontuario.Consulta.DataConsulta;
            this.medico = prontuario.Medico;
            objectListView1.SelectedObject = prontuario.Consulta;
            textBox2.Text = medico.CRM + " - " + medico.Nome;
            textBox1.Text = prontuario.DescricaoPaciente;
            textBox4.Text = prontuario.Diagnostico;
            textBox6.Text = prontuario.PrescricaoMedicamento;
            textBox5.Text = prontuario.PrescricaoTratamento;
            objectListView1.SetObjects(ConsultaController.ConsultaC.search(dateTimePicker1.Value, medico.CRM));
            objectListView1.SelectedObject = prontuario.Consulta;

            this.prontuario = prontuario;

            if (!isEditable)
            {
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).ReadOnly = true;
                    }
                }
                dateTimePicker1.Enabled = false;
                button2.Enabled = false;
                textBox2.Enabled = false;
                button3.Enabled = false;
                objectListView1.Enabled = false;
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).ReadOnly = false;
                    }
                }
                dateTimePicker1.Enabled = false;
                button2.Enabled = true;
                textBox2.Enabled = false;
                button3.Enabled = false;
                objectListView1.Enabled = false;
                buttonExcluir.Enabled = true;
            }
        }

        //Limpa as caixas
        public void clearBoxes()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)(c)).Text = string.Empty;
                }
            }
            dateTimePicker1.Enabled = true;
            dateTimePicker1.Value = DateTime.Today;
            button1.Enabled = true;
            medico = null;
            paciente = null;
            consulta = null;
            buttonExcluir.Enabled = false;
            objectListView1.SetObjects(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Verifica se os campos são nulos ou não
        //Seta o modelo de acordo e envia para o banco para adição ou edição
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox4.Text != "" && textBox6.Text != "" && textBox5.Text != "" &&
                dateTimePicker1.Value != null  && medico != null && objectListView1.SelectedObject != null)
            {
                prontuario.Consulta = ((Consulta)objectListView1.SelectedObject);
                prontuario.Medico = ((Consulta)objectListView1.SelectedObject).Medico;
                prontuario.Paciente = ((Consulta)objectListView1.SelectedObject).Paciente;
                prontuario.DescricaoPaciente = textBox1.Text;
                prontuario.Diagnostico = textBox4.Text;
                prontuario.PrescricaoMedicamento = textBox6.Text;
                prontuario.PrescricaoTratamento = textBox5.Text;

                if (isEditable && !isUpdating)
                    ProntuarioController.ProntuarioC.add(prontuario);
                else if (isEditable && isUpdating)
                    ProntuarioController.ProntuarioC.update(prontuario);
                clearBoxes();
                Program.closeProntuario();
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProntuarioView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultoríoDataSet.MedicoSet'. Você pode movê-la ou removê-la conforme necessário.
            this.medicoSetTableAdapter.Fill(this.consultoríoDataSet.MedicoSet);

        }

        //Verifica se quer excluir e caso sim exclui
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja realmente excluir esse registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                ProntuarioController.ProntuarioC.delete(prontuario.Id);
                clearBoxes();
                Program.closeProntuario();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Atualiza os campos de acordo com a data
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (medico != null && dateTimePicker1.Value != null)
            {
                objectListView1.SetObjects(ConsultaController.ConsultaC.search(dateTimePicker1.Value, medico.CRM));
            }
        }

        //Procura e preenche o medico
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Medico m = MedicoController.MedicoC.search(textBox2.Text);
                if (m != null)
                {
                    textBox2.Text = m.CRM + " - " + m.Nome;
                    medico = m;
                    textBox2.ReadOnly = true;
                    button3.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Médico não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
