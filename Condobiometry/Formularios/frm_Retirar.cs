using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using CondoBiometry.sqLite.Repositorio;

namespace CondoBiometry
{
    public partial class frm_Retirar : Form
    {
        private CondoRepositorio repo = new CondoRepositorio();
        Modelo mod = new Modelo();


        public static string port_Com, Serial_read, msg_portCom;
        public string Data;
        public int id_ebox, id_user, rtn_Arduino_Ebox;
        public string id_morador, morador, id_entrega, id_biometria, bloco, apto, num_encomenda, num_ebox, rua, numero, cidade, estado;

        String[] comandSerial = { "Ç", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "X", "W", "Y", "Z" };
        public frm_Retirar()
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

        private void frm_Retirar_Load(object sender, EventArgs e)
        {
            frm_principal frm = new frm_principal();
            port_Com = frm.port_Conect;
            tabControl1.Controls.Remove(tabPage2);
            tabControl1.Controls.Remove(tabPage3);
            tabControl1.Controls.Remove(tabPage4);
            tabControl1.Controls.Remove(tabPage5);
            //tabControl1.Controls.Remove(tabPage6);
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
            TabPage[] tabPag = { tabPage1, tabPage2, tabPage3, tabPage4, tabPage5 };
            tabControl1.Controls.Add(tabPag[index]);
            tabControl1.SelectedTab = tabPag[index];
        }

