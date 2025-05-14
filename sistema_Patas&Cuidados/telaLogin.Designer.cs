namespace sistema_Patas_Cuidados
{
    partial class telaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaInicial));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            btEntrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(128, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(464, 540);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(556, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(588, 310);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(80, 22);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(588, 341);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(363, 31);
            txtUsuario.TabIndex = 4;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(588, 392);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(70, 22);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(588, 420);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(363, 31);
            txtSenha.TabIndex = 6;
            // 
            // btEntrar
            // 
            btEntrar.BackColor = Color.GhostWhite;
            btEntrar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEntrar.ForeColor = Color.Indigo;
            btEntrar.Location = new Point(692, 479);
            btEntrar.Name = "btEntrar";
            btEntrar.Size = new Size(107, 36);
            btEntrar.TabIndex = 7;
            btEntrar.Text = "Entrar";
            btEntrar.UseVisualStyleBackColor = false;
            btEntrar.Click += btEntrar_Click;
            // 
            // telaInicial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1154, 670);
            Controls.Add(btEntrar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "telaInicial";
            Text = "Clínica Patas & Cuidados";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblSenha;
        private TextBox txtSenha;
        private Button btEntrar;
    }
}
