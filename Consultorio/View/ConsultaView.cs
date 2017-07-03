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
    public partial class ConsultaView : Form
    {
        private Consulta consulta;

        private Medico medico;
        private Paciente paciente;

        public bool isEditable = true;
        public bool isUpdating = false;

        public ConsultaView()
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
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            this.dateTimePicker1.MinDate = DateTime.Today;
            consulta = new Consulta();
        }

        public void setComponents(Consulta consulta, bool isEditable)
        {
            this.dateTimePicker1.MinDate = new DateTime(1753,01,02,00,00,00);
            dateTimePicker1.Value = consulta.DataConsulta;
            textBox2.Text = consulta.Medico.CRM + " - " + consulta.Medico.Nome;
            textBox3.Text = consulta.Paciente.CPF + " - " + consulta.Paciente.Nome;
            textBox1.Text = consulta.Motivo;
            medico = consulta.Medico;
            paciente = consulta.Paciente;
            

            this.consulta = consulta;

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
                button3.Enabled = false;
                button4.Enabled = false;
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
                button3.Enabled = true;
                button4.Enabled = true;
                buttonExcluir.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && medico != null && paciente != null && dateTimePicker1.Value != null)
            {
                consulta.DataConsulta = dateTimePicker1.Value;
                consulta.Medico = medico;
                consulta.Paciente = paciente;
                consulta.Motivo = textBox1.Text;


                Consulta c = ConsultaController.ConsultaC.search(dateTimePicker1.Value);
                if (c != null && c.Medico.CRM == medico.CRM)
                {
                    MessageBox.Show("Essa data já está marcada para outra consulta com o mesmo médico!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateTimePicker1.Focus();
                }
                else
                {
                    if (isEditable && !isUpdating)
                        ConsultaController.ConsultaC.add(consulta);
                    else if (isEditable && isUpdating)
                        ConsultaController.ConsultaC.update(consulta);
                    clearBoxes();
                    Program.closeConsulta();
                }
                
                
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                Paciente p = PacienteController.PacienteC.search(textBox3.Text);
                if (p != null)
                {
                    textBox3.Text = p.CPF + " - " + p.Nome;
                    paciente = p;
                    textBox3.ReadOnly = true;
                    button4.Enabled = false;
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

        public void clearBoxes()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)(c)).Text = string.Empty;
                }
            }
            button3.Enabled = true;
            button4.Enabled = true;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            medico = null;
            paciente = null;
            dateTimePicker1.Value = DateTime.Today;
            buttonExcluir.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearBoxes();
        }

        private void ConsultaView_Load(object sender, EventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja realmente excluir esse registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try{
                    ConsultaController.ConsultaC.delete(consulta.Id);
                    clearBoxes();
                    Program.closeConsulta();
                }
                catch(Exception e1)
                {
                    MessageBox.Show("Não foi possível excluir pois algum cadastro ainda depende do registro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (isEditable && !isUpdating)
            {
                if (dateTimePicker1.Value.Minute != 0 && dateTimePicker1.Value.Minute != 30)
                {
                    MessageBox.Show("Só é possível marcar consultas de meia em meia hora (0 e 30)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateTimePicker1.Focus();
                }
            }
        }
    }
}
