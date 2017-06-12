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
            this.patientList = new BrightIdeasSoftware.ObjectListView();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.editPatientButton = new System.Windows.Forms.Button();
            this.deletePatientButton = new System.Windows.Forms.Button();
            this.deleteMedicButton = new System.Windows.Forms.Button();
            this.editMedicButton = new System.Windows.Forms.Button();
            this.addMedicButton = new System.Windows.Forms.Button();
            this.medicList = new BrightIdeasSoftware.ObjectListView();
            this.deleteAppointmentButton = new System.Windows.Forms.Button();
            this.editAppointmentButton = new System.Windows.Forms.Button();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.deleteMedicalRecordButton = new System.Windows.Forms.Button();
            this.editMedicalRecordButton = new System.Windows.Forms.Button();
            this.addMedicalRecordButton = new System.Windows.Forms.Button();
            this.appointmentList = new BrightIdeasSoftware.ObjectListView();
            this.medicalRecordList = new BrightIdeasSoftware.ObjectListView();
            ((System.ComponentModel.ISupportInitialize)(this.patientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordList)).BeginInit();
            this.SuspendLayout();
            // 
            // patientList
            // 
            this.patientList.CellEditUseWholeCell = false;
            this.patientList.Cursor = System.Windows.Forms.Cursors.Default;
            this.patientList.Location = new System.Drawing.Point(12, 12);
            this.patientList.Name = "patientList";
            this.patientList.Size = new System.Drawing.Size(199, 236);
            this.patientList.TabIndex = 0;
            this.patientList.UseCompatibleStateImageBehavior = false;
            this.patientList.View = System.Windows.Forms.View.Details;
            // 
            // addPatientButton
            // 
            this.addPatientButton.Location = new System.Drawing.Point(218, 13);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(75, 36);
            this.addPatientButton.TabIndex = 1;
            this.addPatientButton.Text = "Adicionar Paciente";
            this.addPatientButton.UseVisualStyleBackColor = true;
            // 
            // editPatientButton
            // 
            this.editPatientButton.Location = new System.Drawing.Point(218, 55);
            this.editPatientButton.Name = "editPatientButton";
            this.editPatientButton.Size = new System.Drawing.Size(75, 36);
            this.editPatientButton.TabIndex = 2;
            this.editPatientButton.Text = "Editar Paciente";
            this.editPatientButton.UseVisualStyleBackColor = true;
            // 
            // deletePatientButton
            // 
            this.deletePatientButton.Location = new System.Drawing.Point(217, 97);
            this.deletePatientButton.Name = "deletePatientButton";
            this.deletePatientButton.Size = new System.Drawing.Size(75, 36);
            this.deletePatientButton.TabIndex = 3;
            this.deletePatientButton.Text = "Excluir Paciente";
            this.deletePatientButton.UseVisualStyleBackColor = true;
            // 
            // deleteMedicButton
            // 
            this.deleteMedicButton.Location = new System.Drawing.Point(504, 97);
            this.deleteMedicButton.Name = "deleteMedicButton";
            this.deleteMedicButton.Size = new System.Drawing.Size(75, 36);
            this.deleteMedicButton.TabIndex = 7;
            this.deleteMedicButton.Text = "Excluir Médico";
            this.deleteMedicButton.UseVisualStyleBackColor = true;
            // 
            // editMedicButton
            // 
            this.editMedicButton.Location = new System.Drawing.Point(505, 55);
            this.editMedicButton.Name = "editMedicButton";
            this.editMedicButton.Size = new System.Drawing.Size(75, 36);
            this.editMedicButton.TabIndex = 6;
            this.editMedicButton.Text = "Editar Médico";
            this.editMedicButton.UseVisualStyleBackColor = true;
            // 
            // addMedicButton
            // 
            this.addMedicButton.Location = new System.Drawing.Point(505, 13);
            this.addMedicButton.Name = "addMedicButton";
            this.addMedicButton.Size = new System.Drawing.Size(75, 36);
            this.addMedicButton.TabIndex = 5;
            this.addMedicButton.Text = "Adicionar Médico";
            this.addMedicButton.UseVisualStyleBackColor = true;
            // 
            // medicList
            // 
            this.medicList.CellEditUseWholeCell = false;
            this.medicList.Cursor = System.Windows.Forms.Cursors.Default;
            this.medicList.Location = new System.Drawing.Point(299, 12);
            this.medicList.Name = "medicList";
            this.medicList.Size = new System.Drawing.Size(199, 236);
            this.medicList.TabIndex = 4;
            this.medicList.UseCompatibleStateImageBehavior = false;
            this.medicList.View = System.Windows.Forms.View.Details;
            // 
            // deleteAppointmentButton
            // 
            this.deleteAppointmentButton.Location = new System.Drawing.Point(217, 356);
            this.deleteAppointmentButton.Name = "deleteAppointmentButton";
            this.deleteAppointmentButton.Size = new System.Drawing.Size(75, 36);
            this.deleteAppointmentButton.TabIndex = 11;
            this.deleteAppointmentButton.Text = "Excluir Consulta";
            this.deleteAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // editAppointmentButton
            // 
            this.editAppointmentButton.Location = new System.Drawing.Point(218, 314);
            this.editAppointmentButton.Name = "editAppointmentButton";
            this.editAppointmentButton.Size = new System.Drawing.Size(75, 36);
            this.editAppointmentButton.TabIndex = 10;
            this.editAppointmentButton.Text = "Editar Consulta";
            this.editAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.Location = new System.Drawing.Point(218, 272);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(75, 36);
            this.addAppointmentButton.TabIndex = 9;
            this.addAppointmentButton.Text = "Adicionar Consulta";
            this.addAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // deleteMedicalRecordButton
            // 
            this.deleteMedicalRecordButton.Location = new System.Drawing.Point(504, 356);
            this.deleteMedicalRecordButton.Name = "deleteMedicalRecordButton";
            this.deleteMedicalRecordButton.Size = new System.Drawing.Size(75, 36);
            this.deleteMedicalRecordButton.TabIndex = 15;
            this.deleteMedicalRecordButton.Text = "Excluir Prontuário";
            this.deleteMedicalRecordButton.UseVisualStyleBackColor = true;
            // 
            // editMedicalRecordButton
            // 
            this.editMedicalRecordButton.Location = new System.Drawing.Point(505, 314);
            this.editMedicalRecordButton.Name = "editMedicalRecordButton";
            this.editMedicalRecordButton.Size = new System.Drawing.Size(75, 36);
            this.editMedicalRecordButton.TabIndex = 14;
            this.editMedicalRecordButton.Text = "Editar Prontuário";
            this.editMedicalRecordButton.UseVisualStyleBackColor = true;
            // 
            // addMedicalRecordButton
            // 
            this.addMedicalRecordButton.Location = new System.Drawing.Point(505, 272);
            this.addMedicalRecordButton.Name = "addMedicalRecordButton";
            this.addMedicalRecordButton.Size = new System.Drawing.Size(75, 36);
            this.addMedicalRecordButton.TabIndex = 13;
            this.addMedicalRecordButton.Text = "Adicionar Prontuário";
            this.addMedicalRecordButton.UseVisualStyleBackColor = true;
            // 
            // appointmentList
            // 
            this.appointmentList.CellEditUseWholeCell = false;
            this.appointmentList.Cursor = System.Windows.Forms.Cursors.Default;
            this.appointmentList.Location = new System.Drawing.Point(12, 272);
            this.appointmentList.Name = "appointmentList";
            this.appointmentList.Size = new System.Drawing.Size(199, 236);
            this.appointmentList.TabIndex = 16;
            this.appointmentList.UseCompatibleStateImageBehavior = false;
            this.appointmentList.View = System.Windows.Forms.View.Details;
            // 
            // medicalRecordList
            // 
            this.medicalRecordList.CellEditUseWholeCell = false;
            this.medicalRecordList.Cursor = System.Windows.Forms.Cursors.Default;
            this.medicalRecordList.Location = new System.Drawing.Point(300, 272);
            this.medicalRecordList.Name = "medicalRecordList";
            this.medicalRecordList.Size = new System.Drawing.Size(199, 236);
            this.medicalRecordList.TabIndex = 17;
            this.medicalRecordList.UseCompatibleStateImageBehavior = false;
            this.medicalRecordList.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 517);
            this.Controls.Add(this.medicalRecordList);
            this.Controls.Add(this.appointmentList);
            this.Controls.Add(this.deleteMedicalRecordButton);
            this.Controls.Add(this.editMedicalRecordButton);
            this.Controls.Add(this.addMedicalRecordButton);
            this.Controls.Add(this.deleteAppointmentButton);
            this.Controls.Add(this.editAppointmentButton);
            this.Controls.Add(this.addAppointmentButton);
            this.Controls.Add(this.deleteMedicButton);
            this.Controls.Add(this.editMedicButton);
            this.Controls.Add(this.addMedicButton);
            this.Controls.Add(this.medicList);
            this.Controls.Add(this.deletePatientButton);
            this.Controls.Add(this.editPatientButton);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.patientList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Consultorio";
            ((System.ComponentModel.ISupportInitialize)(this.patientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView patientList;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button editPatientButton;
        private System.Windows.Forms.Button deletePatientButton;
        private System.Windows.Forms.Button deleteMedicButton;
        private System.Windows.Forms.Button editMedicButton;
        private System.Windows.Forms.Button addMedicButton;
        private BrightIdeasSoftware.ObjectListView medicList;
        private System.Windows.Forms.Button deleteAppointmentButton;
        private System.Windows.Forms.Button editAppointmentButton;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.Button deleteMedicalRecordButton;
        private System.Windows.Forms.Button editMedicalRecordButton;
        private System.Windows.Forms.Button addMedicalRecordButton;
        private BrightIdeasSoftware.ObjectListView appointmentList;
        private BrightIdeasSoftware.ObjectListView medicalRecordList;
    }
}

