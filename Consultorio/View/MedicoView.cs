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
    public partial class MedicoView : Form
    {
        private Medico medico;

        public bool isEditable = true;
        public bool isUpdating = false;

        public MedicoView()
        {
            InitializeComponent();
        }

        //Seta componentes em caso de novo registro
        public void setComponents()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = false;
                }
            }
            medico = new Model.Medico();
            button2.Enabled = true;
        }

        //Preeenche os campos e edita ou visualiza de acordo
        public void setComponents(Medico medico, bool isEditable)
        {
            textBox1.Text = medico.Nome;
            textBox2.Text = medico.CRM;
            textBox3.Text = medico.CPF;
            textBox4.Text = medico.RG;
            textBox5.Text = medico.Idade.ToString();
            textBox6.Text = medico.Email;
            textBox7.Text = medico.Telefone;
            textBox8.Text = medico.Especializacao;

            this.medico = medico;

            if (!isEditable)
            {
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
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
                    if (c is TextBox)
                    {
                        ((TextBox)c).ReadOnly = false;
                    }
                }
                button2.Enabled = true;
                buttonExcluir.Enabled = true;
            }
        }

        //Verifica se os campos são nulos ou não
        //Preenche de acordo o modelo e envia ou atualiza o banco
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&
                textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" &&
                textBox7.Text != "" && textBox8.Text != "")
            {
                int idade;

                medico.Nome = textBox1.Text;
                medico.CRM = textBox2.Text;
                medico.CPF = textBox3.Text;
                medico.RG = textBox4.Text;
                if (int.TryParse(textBox5.Text, out idade))
                {
                    medico.Idade = idade;
                    medico.Email = textBox6.Text;
                    medico.Telefone = textBox7.Text;
                    medico.Especializacao = textBox8.Text;

                    if (isEditable && !isUpdating)
                        MedicoController.MedicoC.add(medico);
                    else if (isEditable && isUpdating)
                        MedicoController.MedicoC.update(medico);
                    clearBoxes();
                    Program.closeMedico();
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

        private void MedicoView_Load(object sender, EventArgs e)
        {

        }
        
        //Botão de excluir que confirma e exclui o aberto
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja realmente excluir esse registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    MedicoController.MedicoC.delete(medico.Id);
                    clearBoxes();
                    Program.closeMedico();
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Não foi possível excluir pois algum cadastro ainda depende do registro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
