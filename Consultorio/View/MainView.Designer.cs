namespace Consultorio
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prontuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.médicoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prontuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaLToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.prontuarioLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.procurarToolStripMenuItem,
            this.listasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.médicoToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.prontuárioToolStripMenuItem});
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.adicionarToolStripMenuItem.Text = "&Adicionar";
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.pacienteToolStripMenuItem.Text = "&Paciente";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // médicoToolStripMenuItem
            // 
            this.médicoToolStripMenuItem.Name = "médicoToolStripMenuItem";
            this.médicoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.médicoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.médicoToolStripMenuItem.Text = "&Médico";
            this.médicoToolStripMenuItem.Click += new System.EventHandler(this.médicoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.consultaToolStripMenuItem.Text = "&Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // prontuárioToolStripMenuItem
            // 
            this.prontuárioToolStripMenuItem.Name = "prontuárioToolStripMenuItem";
            this.prontuárioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.prontuárioToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.prontuárioToolStripMenuItem.Text = "&Prontuário";
            this.prontuárioToolStripMenuItem.Click += new System.EventHandler(this.prontuárioToolStripMenuItem_Click_1);
            // 
            // procurarToolStripMenuItem
            // 
            this.procurarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem1,
            this.médicoToolStripMenuItem1,
            this.consultaToolStripMenuItem1,
            this.prontuárioToolStripMenuItem1});
            this.procurarToolStripMenuItem.Name = "procurarToolStripMenuItem";
            this.procurarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.procurarToolStripMenuItem.Text = "&Procurar";
            // 
            // pacienteToolStripMenuItem1
            // 
            this.pacienteToolStripMenuItem1.Name = "pacienteToolStripMenuItem1";
            this.pacienteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.pacienteToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.pacienteToolStripMenuItem1.Text = "&Paciente";
            this.pacienteToolStripMenuItem1.Click += new System.EventHandler(this.pacienteToolStripMenuItem1_Click);
            // 
            // médicoToolStripMenuItem1
            // 
            this.médicoToolStripMenuItem1.Name = "médicoToolStripMenuItem1";
            this.médicoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.médicoToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.médicoToolStripMenuItem1.Text = "&Médico";
            this.médicoToolStripMenuItem1.Click += new System.EventHandler(this.médicoToolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.consultaToolStripMenuItem1.Text = "&Consulta";
            this.consultaToolStripMenuItem1.Click += new System.EventHandler(this.consultaToolStripMenuItem1_Click);
            // 
            // prontuárioToolStripMenuItem1
            // 
            this.prontuárioToolStripMenuItem1.Name = "prontuárioToolStripMenuItem1";
            this.prontuárioToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.prontuárioToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.prontuárioToolStripMenuItem1.Text = "&Prontuário";
            this.prontuárioToolStripMenuItem1.Click += new System.EventHandler(this.prontuárioToolStripMenuItem1_Click);
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteLToolStripMenuItem,
            this.medicoLToolStripMenuItem1,
            this.consultaLToolStripMenuItem2,
            this.prontuarioLToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.listasToolStripMenuItem.Text = "&Listas";
            // 
            // pacienteLToolStripMenuItem
            // 
            this.pacienteLToolStripMenuItem.Name = "pacienteLToolStripMenuItem";
            this.pacienteLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.pacienteLToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pacienteLToolStripMenuItem.Text = "&Paciente";
            this.pacienteLToolStripMenuItem.Click += new System.EventHandler(this.pacienteLToolStripMenuItem_Click);
            // 
            // medicoLToolStripMenuItem1
            // 
            this.medicoLToolStripMenuItem1.Name = "medicoLToolStripMenuItem1";
            this.medicoLToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.medicoLToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.medicoLToolStripMenuItem1.Text = "&Medico";
            this.medicoLToolStripMenuItem1.Click += new System.EventHandler(this.medicoLToolStripMenuItem1_Click);
            // 
            // consultaLToolStripMenuItem2
            // 
            this.consultaLToolStripMenuItem2.Name = "consultaLToolStripMenuItem2";
            this.consultaLToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.consultaLToolStripMenuItem2.Size = new System.Drawing.Size(167, 22);
            this.consultaLToolStripMenuItem2.Text = "&Consulta";
            this.consultaLToolStripMenuItem2.Click += new System.EventHandler(this.consultaLToolStripMenuItem2_Click);
            // 
            // prontuarioLToolStripMenuItem
            // 
            this.prontuarioLToolStripMenuItem.Name = "prontuarioLToolStripMenuItem";
            this.prontuarioLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.prontuarioLToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.prontuarioLToolStripMenuItem.Text = "&Prontuário";
            this.prontuarioLToolStripMenuItem.Click += new System.EventHandler(this.prontuarioLToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Consultorio.Imagens.flat_round_medical_icons_set_23_2147495494;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 419);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 443);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Consultório";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prontuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem médicoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prontuárioToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicoLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaLToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem prontuarioLToolStripMenuItem;
    }
}

