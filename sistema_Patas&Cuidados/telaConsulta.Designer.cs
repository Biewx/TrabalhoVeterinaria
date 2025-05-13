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
            textBox1 = new TextBox();
            lblMotivo = new Label();
            textBox2 = new TextBox();
            lblVeterinario = new Label();
            textBox3 = new TextBox();
            lblData = new Label();
            maskedTextBox1 = new MaskedTextBox();
            lblContato = new Label();
            txtContato = new TextBox();
            lblHora = new Label();
            maskedTextBox2 = new MaskedTextBox();
            btConsultar = new Button();
            btAgendar = new Button();
            btEditar = new Button();
            btExcluir = new Button();
            pictureBox3 = new PictureBox();
            dgvConsultas = new DataGridView();
            btlistar = new Button();
            btListarTodos = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(274, 299);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(420, 30);
            textBox1.TabIndex = 7;
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
            // textBox2
            // 
            textBox2.Location = new Point(729, 468);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 30);
            textBox2.TabIndex = 9;
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
            // textBox3
            // 
            textBox3.Location = new Point(274, 386);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(741, 30);
            textBox3.TabIndex = 11;
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
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(274, 468);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(111, 30);
            maskedTextBox1.TabIndex = 13;
            maskedTextBox1.ValidatingType = typeof(DateTime);
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
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(509, 468);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(111, 30);
            maskedTextBox2.TabIndex = 17;
            maskedTextBox2.ValidatingType = typeof(DateTime);
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
            // 
            // btlistar
            // 
            btlistar.BackColor = Color.Indigo;
            btlistar.ForeColor = SystemColors.ButtonHighlight;
            btlistar.Location = new Point(70, 245);
            btlistar.Name = "btlistar";
            btlistar.Size = new Size(112, 34);
            btlistar.TabIndex = 24;
            btlistar.Text = "Listar";
            btlistar.UseVisualStyleBackColor = false;
            // 
            // btListarTodos
            // 
            btListarTodos.BackColor = Color.Indigo;
            btListarTodos.ForeColor = SystemColors.ButtonHighlight;
            btListarTodos.Location = new Point(70, 299);
            btListarTodos.Name = "btListarTodos";
            btListarTodos.Size = new Size(127, 34);
            btListarTodos.TabIndex = 25;
            btListarTodos.Text = "Listar Todos";
            btListarTodos.UseVisualStyleBackColor = false;
            // 
            // telaPrinciapal
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1154, 670);
            Controls.Add(btListarTodos);
            Controls.Add(btlistar);
            Controls.Add(dgvConsultas);
            Controls.Add(pictureBox3);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(btAgendar);
            Controls.Add(btConsultar);
            Controls.Add(maskedTextBox2);
            Controls.Add(lblHora);
            Controls.Add(txtContato);
            Controls.Add(lblContato);
            Controls.Add(maskedTextBox1);
            Controls.Add(lblData);
            Controls.Add(textBox3);
            Controls.Add(lblVeterinario);
            Controls.Add(textBox2);
            Controls.Add(lblMotivo);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label lblMotivo;
        private TextBox textBox2;
        private Label lblVeterinario;
        private TextBox textBox3;
        private Label lblData;
        private MaskedTextBox maskedTextBox1;
        private Label lblContato;
        private TextBox txtContato;
        private Label lblHora;
        private MaskedTextBox maskedTextBox2;
        private Button btConsultar;
        private Button btAgendar;
        private Button btEditar;
        private Button btExcluir;
        private PictureBox pictureBox3;
        private DataGridView dgvConsultas;
        private Button btlistar;
        private Button btListarTodos;
    }
}