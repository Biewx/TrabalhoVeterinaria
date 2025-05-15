namespace sistema_Patas_Cuidados
{
    partial class telaPets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaPets));
            pictureBox3 = new PictureBox();
            btnVerDiagnostico = new Button();
            lblTutor = new Label();
            lblEspecie = new Label();
            lblPet = new Label();
            pictureBox2 = new PictureBox();
            txtSintomas = new TextBox();
            lblConsultaN = new Label();
            lblDiagnostico = new Label();
            lblNomePet = new Label();
            lblEspecie2 = new Label();
            lblTutor2 = new Label();
            lblNumConsulta = new Label();
            btnVoltar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-5, 250);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(276, 316);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 49;
            pictureBox3.TabStop = false;
            // 
            // btnVerDiagnostico
            // 
            btnVerDiagnostico.BackColor = Color.Indigo;
            btnVerDiagnostico.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerDiagnostico.ForeColor = SystemColors.ButtonHighlight;
            btnVerDiagnostico.Location = new Point(609, 353);
            btnVerDiagnostico.Margin = new Padding(2);
            btnVerDiagnostico.Name = "btnVerDiagnostico";
            btnVerDiagnostico.Size = new Size(174, 50);
            btnVerDiagnostico.TabIndex = 46;
            btnVerDiagnostico.Text = "Ver Diagnóstico";
            btnVerDiagnostico.UseVisualStyleBackColor = false;
            btnVerDiagnostico.Click += btnVerDiagnostico_Click;
            // 
            // lblTutor
            // 
            lblTutor.AutoSize = true;
            lblTutor.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblTutor.Location = new Point(431, 109);
            lblTutor.Margin = new Padding(2, 0, 2, 0);
            lblTutor.Name = "lblTutor";
            lblTutor.Size = new Size(49, 19);
            lblTutor.TabIndex = 33;
            lblTutor.Text = "Tutor:";
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblEspecie.Location = new Point(681, 60);
            lblEspecie.Margin = new Padding(2, 0, 2, 0);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(72, 19);
            lblEspecie.TabIndex = 31;
            lblEspecie.Text = "Espécie:";
            // 
            // lblPet
            // 
            lblPet.AutoSize = true;
            lblPet.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblPet.Location = new Point(431, 61);
            lblPet.Margin = new Padding(2, 0, 2, 0);
            lblPet.Name = "lblPet";
            lblPet.Size = new Size(90, 19);
            lblPet.TabIndex = 29;
            lblPet.Text = "Nome pet:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-5, -2);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(292, 211);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(376, 178);
            txtSintomas.Margin = new Padding(2);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(1312, 23);
            txtSintomas.TabIndex = 60;
            // 
            // lblConsultaN
            // 
            lblConsultaN.AutoSize = true;
            lblConsultaN.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblConsultaN.Location = new Point(681, 109);
            lblConsultaN.Margin = new Padding(2, 0, 2, 0);
            lblConsultaN.Name = "lblConsultaN";
            lblConsultaN.Size = new Size(102, 19);
            lblConsultaN.TabIndex = 61;
            lblConsultaN.Text = "N° Consulta:";
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblDiagnostico.Location = new Point(290, 228);
            lblDiagnostico.Margin = new Padding(2, 0, 2, 0);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(104, 19);
            lblDiagnostico.TabIndex = 63;
            lblDiagnostico.Text = "Diagnóstico:";
            lblDiagnostico.Click += lblDiagnostico_Click;
            // 
            // lblNomePet
            // 
            lblNomePet.AutoSize = true;
            lblNomePet.Font = new Font("Segoe UI", 12F);
            lblNomePet.Location = new Point(525, 61);
            lblNomePet.Margin = new Padding(2, 0, 2, 0);
            lblNomePet.Name = "lblNomePet";
            lblNomePet.Size = new Size(52, 21);
            lblNomePet.TabIndex = 64;
            lblNomePet.Text = "label1";
            lblNomePet.Click += lblNomePet_Click;
            // 
            // lblEspecie2
            // 
            lblEspecie2.AutoSize = true;
            lblEspecie2.Font = new Font("Segoe UI", 12F);
            lblEspecie2.Location = new Point(757, 58);
            lblEspecie2.Margin = new Padding(2, 0, 2, 0);
            lblEspecie2.Name = "lblEspecie2";
            lblEspecie2.Size = new Size(52, 21);
            lblEspecie2.TabIndex = 65;
            lblEspecie2.Text = "label2";
            // 
            // lblTutor2
            // 
            lblTutor2.AutoSize = true;
            lblTutor2.Font = new Font("Segoe UI", 12F);
            lblTutor2.Location = new Point(484, 107);
            lblTutor2.Margin = new Padding(2, 0, 2, 0);
            lblTutor2.Name = "lblTutor2";
            lblTutor2.Size = new Size(52, 21);
            lblTutor2.TabIndex = 66;
            lblTutor2.Text = "label3";
            lblTutor2.Click += label3_Click;
            // 
            // lblNumConsulta
            // 
            lblNumConsulta.AutoSize = true;
            lblNumConsulta.Font = new Font("Segoe UI", 12F);
            lblNumConsulta.Location = new Point(787, 107);
            lblNumConsulta.Margin = new Padding(2, 0, 2, 0);
            lblNumConsulta.Name = "lblNumConsulta";
            lblNumConsulta.Size = new Size(52, 21);
            lblNumConsulta.TabIndex = 67;
            lblNumConsulta.Text = "label4";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Indigo;
            btnVoltar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = SystemColors.ButtonHighlight;
            btnVoltar.Location = new Point(969, 481);
            btnVoltar.Margin = new Padding(2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(174, 50);
            btnVoltar.TabIndex = 68;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(290, 177);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 69;
            label1.Text = "Sintomas:";
            // 
            // telaPets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1154, 542);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btnVoltar);
            Controls.Add(lblNumConsulta);
            Controls.Add(lblTutor2);
            Controls.Add(lblEspecie2);
            Controls.Add(lblNomePet);
            Controls.Add(lblDiagnostico);
            Controls.Add(lblConsultaN);
            Controls.Add(txtSintomas);
            Controls.Add(pictureBox3);
            Controls.Add(btnVerDiagnostico);
            Controls.Add(lblTutor);
            Controls.Add(lblEspecie);
            Controls.Add(lblPet);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "telaPets";
            Text = "Clínica Patas & Cuidados";
            Load += telaPets_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btListarTodos;
        private DataGridView dgvPets;
        private PictureBox pictureBox3;
        private Button btExcluir;
        private Button btEditar;
        private Button btnVerDiagnostico;
        private Label lblTutor;
        private Label lblEspecie;
        private Label lblPet;
        private PictureBox pictureBox2;
        private TextBox txtSintomas;
        private Label lblConsultaN;
        private Label lblDiagnostico;
        private Label lblNomePet;
        private Label lblEspecie2;
        private Label lblTutor2;
        private Label lblNumConsulta;
        private Button btnVoltar;
        private Label label1;
    }
}