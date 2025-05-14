namespace sistema_Patas_Cuidados
{
    partial class telaPrinciapal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaPrinciapal));
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
            btEditar = new Button();
            btExcluir = new Button();
            pictureBox3 = new PictureBox();
            dgvConsultas = new DataGridView();
            btlistar = new Button();
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
            pictureBox2.Location = new Point(12, 8);
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
            lblPet.Size = new Size(103, 22);
            lblPet.TabIndex = 2;
            lblPet.Text = "Nome pet:";
            // 
            // txtPet
            // 
            txtPet.Location = new Point(274, 225);
            txtPet.Name = "txtPet";
            txtPet.Size = new Size(420, 30);
            txtPet.TabIndex = 3;
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Location = new Point(729, 200);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(84, 22);
            lblEspecie.TabIndex = 4;
            lblEspecie.Text = "Espécie:";
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(729, 225);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(286, 30);
            txtEspecie.TabIndex = 5;
            // 
            // lblTutor
            // 
            lblTutor.AutoSize = true;
            lblTutor.Location = new Point(274, 274);
            lblTutor.Name = "lblTutor";
            lblTutor.Size = new Size(57, 22);
            lblTutor.TabIndex = 6;
            lblTutor.Text = "Tutor:";
            // 
            // txtTutor
            // 
            txtTutor.Location = new Point(274, 299);
            txtTutor.Name = "txtTutor";
            txtTutor.Size = new Size(420, 30);
            txtTutor.TabIndex = 7;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(729, 443);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(154, 22);
            lblMotivo.TabIndex = 8;
            lblMotivo.Text = "Motivo consulta:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(729, 468);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(286, 30);
            txtMotivo.TabIndex = 9;
            // 
            // lblVeterinario
            // 
            lblVeterinario.AutoSize = true;
            lblVeterinario.Location = new Point(274, 361);
            lblVeterinario.Name = "lblVeterinario";
            lblVeterinario.Size = new Size(111, 22);
            lblVeterinario.TabIndex = 10;
            lblVeterinario.Text = "Veterinário:";
            // 
            // txtVeterinario
            // 
            txtVeterinario.Location = new Point(274, 386);
            txtVeterinario.Name = "txtVeterinario";
            txtVeterinario.Size = new Size(420, 30);
            txtVeterinario.TabIndex = 11;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(274, 443);
            lblData.Name = "lblData";
            lblData.Size = new Size(57, 22);
            lblData.TabIndex = 12;
            lblData.Text = "Data:";
            // 
            // txtData
            // 
            txtData.Location = new Point(274, 468);
            txtData.Mask = "00/00/0000";
            txtData.Name = "txtData";
            txtData.Size = new Size(111, 30);
            txtData.TabIndex = 13;
            txtData.ValidatingType = typeof(DateTime);
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(729, 274);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(86, 22);
            lblContato.TabIndex = 14;
            lblContato.Text = "Contato:";
            // 
            // txtContato
            // 
            txtContato.Location = new Point(729, 299);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(286, 30);
            txtContato.TabIndex = 15;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(509, 443);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(79, 22);
            lblHora.TabIndex = 16;
            lblHora.Text = "Horário:";
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(509, 468);
            txtHorario.Mask = "00:00";
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(111, 30);
            txtHorario.TabIndex = 17;
            txtHorario.ValidatingType = typeof(DateTime);
            // 
            // btConsultar
            // 
            btConsultar.BackColor = Color.Indigo;
            btConsultar.ForeColor = SystemColors.ButtonHighlight;
            btConsultar.Location = new Point(476, 558);
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
            btAgendar.Location = new Point(274, 558);
            btAgendar.Name = "btAgendar";
            btAgendar.Size = new Size(112, 34);
            btAgendar.TabIndex = 19;
            btAgendar.Text = "Agendar";
            btAgendar.UseVisualStyleBackColor = false;
            btAgendar.Click += btAgendar_Click;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.Indigo;
            btEditar.ForeColor = SystemColors.ButtonHighlight;
            btEditar.Location = new Point(689, 558);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(112, 34);
            btEditar.TabIndex = 20;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = false;
            // 
            // btExcluir
            // 
            btExcluir.BackColor = Color.Indigo;
            btExcluir.ForeColor = SystemColors.ButtonHighlight;
            btExcluir.Location = new Point(903, 558);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(112, 34);
            btExcluir.TabIndex = 21;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-8, 386);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(276, 310);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // dgvConsultas
            // 
            dgvConsultas.BackgroundColor = SystemColors.ButtonFace;
            dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultas.Location = new Point(347, 24);
            dgvConsultas.Name = "dgvConsultas";
            dgvConsultas.RowHeadersWidth = 62;
            dgvConsultas.Size = new Size(668, 161);
            dgvConsultas.TabIndex = 23;
            dgvConsultas.CellDoubleClick += dgvConsultas_CellDoubleClick;
            // 
            // btlistar
            // 
            btlistar.BackColor = Color.Indigo;
            btlistar.ForeColor = SystemColors.ButtonHighlight;
            btlistar.Location = new Point(70, 274);
            btlistar.Name = "btlistar";
            btlistar.Size = new Size(112, 34);
            btlistar.TabIndex = 24;
            btlistar.Text = "Listar";
            btlistar.UseVisualStyleBackColor = false;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(729, 361);
            lblID.Name = "lblID";
            lblID.Size = new Size(117, 22);
            lblID.TabIndex = 26;
            lblID.Text = "N° Consulta:";
            lblID.TextAlign = ContentAlignment.TopCenter;
            lblID.Click += lblID_Click;
            // 
            // txtNumeroConsulta
            // 
            txtNumeroConsulta.Location = new Point(729, 386);
            txtNumeroConsulta.Name = "txtNumeroConsulta";
            txtNumeroConsulta.Size = new Size(286, 30);
            txtNumeroConsulta.TabIndex = 27;
            // 
            // telaPrinciapal
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1154, 670);
            Controls.Add(txtNumeroConsulta);
            Controls.Add(lblID);
            Controls.Add(btlistar);
            Controls.Add(dgvConsultas);
            Controls.Add(pictureBox3);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
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
            Name = "telaPrinciapal";
            Text = "Clínica Patas & Cuidados";
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
        private Button btEditar;
        private Button btExcluir;
        private PictureBox pictureBox3;
        private DataGridView dgvConsultas;
        private Button btlistar;
        private Label lblID;
        private TextBox txtNumeroConsulta;
    }
}