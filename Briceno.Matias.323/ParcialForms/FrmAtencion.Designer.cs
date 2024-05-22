namespace ParcialForms
{
    partial class FrmAtencion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAtender = new Button();
            btnSalir = new Button();
            lblMedicos = new Label();
            lblPacientes = new Label();
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            rtbInfoMedico = new RichTextBox();
            SuspendLayout();
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(626, 45);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(162, 73);
            btnAtender.TabIndex = 0;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(626, 447);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(162, 73);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedicos.Location = new Point(30, 9);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(106, 17);
            lblMedicos.TabIndex = 2;
            lblMedicos.Text = "Personal Medico";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPacientes.Location = new Point(359, 9);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(62, 17);
            lblPacientes.TabIndex = 3;
            lblPacientes.Text = "Pacientes";
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(30, 45);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(270, 259);
            lstMedicos.TabIndex = 4;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(359, 45);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(243, 259);
            lstPacientes.TabIndex = 5;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(30, 319);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.ReadOnly = true;
            rtbInfoMedico.Size = new Size(572, 201);
            rtbInfoMedico.TabIndex = 6;
            rtbInfoMedico.Text = "";
            // 
            // FrmAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(rtbInfoMedico);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Name = "FrmAtencion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atencion de pacientes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtender;
        private Button btnSalir;
        private Label lblMedicos;
        private Label lblPacientes;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private RichTextBox rtbInfoMedico;
    }
}
