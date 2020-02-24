namespace CondoBiometry
{
    partial class frm_Entregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Entregar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_msgArduino = new System.Windows.Forms.TextBox();
            this.txt_nomeEntregador = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cancelarPage1 = new System.Windows.Forms.Button();
            this.btn_continuarPage1 = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_entregadorPage2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_apartamento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_bloco = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_cancelarPage2 = new System.Windows.Forms.Button();
            this.btn_continuarPage2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_cancearPage3 = new System.Windows.Forms.Button();
            this.btn_continuarPage3 = new System.Windows.Forms.Button();
            this.btn_pequeno = new System.Windows.Forms.Button();
            this.btn_medio = new System.Windows.Forms.Button();
            this.btn_grande = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_cancelarPage4 = new System.Windows.Forms.Button();
            this.btn_confirmarPage4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txt_msgBox = new System.Windows.Forms.TextBox();
            this.btn_Porta = new System.Windows.Forms.Button();
            this.btn_cancelarPage5 = new System.Windows.Forms.Button();
            this.btn_ConfirmarPage5 = new System.Windows.Forms.Button();
            this.txt_idEbox = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lbtxt_msgBox = new System.Windows.Forms.Label();
            this.btn_Encerrar = new System.Windows.Forms.Button();
            this.btn_entregarNovo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_statusPort = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_voltar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 60);
            this.panel1.TabIndex = 1;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_voltar.Image = global::CondoBiometry.Properties.Resources.RETORNAR;
            this.btn_voltar.Location = new System.Drawing.Point(724, 1);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(104, 55);
            this.btn_voltar.TabIndex = 100;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(252, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTREGA DE ENCOMENDAS";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 540);
            this.tabControl1.TabIndex = 100;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.txt_msgArduino);
            this.tabPage1.Controls.Add(this.txt_nomeEntregador);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btn_cancelarPage1);
            this.tabPage1.Controls.Add(this.btn_continuarPage1);
            this.tabPage1.Controls.Add(this.txt_senha);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Identificação";
            // 
            // txt_msgArduino
            // 
            this.txt_msgArduino.BackColor = System.Drawing.Color.MidnightBlue;
            this.txt_msgArduino.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msgArduino.ForeColor = System.Drawing.Color.Gold;
            this.txt_msgArduino.Location = new System.Drawing.Point(2, 319);
            this.txt_msgArduino.Name = "txt_msgArduino";
            this.txt_msgArduino.Size = new System.Drawing.Size(806, 50);
            this.txt_msgArduino.TabIndex = 16;
            this.txt_msgArduino.Text = "Acesso negado!";
            this.txt_msgArduino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_msgArduino.Visible = false;
            // 
            // txt_nomeEntregador
            // 
            this.txt_nomeEntregador.AutoSize = true;
            this.txt_nomeEntregador.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeEntregador.ForeColor = System.Drawing.Color.White;
            this.txt_nomeEntregador.Location = new System.Drawing.Point(294, 340);
            this.txt_nomeEntregador.Name = "txt_nomeEntregador";
            this.txt_nomeEntregador.Size = new System.Drawing.Size(45, 29);
            this.txt_nomeEntregador.TabIndex = 14;
            this.txt_nomeEntregador.Text = "****";
            this.txt_nomeEntregador.Click += new System.EventHandler(this.txt_nomeEntregador_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(162, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Entregador:";
            // 
            // btn_cancelarPage1
            // 
            this.btn_cancelarPage1.BackColor = System.Drawing.Color.Gold;
            this.btn_cancelarPage1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarPage1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_cancelarPage1.Location = new System.Drawing.Point(392, 402);
            this.btn_cancelarPage1.Name = "btn_cancelarPage1";
            this.btn_cancelarPage1.Size = new System.Drawing.Size(202, 68);
            this.btn_cancelarPage1.TabIndex = 12;
            this.btn_cancelarPage1.Text = "Cancelar";
            this.btn_cancelarPage1.UseVisualStyleBackColor = false;
            this.btn_cancelarPage1.Click += new System.EventHandler(this.btn_cancelarPage1_Click);
            // 
            // btn_continuarPage1
            // 
            this.btn_continuarPage1.BackColor = System.Drawing.Color.Gold;
            this.btn_continuarPage1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuarPage1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_continuarPage1.Location = new System.Drawing.Point(167, 402);
            this.btn_continuarPage1.Name = "btn_continuarPage1";
            this.btn_continuarPage1.Size = new System.Drawing.Size(202, 68);
            this.btn_continuarPage1.TabIndex = 11;
            this.btn_continuarPage1.Text = "Continuar";
            this.btn_continuarPage1.UseVisualStyleBackColor = false;
            this.btn_continuarPage1.Click += new System.EventHandler(this.btn_continuarPage1_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(280, 269);
            this.txt_senha.MaxLength = 8;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(212, 32);
            this.txt_senha.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(294, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ou digite sua senha:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(299, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(264, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Pressione o dedo no sensor";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.txt_entregadorPage2);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txt_apartamento);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txt_bloco);
            this.tabPage2.Controls.Add(this.txt_codigo);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.btn_cancelarPage2);
            this.tabPage2.Controls.Add(this.btn_continuarPage2);
            this.tabPage2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados Encomenda";
            // 
            // txt_entregadorPage2
            // 
            this.txt_entregadorPage2.AutoSize = true;
            this.txt_entregadorPage2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_entregadorPage2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_entregadorPage2.Location = new System.Drawing.Point(163, 438);
            this.txt_entregadorPage2.Name = "txt_entregadorPage2";
            this.txt_entregadorPage2.Size = new System.Drawing.Size(50, 31);
            this.txt_entregadorPage2.TabIndex = 25;
            this.txt_entregadorPage2.Text = "****";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(178, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 37);
            this.label10.TabIndex = 24;
            this.label10.Text = "Bloco:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(178, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 37);
            this.label12.TabIndex = 23;
            this.label12.Text = "Apartamento:";
            // 
            // txt_apartamento
            // 
            this.txt_apartamento.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apartamento.Location = new System.Drawing.Point(373, 212);
            this.txt_apartamento.Name = "txt_apartamento";
            this.txt_apartamento.Size = new System.Drawing.Size(270, 44);
            this.txt_apartamento.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(21, 438);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 31);
            this.label13.TabIndex = 19;
            this.label13.Text = "Entregador:";
            // 
            // txt_bloco
            // 
            this.txt_bloco.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bloco.Location = new System.Drawing.Point(373, 150);
            this.txt_bloco.Name = "txt_bloco";
            this.txt_bloco.Size = new System.Drawing.Size(270, 44);
            this.txt_bloco.TabIndex = 21;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(373, 84);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(270, 44);
            this.txt_codigo.TabIndex = 20;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(178, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 37);
            this.label14.TabIndex = 18;
            this.label14.Text = "Código :";
            // 
            // btn_cancelarPage2
            // 
            this.btn_cancelarPage2.BackColor = System.Drawing.Color.Gold;
            this.btn_cancelarPage2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarPage2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_cancelarPage2.Location = new System.Drawing.Point(425, 317);
            this.btn_cancelarPage2.Name = "btn_cancelarPage2";
            this.btn_cancelarPage2.Size = new System.Drawing.Size(202, 68);
            this.btn_cancelarPage2.TabIndex = 17;
            this.btn_cancelarPage2.Text = "Cancelar";
            this.btn_cancelarPage2.UseVisualStyleBackColor = false;
            this.btn_cancelarPage2.Click += new System.EventHandler(this.btn_cancelarPage2_Click);
            // 
            // btn_continuarPage2
            // 
            this.btn_continuarPage2.BackColor = System.Drawing.Color.Gold;
            this.btn_continuarPage2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuarPage2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_continuarPage2.Location = new System.Drawing.Point(200, 317);
            this.btn_continuarPage2.Name = "btn_continuarPage2";
            this.btn_continuarPage2.Size = new System.Drawing.Size(202, 68);
            this.btn_continuarPage2.TabIndex = 16;
            this.btn_continuarPage2.Text = "Continuar";
            this.btn_continuarPage2.UseVisualStyleBackColor = false;
            this.btn_continuarPage2.Click += new System.EventHandler(this.btn_continuarPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage3.Controls.Add(this.btn_cancearPage3);
            this.tabPage3.Controls.Add(this.btn_continuarPage3);
            this.tabPage3.Controls.Add(this.btn_pequeno);
            this.tabPage3.Controls.Add(this.btn_medio);
            this.tabPage3.Controls.Add(this.btn_grande);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(822, 501);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Escolha Compartimento";
            // 
            // btn_cancearPage3
            // 
            this.btn_cancearPage3.BackColor = System.Drawing.Color.Gold;
            this.btn_cancearPage3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancearPage3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_cancearPage3.Location = new System.Drawing.Point(422, 384);
            this.btn_cancearPage3.Name = "btn_cancearPage3";
            this.btn_cancearPage3.Size = new System.Drawing.Size(202, 68);
            this.btn_cancearPage3.TabIndex = 26;
            this.btn_cancearPage3.Text = "Cancelar";
            this.btn_cancearPage3.UseVisualStyleBackColor = false;
            this.btn_cancearPage3.Click += new System.EventHandler(this.btn_cancearPage3_Click);
            // 
            // btn_continuarPage3
            // 
            this.btn_continuarPage3.BackColor = System.Drawing.Color.Gold;
            this.btn_continuarPage3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuarPage3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_continuarPage3.Location = new System.Drawing.Point(197, 384);
            this.btn_continuarPage3.Name = "btn_continuarPage3";
            this.btn_continuarPage3.Size = new System.Drawing.Size(202, 68);
            this.btn_continuarPage3.TabIndex = 25;
            this.btn_continuarPage3.Text = "Continuar";
            this.btn_continuarPage3.UseVisualStyleBackColor = false;
            this.btn_continuarPage3.Click += new System.EventHandler(this.btn_continuarPage3_Click);
            // 
            // btn_pequeno
            // 
            this.btn_pequeno.BackColor = System.Drawing.Color.Gold;
            this.btn_pequeno.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pequeno.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_pequeno.Location = new System.Drawing.Point(62, 121);
            this.btn_pequeno.Name = "btn_pequeno";
            this.btn_pequeno.Size = new System.Drawing.Size(159, 163);
            this.btn_pequeno.TabIndex = 24;
            this.btn_pequeno.Text = "Pequeno";
            this.btn_pequeno.UseVisualStyleBackColor = false;
            this.btn_pequeno.Click += new System.EventHandler(this.btn_pequeno_Click);
            // 
            // btn_medio
            // 
            this.btn_medio.BackColor = System.Drawing.Color.Gold;
            this.btn_medio.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_medio.Location = new System.Drawing.Point(249, 121);
            this.btn_medio.Name = "btn_medio";
            this.btn_medio.Size = new System.Drawing.Size(210, 163);
            this.btn_medio.TabIndex = 23;
            this.btn_medio.Text = "Médio";
            this.btn_medio.UseVisualStyleBackColor = false;
            this.btn_medio.Click += new System.EventHandler(this.btn_medio_Click);
            // 
            // btn_grande
            // 
            this.btn_grande.BackColor = System.Drawing.Color.Gold;
            this.btn_grande.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grande.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_grande.Location = new System.Drawing.Point(486, 121);
            this.btn_grande.Name = "btn_grande";
            this.btn_grande.Size = new System.Drawing.Size(286, 163);
            this.btn_grande.TabIndex = 22;
            this.btn_grande.Text = "Grande";
            this.btn_grande.UseVisualStyleBackColor = false;
            this.btn_grande.Click += new System.EventHandler(this.btn_grande_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(141, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(517, 37);
            this.label15.TabIndex = 19;
            this.label15.Text = "Selecione o tamanho do compartimento";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage4.Controls.Add(this.listBox1);
            this.tabPage4.Controls.Add(this.btn_cancelarPage4);
            this.tabPage4.Controls.Add(this.btn_confirmarPage4);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage4.Location = new System.Drawing.Point(4, 35);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(822, 501);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Confirma Dados";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(63, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(686, 283);
            this.listBox1.TabIndex = 33;
            // 
            // btn_cancelarPage4
            // 
            this.btn_cancelarPage4.BackColor = System.Drawing.Color.Gold;
            this.btn_cancelarPage4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarPage4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_cancelarPage4.Location = new System.Drawing.Point(426, 395);
            this.btn_cancelarPage4.Name = "btn_cancelarPage4";
            this.btn_cancelarPage4.Size = new System.Drawing.Size(202, 68);
            this.btn_cancelarPage4.TabIndex = 30;
            this.btn_cancelarPage4.Text = "Cancelar";
            this.btn_cancelarPage4.UseVisualStyleBackColor = false;
            this.btn_cancelarPage4.Click += new System.EventHandler(this.btn_cancelarPage4_Click);
            // 
            // btn_confirmarPage4
            // 
            this.btn_confirmarPage4.BackColor = System.Drawing.Color.Gold;
            this.btn_confirmarPage4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmarPage4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_confirmarPage4.Location = new System.Drawing.Point(201, 395);
            this.btn_confirmarPage4.Name = "btn_confirmarPage4";
            this.btn_confirmarPage4.Size = new System.Drawing.Size(202, 68);
            this.btn_confirmarPage4.TabIndex = 29;
            this.btn_confirmarPage4.Text = "Confirmar";
            this.btn_confirmarPage4.UseVisualStyleBackColor = false;
            this.btn_confirmarPage4.Click += new System.EventHandler(this.btn_confirmarPage4_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(199, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(396, 37);
            this.label16.TabIndex = 20;
            this.label16.Text = "Confirma os dados de entrega";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage5.Controls.Add(this.txt_msgBox);
            this.tabPage5.Controls.Add(this.btn_Porta);
            this.tabPage5.Controls.Add(this.btn_cancelarPage5);
            this.tabPage5.Controls.Add(this.btn_ConfirmarPage5);
            this.tabPage5.Controls.Add(this.txt_idEbox);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage5.Location = new System.Drawing.Point(4, 35);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(822, 501);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Confirma Entrega";
            // 
            // txt_msgBox
            // 
            this.txt_msgBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.txt_msgBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msgBox.ForeColor = System.Drawing.Color.Gold;
            this.txt_msgBox.Location = new System.Drawing.Point(21, 213);
            this.txt_msgBox.Multiline = true;
            this.txt_msgBox.Name = "txt_msgBox";
            this.txt_msgBox.Size = new System.Drawing.Size(193, 40);
            this.txt_msgBox.TabIndex = 106;
            this.txt_msgBox.Text = "MSG RECEBIDA DO ARDUINO";
            this.txt_msgBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_msgBox.Visible = false;
            // 
            // btn_Porta
            // 
            this.btn_Porta.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Porta.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Porta.ForeColor = System.Drawing.Color.Gold;
            this.btn_Porta.Location = new System.Drawing.Point(126, 283);
            this.btn_Porta.Name = "btn_Porta";
            this.btn_Porta.Size = new System.Drawing.Size(556, 68);
            this.btn_Porta.TabIndex = 29;
            this.btn_Porta.Text = "COMPARTIMENTO FECHADO";
            this.btn_Porta.UseVisualStyleBackColor = false;
            // 
            // btn_cancelarPage5
            // 
            this.btn_cancelarPage5.BackColor = System.Drawing.Color.Gold;
            this.btn_cancelarPage5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarPage5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_cancelarPage5.Location = new System.Drawing.Point(422, 390);
            this.btn_cancelarPage5.Name = "btn_cancelarPage5";
            this.btn_cancelarPage5.Size = new System.Drawing.Size(233, 68);
            this.btn_cancelarPage5.TabIndex = 28;
            this.btn_cancelarPage5.Text = "Cancelar entrega";
            this.btn_cancelarPage5.UseVisualStyleBackColor = false;
            this.btn_cancelarPage5.Click += new System.EventHandler(this.btn_cancelarPage5_Click);
            // 
            // btn_ConfirmarPage5
            // 
            this.btn_ConfirmarPage5.BackColor = System.Drawing.Color.Gold;
            this.btn_ConfirmarPage5.Enabled = false;
            this.btn_ConfirmarPage5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmarPage5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_ConfirmarPage5.Location = new System.Drawing.Point(157, 390);
            this.btn_ConfirmarPage5.Name = "btn_ConfirmarPage5";
            this.btn_ConfirmarPage5.Size = new System.Drawing.Size(233, 68);
            this.btn_ConfirmarPage5.TabIndex = 27;
            this.btn_ConfirmarPage5.Text = "Confirmar entrega";
            this.btn_ConfirmarPage5.UseVisualStyleBackColor = false;
            this.btn_ConfirmarPage5.Click += new System.EventHandler(this.btn_ConfirmarPage5_Click);
            // 
            // txt_idEbox
            // 
            this.txt_idEbox.AutoSize = true;
            this.txt_idEbox.BackColor = System.Drawing.Color.Gold;
            this.txt_idEbox.Font = new System.Drawing.Font("Arial Narrow", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idEbox.Location = new System.Drawing.Point(289, 100);
            this.txt_idEbox.Name = "txt_idEbox";
            this.txt_idEbox.Size = new System.Drawing.Size(187, 153);
            this.txt_idEbox.TabIndex = 22;
            this.txt_idEbox.Text = "01";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(172, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(483, 37);
            this.label17.TabIndex = 21;
            this.label17.Text = "Deposite o objeto no compartimento:";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage6.Controls.Add(this.lbtxt_msgBox);
            this.tabPage6.Controls.Add(this.btn_Encerrar);
            this.tabPage6.Controls.Add(this.btn_entregarNovo);
            this.tabPage6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage6.Location = new System.Drawing.Point(4, 35);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(822, 501);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Finalizar";
            // 
            // lbtxt_msgBox
            // 
            this.lbtxt_msgBox.AutoSize = true;
            this.lbtxt_msgBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbtxt_msgBox.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtxt_msgBox.ForeColor = System.Drawing.Color.Gold;
            this.lbtxt_msgBox.Location = new System.Drawing.Point(164, 112);
            this.lbtxt_msgBox.Name = "lbtxt_msgBox";
            this.lbtxt_msgBox.Size = new System.Drawing.Size(483, 43);
            this.lbtxt_msgBox.TabIndex = 30;
            this.lbtxt_msgBox.Text = "Entrega realizada com sucesso!";
            // 
            // btn_Encerrar
            // 
            this.btn_Encerrar.BackColor = System.Drawing.Color.Gold;
            this.btn_Encerrar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encerrar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Encerrar.Location = new System.Drawing.Point(447, 202);
            this.btn_Encerrar.Name = "btn_Encerrar";
            this.btn_Encerrar.Size = new System.Drawing.Size(233, 174);
            this.btn_Encerrar.TabIndex = 29;
            this.btn_Encerrar.Text = "Encerrar Distribuição";
            this.btn_Encerrar.UseVisualStyleBackColor = false;
            this.btn_Encerrar.Click += new System.EventHandler(this.btn_Encerrar_Click);
            // 
            // btn_entregarNovo
            // 
            this.btn_entregarNovo.BackColor = System.Drawing.Color.Gold;
            this.btn_entregarNovo.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entregarNovo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_entregarNovo.Location = new System.Drawing.Point(151, 202);
            this.btn_entregarNovo.Name = "btn_entregarNovo";
            this.btn_entregarNovo.Size = new System.Drawing.Size(240, 174);
            this.btn_entregarNovo.TabIndex = 28;
            this.btn_entregarNovo.Text = "Entregar novo objeto";
            this.btn_entregarNovo.UseVisualStyleBackColor = false;
            this.btn_entregarNovo.Click += new System.EventHandler(this.btn_entregarNovo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_statusPort);
            this.panel2.Controls.Add(this.txt_data);
            this.panel2.Location = new System.Drawing.Point(2, 610);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 50);
            this.panel2.TabIndex = 101;
            // 
            // txt_statusPort
            // 
            this.txt_statusPort.AutoSize = true;
            this.txt_statusPort.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_statusPort.ForeColor = System.Drawing.Color.Gold;
            this.txt_statusPort.Location = new System.Drawing.Point(674, 13);
            this.txt_statusPort.Name = "txt_statusPort";
            this.txt_statusPort.Size = new System.Drawing.Size(125, 20);
            this.txt_statusPort.TabIndex = 5;
            this.txt_statusPort.Text = "Não conectado:****";
            // 
            // txt_data
            // 
            this.txt_data.AutoSize = true;
            this.txt_data.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.ForeColor = System.Drawing.Color.Gold;
            this.txt_data.Location = new System.Drawing.Point(7, 13);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(246, 20);
            this.txt_data.TabIndex = 2;
            this.txt_data.Text = "Sabado 04 de Agosto de 2018 19:33:57";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // frm_Entregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(834, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Entregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condo Biometry";
            this.Load += new System.EventHandler(this.frm_Entregar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label txt_nomeEntregador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cancelarPage1;
        private System.Windows.Forms.Button btn_continuarPage1;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label txt_entregadorPage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_apartamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_bloco;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_cancelarPage2;
        private System.Windows.Forms.Button btn_continuarPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_cancearPage3;
        private System.Windows.Forms.Button btn_continuarPage3;
        private System.Windows.Forms.Button btn_pequeno;
        private System.Windows.Forms.Button btn_medio;
        private System.Windows.Forms.Button btn_grande;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_cancelarPage4;
        private System.Windows.Forms.Button btn_confirmarPage4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btn_Porta;
        private System.Windows.Forms.Button btn_cancelarPage5;
        private System.Windows.Forms.Button btn_ConfirmarPage5;
        private System.Windows.Forms.Label txt_idEbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label lbtxt_msgBox;
        private System.Windows.Forms.Button btn_Encerrar;
        private System.Windows.Forms.Button btn_entregarNovo;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txt_statusPort;
        private System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txt_msgBox;
        private System.Windows.Forms.TextBox txt_msgArduino;
    }
}