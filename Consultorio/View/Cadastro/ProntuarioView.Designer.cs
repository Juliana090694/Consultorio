﻿using System.Windows.Forms;

namespace Consultorio.View
{
    partial class ProntuarioView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.medicoSetBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.consultoríoDataSet = new Consultorio.ConsultoríoDataSet();
            this.medicoSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.medicoSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.medicoSetTableAdapter = new Consultorio.ConsultoríoDataSetTableAdapters.MedicoSetTableAdapter();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.Data = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medicoSetBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoríoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 188);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(485, 78);
            this.textBox1.TabIndex = 67;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 63;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(579, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Descrição Paciente:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(169, 272);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(485, 78);
            this.textBox4.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Diagnóstico:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(169, 440);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(485, 78);
            this.textBox5.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Prescrição Tratamento:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(169, 356);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(485, 78);
            this.textBox6.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Prescrição Medicamento:";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Enabled = false;
            this.buttonExcluir.Location = new System.Drawing.Point(12, 543);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 77;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Dia:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(485, 20);
            this.dateTimePicker1.TabIndex = 85;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // medicoSetBindingSource3
            // 
            this.medicoSetBindingSource3.DataMember = "MedicoSet";
            this.medicoSetBindingSource3.DataSource = this.consultoríoDataSet;
            // 
            // consultoríoDataSet
            // 
            this.consultoríoDataSet.DataSetName = "ConsultoríoDataSet";
            this.consultoríoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicoSetBindingSource2
            // 
            this.medicoSetBindingSource2.DataMember = "MedicoSet";
            this.medicoSetBindingSource2.DataSource = this.consultoríoDataSet;
            // 
            // medicoSetBindingSource1
            // 
            this.medicoSetBindingSource1.DataMember = "MedicoSet";
            this.medicoSetBindingSource1.DataSource = this.consultoríoDataSet;
            // 
            // medicoSetBindingSource
            // 
            this.medicoSetBindingSource.DataMember = "MedicoSet";
            this.medicoSetBindingSource.DataSource = this.consultoríoDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Consultas:";
            // 
            // medicoSetTableAdapter
            // 
            this.medicoSetTableAdapter.ClearBeforeFill = true;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.Data);
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Data,
            this.olvColumn1});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.Location = new System.Drawing.Point(169, 64);
            this.objectListView1.MultiSelect = false;
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(485, 118);
            this.objectListView1.TabIndex = 87;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // Data
            // 
            this.Data.AspectName = "DataConsulta";
            this.Data.Text = "Data Consulta";
            this.Data.Width = 154;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Paciente.Nome";
            this.olvColumn1.Text = "Paciente";
            this.olvColumn1.Width = 273;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(557, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 21);
            this.button3.TabIndex = 90;
            this.button3.Text = "Procurar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(382, 20);
            this.textBox2.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Médico (CRM):";
            // 
            // ProntuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 578);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProntuarioView";
            this.Text = "Prontuário";
            this.Load += new System.EventHandler(this.ProntuarioView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicoSetBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoríoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private Button buttonExcluir;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private ConsultoríoDataSet consultoríoDataSet;
        private BindingSource medicoSetBindingSource;
        private ConsultoríoDataSetTableAdapters.MedicoSetTableAdapter medicoSetTableAdapter;
        private BindingSource medicoSetBindingSource1;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn Data;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BindingSource medicoSetBindingSource3;
        private BindingSource medicoSetBindingSource2;
        private Button button3;
        private TextBox textBox2;
        private Label label2;
    }
}