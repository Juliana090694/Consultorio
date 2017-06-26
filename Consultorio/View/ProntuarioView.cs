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
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            button2.Enabled = true;
            button5.Enabled = true;

            prontuario = new Prontuario();
        }

        public void setComponents(Prontuario prontuario, bool isEditable)
        {
            dateTimePicker1.Value = prontuario.Consulta.DataConsulta;
            textBox2.Text = prontuario.Medico.CRM + " - " + prontuario.Medico.Nome;
            textBox3.Text = prontuario.Paciente.CPF + " - " + prontuario.Medico.Nome;
            textBox1.Text = prontuario.DescricaoPaciente;
            textBox4.Text = prontuario.Diagnostico;
            textBox6.Text = prontuario.PrescricaoMedicamento;
            textBox5.Text = prontuario.PrescricaoTratamento;

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
                button5.Enabled = false;
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
                dateTimePicker1.Enabled = true;
                button2.Enabled = true;
                button5.Enabled = true;
                buttonExcluir.Enabled = true;
            }
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

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
            button5.Enabled = true;
            buttonExcluir.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox4.Text != "" && textBox6.Text != "" && textBox5.Text != "" &&
                dateTimePicker1.Value != null && consulta != null && paciente != null && medico != null)
            {
                prontuario.Consulta = consulta;
                prontuario.Medico = consulta.Medico;
                prontuario.Paciente = consulta.Paciente;
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != null || dateTimePicker1.Text == "")
            {
                Consulta c = ConsultaController.ConsultaC.search(dateTimePicker1.Value);
                if (c != null)
                {
                    consulta = c;
                    medico = c.Medico;
                    paciente = c.Paciente;
                    textBox2.Text = c.Medico.CRM + " - " + c.Medico.Nome;
                    textBox3.Text = c.Paciente.CPF + " - " + c.Paciente.Nome;

                    textBox2.ReadOnly = true;
                    textBox3.ReadOnly = true;
                    dateTimePicker1.Enabled = false;
                    button5.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Paciente não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProntuarioView_Load(object sender, EventArgs e)
        {

        }

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
    }
}
