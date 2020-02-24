namespace CondoBiometry
{
    partial class frm_Relatorio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Relatorio));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_statusPort = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.txt_filtro = new System.Windows.Forms.ComboBox();
            this.txt_periodo_boco = new System.Windows.Forms.Label();
            this.txt_periodo = new System.Windows.Forms.ComboBox();
            this.btn_gerar_Relatorio = new System.Windows.Forms.Button();
            this.txt_apto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_bloco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_entrada_busca = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_entrada = new System.Windows.Forms.TextBox();
            this.txt_tipo_relatorio = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_nome = new System.Windows.Forms.Panel();
            this.panel_bloco = new System.Windows.Forms.Panel();
            this.panel_periodo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel_nome.SuspendLayout();
            this.panel_bloco.SuspendLayout();
            this.panel_periodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_statusPort);
            this.panel2.Controls.Add(this.txt_usuario);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_data);
            this.panel2.Location = new System.Drawing.Point(2, 609);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 50);
            this.panel2.TabIndex = 107;
            // 
            // txt_statusPort
            // 
            this.txt_statusPort.AutoSize = true;
            this.txt_statusPort.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_statusPort.ForeColor = System.Drawing.Color.Gold;
            this.txt_statusPort.Location = new System.Drawing.Point(847, 13);
            this.txt_statusPort.Name = "txt_statusPort";
            this.txt_statusPort.Size = new System.Drawing.Size(121, 20);
            this.txt_statusPort.TabIndex = 5;
            this.txt_statusPort.Text = "Não conectado****";
            // 
            // txt_usuario
            // 
            this.txt_usuario.AutoSize = true;
            this.txt_usuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Gold;
            this.txt_usuario.Location = new System.Drawing.Point(704, 13);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(114, 20);
            this.txt_usuario.TabIndex = 4;
            this.txt_usuario.Text = "Condo  Biometry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(637, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuário:";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.btn_voltar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 60);
            this.panel1.TabIndex = 108;
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
            this.btn_voltar.Location = new System.Drawing.Point(720, -1);
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
            this.label1.Location = new System.Drawing.Point(334, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "RELATÓRIOS";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(315, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 23);
            this.label13.TabIndex = 163;
            this.label13.Text = "Filtrar por:";
            // 
            // txt_filtro
            // 
            this.txt_filtro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro.FormattingEnabled = true;
            this.txt_filtro.Items.AddRange(new object[] {
            "Selecione"});
            this.txt_filtro.Location = new System.Drawing.Point(416, 11);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(225, 28);
            this.txt_filtro.TabIndex = 162;
            this.txt_filtro.SelectedIndexChanged += new System.EventHandler(this.txt_filtro_SelectedIndexChanged);
            // 
            // txt_periodo_boco
            // 
            this.txt_periodo_boco.AutoSize = true;
            this.txt_periodo_boco.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_periodo_boco.ForeColor = System.Drawing.Color.White;
            this.txt_periodo_boco.Location = new System.Drawing.Point(3, 10);
            this.txt_periodo_boco.Name = "txt_periodo_boco";
            this.txt_periodo_boco.Size = new System.Drawing.Size(59, 23);
            this.txt_periodo_boco.TabIndex = 161;
            this.txt_periodo_boco.Text = "Bloco:";
            // 
            // txt_periodo
            // 
            this.txt_periodo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_periodo.FormattingEnabled = true;
            this.txt_periodo.Items.AddRange(new object[] {
            "Mensal",
            "Trimestral",
            "Semestral",
            "Anual"});
            this.txt_periodo.Location = new System.Drawing.Point(92, 5);
            this.txt_periodo.Name = "txt_periodo";
            this.txt_periodo.Size = new System.Drawing.Size(225, 28);
            this.txt_periodo.TabIndex = 160;
            this.txt_periodo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btn_gerar_Relatorio
            // 
            this.btn_gerar_Relatorio.BackColor = System.Drawing.Color.Gold;
            this.btn_gerar_Relatorio.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerar_Relatorio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_gerar_Relatorio.Location = new System.Drawing.Point(660, 45);
            this.btn_gerar_Relatorio.Name = "btn_gerar_Relatorio";
            this.btn_gerar_Relatorio.Size = new System.Drawing.Size(162, 44);
            this.btn_gerar_Relatorio.TabIndex = 159;
            this.btn_gerar_Relatorio.Text = "Relatório";
            this.btn_gerar_Relatorio.UseVisualStyleBackColor = false;
            this.btn_gerar_Relatorio.Click += new System.EventHandler(this.btn_gerar_Relatorio_Click);
            // 
            // txt_apto
            // 
            this.txt_apto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apto.Location = new System.Drawing.Point(196, 10);
            this.txt_apto.Name = "txt_apto";
            this.txt_apto.Size = new System.Drawing.Size(81, 26);
            this.txt_apto.TabIndex = 158;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(139, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 157;
            this.label6.Text = "Apto:";
            // 
            // txt_bloco
            // 
            this.txt_bloco.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bloco.Location = new System.Drawing.Point(68, 7);
            this.txt_bloco.Name = "txt_bloco";
            this.txt_bloco.Size = new System.Drawing.Size(65, 29);
            this.txt_bloco.TabIndex = 156;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-1, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 154;
            this.label4.Text = "Tipo relatório:";
            // 
            // txt_entrada_busca
            // 
            this.txt_entrada_busca.AutoSize = true;
            this.txt_entrada_busca.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_entrada_busca.ForeColor = System.Drawing.Color.White;
            this.txt_entrada_busca.Location = new System.Drawing.Point(1, 8);
            this.txt_entrada_busca.Name = "txt_entrada_busca";
            this.txt_entrada_busca.Size = new System.Drawing.Size(121, 23);
            this.txt_entrada_busca.TabIndex = 153;
            this.txt_entrada_busca.Text = "Nome usuario:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Gold;
            this.btn_buscar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_buscar.Location = new System.Drawing.Point(660, 3);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(162, 44);
            this.btn_buscar.TabIndex = 152;
            this.btn_buscar.Text = "Consulta";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_entrada
            // 
            this.txt_entrada.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_entrada.Location = new System.Drawing.Point(156, 8);
            this.txt_entrada.Name = "txt_entrada";
            this.txt_entrada.Size = new System.Drawing.Size(266, 26);
            this.txt_entrada.TabIndex = 150;
            // 
            // txt_tipo_relatorio
            // 
            this.txt_tipo_relatorio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo_relatorio.FormattingEnabled = true;
            this.txt_tipo_relatorio.Items.AddRange(new object[] {
            "Usuarios",
            "Encomendas",
            "Compartimentos",
            "Manutenção",
            "Aberturas",
            "Auditoria"});
            this.txt_tipo_relatorio.Location = new System.Drawing.Point(126, 14);
            this.txt_tipo_relatorio.Name = "txt_tipo_relatorio";
            this.txt_tipo_relatorio.Size = new System.Drawing.Size(183, 28);
            this.txt_tipo_relatorio.TabIndex = 148;
            this.txt_tipo_relatorio.SelectedIndexChanged += new System.EventHandler(this.txt_tipo_relatorio_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(4, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(827, 432);
            this.dataGridView1.TabIndex = 147;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel_nome);
            this.panel3.Controls.Add(this.btn_buscar);
            this.panel3.Controls.Add(this.btn_gerar_Relatorio);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_filtro);
            this.panel3.Controls.Add(this.txt_tipo_relatorio);
            this.panel3.Location = new System.Drawing.Point(2, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(829, 102);
            this.panel3.TabIndex = 164;
            // 
            // panel_nome
            // 
            this.panel_nome.Controls.Add(this.txt_entrada_busca);
            this.panel_nome.Controls.Add(this.txt_entrada);
            this.panel_nome.Location = new System.Drawing.Point(0, 48);
            this.panel_nome.Name = "panel_nome";
            this.panel_nome.Size = new System.Drawing.Size(641, 47);
            this.panel_nome.TabIndex = 164;
            this.panel_nome.Visible = false;
            // 
            // panel_bloco
            // 
            this.panel_bloco.Controls.Add(this.txt_periodo_boco);
            this.panel_bloco.Controls.Add(this.txt_apto);
            this.panel_bloco.Controls.Add(this.txt_bloco);
            this.panel_bloco.Controls.Add(this.label6);
            this.panel_bloco.Location = new System.Drawing.Point(4, 113);
            this.panel_bloco.Name = "panel_bloco";
            this.panel_bloco.Size = new System.Drawing.Size(611, 50);
            this.panel_bloco.TabIndex = 165;
            this.panel_bloco.Visible = false;
            // 
            // panel_periodo
            // 
            this.panel_periodo.Controls.Add(this.label2);
            this.panel_periodo.Controls.Add(this.txt_periodo);
            this.panel_periodo.Location = new System.Drawing.Point(6, 117);
            this.panel_periodo.Name = "panel_periodo";
            this.panel_periodo.Size = new System.Drawing.Size(587, 43);
            this.panel_periodo.TabIndex = 166;
            this.panel_periodo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 162;
            this.label2.Text = "Período:";
            // 
            // frm_Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(834, 661);
            this.Controls.Add(this.panel_periodo);
            this.Controls.Add(this.panel_bloco);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condo Biometry";
            this.Load += new System.EventHandler(this.frm_Relatorio_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_nome.ResumeLayout(false);
            this.panel_nome.PerformLayout();
            this.panel_bloco.ResumeLayout(false);
            this.panel_bloco.PerformLayout();
            this.panel_periodo.ResumeLayout(false);
            this.panel_periodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txt_statusPort;
        private System.Windows.Forms.Label txt_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox txt_filtro;
        private System.Windows.Forms.Label txt_periodo_boco;
        private System.Windows.Forms.ComboBox txt_periodo;
        private System.Windows.Forms.Button btn_gerar_Relatorio;
        private System.Windows.Forms.TextBox txt_apto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_bloco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_entrada_busca;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_entrada;
        private System.Windows.Forms.ComboBox txt_tipo_relatorio;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_nome;
        private System.Windows.Forms.Panel panel_bloco;
        private System.Windows.Forms.Panel panel_periodo;
        private System.Windows.Forms.Label label2;
    }
}