namespace CondoBiometry.Formularios
{
    partial class Develophers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Develophers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_principal = new System.Windows.Forms.Button();
            this.btn_compartimentos = new System.Windows.Forms.Button();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.btn_manutencao = new System.Windows.Forms.Button();
            this.btn_relatorio = new System.Windows.Forms.Button();
            this.btn_encomendas = new System.Windows.Forms.Button();
            this.btn_entregar = new System.Windows.Forms.Button();
            this.btn_retirar = new System.Windows.Forms.Button();
            this.btn_setup = new System.Windows.Forms.Button();
            this.btn_P_compartimentos = new System.Windows.Forms.Button();
            this.txt_local_instalacaoMysql = new System.Windows.Forms.TextBox();
            this.txt_localArquivoSql = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_local1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_local2 = new System.Windows.Forms.Button();
            this.btn_local3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_local_Backup = new System.Windows.Forms.TextBox();
            this.btn_RealizarBackup = new System.Windows.Forms.Button();
            this.btn_RestaurarBD = new System.Windows.Forms.Button();
            this.btn_criarBD = new System.Windows.Forms.Button();
            this.txt_listsPort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_conectarArduino = new System.Windows.Forms.Button();
            this.txt_StatusPort = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_AbrirUm = new System.Windows.Forms.Button();
            this.btn_TesteLeitor = new System.Windows.Forms.Button();
            this.txt_msgPort = new System.Windows.Forms.TextBox();
            this.btn_RemoverBiometrias = new System.Windows.Forms.Button();
            this.btn_AbrirTodos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_biometriaRemovida = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_InstalarDotNEt = new System.Windows.Forms.Button();
            this.btn_instalarPlugin = new System.Windows.Forms.Button();
            this.btn_InstalarMysql = new System.Windows.Forms.Button();
            this.txt_localArquivoEXE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_local4 = new System.Windows.Forms.Button();
            this.btn_trucateBD = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_usuario = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.Label();
            this.txt_statusPorta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.btn_voltar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 60);
            this.panel1.TabIndex = 6;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_sair.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Gold;
            this.btn_sair.Location = new System.Drawing.Point(-1, -1);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(117, 59);
            this.btn_sair.TabIndex = 101;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
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
            this.label1.Location = new System.Drawing.Point(296, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEVELOPHERS";
            // 
            // btn_principal
            // 
            this.btn_principal.BackColor = System.Drawing.Color.Gold;
            this.btn_principal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_principal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_principal.Location = new System.Drawing.Point(40, 65);
            this.btn_principal.Name = "btn_principal";
            this.btn_principal.Size = new System.Drawing.Size(141, 35);
            this.btn_principal.TabIndex = 89;
            this.btn_principal.Text = " Principal";
            this.btn_principal.UseVisualStyleBackColor = false;
            this.btn_principal.Click += new System.EventHandler(this.btn_principal_Click);
            // 
            // btn_compartimentos
            // 
            this.btn_compartimentos.BackColor = System.Drawing.Color.Gold;
            this.btn_compartimentos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compartimentos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_compartimentos.Location = new System.Drawing.Point(342, 100);
            this.btn_compartimentos.Name = "btn_compartimentos";
            this.btn_compartimentos.Size = new System.Drawing.Size(141, 36);
            this.btn_compartimentos.TabIndex = 90;
            this.btn_compartimentos.Text = " Compartimentos";
            this.btn_compartimentos.UseVisualStyleBackColor = false;
            this.btn_compartimentos.Click += new System.EventHandler(this.btn_compartimentos_Click);
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.BackColor = System.Drawing.Color.Gold;
            this.btn_cadastro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_cadastro.Location = new System.Drawing.Point(644, 65);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(141, 35);
            this.btn_cadastro.TabIndex = 91;
            this.btn_cadastro.Text = " Cadastro";
            this.btn_cadastro.UseVisualStyleBackColor = false;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // btn_manutencao
            // 
            this.btn_manutencao.BackColor = System.Drawing.Color.Gold;
            this.btn_manutencao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manutencao.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_manutencao.Location = new System.Drawing.Point(493, 100);
            this.btn_manutencao.Name = "btn_manutencao";
            this.btn_manutencao.Size = new System.Drawing.Size(141, 36);
            this.btn_manutencao.TabIndex = 92;
            this.btn_manutencao.Text = "Manutenção";
            this.btn_manutencao.UseVisualStyleBackColor = false;
            this.btn_manutencao.Click += new System.EventHandler(this.btn_manutencao_Click);
            // 
            // btn_relatorio
            // 
            this.btn_relatorio.BackColor = System.Drawing.Color.Gold;
            this.btn_relatorio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_relatorio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_relatorio.Location = new System.Drawing.Point(644, 100);
            this.btn_relatorio.Name = "btn_relatorio";
            this.btn_relatorio.Size = new System.Drawing.Size(141, 36);
            this.btn_relatorio.TabIndex = 93;
            this.btn_relatorio.Text = " Relatorio";
            this.btn_relatorio.UseVisualStyleBackColor = false;
            this.btn_relatorio.Click += new System.EventHandler(this.btn_relatorio_Click);
            // 
            // btn_encomendas
            // 
            this.btn_encomendas.BackColor = System.Drawing.Color.Gold;
            this.btn_encomendas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encomendas.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_encomendas.Location = new System.Drawing.Point(191, 100);
            this.btn_encomendas.Name = "btn_encomendas";
            this.btn_encomendas.Size = new System.Drawing.Size(141, 36);
            this.btn_encomendas.TabIndex = 94;
            this.btn_encomendas.Text = "Encomendas";
            this.btn_encomendas.UseVisualStyleBackColor = false;
            this.btn_encomendas.Click += new System.EventHandler(this.btn_encomendas_Click);
            // 
            // btn_entregar
            // 
            this.btn_entregar.BackColor = System.Drawing.Color.Gold;
            this.btn_entregar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entregar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_entregar.Location = new System.Drawing.Point(493, 65);
            this.btn_entregar.Name = "btn_entregar";
            this.btn_entregar.Size = new System.Drawing.Size(141, 35);
            this.btn_entregar.TabIndex = 95;
            this.btn_entregar.Text = "Entregar";
            this.btn_entregar.UseVisualStyleBackColor = false;
            this.btn_entregar.Click += new System.EventHandler(this.btn_entregar_Click);
            // 
            // btn_retirar
            // 
            this.btn_retirar.BackColor = System.Drawing.Color.Gold;
            this.btn_retirar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retirar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_retirar.Location = new System.Drawing.Point(342, 65);
            this.btn_retirar.Name = "btn_retirar";
            this.btn_retirar.Size = new System.Drawing.Size(141, 35);
            this.btn_retirar.TabIndex = 96;
            this.btn_retirar.Text = "Retirar";
            this.btn_retirar.UseVisualStyleBackColor = false;
            this.btn_retirar.Click += new System.EventHandler(this.btn_retirar_Click);
            // 
            // btn_setup
            // 
            this.btn_setup.BackColor = System.Drawing.Color.Gold;
            this.btn_setup.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setup.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_setup.Location = new System.Drawing.Point(191, 65);
            this.btn_setup.Name = "btn_setup";
            this.btn_setup.Size = new System.Drawing.Size(141, 35);
            this.btn_setup.TabIndex = 97;
            this.btn_setup.Text = "Setup";
            this.btn_setup.UseVisualStyleBackColor = false;
            this.btn_setup.Click += new System.EventHandler(this.btn_setup_Click);
            // 
            // btn_P_compartimentos
            // 
            this.btn_P_compartimentos.BackColor = System.Drawing.Color.Gold;
            this.btn_P_compartimentos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P_compartimentos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_P_compartimentos.Location = new System.Drawing.Point(40, 100);
            this.btn_P_compartimentos.Name = "btn_P_compartimentos";
            this.btn_P_compartimentos.Size = new System.Drawing.Size(141, 36);
            this.btn_P_compartimentos.TabIndex = 98;
            this.btn_P_compartimentos.Text = " P. Compartimentos";
            this.btn_P_compartimentos.UseVisualStyleBackColor = false;
            this.btn_P_compartimentos.Click += new System.EventHandler(this.btn_P_compartimentos_Click);
            // 
            // txt_local_instalacaoMysql
            // 
            this.txt_local_instalacaoMysql.Location = new System.Drawing.Point(22, 172);
            this.txt_local_instalacaoMysql.Name = "txt_local_instalacaoMysql";
            this.txt_local_instalacaoMysql.Size = new System.Drawing.Size(548, 29);
            this.txt_local_instalacaoMysql.TabIndex = 99;
            this.txt_local_instalacaoMysql.TextChanged += new System.EventHandler(this.txt_local_instalacaoMysql_TextChanged);
            // 
            // txt_localArquivoSql
            // 
            this.txt_localArquivoSql.Location = new System.Drawing.Point(22, 228);
            this.txt_localArquivoSql.Name = "txt_localArquivoSql";
            this.txt_localArquivoSql.Size = new System.Drawing.Size(548, 29);
            this.txt_localArquivoSql.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 101;
            this.label2.Text = "Local instalação MySql";
            // 
            // btn_local1
            // 
            this.btn_local1.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_local1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_local1.ForeColor = System.Drawing.Color.Gold;
            this.btn_local1.Location = new System.Drawing.Point(576, 170);
            this.btn_local1.Name = "btn_local1";
            this.btn_local1.Size = new System.Drawing.Size(109, 36);
            this.btn_local1.TabIndex = 102;
            this.btn_local1.Text = "Local";
            this.btn_local1.UseVisualStyleBackColor = false;
            this.btn_local1.Click += new System.EventHandler(this.btn_local1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 23);
            this.label3.TabIndex = 103;
            this.label3.Text = "Local  do arquivo .Sql";
            // 
            // btn_local2
            // 
            this.btn_local2.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_local2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_local2.ForeColor = System.Drawing.Color.Gold;
            this.btn_local2.Location = new System.Drawing.Point(576, 226);
            this.btn_local2.Name = "btn_local2";
            this.btn_local2.Size = new System.Drawing.Size(109, 36);
            this.btn_local2.TabIndex = 104;
            this.btn_local2.Text = "Local";
            this.btn_local2.UseVisualStyleBackColor = false;
            this.btn_local2.Click += new System.EventHandler(this.btn_local2_Click);
            // 
            // btn_local3
            // 
            this.btn_local3.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_local3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_local3.ForeColor = System.Drawing.Color.Gold;
            this.btn_local3.Location = new System.Drawing.Point(576, 281);
            this.btn_local3.Name = "btn_local3";
            this.btn_local3.Size = new System.Drawing.Size(109, 36);
            this.btn_local3.TabIndex = 107;
            this.btn_local3.Text = "Local";
            this.btn_local3.UseVisualStyleBackColor = false;
            this.btn_local3.Click += new System.EventHandler(this.btn_local3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 23);
            this.label4.TabIndex = 106;
            this.label4.Text = "Local para backup ou salvar arquivo  .Sql";
            // 
            // txt_local_Backup
            // 
            this.txt_local_Backup.Location = new System.Drawing.Point(22, 286);
            this.txt_local_Backup.Name = "txt_local_Backup";
            this.txt_local_Backup.Size = new System.Drawing.Size(548, 29);
            this.txt_local_Backup.TabIndex = 105;
            // 
            // btn_RealizarBackup
            // 
            this.btn_RealizarBackup.BackColor = System.Drawing.Color.Gold;
            this.btn_RealizarBackup.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RealizarBackup.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_RealizarBackup.Location = new System.Drawing.Point(690, 347);
            this.btn_RealizarBackup.Name = "btn_RealizarBackup";
            this.btn_RealizarBackup.Size = new System.Drawing.Size(141, 56);
            this.btn_RealizarBackup.TabIndex = 108;
            this.btn_RealizarBackup.Text = "Realizar Backup";
            this.btn_RealizarBackup.UseVisualStyleBackColor = false;
            this.btn_RealizarBackup.Click += new System.EventHandler(this.btn_RealizarBackup_Click);
            // 
            // btn_RestaurarBD
            // 
            this.btn_RestaurarBD.BackColor = System.Drawing.Color.Gold;
            this.btn_RestaurarBD.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RestaurarBD.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_RestaurarBD.Location = new System.Drawing.Point(691, 229);
            this.btn_RestaurarBD.Name = "btn_RestaurarBD";
            this.btn_RestaurarBD.Size = new System.Drawing.Size(141, 59);
            this.btn_RestaurarBD.TabIndex = 109;
            this.btn_RestaurarBD.Text = "Restaurar Banco de Dados";
            this.btn_RestaurarBD.UseVisualStyleBackColor = false;
            this.btn_RestaurarBD.Click += new System.EventHandler(this.btn_RestaurarBD_Click);
            // 
            // btn_criarBD
            // 
            this.btn_criarBD.BackColor = System.Drawing.Color.Gold;
            this.btn_criarBD.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criarBD.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_criarBD.Location = new System.Drawing.Point(691, 172);
            this.btn_criarBD.Name = "btn_criarBD";
            this.btn_criarBD.Size = new System.Drawing.Size(141, 56);
            this.btn_criarBD.TabIndex = 110;
            this.btn_criarBD.Text = "Criar Banco de Dados";
            this.btn_criarBD.UseVisualStyleBackColor = false;
            this.btn_criarBD.Click += new System.EventHandler(this.btn_criarBD_Click);
            // 
            // txt_listsPort
            // 
            this.txt_listsPort.FormattingEnabled = true;
            this.txt_listsPort.Location = new System.Drawing.Point(24, 32);
            this.txt_listsPort.Name = "txt_listsPort";
            this.txt_listsPort.Size = new System.Drawing.Size(96, 31);
            this.txt_listsPort.TabIndex = 111;
            this.txt_listsPort.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.txt_listsPort.Click += new System.EventHandler(this.txt_listsPort_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 23);
            this.label5.TabIndex = 112;
            this.label5.Text = "Porta de conexão com arduino";
            // 
            // btn_conectarArduino
            // 
            this.btn_conectarArduino.BackColor = System.Drawing.Color.Gold;
            this.btn_conectarArduino.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectarArduino.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_conectarArduino.Location = new System.Drawing.Point(126, 30);
            this.btn_conectarArduino.Name = "btn_conectarArduino";
            this.btn_conectarArduino.Size = new System.Drawing.Size(131, 36);
            this.btn_conectarArduino.TabIndex = 113;
            this.btn_conectarArduino.Text = "Conectar";
            this.btn_conectarArduino.UseVisualStyleBackColor = false;
            this.btn_conectarArduino.Click += new System.EventHandler(this.btn_conectarArduino_Click);
            // 
            // txt_StatusPort
            // 
            this.txt_StatusPort.AutoSize = true;
            this.txt_StatusPort.BackColor = System.Drawing.Color.Lime;
            this.txt_StatusPort.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StatusPort.ForeColor = System.Drawing.Color.Red;
            this.txt_StatusPort.Location = new System.Drawing.Point(24, 68);
            this.txt_StatusPort.Name = "txt_StatusPort";
            this.txt_StatusPort.Size = new System.Drawing.Size(159, 23);
            this.txt_StatusPort.TabIndex = 114;
            this.txt_StatusPort.Text = "Não conectado *****";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(278, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 23);
            this.label7.TabIndex = 115;
            this.label7.Text = "Abertura de Compartimentos";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(282, 32);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(83, 50);
            this.numericUpDown1.TabIndex = 117;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.Click += new System.EventHandler(this.numericUpDown1_Click);
            // 
            // btn_AbrirUm
            // 
            this.btn_AbrirUm.BackColor = System.Drawing.Color.Gold;
            this.btn_AbrirUm.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AbrirUm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_AbrirUm.Location = new System.Drawing.Point(371, 32);
            this.btn_AbrirUm.Name = "btn_AbrirUm";
            this.btn_AbrirUm.Size = new System.Drawing.Size(119, 50);
            this.btn_AbrirUm.TabIndex = 118;
            this.btn_AbrirUm.Text = "Abrir Um";
            this.btn_AbrirUm.UseVisualStyleBackColor = false;
            this.btn_AbrirUm.Click += new System.EventHandler(this.btn_AbrirUm_Click);
            // 
            // btn_TesteLeitor
            // 
            this.btn_TesteLeitor.BackColor = System.Drawing.Color.Gold;
            this.btn_TesteLeitor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TesteLeitor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_TesteLeitor.Location = new System.Drawing.Point(5, 3);
            this.btn_TesteLeitor.Name = "btn_TesteLeitor";
            this.btn_TesteLeitor.Size = new System.Drawing.Size(174, 36);
            this.btn_TesteLeitor.TabIndex = 120;
            this.btn_TesteLeitor.Text = "Teste Leitor Biométrico";
            this.btn_TesteLeitor.UseVisualStyleBackColor = false;
            this.btn_TesteLeitor.Click += new System.EventHandler(this.btn_TesteLeitor_Click);
            // 
            // txt_msgPort
            // 
            this.txt_msgPort.BackColor = System.Drawing.Color.Cyan;
            this.txt_msgPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_msgPort.Location = new System.Drawing.Point(4, 45);
            this.txt_msgPort.Multiline = true;
            this.txt_msgPort.Name = "txt_msgPort";
            this.txt_msgPort.Size = new System.Drawing.Size(606, 58);
            this.txt_msgPort.TabIndex = 121;
            // 
            // btn_RemoverBiometrias
            // 
            this.btn_RemoverBiometrias.BackColor = System.Drawing.Color.Gold;
            this.btn_RemoverBiometrias.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoverBiometrias.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_RemoverBiometrias.Location = new System.Drawing.Point(183, 3);
            this.btn_RemoverBiometrias.Name = "btn_RemoverBiometrias";
            this.btn_RemoverBiometrias.Size = new System.Drawing.Size(182, 36);
            this.btn_RemoverBiometrias.TabIndex = 122;
            this.btn_RemoverBiometrias.Text = "Remover todas biometrias";
            this.btn_RemoverBiometrias.UseVisualStyleBackColor = false;
            this.btn_RemoverBiometrias.Click += new System.EventHandler(this.btn_RemoverBiometrias_Click);
            // 
            // btn_AbrirTodos
            // 
            this.btn_AbrirTodos.BackColor = System.Drawing.Color.Gold;
            this.btn_AbrirTodos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AbrirTodos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_AbrirTodos.Location = new System.Drawing.Point(496, 32);
            this.btn_AbrirTodos.Name = "btn_AbrirTodos";
            this.btn_AbrirTodos.Size = new System.Drawing.Size(114, 50);
            this.btn_AbrirTodos.TabIndex = 123;
            this.btn_AbrirTodos.Text = "Abrir Todos";
            this.btn_AbrirTodos.UseVisualStyleBackColor = false;
            this.btn_AbrirTodos.Click += new System.EventHandler(this.btn_AbrirTodos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_listsPort);
            this.panel2.Controls.Add(this.btn_AbrirTodos);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_conectarArduino);
            this.panel2.Controls.Add(this.txt_StatusPort);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.btn_AbrirUm);
            this.panel2.Location = new System.Drawing.Point(22, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 100);
            this.panel2.TabIndex = 124;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txt_biometriaRemovida);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btn_RemoverBiometrias);
            this.panel3.Controls.Add(this.txt_msgPort);
            this.panel3.Controls.Add(this.btn_TesteLeitor);
            this.panel3.Location = new System.Drawing.Point(22, 496);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 110);
            this.panel3.TabIndex = 125;
            // 
            // txt_biometriaRemovida
            // 
            this.txt_biometriaRemovida.AutoSize = true;
            this.txt_biometriaRemovida.BackColor = System.Drawing.Color.Lime;
            this.txt_biometriaRemovida.ForeColor = System.Drawing.Color.Red;
            this.txt_biometriaRemovida.Location = new System.Drawing.Point(545, 8);
            this.txt_biometriaRemovida.Name = "txt_biometriaRemovida";
            this.txt_biometriaRemovida.Size = new System.Drawing.Size(46, 23);
            this.txt_biometriaRemovida.TabIndex = 124;
            this.txt_biometriaRemovida.Text = "0000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(371, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 23);
            this.label9.TabIndex = 123;
            this.label9.Text = "Removido Biometria:";
            // 
            // btn_InstalarDotNEt
            // 
            this.btn_InstalarDotNEt.BackColor = System.Drawing.Color.Gold;
            this.btn_InstalarDotNEt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InstalarDotNEt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_InstalarDotNEt.Location = new System.Drawing.Point(690, 406);
            this.btn_InstalarDotNEt.Name = "btn_InstalarDotNEt";
            this.btn_InstalarDotNEt.Size = new System.Drawing.Size(141, 56);
            this.btn_InstalarDotNEt.TabIndex = 126;
            this.btn_InstalarDotNEt.Text = "Instalar dot .Net";
            this.btn_InstalarDotNEt.UseVisualStyleBackColor = false;
            this.btn_InstalarDotNEt.Click += new System.EventHandler(this.btn_InstalarDotNEt_Click);
            // 
            // btn_instalarPlugin
            // 
            this.btn_instalarPlugin.BackColor = System.Drawing.Color.Gold;
            this.btn_instalarPlugin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_instalarPlugin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_instalarPlugin.Location = new System.Drawing.Point(690, 464);
            this.btn_instalarPlugin.Name = "btn_instalarPlugin";
            this.btn_instalarPlugin.Size = new System.Drawing.Size(141, 56);
            this.btn_instalarPlugin.TabIndex = 123;
            this.btn_instalarPlugin.Text = "Instalar plugin Mysql";
            this.btn_instalarPlugin.UseVisualStyleBackColor = false;
            this.btn_instalarPlugin.Click += new System.EventHandler(this.btn_instalarPlugin_Click);
            // 
            // btn_InstalarMysql
            // 
            this.btn_InstalarMysql.BackColor = System.Drawing.Color.Gold;
            this.btn_InstalarMysql.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InstalarMysql.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_InstalarMysql.Location = new System.Drawing.Point(690, 523);
            this.btn_InstalarMysql.Name = "btn_InstalarMysql";
            this.btn_InstalarMysql.Size = new System.Drawing.Size(141, 56);
            this.btn_InstalarMysql.TabIndex = 123;
            this.btn_InstalarMysql.Text = "Instalar MySql";
            this.btn_InstalarMysql.UseVisualStyleBackColor = false;
            this.btn_InstalarMysql.Click += new System.EventHandler(this.btn_InstalarMysql_Click);
            // 
            // txt_localArquivoEXE
            // 
            this.txt_localArquivoEXE.Location = new System.Drawing.Point(22, 355);
            this.txt_localArquivoEXE.Name = "txt_localArquivoEXE";
            this.txt_localArquivoEXE.Size = new System.Drawing.Size(548, 29);
            this.txt_localArquivoEXE.TabIndex = 127;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(18, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(432, 23);
            this.label11.TabIndex = 128;
            this.label11.Text = "Selecione o local do arquivo .EXE para iniciar instalação";
            // 
            // btn_local4
            // 
            this.btn_local4.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_local4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_local4.ForeColor = System.Drawing.Color.Gold;
            this.btn_local4.Location = new System.Drawing.Point(573, 353);
            this.btn_local4.Name = "btn_local4";
            this.btn_local4.Size = new System.Drawing.Size(109, 36);
            this.btn_local4.TabIndex = 129;
            this.btn_local4.Text = "Local";
            this.btn_local4.UseVisualStyleBackColor = false;
            this.btn_local4.Click += new System.EventHandler(this.btn_local4_Click);
            // 
            // btn_trucateBD
            // 
            this.btn_trucateBD.BackColor = System.Drawing.Color.Gold;
            this.btn_trucateBD.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trucateBD.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_trucateBD.Location = new System.Drawing.Point(691, 289);
            this.btn_trucateBD.Name = "btn_trucateBD";
            this.btn_trucateBD.Size = new System.Drawing.Size(141, 56);
            this.btn_trucateBD.TabIndex = 130;
            this.btn_trucateBD.Text = "Truncate Banco de Dados";
            this.btn_trucateBD.UseVisualStyleBackColor = false;
            this.btn_trucateBD.Click += new System.EventHandler(this.btn_trucateBD_Click);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txt_statusPorta);
            this.panel4.Controls.Add(this.txt_usuario);
            this.panel4.Controls.Add(this.txt_data);
            this.panel4.Location = new System.Drawing.Point(1, 612);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(831, 50);
            this.panel4.TabIndex = 131;
            // 
            // txt_usuario
            // 
            this.txt_usuario.AutoSize = true;
            this.txt_usuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Gold;
            this.txt_usuario.Location = new System.Drawing.Point(362, 13);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(131, 20);
            this.txt_usuario.TabIndex = 4;
            this.txt_usuario.Text = "Develophers Admin";
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
            // txt_statusPorta
            // 
            this.txt_statusPorta.AutoSize = true;
            this.txt_statusPorta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_statusPorta.ForeColor = System.Drawing.Color.Gold;
            this.txt_statusPorta.Location = new System.Drawing.Point(694, 13);
            this.txt_statusPorta.Name = "txt_statusPorta";
            this.txt_statusPorta.Size = new System.Drawing.Size(125, 20);
            this.txt_statusPorta.TabIndex = 6;
            this.txt_statusPorta.Text = "Não conectado:****";
            // 
            // Develophers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(834, 661);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_trucateBD);
            this.Controls.Add(this.btn_local4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_localArquivoEXE);
            this.Controls.Add(this.btn_InstalarMysql);
            this.Controls.Add(this.btn_instalarPlugin);
            this.Controls.Add(this.btn_InstalarDotNEt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_criarBD);
            this.Controls.Add(this.btn_RestaurarBD);
            this.Controls.Add(this.btn_RealizarBackup);
            this.Controls.Add(this.btn_local3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_local_Backup);
            this.Controls.Add(this.btn_local2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_local1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_localArquivoSql);
            this.Controls.Add(this.txt_local_instalacaoMysql);
            this.Controls.Add(this.btn_P_compartimentos);
            this.Controls.Add(this.btn_setup);
            this.Controls.Add(this.btn_retirar);
            this.Controls.Add(this.btn_entregar);
            this.Controls.Add(this.btn_encomendas);
            this.Controls.Add(this.btn_relatorio);
            this.Controls.Add(this.btn_manutencao);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.btn_compartimentos);
            this.Controls.Add(this.btn_principal);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Develophers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Develophers";
            this.Load += new System.EventHandler(this.Develophers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_principal;
        private System.Windows.Forms.Button btn_compartimentos;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Button btn_manutencao;
        private System.Windows.Forms.Button btn_relatorio;
        private System.Windows.Forms.Button btn_encomendas;
        private System.Windows.Forms.Button btn_entregar;
        private System.Windows.Forms.Button btn_retirar;
        private System.Windows.Forms.Button btn_setup;
        private System.Windows.Forms.Button btn_P_compartimentos;
        private System.Windows.Forms.TextBox txt_local_instalacaoMysql;
        private System.Windows.Forms.TextBox txt_localArquivoSql;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_local1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_local2;
        private System.Windows.Forms.Button btn_local3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_local_Backup;
        private System.Windows.Forms.Button btn_RealizarBackup;
        private System.Windows.Forms.Button btn_RestaurarBD;
        private System.Windows.Forms.Button btn_criarBD;
        private System.Windows.Forms.ComboBox txt_listsPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_conectarArduino;
        private System.Windows.Forms.Label txt_StatusPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_AbrirUm;
        private System.Windows.Forms.Button btn_TesteLeitor;
        private System.Windows.Forms.TextBox txt_msgPort;
        private System.Windows.Forms.Button btn_RemoverBiometrias;
        private System.Windows.Forms.Button btn_AbrirTodos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txt_biometriaRemovida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_InstalarDotNEt;
        private System.Windows.Forms.Button btn_instalarPlugin;
        private System.Windows.Forms.Button btn_InstalarMysql;
        private System.Windows.Forms.TextBox txt_localArquivoEXE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_local4;
        private System.Windows.Forms.Button btn_trucateBD;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txt_usuario;
        private System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.Label txt_statusPorta;
    }
}