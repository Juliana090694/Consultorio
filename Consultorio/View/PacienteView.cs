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
    public partial class PacienteView : Form
    {
        private Paciente paciente;

        public bool isEditable = true;
        public bool isUpdating = false;

        public PacienteView()
        {
            InitializeComponent();
        }

        //Seta os campos para nova adição
        public void setComponents()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)c).ReadOnly = false;
                }
            }
            button2.Enabled = true;

            paciente = new Model.Paciente();
        }

        //Seta os campos com os valores e em seguida para edição ou visualização
        public void setComponents(Paciente paciente, bool isEditable)
        {
            textBox1.Text = paciente.Carteirinha;
            textBox2.Text = paciente.Nome;
            textBox3.Text = paciente.CPF;
            textBox4.Text = paciente.RG;
            textBox5.Text = paciente.Idade.ToString();
            textBox6.Text = paciente.Email;
            textBox7.Text = paciente.Telefone;

            this.paciente = paciente;

            if (!isEditable)
            {
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        ((TextBox)c).ReadOnly = true;
                    }
                }
                button2.Enabled = false;
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        ((TextBox)c).ReadOnly = false;
                    }
                }
                button2.Enabled = true;
                buttonExcluir.Enabled = true;
            }
        }

        //Verifica se os campos são nulos ou não, se não for preenche o modelo, verifica se edita ou não
        //No fim envia para adição ou edição
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&
                textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" &&
                textBox7.Text != "")
            {
                int idade;

                paciente.Nome = textBox2.Text;
                paciente.Carteirinha = textBox1.Text;
                paciente.CPF = textBox3.Text;
                paciente.RG = textBox4.Text;
                if (int.TryParse(textBox5.Text, out idade))
                {
                    paciente.Idade = idade;
                    paciente.Email = textBox6.Text;
                    paciente.Telefone = textBox7.Text;

                    if (isEditable && !isUpdating)
                        PacienteController.PacienteC.add(paciente);
                    else if (isEditable && isUpdating)
                        PacienteController.PacienteC.update(paciente);
                    clearBoxes();
                    Program.closePaciente();
                }
                else
                {
                    MessageBox.Show("Dados inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            buttonExcluir.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearBoxes();
        }

        private void PacienteView_Load(object sender, EventArgs e)
        {

        }

        //Exclui o registro, confirmando antes ou não
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja realmente excluir esse registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    PacienteController.PacienteC.delete(paciente.Id);
                    clearBoxes();
                    Program.closePaciente();
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Não foi possível excluir pois algum cadastro ainda depende do registro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
