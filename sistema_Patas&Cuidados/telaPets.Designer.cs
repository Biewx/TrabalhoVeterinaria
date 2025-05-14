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
            dgvPets = new DataGridView();
            pictureBox3 = new PictureBox();
            btSalvar = new Button();
            btLimpar = new Button();
            lblTutor = new Label();
            lblEspecie = new Label();
            lblPet = new Label();
            pictureBox2 = new PictureBox();
            lblSintomas = new Label();
            txtSintomas = new TextBox();
            lblConsultaN = new Label();
            lblDiagnostico = new Label();
            btTelaConsulta = new Button();
            lblNomePet = new Label();
            lblTutor2 = new Label();
            lblEspecie2 = new Label();
            lblNumConsulta = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvPets
            // 
            dgvPets.BackgroundColor = SystemColors.ButtonFace;
            dgvPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPets.Location = new Point(283, 14);
            dgvPets.Name = "dgvPets";
            dgvPets.RowHeadersWidth = 62;
            dgvPets.Size = new Size(741, 145);
            dgvPets.TabIndex = 50;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1, 376);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(276, 310);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 49;
            pictureBox3.TabStop = false;
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.Indigo;
            btSalvar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSalvar.ForeColor = SystemColors.ButtonHighlight;
            btSalvar.Location = new Point(507, 548);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(112, 34);
            btSalvar.TabIndex = 46;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            // 
            // btLimpar
            // 
            btLimpar.BackColor = Color.Indigo;
            btLimpar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLimpar.ForeColor = SystemColors.ButtonHighlight;
            btLimpar.Location = new Point(743, 548);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(112, 34);
            btLimpar.TabIndex = 45;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = false;
            // 
            // lblTutor
            // 
            lblTutor.AutoSize = true;
            lblTutor.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTutor.Location = new Point(283, 265);
            lblTutor.Name = "lblTutor";
            lblTutor.Size = new Size(57, 22);
            lblTutor.TabIndex = 33;
            lblTutor.Text = "Tutor:";
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEspecie.Location = new Point(738, 183);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(84, 22);
            lblEspecie.TabIndex = 31;
            lblEspecie.Text = "Espécie:";
            // 
            // lblPet
            // 
            lblPet.AutoSize = true;
            lblPet.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPet.Location = new Point(283, 183);
            lblPet.Name = "lblPet";
            lblPet.Size = new Size(103, 22);
            lblPet.TabIndex = 29;
            lblPet.Text = "Nome pet:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(275, 251);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSintomas.Location = new Point(283, 353);
            lblSintomas.Name = "lblSintomas";
            lblSintomas.Size = new Size(93, 22);
            lblSintomas.TabIndex = 59;
            lblSintomas.Text = "Sintomas:";
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(283, 378);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(741, 31);
            txtSintomas.TabIndex = 60;
            // 
            // lblConsultaN
            // 
            lblConsultaN.AutoSize = true;
            lblConsultaN.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultaN.Location = new Point(738, 265);
            lblConsultaN.Name = "lblConsultaN";
            lblConsultaN.Size = new Size(117, 22);
            lblConsultaN.TabIndex = 61;
            lblConsultaN.Text = "N° Consulta:";
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiagnostico.Location = new Point(283, 435);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(120, 22);
            lblDiagnostico.TabIndex = 63;
            lblDiagnostico.Text = "Diagnóstico:";
            // 
            // btTelaConsulta
            // 
            btTelaConsulta.BackColor = Color.Indigo;
            btTelaConsulta.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTelaConsulta.ForeColor = SystemColors.ButtonHighlight;
            btTelaConsulta.Location = new Point(78, 290);
            btTelaConsulta.Name = "btTelaConsulta";
            btTelaConsulta.Size = new Size(112, 34);
            btTelaConsulta.TabIndex = 51;
            btTelaConsulta.Text = "Consultas";
            btTelaConsulta.UseVisualStyleBackColor = false;
            // 
            // lblNomePet
            // 
            lblNomePet.AutoSize = true;
            lblNomePet.Location = new Point(392, 183);
            lblNomePet.Name = "lblNomePet";
            lblNomePet.Size = new Size(59, 25);
            lblNomePet.TabIndex = 64;
            lblNomePet.Text = "label1";
            // 
            // lblTutor2
            // 
            lblTutor2.AutoSize = true;
            lblTutor2.Location = new Point(828, 183);
            lblTutor2.Name = "lblTutor2";
            lblTutor2.Size = new Size(59, 25);
            lblTutor2.TabIndex = 65;
            lblTutor2.Text = "label2";
            // 
            // lblEspecie2
            // 
            lblEspecie2.AutoSize = true;
            lblEspecie2.Location = new Point(344, 262);
            lblEspecie2.Name = "lblEspecie2";
            lblEspecie2.Size = new Size(59, 25);
            lblEspecie2.TabIndex = 66;
            lblEspecie2.Text = "label3";
            lblEspecie2.Click += label3_Click;
            // 
            // lblNumConsulta
            // 
            lblNumConsulta.AutoSize = true;
            lblNumConsulta.Location = new Point(861, 265);
            lblNumConsulta.Name = "lblNumConsulta";
            lblNumConsulta.Size = new Size(59, 25);
            lblNumConsulta.TabIndex = 67;
            lblNumConsulta.Text = "label4";
            // 
            // telaPets
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1154, 670);
            Controls.Add(lblNumConsulta);
            Controls.Add(lblEspecie2);
            Controls.Add(lblTutor2);
            Controls.Add(lblNomePet);
            Controls.Add(lblDiagnostico);
            Controls.Add(lblConsultaN);
            Controls.Add(txtSintomas);
            Controls.Add(lblSintomas);
            Controls.Add(btTelaConsulta);
            Controls.Add(dgvPets);
            Controls.Add(pictureBox3);
            Controls.Add(btSalvar);
            Controls.Add(btLimpar);
            Controls.Add(lblTutor);
            Controls.Add(lblEspecie);
            Controls.Add(lblPet);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "telaPets";
            Text = "Clínica Patas & Cuidados";
            Load += telaPets_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
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
        private Button btSalvar;
        private Button btLimpar;
        private Label lblTutor;
        private Label lblEspecie;
        private Label lblPet;
        private PictureBox pictureBox2;
        private Label lblSintomas;
        private TextBox txtSintomas;
        private Label lblConsultaN;
        private Label lblDiagnostico;
        private Button btTelaConsulta;
        private Label lblNomePet;
        private Label lblTutor2;
        private Label lblEspecie2;
        private Label lblNumConsulta;
    }
}