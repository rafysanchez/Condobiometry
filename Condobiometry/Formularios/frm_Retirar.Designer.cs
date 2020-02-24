namespace CondoBiometry
{
    partial class frm_Retirar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Retirar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_statusPort = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_msgBox = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_apartamento = new System.Windows.Forms.TextBox();
            this.txt_bloco = new System.Windows.Forms.TextBox();
            this.btn_cancelarPage2 = new System.Windows.Forms.Button();
            this.btn_retiraPage1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_msgArduino = new System.Windows.Forms.TextBox();
            this.txt_morador = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancelarPage1 = new System.Windows.Forms.Button();
            this.btn_continuarPage2 = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_cancelaRetirada = new System.Windows.Forms.Button();
            this.lbtxt_morador = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Porta = new System.Windows.Forms.Button();
            this.btn_ConfirmarPage3 = new System.Windows.Forms.Button();
            this.txt_idEbox = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbtxt_msgBox1 = new System.Windows.Forms.Label();
            this.btn_Encerrar = new System.Windows.Forms.Button();
            this.btn_retirarNovo = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_voltar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 60);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(241, 44);
            this.dataGridView1.TabIndex = 101;
            this.dataGridView1.Visible = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_voltar.Image = global::CondoBiometry.Properties.Resources.RETORNAR;
            this.btn_voltar.Location = new System.Drawing.Point(724, -1);
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
            this.label1.Location = new System.Drawing.Point(250, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "RETIRADA DE ENCOMENDAS";
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
            this.panel2.TabIndex = 102;
            // 
            // txt_statusPort
            // 
            this.txt_statusPort.AutoSize = true;
            this.txt_statusPort.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_statusPort.ForeColor = System.Drawing.Color.Gold;
            this.txt_statusPort.Location = new System.Drawing.Point(681, 10);
            this.txt_statusPort.Name = "txt_statusPort";
            this.txt_statusPort.Size = new System.Drawing.Size(125, 20);
            this.txt_statusPort.TabIndex = 6;
            this.txt_statusPort.Text = "Não conectado:****";
            this.txt_statusPort.Click += new System.EventHandler(this.txt_statusPort_Click);
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
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 541);
            this.tabControl1.TabIndex = 103;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.txt_msgBox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_apartamento);
            this.tabPage1.Controls.Add(this.txt_bloco);
            this.tabPage1.Controls.Add(this.btn_cancelarPage2);
            this.tabPage1.Controls.Add(this.btn_retiraPage1);
            this.tabPage1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 502);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Consulta encomendas";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.listBox1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(28, 197);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(759, 128);
            this.listBox1.TabIndex = 32;
            this.listBox1.Visible = false;
            // 
            // txt_msgBox
            // 
            this.txt_msgBox.AutoSize = true;
            this.txt_msgBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.txt_msgBox.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msgBox.ForeColor = System.Drawing.Color.Gold;
            this.txt_msgBox.Location = new System.Drawing.Point(42, 237);
            this.txt_msgBox.Name = "txt_msgBox";
            this.txt_msgBox.Size = new System.Drawing.Size(729, 37);
            this.txt_msgBox.TabIndex = 31;
            this.txt_msgBox.Text = "NÃO TEM ENCOMENDA PARA A UNIDADE INFORMADA!";
            this.txt_msgBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(155, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 37);
            this.label8.TabIndex = 24;
            this.label8.Text = "Bloco:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(142, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 37);
            this.label7.TabIndex = 23;
            this.label7.Text = "Apartamento:";
            // 
            // txt_apartamento
            // 
            this.txt_apartamento.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apartamento.Location = new System.Drawing.Point(337, 137);
            this.txt_apartamento.Name = "txt_apartamento";
            this.txt_apartamento.Size = new System.Drawing.Size(270, 44);
            this.txt_apartamento.TabIndex = 22;
            // 
            // txt_bloco
            // 
            this.txt_bloco.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bloco.Location = new System.Drawing.Point(337, 75);
            this.txt_bloco.Name = "txt_bloco";
            this.txt_bloco.Size = new System.Drawing.Size(270, 44);
            this.txt_bloco.TabIndex = 21;
            // 
            // btn_cancelarPage2
            // 
            this.btn_cancelarPage2.BackColor = System.Drawing.Color.Gold;
            this.btn_cancelarPage2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarPage2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_cancelarPage2.Location = new System.Drawing.Point(435, 342);
            this.btn_cancelarPage2.Name = "btn_cancelarPage2";
            this.btn_cancelarPage2.Size = new System.Drawing.Size(286, 95);
            this.btn_cancelarPage2.TabIndex = 17;
            this.btn_cancelarPage2.Text = "Cancelar retirada";
            this.btn_cancelarPage2.UseVisualStyleBackColor = false;
            this.btn_cancelarPage2.Click += new System.EventHandler(this.btn_cancelarPage2_Click);
            // 
            // btn_retiraPage1
            // 
            this.btn_retiraPage1.BackColor = System.Drawing.Color.Gold;
            this.btn_retiraPage1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retiraPage1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_retiraPage1.Location = new System.Drawing.Point(110, 342);
            this.btn_retiraPage1.Name = "btn_retiraPage1";
            this.btn_retiraPage1.Size = new System.Drawing.Size(286, 95);
            this.btn_retiraPage1.TabIndex = 16;
            this.btn_retiraPage1.Text = "Retirar encomenda";
            this.btn_retiraPage1.UseVisualStyleBackColor = false;
            this.btn_retiraPage1.Click += new System.EventHandler(this.btn_retiraPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.txt_msgArduino);
            this.tabPage2.Controls.Add(this.txt_morador);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btn_cancelarPage1);
            this.tabPage2.Controls.Add(this.btn_continuarPage2);
            this.tabPage2.Controls.Add(this.txt_senha);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 502);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Identificação Usuário";
            // 
            // txt_msgArduino
            // 
            this.txt_msgArduino.BackColor = System.Drawing.Color.MidnightBlue;
            this.txt_msgArduino.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msgArduino.ForeColor = System.Drawing.Color.Gold;
            this.txt_msgArduino.Location = new System.Drawing.Point(4, 312);
            this.txt_msgArduino.Name = "txt_msgArduino";
            this.txt_msgArduino.Size = new System.Drawing.Size(806, 50);
            this.txt_msgArduino.TabIndex = 15;
            this.txt_msgArduino.Text = "Acesso negado!";
            this.txt_msgArduino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_msgArduino.Visible = false;
            // 
            // txt_morador
            // 
            this.txt_morador.AutoSize = true;
            this.txt_morador.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_morador.ForeColor = System.Drawing.Color.White;
            this.txt_morador.Location = new System.Drawing.Point(296, 333);
            this.txt_morador.Name = "txt_morador";
            this.txt_morador.Size = new System.Drawing.Size(21, 29);
            this.txt_morador.TabIndex = 14;
            this.txt_morador.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(191, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Morador:";
            // 
            // btn_cancelarPage1
            // 
            this.btn_cancelarPage1.BackColor = System.Drawing.Color.Gold;
            this.btn_cancelarPage1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarPage1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_cancelarPage1.Location = new System.Drawing.Point(437, 382);
            this.btn_cancelarPage1.Name = "btn_cancelarPage1";
            this.btn_cancelarPage1.Size = new System.Drawing.Size(222, 68);
            this.btn_cancelarPage1.TabIndex = 12;
            this.btn_cancelarPage1.Text = "Cancelar retirada";
            this.btn_cancelarPage1.UseVisualStyleBackColor = false;
            this.btn_cancelarPage1.Click += new System.EventHandler(this.btn_cancelarPage1_Click);
            // 
            // btn_continuarPage2
            // 
            this.btn_continuarPage2.BackColor = System.Drawing.Color.Gold;
            this.btn_continuarPage2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuarPage2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_continuarPage2.Location = new System.Drawing.Point(193, 382);
            this.btn_continuarPage2.Name = "btn_continuarPage2";
            this.btn_continuarPage2.Size = new System.Drawing.Size(222, 68);
            this.btn_continuarPage2.TabIndex = 11;
            this.btn_continuarPage2.Text = "Confirmar retirada";
            this.btn_continuarPage2.UseVisualStyleBackColor = false;
            this.btn_continuarPage2.Click += new System.EventHandler(this.btn_continuarPage2_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(292, 258);
            this.txt_senha.MaxLength = 8;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(212, 32);
            this.txt_senha.TabIndex = 10;
            this.txt_senha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_senha_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(300, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ou digite sua senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(273, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pressione o dedo no sensor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(305, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage3.Controls.Add(this.btn_cancelaRetirada);
            this.tabPage3.Controls.Add(this.lbtxt_morador);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.btn_Porta);
            this.tabPage3.Controls.Add(this.btn_ConfirmarPage3);
            this.tabPage3.Controls.Add(this.txt_idEbox);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(822, 502);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Confirma retirada";
            // 
            // btn_cancelaRetirada
            // 
            this.btn_cancelaRetirada.BackColor = System.Drawing.Color.Gold;
            this.btn_cancelaRetirada.Enabled = false;
            this.btn_cancelaRetirada.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelaRetirada.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_cancelaRetirada.Location = new System.Drawing.Point(423, 381);
            this.btn_cancelaRetirada.Name = "btn_cancelaRetirada";
            this.btn_cancelaRetirada.Size = new System.Drawing.Size(233, 68);
            this.btn_cancelaRetirada.TabIndex = 32;
            this.btn_cancelaRetirada.Text = "Cancelar retirada";
            this.btn_cancelaRetirada.UseVisualStyleBackColor = false;
            this.btn_cancelaRetirada.Click += new System.EventHandler(this.btn_cancelaRetirdaa_Click);
            // 
            // lbtxt_morador
            // 
            this.lbtxt_morador.AutoSize = true;
            this.lbtxt_morador.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtxt_morador.ForeColor = System.Drawing.Color.White;
            this.lbtxt_morador.Location = new System.Drawing.Point(200, 320);
            this.lbtxt_morador.Name = "lbtxt_morador";
            this.lbtxt_morador.Size = new System.Drawing.Size(92, 29);
            this.lbtxt_morador.TabIndex = 31;
            this.lbtxt_morador.Text = "Morador";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(95, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 29);
            this.label10.TabIndex = 30;
            this.label10.Text = "Morador:";
            // 
            // btn_Porta
            // 
            this.btn_Porta.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Porta.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Porta.ForeColor = System.Drawing.Color.Gold;
            this.btn_Porta.Location = new System.Drawing.Point(100, 234);
            this.btn_Porta.Name = "btn_Porta";
            this.btn_Porta.Size = new System.Drawing.Size(556, 68);
            this.btn_Porta.TabIndex = 29;
            this.btn_Porta.Text = "COMPARTIMENTO FECHADO";
            this.btn_Porta.UseVisualStyleBackColor = false;
            // 
            // btn_ConfirmarPage3
            // 
            this.btn_ConfirmarPage3.BackColor = System.Drawing.Color.Gold;
            this.btn_ConfirmarPage3.Enabled = false;
            this.btn_ConfirmarPage3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmarPage3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_ConfirmarPage3.Location = new System.Drawing.Point(179, 381);
            this.btn_ConfirmarPage3.Name = "btn_ConfirmarPage3";
            this.btn_ConfirmarPage3.Size = new System.Drawing.Size(233, 68);
            this.btn_ConfirmarPage3.TabIndex = 27;
            this.btn_ConfirmarPage3.Text = "Confirmar retirada";
            this.btn_ConfirmarPage3.UseVisualStyleBackColor = false;
            this.btn_ConfirmarPage3.Click += new System.EventHandler(this.btn_ConfirmarPage3_Click);
            // 
            // txt_idEbox
            // 
            this.txt_idEbox.AutoSize = true;
            this.txt_idEbox.BackColor = System.Drawing.Color.Gold;
            this.txt_idEbox.Font = new System.Drawing.Font("Arial Narrow", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idEbox.Location = new System.Drawing.Point(302, 67);
            this.txt_idEbox.Name = "txt_idEbox";
            this.txt_idEbox.Size = new System.Drawing.Size(187, 153);
            this.txt_idEbox.TabIndex = 22;
            this.txt_idEbox.Text = "01";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(172, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(446, 37);
            this.label14.TabIndex = 21;
            this.label14.Text = "Retire o objeto no compartimento:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage4.Controls.Add(this.lbtxt_msgBox1);
            this.tabPage4.Controls.Add(this.btn_Encerrar);
            this.tabPage4.Controls.Add(this.btn_retirarNovo);
            this.tabPage4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage4.Location = new System.Drawing.Point(4, 35);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(822, 502);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Finalizar";
            // 
            // lbtxt_msgBox1
            // 
            this.lbtxt_msgBox1.AutoSize = true;
            this.lbtxt_msgBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbtxt_msgBox1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtxt_msgBox1.ForeColor = System.Drawing.Color.Gold;
            this.lbtxt_msgBox1.Location = new System.Drawing.Point(123, 108);
            this.lbtxt_msgBox1.Name = "lbtxt_msgBox1";
            this.lbtxt_msgBox1.Size = new System.Drawing.Size(547, 37);
            this.lbtxt_msgBox1.TabIndex = 32;
            this.lbtxt_msgBox1.Text = "ENCOMENDA RETIRADA COM SUCESSO!";
            // 
            // btn_Encerrar
            // 
            this.btn_Encerrar.BackColor = System.Drawing.Color.Gold;
            this.btn_Encerrar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encerrar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Encerrar.Location = new System.Drawing.Point(446, 229);
            this.btn_Encerrar.Name = "btn_Encerrar";
            this.btn_Encerrar.Size = new System.Drawing.Size(233, 174);
            this.btn_Encerrar.TabIndex = 29;
            this.btn_Encerrar.Text = "Encerrar retirada";
            this.btn_Encerrar.UseVisualStyleBackColor = false;
            this.btn_Encerrar.Click += new System.EventHandler(this.btn_Encerrar_Click);
            // 
            // btn_retirarNovo
            // 
            this.btn_retirarNovo.BackColor = System.Drawing.Color.Gold;
            this.btn_retirarNovo.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retirarNovo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_retirarNovo.Location = new System.Drawing.Point(150, 229);
            this.btn_retirarNovo.Name = "btn_retirarNovo";
            this.btn_retirarNovo.Size = new System.Drawing.Size(240, 174);
            this.btn_retirarNovo.TabIndex = 28;
            this.btn_retirarNovo.Text = "Retirar novo objeto";
            this.btn_retirarNovo.UseVisualStyleBackColor = false;
            this.btn_retirarNovo.Click += new System.EventHandler(this.btn_retirarNovo_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage5.Location = new System.Drawing.Point(4, 35);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(822, 502);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Lista de Encomendas";
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
            // frm_Retirar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(834, 661);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Retirar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condo Biometry";
            this.Load += new System.EventHandler(this.frm_Retirar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label txt_msgBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_apartamento;
        private System.Windows.Forms.TextBox txt_bloco;
        private System.Windows.Forms.Button btn_cancelarPage2;
        private System.Windows.Forms.Button btn_retiraPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label txt_morador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancelarPage1;
        private System.Windows.Forms.Button btn_continuarPage2;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbtxt_morador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Porta;
        private System.Windows.Forms.Button btn_ConfirmarPage3;
        private System.Windows.Forms.Label txt_idEbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lbtxt_msgBox1;
        private System.Windows.Forms.Button btn_Encerrar;
        private System.Windows.Forms.Button btn_retirarNovo;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txt_statusPort;
        private System.Windows.Forms.TextBox txt_msgArduino;
        private System.Windows.Forms.Button btn_cancelaRetirada;
    }
}