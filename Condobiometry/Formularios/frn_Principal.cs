using CondoBiometry.Formularios;
using CondoBiometry.sqLite.Repositorio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Windows.Forms;

namespace CondoBiometry
{
    public partial class frm_principal : Form
    {

        Modelo mod = new Modelo();


        //variaveis para passar dados para outro forms  
        public static string login;
        public static string id_ogin;
        public static string port_Com;

        public static string script_backup;//passa  valor para class
        public static string local_backup;
        public static string local_restore;
        public static string caminho_instalacao_Mysql;


        //metodo construtor para passar dados para outros forms
        public string id_usuario
        {
            get { return id_ogin; }
        }
        public string nome_usuario
        {
            get { return login; }
        }
        public string port_Conect
        {
            get { return port_Com; }
        }
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_entregar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            frm_Entregar frm = new frm_Entregar();
            this.Hide();
            frm.Show();
        }

        private void btn_retirar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            frm_Retirar frm = new frm_Retirar();
            this.Hide();
            frm.Show();
        }

        private void btn_setup_Click(object sender, EventArgs e)
        {
            panel_login.Visible = true;
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();


            foreach (string s in SerialPort.GetPortNames())
            {
                txt_ListPort.Items.Add(s);
            }

            Conecta_Porta();

            try
            {

                CondoRepositorio repo = new CondoRepositorio();
                List<string> listNomes = new List<string>();
                listNomes = repo.CarregaNomesLogin();

                int i = 0;
                foreach (var item in listNomes)
                {
                    txt_nomeUsuaario.Items.Insert(i, item.ToString().ToUpper());
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DADOS " + ex.Message, "ERRO1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Conecta_Porta()
        {

            try
            {
                CondoRepositorio repo = new CondoRepositorio();

                port_Com = repo.GetUltimaPorta();

                lb_ultimaPorta.Text = "Porta: " + port_Com;

                if ((port_Com != null) && (port_Com != "port_conection"))
                {
                    serialPort1.PortName = port_Com;
                }

                if (serialPort1.IsOpen != true)
                {
                    serialPort1.Open();
                    if (serialPort1.IsOpen)
                    {
                        txt_estadoPorta.Text = "Conectado: " + port_Com;
                        txt_statusPort.Text = "Conectado: " + port_Com;
                        btn_conectar.Text = "Desconectar";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL SE CONECTAR COM A PLACA RAPSBERRY. " + ex.Message, "ERRO2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                panel_conection.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

        private void txt_ListPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            port_Com = txt_ListPort.SelectedItem.ToString();
        }
        private void Salva_log(string Porta = "", string acao = "")
        {
            try
            {

                CondoRepositorio repo = new CondoRepositorio();

                repo.InsereLog_Conexao(Porta, "Conexao");

            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DADOS " + ex.Message, "ERRO3", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_conectar_Click(object sender, EventArgs e)
        {
            if (btn_conectar.Text == "Conectar")
            {
                if (txt_ListPort.Text == "")
                {
                    MessageBox.Show("PRIMEIRO SELECIONA A PORTA PARA CONEXÃO COM O ARDUINO.", "ERRO4", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    try
                    {
                        if (port_Com != null)
                        {
                            serialPort1.PortName = port_Com;
                        }

                        if (serialPort1.IsOpen != true)
                        {
                            serialPort1.Open();
                            if (serialPort1.IsOpen)
                            {
                                txt_estadoPorta.Text = "Conectado:  " + port_Com;
                                txt_statusPort.Text = "Conectado: " + port_Com;
                                btn_conectar.Text = "Desconectar";
                                Salva_log();
                                panel_conection.Visible = false;
                            }
                        }

                    }
                    catch
                    {
                        MessageBox.Show("ERRO DE CONEXÃO COM O ARDUINO." + "\n" + "VERIFIQUE SE O CABO USB ESTA CONECTADO. ", "ERRO5", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else if (btn_conectar.Text == "Desconectar")
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close();
                        if (serialPort1.IsOpen != true)
                        {
                            txt_estadoPorta.Text = "Não conectado: ****";
                            txt_statusPort.Text = "Não conectado: ****";
                            btn_conectar.Text = "Conectar";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("ERRO DE CONEXÃO COM O ARDUINO." + "\n" + "VERIFIQUE SE O CABO USB ESTA CONECTADO. ", "ERRO6", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            panel_conection.Visible = false;
        }

        private void txt_ListPort_Click(object sender, EventArgs e)
        {
            txt_ListPort.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                txt_ListPort.Items.Add(s);
            }
        }

        private void btn_cancelar2_Click(object sender, EventArgs e)
        {
            txt_nomeUsuaario.Text = "";
            txt_senhaUsuario.Text = "";
            panel_login.Visible = false;
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            if ((txt_nomeUsuaario.Text == "admin") & (txt_senhaUsuario.Text == "condobiometry2018admin"))
            {
                Develophers develophers = new Develophers();
                develophers.Show();
                this.Hide();
            }
            else
            {
                try
                {

                    mod.nome = txt_nomeUsuaario.Text;
                    mod.senha = txt_senhaUsuario.Text;
                 

                    if ((txt_nomeUsuaario.Text == "") || (txt_senhaUsuario.Text == ""))
                    {
                        MessageBox.Show("PREENCHA OS CAMPOS NOME E SENHA!", "ACESO NEGADO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        CondoRepositorio repo = new CondoRepositorio();

                        if (!repo.Verifica_Login(mod))
                        {
                            MessageBox.Show("LOGIN OU SENHA INVÁLIDOS!", "ACESSO NEGADO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_nomeUsuaario.Text = "";
                            txt_senhaUsuario.Text = "";
                        }
                        else
                        {
                            panel_login.Visible = false;
                            if (serialPort1.IsOpen)
                            {
                                serialPort1.Close();
                            }
                            frm_Setup frm = new frm_Setup();
                            this.Hide();
                            frm.ShowDialog();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DADOS " + ex.Message, "ERRO8", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


    }
}