        private void btn_retiraPage1_Click(object sender, EventArgs e)
        {
            try
            {

                if ((txt_bloco.Text == "") | (txt_apartamento.Text == ""))
                {
                    MessageBox.Show("TODOS OS CAMPOS E DE PREENCHIMENTO OBRIGATÓRIO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    mod.sql = "select id_entrega,num_encomenda,id_ebox,bloco,apto from tbl_entrega where bloco ='" + txt_bloco.Text + "' and apto ='" + txt_apartamento.Text + "' and processo = 'Aberto' ";
                    //dataGridView1.DataSource = ObjDAo.ListarTabela_DGV(mod);
                    if (dataGridView1.Rows.Count > 1)
                    {
                        id_entrega = dataGridView1.Rows[0].Cells[0].Value.ToString();
                        num_encomenda = dataGridView1.Rows[0].Cells[1].Value.ToString();
                        num_ebox = dataGridView1.Rows[0].Cells[2].Value.ToString();
                        bloco = dataGridView1.Rows[0].Cells[3].Value.ToString();
                        apto = dataGridView1.Rows[0].Cells[4].Value.ToString();

                        if ((id_entrega == null) || (id_entrega == "id_entrega") || (bloco == "bloco") || (apto == "bloco") || (num_encomenda == null))
                        {
                            txt_msgBox.Visible = true;
                            txt_msgBox.Text = "NÃO TEM ENCOMENDA PARA A UNIDADE INFORMADA.";
                            txt_bloco.Text = "";
                            txt_apartamento.Text = "";
                            listBox1.Visible = false;
                        }
                        else
                        {
                            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                            {
                                listBox1.Items.Add("Encomenda: " + dataGridView1.Rows[i].Cells[1].Value.ToString() + "     " +
                                                  " Compartimento: " + dataGridView1.Rows[i].Cells[2].Value.ToString());
                            }
                            id_ebox = int.Parse(num_ebox);
                            if (serialPort1.IsOpen)
                            {
                                serialPort1.Write("c");
                            }
                            listBox1.Visible = true;
                            Select_tab(1);
                        }
                    }
                    else
                    {
                        txt_msgBox.Visible = true;
                        txt_msgBox.Text = "NÃO TEM ENCOMENDA PARA A UNIDADE INFORMADA";
                        txt_bloco.Text = "";
                        txt_apartamento.Text = "";
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL VERIFICAR LISTA ENCOMENDAS.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
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

        private void btn_continuarPage2_Click(object sender, EventArgs e)
        {
            if ((id_user > 0) && (txt_morador.Text.Length > 3) && (id_ebox > 0))
            {
                lbtxt_morador.Text = txt_morador.Text;
                txt_idEbox.Text = id_ebox.ToString();
                //MessageBox.Show(id_ebox.ToString());
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(comandSerial[id_ebox]);
                }
                if (txt_idEbox.Text.Length == 1)
                {
                    txt_idEbox.Text = "0" + id_ebox.ToString();
                }
                else
                {
                    txt_idEbox.Text = id_ebox.ToString();
                }
                Select_tab(2);
            }
        }

        private void txt_senha_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_senha.Text.Length > 7)
            {

                try
                {
                    mod.sql = "Select id_user,nome,perfil from tbl_usuario where senha = '" + txt_senha.Text + "' and bloco = '" + bloco
                             + "' and apto = '" + apto + "' and perfil = 'Morador' ";
                    mod.string_1 = "id_user";
                    mod.string_2 = "nome";
                    mod.string_3 = "perfil";

                    //ObjDao.Retorna_String3(mod);
                    id_morador = mod.string_1;
                    morador = mod.string_2;
                    string perfil = mod.string_3;
                    if ((id_morador != null) && ((perfil == "Morador") && (id_morador != "id_user")))
                    {
                        txt_morador.Text = "00" + id_morador + " - " + morador;
                        id_user = int.Parse(id_morador);
                        if (serialPort1.IsOpen)
                        {
                            serialPort1.Write("d");
                        }
                        txt_msgArduino.Visible = false;
                        txt_msgArduino.Text = "";
                    }
                    else
                    {
                        txt_msgArduino.Visible = true;
                        txt_msgArduino.Text = "ACESSO NEGADO!";
                        //MessageBox.Show("SENHA INCORRETA.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_senha.Text = "";
                        txt_morador.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DE DADOS.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Biometry_Authentication()
        {

            try
            {
                mod.sql = "Select id_user,nome,perfil from tbl_usuario where id_biometria = '" + id_biometria + "' and bloco = '" + bloco
                         + "' and apto = '" + apto + "' and perfil = 'Morador' ";
                mod.string_1 = "id_user";
                mod.string_2 = "nome";
                mod.string_3 = "perfil";

                //ObjDao.Retorna_String3(mod);
                id_morador = mod.string_1;
                morador = mod.string_2;
                string perfil = mod.string_3;
                if ((id_morador != null) && ((perfil == "Morador") && (id_morador != "id_user")))
                {
                    txt_morador.Text = "00" + id_morador + " - " + morador;
                    id_user = int.Parse(id_morador);
                    txt_msgArduino.Visible = false;
                    txt_msgArduino.Text = "";
                }
                else
                {
                    txt_msgArduino.Visible = true;
                    txt_msgArduino.Text = "ACESSO NEGADO!";
                    txt_senha.Text = "";
                    txt_morador.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DE DADOS.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_statusPort_Click(object sender, EventArgs e)
        {

        }
        private void Registra_Retirada()
        {
            try
            {


                mod.sql = "Update tbl_entrega SET data_retirada = current_date,id_morador = '" + id_user + "',nome_morador = '" + morador
                    + "',status_retirada = 'Retirado',processo = 'Concluido' where id_entrega = '" + id_entrega + "' ";


                // MessageBox.Show("A ENCOMENDA " + num_encomenda + " FOI RETIRADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mod.sql = "update tbl_ebox set status_ebox = 'Livre' where id_ebox = '" + id_ebox + "' ";

                btn_cancelaRetirada.Enabled = false;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DE DADOS.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ConfirmarPage3_Click(object sender, EventArgs e)
        {
            if ((btn_Porta.Text == "COMPARTIMENTO ABERTO") || (btn_Porta.Text == "COMPARTIMENTO ERROR"))
            {
                MessageBox.Show("FECHE A PORTA DO COMPARTIMENTO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("A ENCOMENDA " + num_encomenda + " FOI RETIRADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Select_tab(3);

            }

        }

        private void btn_retirarNovo_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            frm_Retirar frm = new frm_Retirar();
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
                if (Serial_read.IndexOf("#") > 0)
                {
                    msg_portCom = Serial_read.Substring(0, (Serial_read.IndexOf("#")));

                    rtn_Arduino_Ebox = int.Parse(msg_portCom);

                    if (rtn_Arduino_Ebox == 1)
                    {
                        btn_Porta.Text = "COMPARTIMENTO ABERTO";
                        btn_Porta.BackColor = Color.Lime;
                        btn_Porta.ForeColor = Color.Red;
                        btn_ConfirmarPage3.Enabled = true;
                        Registra_Retirada();
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
                        btn_cancelaRetirada.Enabled = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("A CONEXÃO COM O ARDUINO FOI PERDIDA. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelaRetirdaa_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            frm_principal frm = new frm_principal();
            this.Hide();
            frm.Show();
        }
    }
}
