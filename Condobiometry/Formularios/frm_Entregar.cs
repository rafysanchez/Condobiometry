using CondoBiometry.Class;
using CondoBiometry.sqLite.Repositorio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondoBiometry
{

    public partial class frm_Entregar : Form
    {
        private CondoRepositorio repo = new CondoRepositorio();

        Conexao ObjCon = new Conexao(DadosConexao.StringConection);
        Modelo mod = new Modelo();


        //variaveis para passar dados para outro forms  
        public static string login;
        public static string id_login;
        public static string port_Com;
        public string tamanho_ebox, num_ebox, Serial_read, msg_portCom, id_biometria;
        public int id_ebox, rtn_Arduino_Ebox;
        public string morador, rua, numero, bloco, apto, cidade, estado;
        String[] comandSerial = { "Ç", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "X", "W", "Y", "Z" };
        public frm_Entregar()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            frm_principal frm = new frm_principal();
            this.Hide();
            frm.Show();
        }

        private void frm_Entregar_Load(object sender, EventArgs e)
        {
            frm_principal frm = new frm_principal();
            port_Com = frm.port_Conect;
            tabControl1.Controls.Remove(tabPage2);
            tabControl1.Controls.Remove(tabPage3);
            tabControl1.Controls.Remove(tabPage4);
            tabControl1.Controls.Remove(tabPage5);
            tabControl1.Controls.Remove(tabPage6);
            Select_tab(0);
            try
            {
                if ((port_Com != null) && (port_Com != "port_conection"))
                {
                    serialPort1.PortName = port_Com;
                }

                if (serialPort1.IsOpen != true)
                {
                    serialPort1.Open();
                    if (serialPort1.IsOpen)
                    {
                        txt_statusPort.Text = "Conectado: " + port_Com;
                    }
                }
            }
            catch
            {
                MessageBox.Show("NÃO FOI POSSIVEL SE CONECTAR COM O ARDUINO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Select_tab(int index)
        {
            tabControl1.Controls.RemoveAt(0);
            TabPage[] tabPag = { tabPage1, tabPage2, tabPage3, tabPage4, tabPage5, tabPage6 };
            tabControl1.Controls.Add(tabPag[index]);
            tabControl1.SelectedTab = tabPag[index];
        }
        private void Select_button(int index)
        {
            Button[] botao = { btn_pequeno, btn_medio, btn_grande };
            for (int i = 0; i < 3; i++)
            {
                if (i == index)
                {
                    botao[i].BackColor = Color.Lime;
                    botao[i].ForeColor = Color.MidnightBlue;
                }
                else
                {
                    botao[i].BackColor = Color.Gold;
                    botao[i].ForeColor = Color.MidnightBlue;
                }
            }
        }

        private void btn_cancelarPage1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            frm_principal frm = new frm_principal();
            this.Hide();
            frm.Show();
        }

        private void txt_nomeEntregador_Click(object sender, EventArgs e)
        {

        }

        private void btn_continuarPage1_Click(object sender, EventArgs e)
        {
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            try
            {
                var senha = txt_senha.Text;
                Login _login = new Login();
                _login.senha = txt_senha.Text;

                _login = repo.GetLoginDataByPass(_login);


                if (_login != null)
                {
                    txt_nomeEntregador.Text = "00" + _login.id_login + " - " + login;
                    txt_entregadorPage2.Text = "00" + _login.id_login + " - " + login;
                    txt_msgArduino.Visible = false;
                    txt_msgArduino.Text = "";
                    Select_tab(1);
                }
                else
                {
                    txt_msgArduino.Visible = true;
                    txt_msgArduino.Text = "ACESSO NEGADO!";
                    txt_senha.Text = "";
                    txt_nomeEntregador.Text = "";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("NÃO FOI POSSÍVEL SE CONECTAR A BASE DE DADOS." + "ERROS DE COMANDOS:" + ex.Message);
            }
        }
        private void Biometry_Authentication()
        {

            try
            {

                Login _login = new Login();
                _login.id_biometria = id_biometria;

                _login = repo.GetLoginByBiometry(_login);


                if (_login != null)
                {
                    txt_nomeEntregador.Text = "00" + _login.id_login + " - " + login;
                    txt_entregadorPage2.Text = "00" + _login.id_login + " - " + login;
                    txt_msgArduino.Visible = false;
                    txt_msgArduino.Text = "";
                    Select_tab(1);
                }
                else
                {
                    txt_msgArduino.Visible = true;
                    txt_msgArduino.Text = "ACESSO NEGADO!";
                    txt_senha.Text = "";
                    txt_nomeEntregador.Text = "";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("NÃO FOI POSSÍVEL SE CONECTAR A BASE DE DADOS." + "ERROS DE COMANDOS:" + ex.Message);
            }
        }

        private void btn_continuarPage2_Click(object sender, EventArgs e)
        {
            if ((txt_codigo.Text == "") || (txt_bloco.Text == "") || (txt_apartamento.Text == ""))
            {
                MessageBox.Show("TODOS OS CAMPOS É DE PREENCHIMENTO OBRIGATÓRIO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mod = null;
                mod.Bloco = txt_bloco.Text;
                mod.Apartamento = txt_apartamento.Text;


                Modelo mor = repo.GetMorador(mod);

                if (mor == null)
                {
                    MessageBox.Show("NENHUM MORADOR FOI ENCONTRADO, OU BLOCO E APARTAMENTO INCORRETOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Select_tab(2);
                }
            }
        }

        private void btn_cancelarPage2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            frm_principal frm = new frm_principal();
            this.Hide();
            frm.Show();
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_pequeno_Click(object sender, EventArgs e)
        {
            List<Ebox> caixasPequenas = new List<Ebox>();

            caixasPequenas = repo.GetCaixasPequenas();

            if (caixasPequenas.Count < 1)
            {
                MessageBox.Show("TAMANHO E-BOX SELECIONADO INDISPONÍVEL NO MOMENTO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_pequeno.Enabled = false;
                tamanho_ebox = null;
            }
            else
            {
                tamanho_ebox = "pequeno";
                id_ebox = int.Parse(caixasPequenas[0].num_ebox);
                Select_button(0);
                //MessageBox.Show(id_ebox.ToString());

            }
            // DateTime date = DateTime.Now;
            // txt_dataRetirada.Text = date.AddDays(5).ToString();
            //lb_prazo_maximo_retirada.Visible = true;
        }

        private void btn_medio_Click(object sender, EventArgs e)
        {
            List<Ebox> caixasMedias = new List<Ebox>();
            caixasMedias = repo.GetCaixasMedias();


            if (caixasMedias.Count < 1)
            {
                MessageBox.Show("TAMANHO E-BOX SELECIONADO INDISPONÍVEL NO MOMENTO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_medio.Enabled = false;
                tamanho_ebox = null;
            }
            else
            {

                tamanho_ebox = "Medio";
                id_ebox = int.Parse(caixasMedias[0].num_ebox);
                Select_button(1);
                //MessageBox.Show(id_ebox.ToString());
            }
        }

        private void btn_grande_Click(object sender, EventArgs e)
        {
            List<Ebox> caixasGrandes = new List<Ebox>();
            caixasGrandes = repo.GetCaixasGrandes();



            if (caixasGrandes.Count < 1)
            {
                MessageBox.Show("TAMANHO E-BOX SELECIONADO INDISPONÍVEL NO MOMENTO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_grande.Enabled = false;
                tamanho_ebox = null;
            }
            else
            {
                tamanho_ebox = "Grande";
                id_ebox = int.Parse(caixasGrandes[0].num_ebox);
                Select_button(2);
                //MessageBox.Show(id_ebox.ToString());
            }
        }

        private void btn_cancearPage3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            frm_principal frm = new frm_principal();
            this.Hide();
            frm.Show();
        }

        private void btn_continuarPage3_Click(object sender, EventArgs e)
        {
            if (tamanho_ebox == null)
            {
                MessageBox.Show("NENHUM COMPARTIMENTO FOI SELECIONADO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Carregas_dados_encomendas();
                Select_tab(3);
            }
        }
        private void Carregas_dados_encomendas()
        {

             try
            {

                Condominio condo = new Condominio();
                condo = repo.GetMaxCondominioById();

                rua = condo.rua;
                numero = condo.numero;
                cidade = condo.cidade;
                estado = condo.estado;

            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi possivel se conectar base de dados" + "ERROS DE COMANDOS:" + ex.Message);
            }

            ObjCon.Fechar();
            listBox1.Items.Add("Destinatário: " + morador);
            listBox1.Items.Add("Rua: " + rua + "," + numero + " Bloco " + bloco + " Apto " + apto);
            listBox1.Items.Add(cidade + " - " + estado);
            listBox1.Items.Add("");
            listBox1.Items.Add("Código da encomenda: " + txt_codigo.Text);
            listBox1.Items.Add("Compartimento: " + id_ebox + " Tamanho: " + tamanho_ebox);
            listBox1.Items.Add("");
            listBox1.Items.Add("Prazo de retirada 5 dias úteis.");

        }

        private void btn_cancelarPage4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            frm_principal frm = new frm_principal();
            this.Hide();
            frm.Show();
        }

        private void btn_confirmarPage4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(id_ebox.ToString());
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(comandSerial[id_ebox]);
            }
            txt_idEbox.Text = id_ebox.ToString();
            if (txt_idEbox.Text.Length == 1)
            {
                txt_idEbox.Text = "0" + id_ebox.ToString();
            }
            else
            {
                txt_idEbox.Text = id_ebox.ToString();
            }
            Select_tab(4);
        }

        private void btn_ConfirmarPage5_Click(object sender, EventArgs e)
        {

            DateTime date = DateTime.Now;
            string data_retirada = date.AddDays(5).ToString();
            data_retirada = data_retirada.Substring(6, 4) + data_retirada.Substring(2, 3) + "/" + data_retirada.Substring(0, 2); //converte para padrao Mysql 

            if ((btn_Porta.Text == "COMPARTIMENTO ABERTO") || (btn_Porta.Text == "COMPARTIMENTO ERROR"))
            {
                MessageBox.Show("FECHE A PORTA DO COMPARTIMENTO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Entrega  entrega = new Entrega();
                    entrega.id_login = id_login;
                    entrega.id_ebox = id_ebox;
                    entrega.num_encomenda = txt_codigo.Text;
                    entrega.Apartamento = txt_apartamento.Text;
                    entrega.Bloco = txt_bloco.Text;
                    entrega.data_inclusao = System.DateTime.Now.ToShortDateString();
                    entrega.data_retirada = data_retirada;
                    entrega.id_morador = data_retirada;
                    entrega.nome_morador = data_retirada;


                    var ret = repo.InsertTblEntrega(entrega);
                  
                    //mod.sql = "insert into tbl_entrega(id_login,id_ebox,num_encomenda,apto,bloco,data_inclusao,data_retirada,id_morador,nome_morador)" +
                    //         "values('" + id_login + "','" + id_ebox + "','" + txt_codigo.Text + "','" + txt_apartamento.Text + "','" + txt_bloco.Text + "',current_date,'" + data_retirada + "',0,0)";
               
                    MessageBox.Show("A ENCOMENDA " + txt_codigo.Text + " FOI ENTREGUE COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Select_tab(5);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DE DADOS.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_cancelarPage5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            frm_principal frm = new frm_principal();
            this.Hide();
            frm.Show();
        }

        private void btn_entregarNovo_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            frm_Entregar frm = new frm_Entregar();
            this.Hide();
            frm.Show();
        }

        private void btn_Encerrar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            frm_principal frm = new frm_principal();
            this.Hide();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(Read_serial));   //chama outra thread para escrever o dado no text box 
        }
        private void Read_serial(object sender, EventArgs e)
        {
            try
            {
                Serial_read = serialPort1.ReadLine();
                txt_msgBox.Text = Serial_read;
                txt_msgArduino.Visible = true;
                txt_msgArduino.Text = Serial_read;
                if ((Serial_read.IndexOf("@") > 0))
                {
                    msg_portCom = Serial_read.Substring(0, (Serial_read.IndexOf("@")));
                    id_biometria = msg_portCom;
                    Biometry_Authentication();
                }
                txt_msgBox.Text = Serial_read;
                if (Serial_read.IndexOf("#") > 0)
                {
                    msg_portCom = Serial_read.Substring(0, (Serial_read.IndexOf("#")));

                    rtn_Arduino_Ebox = int.Parse(msg_portCom);

                    if (rtn_Arduino_Ebox == 1)
                    {
                        btn_Porta.Text = "COMPARTIMENTO ABERTO";
                        btn_Porta.BackColor = Color.Lime;
                        btn_Porta.ForeColor = Color.Red;
                        btn_ConfirmarPage5.Enabled = true;
                    }

                    else if (rtn_Arduino_Ebox == 2)
                    {
                        btn_Porta.Text = "COMPARTIMENTO FECHADO";
                        btn_Porta.BackColor = Color.MidnightBlue;
                        btn_Porta.ForeColor = Color.Gold;
                    }

                    else if (rtn_Arduino_Ebox == 3)
                    {
                        btn_Porta.Text = "COMPARTIMENTO ERROR";
                        btn_Porta.BackColor = Color.Red;
                        btn_Porta.ForeColor = Color.Gold;
                    }
                }
            }
            catch
            {
                MessageBox.Show("A CONEXÃO COM O ARDUINO FOI PERDIDA. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
