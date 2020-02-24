namespace CondoBiometry
{
    partial class frm_Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Setup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_statusPort = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_setup = new System.Windows.Forms.Button();
            this.btn_retirar = new System.Windows.Forms.Button();
            this.btn_entregar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(291, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU ADMINISTRADOR";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_statusPort);
            this.panel2.Controls.Add(this.txt_usuario);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_data);
            this.panel2.Location = new System.Drawing.Point(2, 608);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 50);
            this.panel2.TabIndex = 106;
            // 
            // txt_statusPort
            // 
            this.txt_statusPort.AutoSize = true;
            this.txt_statusPort.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_statusPort.ForeColor = System.Drawing.Color.Gold;
            this.txt_statusPort.Location = new System.Drawing.Point(673, 13);
            this.txt_statusPort.Name = "txt_statusPort";
            this.txt_statusPort.Size = new System.Drawing.Size(129, 20);
            this.txt_statusPort.TabIndex = 5;
            this.txt_statusPort.Text = "Não conectado: ****";
            // 
            // txt_usuario
            // 
            this.txt_usuario.AutoSize = true;
            this.txt_usuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Gold;
            this.txt_usuario.Location = new System.Drawing.Point(428, 13);
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
            this.label3.Location = new System.Drawing.Point(365, 13);
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gold;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button5.Location = new System.Drawing.Point(437, 277);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(341, 99);
            this.button5.TabIndex = 112;
            this.button5.Text = "Mapa Ebox";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(437, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 98);
            this.button1.TabIndex = 111;
            this.button1.Text = "Relatórios";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.Location = new System.Drawing.Point(437, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(341, 93);
            this.button3.TabIndex = 110;
            this.button3.Text = "Compartimentos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_setup
            // 
            this.btn_setup.BackColor = System.Drawing.Color.Gold;
            this.btn_setup.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setup.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_setup.Location = new System.Drawing.Point(50, 278);
            this.btn_setup.Name = "btn_setup";
            this.btn_setup.Size = new System.Drawing.Size(341, 96);
            this.btn_setup.TabIndex = 109;
            this.btn_setup.Text = "Manutenção";
            this.btn_setup.UseVisualStyleBackColor = false;
            this.btn_setup.Click += new System.EventHandler(this.btn_setup_Click);
            // 
            // btn_retirar
            // 
            this.btn_retirar.BackColor = System.Drawing.Color.Gold;
            this.btn_retirar.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retirar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_retirar.Location = new System.Drawing.Point(50, 435);
            this.btn_retirar.Name = "btn_retirar";
            this.btn_retirar.Size = new System.Drawing.Size(341, 96);
            this.btn_retirar.TabIndex = 108;
            this.btn_retirar.Text = "Encomendas";
            this.btn_retirar.UseVisualStyleBackColor = false;
            this.btn_retirar.Click += new System.EventHandler(this.btn_retirar_Click);
            // 
            // btn_entregar
            // 
            this.btn_entregar.BackColor = System.Drawing.Color.Gold;
            this.btn_entregar.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entregar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_entregar.Location = new System.Drawing.Point(50, 125);
            this.btn_entregar.Name = "btn_entregar";
            this.btn_entregar.Size = new System.Drawing.Size(341, 93);
            this.btn_entregar.TabIndex = 107;
            this.btn_entregar.Text = "Cadastros";
            this.btn_entregar.UseVisualStyleBackColor = false;
            this.btn_entregar.Click += new System.EventHandler(this.btn_entregar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(834, 661);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_setup);
            this.Controls.Add(this.btn_retirar);
            this.Controls.Add(this.btn_entregar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condo Biometry";
            this.Load += new System.EventHandler(this.frm_Setup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txt_statusPort;
        private System.Windows.Forms.Label txt_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_setup;
        private System.Windows.Forms.Button btn_retirar;
        private System.Windows.Forms.Button btn_entregar;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}