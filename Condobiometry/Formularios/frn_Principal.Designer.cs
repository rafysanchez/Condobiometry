namespace CondoBiometry
{
    partial class frm_principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_statusPort = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.Label();
            this.btn_entregar = new System.Windows.Forms.Button();
            this.btn_retirar = new System.Windows.Forms.Button();
            this.btn_setup = new System.Windows.Forms.Button();
            this.panel_conection = new System.Windows.Forms.Panel();
            this.lb_ultimaPorta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_estadoPorta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_ListPort = new System.Windows.Forms.ComboBox();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_login = new System.Windows.Forms.Panel();
            this.txt_senhaUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nomeUsuaario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancelar2 = new System.Windows.Forms.Button();
            this.btn_acessar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_conection.SuspendLayout();
            this.panel_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(262, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONDOMINIO EMBU B1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_statusPort);
            this.panel2.Controls.Add(this.txt_usuario);
            this.panel2.Controls.Add(this.txt_data);
            this.panel2.Location = new System.Drawing.Point(2, 609);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 50);
            this.panel2.TabIndex = 1;
            // 
            // txt_statusPort
            // 
            this.txt_statusPort.AutoSize = true;
            this.txt_statusPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_statusPort.ForeColor = System.Drawing.Color.Gold;
            this.txt_statusPort.Location = new System.Drawing.Point(671, 13);
            this.txt_statusPort.Name = "txt_statusPort";
            this.txt_statusPort.Size = new System.Drawing.Size(168, 20);
            this.txt_statusPort.TabIndex = 5;
            this.txt_statusPort.Text = "Não conectado: ****";
            // 
            // txt_usuario
            // 
            this.txt_usuario.AutoSize = true;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Gold;
            this.txt_usuario.Location = new System.Drawing.Point(367, 13);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(173, 20);
            this.txt_usuario.TabIndex = 4;
            this.txt_usuario.Text = "CondoBiometry V1.0";
            // 
            // txt_data
            // 
            this.txt_data.AutoSize = true;
            this.txt_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.ForeColor = System.Drawing.Color.Gold;
            this.txt_data.Location = new System.Drawing.Point(7, 13);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(328, 20);
            this.txt_data.TabIndex = 2;
            this.txt_data.Text = "Sabado 04 de Agosto de 2018 19:33:57";
            // 
            // btn_entregar
            // 
            this.btn_entregar.BackColor = System.Drawing.Color.Gold;
            this.btn_entregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entregar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_entregar.Location = new System.Drawing.Point(63, 77);
            this.btn_entregar.Name = "btn_entregar";
            this.btn_entregar.Size = new System.Drawing.Size(713, 117);
            this.btn_entregar.TabIndex = 2;
            this.btn_entregar.Text = "ENTREGAR  ENCOMENDAS";
            this.btn_entregar.UseVisualStyleBackColor = false;
            this.btn_entregar.Click += new System.EventHandler(this.btn_entregar_Click);
            // 
            // btn_retirar
            // 
            this.btn_retirar.BackColor = System.Drawing.Color.Gold;
            this.btn_retirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retirar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_retirar.Location = new System.Drawing.Point(63, 262);
            this.btn_retirar.Name = "btn_retirar";
            this.btn_retirar.Size = new System.Drawing.Size(713, 117);
            this.btn_retirar.TabIndex = 3;
            this.btn_retirar.Text = "RETIRAR ENCOMENDAS";
            this.btn_retirar.UseVisualStyleBackColor = false;
            this.btn_retirar.Click += new System.EventHandler(this.btn_retirar_Click);
            // 
            // btn_setup
            // 
            this.btn_setup.BackColor = System.Drawing.Color.Gold;
            this.btn_setup.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setup.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_setup.Location = new System.Drawing.Point(602, 539);
            this.btn_setup.Name = "btn_setup";
            this.btn_setup.Size = new System.Drawing.Size(220, 64);
            this.btn_setup.TabIndex = 4;
            this.btn_setup.Text = "SETUP";
            this.btn_setup.UseVisualStyleBackColor = false;
            this.btn_setup.Click += new System.EventHandler(this.btn_setup_Click);
            // 
            // panel_conection
            // 
            this.panel_conection.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_conection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_conection.Controls.Add(this.lb_ultimaPorta);
            this.panel_conection.Controls.Add(this.label7);
            this.panel_conection.Controls.Add(this.txt_estadoPorta);
            this.panel_conection.Controls.Add(this.label8);
            this.panel_conection.Controls.Add(this.btn_cancelar);
            this.panel_conection.Controls.Add(this.txt_ListPort);
            this.panel_conection.Controls.Add(this.btn_conectar);
            this.panel_conection.Controls.Add(this.label9);
            this.panel_conection.Controls.Add(this.label10);
            this.panel_conection.Location = new System.Drawing.Point(31, 77);
            this.panel_conection.Name = "panel_conection";
            this.panel_conection.Size = new System.Drawing.Size(791, 399);
            this.panel_conection.TabIndex = 99;
            this.panel_conection.Visible = false;
            // 
            // lb_ultimaPorta
            // 
            this.lb_ultimaPorta.AutoSize = true;
            this.lb_ultimaPorta.BackColor = System.Drawing.Color.Transparent;
            this.lb_ultimaPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ultimaPorta.ForeColor = System.Drawing.Color.Yellow;
            this.lb_ultimaPorta.Location = new System.Drawing.Point(346, 323);
            this.lb_ultimaPorta.Name = "lb_ultimaPorta";
            this.lb_ultimaPorta.Size = new System.Drawing.Size(96, 31);
            this.lb_ultimaPorta.TabIndex = 59;
            this.lb_ultimaPorta.Text = "COM4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(3, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 31);
            this.label7.TabIndex = 58;
            this.label7.Text = "Ultima porta de conexão.";
            // 
            // txt_estadoPorta
            // 
            this.txt_estadoPorta.AutoSize = true;
            this.txt_estadoPorta.BackColor = System.Drawing.Color.Transparent;
            this.txt_estadoPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estadoPorta.ForeColor = System.Drawing.Color.Gold;
            this.txt_estadoPorta.Location = new System.Drawing.Point(425, 108);
            this.txt_estadoPorta.Name = "txt_estadoPorta";
            this.txt_estadoPorta.Size = new System.Drawing.Size(210, 31);
            this.txt_estadoPorta.TabIndex = 57;
            this.txt_estadoPorta.Text = "Não conectado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(331, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 31);
            this.label8.TabIndex = 55;
            this.label8.Text = "Status:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Gold;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(356, 202);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(200, 54);
            this.btn_cancelar.TabIndex = 43;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_ListPort
            // 
            this.txt_ListPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_ListPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_ListPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ListPort.FormattingEnabled = true;
            this.txt_ListPort.Items.AddRange(new object[] {
            ""});
            this.txt_ListPort.Location = new System.Drawing.Point(131, 104);
            this.txt_ListPort.Name = "txt_ListPort";
            this.txt_ListPort.Size = new System.Drawing.Size(182, 39);
            this.txt_ListPort.TabIndex = 54;
            this.txt_ListPort.SelectedIndexChanged += new System.EventHandler(this.txt_ListPort_SelectedIndexChanged);
            this.txt_ListPort.Click += new System.EventHandler(this.txt_ListPort_Click);
            // 
            // btn_conectar
            // 
            this.btn_conectar.BackColor = System.Drawing.Color.Gold;
            this.btn_conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_conectar.Location = new System.Drawing.Point(129, 202);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(200, 54);
            this.btn_conectar.TabIndex = 18;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = false;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(-9, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(742, 42);
            this.label9.TabIndex = 49;
            this.label9.Text = "Configurar porta para comunicação serial";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(34, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 31);
            this.label10.TabIndex = 45;
            this.label10.Text = "Porta:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_login.Controls.Add(this.txt_senhaUsuario);
            this.panel_login.Controls.Add(this.label5);
            this.panel_login.Controls.Add(this.txt_nomeUsuaario);
            this.panel_login.Controls.Add(this.label4);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.btn_cancelar2);
            this.panel_login.Controls.Add(this.btn_acessar);
            this.panel_login.Location = new System.Drawing.Point(31, 77);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(791, 399);
            this.panel_login.TabIndex = 60;
            this.panel_login.Visible = false;
            // 
            // txt_senhaUsuario
            // 
            this.txt_senhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senhaUsuario.Location = new System.Drawing.Point(260, 155);
            this.txt_senhaUsuario.Name = "txt_senhaUsuario";
            this.txt_senhaUsuario.PasswordChar = '*';
            this.txt_senhaUsuario.Size = new System.Drawing.Size(328, 27);
            this.txt_senhaUsuario.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(142, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 33);
            this.label5.TabIndex = 56;
            this.label5.Text = "Senha:";
            // 
            // txt_nomeUsuaario
            // 
            this.txt_nomeUsuaario.BackColor = System.Drawing.Color.White;
            this.txt_nomeUsuaario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeUsuaario.FormattingEnabled = true;
            this.txt_nomeUsuaario.Items.AddRange(new object[] {
            ""});
            this.txt_nomeUsuaario.Location = new System.Drawing.Point(260, 97);
            this.txt_nomeUsuaario.Name = "txt_nomeUsuaario";
            this.txt_nomeUsuaario.Size = new System.Drawing.Size(328, 28);
            this.txt_nomeUsuaario.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(125, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 33);
            this.label4.TabIndex = 51;
            this.label4.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(113, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(622, 33);
            this.label2.TabIndex = 50;
            this.label2.Text = "Digite nome usuário e senha para continuar";
            // 
            // btn_cancelar2
            // 
            this.btn_cancelar2.BackColor = System.Drawing.Color.Gold;
            this.btn_cancelar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_cancelar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar2.Location = new System.Drawing.Point(388, 226);
            this.btn_cancelar2.Name = "btn_cancelar2";
            this.btn_cancelar2.Size = new System.Drawing.Size(200, 54);
            this.btn_cancelar2.TabIndex = 45;
            this.btn_cancelar2.Text = "Cancelar";
            this.btn_cancelar2.UseVisualStyleBackColor = false;
            this.btn_cancelar2.Click += new System.EventHandler(this.btn_cancelar2_Click);
            // 
            // btn_acessar
            // 
            this.btn_acessar.BackColor = System.Drawing.Color.Gold;
            this.btn_acessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acessar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_acessar.Location = new System.Drawing.Point(167, 226);
            this.btn_acessar.Name = "btn_acessar";
            this.btn_acessar.Size = new System.Drawing.Size(200, 54);
            this.btn_acessar.TabIndex = 44;
            this.btn_acessar.Text = "Acessar";
            this.btn_acessar.UseVisualStyleBackColor = false;
            this.btn_acessar.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(834, 661);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.panel_conection);
            this.Controls.Add(this.btn_setup);
            this.Controls.Add(this.btn_retirar);
            this.Controls.Add(this.btn_entregar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condo Biometry";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_conection.ResumeLayout(false);
            this.panel_conection.PerformLayout();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txt_statusPort;
        private System.Windows.Forms.Label txt_usuario;
        private System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.Button btn_entregar;
        private System.Windows.Forms.Button btn_retirar;
        private System.Windows.Forms.Button btn_setup;
        private System.Windows.Forms.Panel panel_conection;
        private System.Windows.Forms.Label lb_ultimaPorta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt_estadoPorta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ComboBox txt_ListPort;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.ComboBox txt_nomeUsuaario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancelar2;
        private System.Windows.Forms.Button btn_acessar;
        private System.Windows.Forms.TextBox txt_senhaUsuario;
        private System.Windows.Forms.Label label5;
    }
}

