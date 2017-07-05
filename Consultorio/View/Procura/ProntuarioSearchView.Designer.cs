namespace Consultorio.View
{
    partial class ProntuarioSearchView
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
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.Data = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Paciente = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.medicoSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.consultoríoDataSet = new Consultorio.ConsultoríoDataSet();
            this.medicoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.medicoSetTableAdapter = new Consultorio.ConsultoríoDataSetTableAdapters.MedicoSetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoríoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Dia:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(363, 20);
            this.dateTimePicker1.TabIndex = 71;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.Data);
            this.objectListView1.AllColumns.Add(this.Paciente);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Data,
            this.Paciente});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.Location = new System.Drawing.Point(112, 63);
            this.objectListView1.MultiSelect = false;
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(363, 119);
            this.objectListView1.TabIndex = 70;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // Data
            // 
            this.Data.AspectName = "DataConsulta";
            this.Data.AspectToStringFormat = "";
            this.Data.Text = "Data";
            this.Data.Width = 116;
            // 
            // Paciente
            // 
            this.Paciente.AspectName = "Paciente.Nome";
            this.Paciente.Text = "Paciente";
            this.Paciente.Width = 242;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medicoSetBindingSource1, "CRM", true));
            this.comboBox1.DataSource = this.medicoSetBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(363, 21);
            this.comboBox1.TabIndex = 69;
            this.comboBox1.ValueMember = "CRM";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // medicoSetBindingSource1
            // 
            this.medicoSetBindingSource1.DataMember = "MedicoSet";
            this.medicoSetBindingSource1.DataSource = this.consultoríoDataSet;
            // 
            // consultoríoDataSet
            // 
            this.consultoríoDataSet.DataSetName = "ConsultoríoDataSet";
            this.consultoríoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicoSetBindingSource
            // 
            this.medicoSetBindingSource.DataMember = "MedicoSet";
            this.medicoSetBindingSource.DataSource = this.consultoríoDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Médico:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 65;
            this.checkBox1.Text = "Ativar edição";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(319, 188);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 66;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(400, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 67;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Consultas:";
            // 
            // medicoSetTableAdapter
            // 
            this.medicoSetTableAdapter.ClearBeforeFill = true;
            // 
            // ProntuarioSearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 220);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProntuarioSearchView";
            this.Text = "Procurar Prontuário";
            this.Load += new System.EventHandler(this.ProntuarioSearchView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoríoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn Data;
        private BrightIdeasSoftware.OLVColumn Paciente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private ConsultoríoDataSet consultoríoDataSet;
        private System.Windows.Forms.BindingSource medicoSetBindingSource;
        private ConsultoríoDataSetTableAdapters.MedicoSetTableAdapter medicoSetTableAdapter;
        private System.Windows.Forms.BindingSource medicoSetBindingSource1;
    }
}