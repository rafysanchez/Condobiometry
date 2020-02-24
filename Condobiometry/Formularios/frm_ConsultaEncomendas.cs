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
    public partial class frm_ConsultaEncomendas : Form
    {
        private CondoRepositorio repo = new CondoRepositorio();

        Modelo mod = new Modelo();


        public static string port_Com;
        public string Data;
        public string user_login;
        public string id_login;

        public frm_ConsultaEncomendas()
        {
            InitializeComponent();
        }

        private void frm_ConsultaEncomendas_Load(object sender, EventArgs e)
        {
            frm_principal frm = new frm_principal();
            txt_usuario.Text = "0" + frm.id_usuario + " " + frm.nome_usuario;
            user_login = frm.nome_usuario;
            id_login = frm.id_usuario;
            port_Com = frm.port_Conect;

            try
            {
                if ((port_Com != null) || (port_Com != "port_conection"))
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

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            frm_Setup frm = new frm_Setup();
            this.Hide();
            frm.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            if (MessageBox.Show("REALMENTE DESEJA SAIR DO SISTEMA ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

        private void checkBox_Entregue_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Entregue.BackColor = Color.Gold;
            checkBox_Entregue.ForeColor = Color.MidnightBlue;
            checkBox_naoEntregue.BackColor = Color.MidnightBlue;
            checkBox_naoEntregue.ForeColor = Color.Gold;
            checkBox_naoEntregue.Checked = false;

            try
            {
                List<Ebox> listagemEntregues = new List<Ebox>();

                listagemEntregues = repo.GetListagemEboxEntregues();

               
                dataGridView2.DataSource = listagemEntregues;

            }
            catch (MySqlException ex)
            {
               MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA DE USUARIOS. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox_naoEntregue_CheckedChanged(object sender, EventArgs e)
        {


            checkBox_Entregue.BackColor = Color.MidnightBlue;
            checkBox_Entregue.ForeColor = Color.Gold;
            checkBox_naoEntregue.BackColor = Color.Gold;
            checkBox_naoEntregue.ForeColor = Color.MidnightBlue;
            checkBox_Entregue.Checked = false;  
       
            
            try
            {
                List<Ebox> listagemAbertos = new List<Ebox>();

                listagemAbertos = repo.GetListagemEboxAbertos();

            
                dataGridView2.DataSource = listagemAbertos;


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA DE USUARIOS. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
            {
                MessageBox.Show("INFORME O NÚMERO DA ENCOMENDA PARA PESQUISA.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                try
                {
                    if (checkBox_Entregue.Checked)
                    {
                        string param = txt_codigo.Text.Trim();

                        List<Ebox> listagemEntregues = new List<Ebox>();

                        listagemEntregues = repo.GetListagemEboxEntregues(param);

                        dataGridView2.DataSource = listagemEntregues;

                    }
                    else if (checkBox_naoEntregue.Checked)
                    {
                        string param = txt_codigo.Text.Trim();

                        List<Ebox> listagemAbertos = new List<Ebox>();

                        listagemAbertos = repo.GetListagemEboxAbertos();

                        dataGridView2.DataSource = listagemAbertos;

                    }
                    else
                    {
                        string param = txt_codigo.Text.Trim();

                        List<Ebox> Encomendas = new List<Ebox>();

                        Encomendas = repo.GetListagemEncomendasByCodigo(param);

                        dataGridView2.DataSource = Encomendas;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA DE ENCOMENDAS. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_codigo_KeyUp(object sender, KeyEventArgs e)
        {
            btn_buscar_Click(sender, e);
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            if ((txt_bloco.Text == "")||(txt_apto.Text == ""))
            {
                MessageBox.Show("INFORME O BLOCO E APARTAMENTO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btn_buscar_Click(sender, e);
            }
        }
    }
}
