namespace sistema_Patas_Cuidados
{
    partial class telaConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaConsultas));
            pictureBox2 = new PictureBox();
            lblPet = new Label();
            txtPet = new TextBox();
            lblEspecie = new Label();
            txtEspecie = new TextBox();
            lblTutor = new Label();
            txtTutor = new TextBox();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            lblVeterinario = new Label();
            txtVeterinario = new TextBox();
            lblData = new Label();
            txtData = new MaskedTextBox();
            lblContato = new Label();
            txtContato = new TextBox();
            lblHora = new Label();
            txtHorario = new MaskedTextBox();
            btConsultar = new Button();
            btAgendar = new Button();
            btExcluir = new Button();
            pictureBox3 = new PictureBox();
            dgvConsultas = new DataGridView();
            lblID = new Label();
            txtNumeroConsulta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-3, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(292, 211);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lblPet
            // 
            lblPet.AutoSize = true;
            lblPet.Location = new Point(274, 200);
            lblPet.Name = "lblPet";
            lblPet.Size = new Size(68, 16);
            lblPet.TabIndex = 2;
            lblPet.Text = "Nome pet:";
            // 
            // txtPet
            // 
            txtPet.Location = new Point(274, 225);
            txtPet.Name = "txtPet";
            txtPet.Size = new Size(420, 22);
            txtPet.TabIndex = 3;
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Location = new Point(729, 200);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(56, 16);
            lblEspecie.TabIndex = 4;
            lblEspecie.Text = "Espécie:";
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(729, 225);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(286, 22);
            txtEspecie.TabIndex = 5;
            // 
            // lblTutor
            // 
            lblTutor.AutoSize = true;
            lblTutor.Location = new Point(274, 257);
            lblTutor.Name = "lblTutor";
            lblTutor.Size = new Size(38, 16);
            lblTutor.TabIndex = 6;
            lblTutor.Text = "Tutor:";
            // 
            // txtTutor
            // 
            txtTutor.Location = new Point(274, 282);
            txtTutor.Name = "txtTutor";
            txtTutor.Size = new Size(420, 22);
            txtTutor.TabIndex = 7;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(729, 373);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(102, 16);
            lblMotivo.TabIndex = 8;
            lblMotivo.Text = "Motivo consulta:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(729, 398);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(286, 22);
            txtMotivo.TabIndex = 9;
            // 
            // lblVeterinario
            // 
            lblVeterinario.AutoSize = true;
            lblVeterinario.Location = new Point(274, 315);
            lblVeterinario.Name = "lblVeterinario";
            lblVeterinario.Size = new Size(74, 16);
            lblVeterinario.TabIndex = 10;
            lblVeterinario.Text = "Veterinário:";
            // 
            // txtVeterinario
            // 
            txtVeterinario.Location = new Point(274, 340);
            txtVeterinario.Name = "txtVeterinario";
            txtVeterinario.Size = new Size(420, 22);
            txtVeterinario.TabIndex = 11;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(274, 373);
            lblData.Name = "lblData";
            lblData.Size = new Size(37, 16);
            lblData.TabIndex = 12;
            lblData.Text = "Data:";
            // 
            // txtData
            // 
            txtData.Location = new Point(274, 398);
            txtData.Mask = "00/00/0000";
            txtData.Name = "txtData";
            txtData.Size = new Size(111, 22);
            txtData.TabIndex = 13;
            txtData.ValidatingType = typeof(DateTime);
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(729, 257);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(56, 16);
            lblContato.TabIndex = 14;
            lblContato.Text = "Contato:";
            // 
            // txtContato
            // 
            txtContato.Location = new Point(729, 282);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(286, 22);
            txtContato.TabIndex = 15;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(509, 373);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(53, 16);
            lblHora.TabIndex = 16;
            lblHora.Text = "Horário:";
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(509, 398);
            txtHorario.Mask = "00:00";
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(111, 22);
            txtHorario.TabIndex = 17;
            txtHorario.ValidatingType = typeof(DateTime);
            // 
            // btConsultar
            // 
            btConsultar.BackColor = Color.Indigo;
            btConsultar.ForeColor = SystemColors.ButtonHighlight;
            btConsultar.Location = new Point(582, 457);
            btConsultar.Name = "btConsultar";
            btConsultar.Size = new Size(112, 34);
            btConsultar.TabIndex = 18;
            btConsultar.Text = "Consultar";
            btConsultar.UseVisualStyleBackColor = false;
            // 
            // btAgendar
            // 
            btAgendar.BackColor = Color.Indigo;
            btAgendar.ForeColor = SystemColors.ButtonHighlight;
            btAgendar.Location = new Point(320, 457);
            btAgendar.Name = "btAgendar";
            btAgendar.Size = new Size(112, 34);
            btAgendar.TabIndex = 19;
            btAgendar.Text = "Agendar";
            btAgendar.UseVisualStyleBackColor = false;
            btAgendar.Click += btAgendar_Click;
            // 
            // btExcluir
            // 
            btExcluir.BackColor = Color.Indigo;
            btExcluir.ForeColor = SystemColors.ButtonHighlight;
            btExcluir.Location = new Point(852, 457);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(112, 34);
            btExcluir.TabIndex = 21;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-8, 244);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(276, 316);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // dgvConsultas
            // 
            dgvConsultas.BackgroundColor = SystemColors.ButtonFace;
            dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultas.Location = new Point(320, 24);
            dgvConsultas.Name = "dgvConsultas";
            dgvConsultas.RowHeadersWidth = 62;
            dgvConsultas.Size = new Size(782, 173);
            dgvConsultas.TabIndex = 23;
            dgvConsultas.CellContentDoubleClick += dgvConsultas_CellDoubleClick;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(729, 315);
            lblID.Name = "lblID";
            lblID.Size = new Size(77, 16);
            lblID.TabIndex = 26;
            lblID.Text = "N° Consulta:";
            lblID.TextAlign = ContentAlignment.TopCenter;
            lblID.Click += lblID_Click;
            // 
            // txtNumeroConsulta
            // 
            txtNumeroConsulta.Location = new Point(729, 340);
            txtNumeroConsulta.Name = "txtNumeroConsulta";
            txtNumeroConsulta.Size = new Size(286, 22);
            txtNumeroConsulta.TabIndex = 27;
            // 
            // telaConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1154, 542);
            Controls.Add(txtNumeroConsulta);
            Controls.Add(lblID);
            Controls.Add(dgvConsultas);
            Controls.Add(pictureBox3);
            Controls.Add(btExcluir);
            Controls.Add(btAgendar);
            Controls.Add(btConsultar);
            Controls.Add(txtHorario);
            Controls.Add(lblHora);
            Controls.Add(txtContato);
            Controls.Add(lblContato);
            Controls.Add(txtData);
            Controls.Add(lblData);
            Controls.Add(txtVeterinario);
            Controls.Add(lblVeterinario);
            Controls.Add(txtMotivo);
            Controls.Add(lblMotivo);
            Controls.Add(txtTutor);
            Controls.Add(lblTutor);
            Controls.Add(txtEspecie);
            Controls.Add(lblEspecie);
            Controls.Add(txtPet);
            Controls.Add(lblPet);
            Controls.Add(pictureBox2);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "telaConsultas";
            Text = "Clínica Patas & Cuidados";
            Load += telaPrinciapal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label lblPet;
        private TextBox txtPet;
        private Label lblEspecie;
        private TextBox txtEspecie;
        private Label lblTutor;
        private TextBox txtTutor;
        private Label lblMotivo;
        private TextBox txtMotivo;
        private Label lblVeterinario;
        private TextBox txtVeterinario;
        private Label lblData;
        private MaskedTextBox txtData;
        private Label lblContato;
        private TextBox txtContato;
        private Label lblHora;
        private MaskedTextBox txtHorario;
        private Button btConsultar;
        private Button btAgendar;
        private Button btExcluir;
        private PictureBox pictureBox3;
        private DataGridView dgvConsultas;
        private Label lblID;
        private TextBox txtNumeroConsulta;
    }
}