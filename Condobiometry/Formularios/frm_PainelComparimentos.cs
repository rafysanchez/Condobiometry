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
    public partial class frm_PainelComparimentos : Form
    {
        private CondoRepositorio repo = new CondoRepositorio();
        Modelo mod = new Modelo();


        public static string port_Com;
        public string Data;
        public string user_login;
        public string id_login;
        public string Codigo, Num_ebox, Tamanho, Status, Data_inclusao, Bloco, Apto, Data_retirada, Status_retirada;
        public frm_PainelComparimentos()
        {
            InitializeComponent();
        }

        private void frm_PainelComparimentos_Load(object sender, EventArgs e)
        {
            frm_principal frm = new frm_principal();
            txt_usuario.Text = "0" + frm.id_usuario + " " + frm.nome_usuario;
            user_login = frm.nome_usuario;
            id_login = frm.id_usuario;
            port_Com = frm.port_Conect;
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


            try
            {
                List<Ebox> listEbox = new List<Ebox>();
                listEbox = repo.GetAllEbox();

                mod.sql = "select id_ebox as Código,num_ebox as Compartimento,Tamanho,status_ebox from tbl_ebox";
                dataGridView1.DataSource = listEbox;

            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            carregaEbox();
        }
        private void carregaEbox()
        {
            try
            {

                if (dataGridView1.Rows.Count > 1)
                {
                    for (int x = 0; x < dataGridView1.Rows.Count - 1; x++)
                    {
                        Codigo = dataGridView1.Rows[x].Cells[0].Value.ToString();
                        Num_ebox = dataGridView1.Rows[x].Cells[1].Value.ToString();
                        Tamanho = dataGridView1.Rows[x].Cells[2].Value.ToString();
                        Status = dataGridView1.Rows[x].Cells[3].Value.ToString();
                        string nome = dataGridView1.Rows[x].Cells[3].Value.ToString();

                        if (nome == "Ocupado")
                        {
                            List<Entrega> entregas = new List<Entrega>();
                            int id =Convert.ToInt32( dataGridView1.Rows[x].Cells[0].Value.ToString());
                            entregas = repo.GetAllEntregas().Where(val => val.processo == "Aberto").ToList();
                            var ret = entregas.Where(a => a.id_ebox == id).SingleOrDefault();

                            //mod.sql = "select data_inclusao,bloco,apto,data_retirada,status_retirada from tbl_entrega where id_ebox ='" + dataGridView1.Rows[x].Cells[0].Value.ToString() + "' and processo = 'Aberto'";

                            Data_inclusao = ret.data_inclusao;
                            Bloco = ret.Bloco;
                            Apto = ret.Apartamento;
                            Data_retirada = ret.data_retirada;
                            Status_retirada = ret.status_retirada;

                        }
                        else
                        {
                            Data_inclusao = "";
                            Bloco = "";
                            Apto = "";
                            Data_retirada = "";
                            Status_retirada = "";
                        }
                        dataGridView2.Rows.Add(Codigo, Num_ebox, Tamanho, Status, Data_inclusao, Bloco, Apto, Data_retirada, Status_retirada);
                    }
                    analise_datagreedview();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA DE COMPARTIMENTOS. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void analise_datagreedview()
        {
            try
            {
                if (dataGridView2.Rows.Count > 1)
                {
                    for (int x = 0; x < dataGridView2.Rows.Count - 1; x++)
                    {
                        string status = dataGridView2.Rows[x].Cells[3].Value.ToString();
                        if (status == "Livre")
                        {
                            dataGridView2.Rows[x].DefaultCellStyle.BackColor = Color.Lime;
                            dataGridView2.Rows[x].DefaultCellStyle.ForeColor = Color.MidnightBlue;
                        }
                        if (status == "Ocupado")
                        {
                            dataGridView2.Rows[x].DefaultCellStyle.BackColor = Color.Gold;
                            DateTime dataRetirada;
                            DateTime Data_atual;
                            string dataAtual = DateTime.Now.ToLongDateString();
                            dataRetirada = Convert.ToDateTime(dataGridView2.Rows[x].Cells[7].Value.ToString());
                            Data_atual = Convert.ToDateTime(dataAtual);

                            if (Data_atual > dataRetirada)
                            {
                                dataGridView2.Rows[x].Cells[7].Style.BackColor = Color.White;
                            }

                        }
                        if (status == "Interditado")
                        {
                            dataGridView2.Rows[x].DefaultCellStyle.BackColor = Color.Red;
                            dataGridView2.Rows[x].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA DE COMPARTIMENTOS. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
