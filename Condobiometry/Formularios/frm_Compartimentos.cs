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
    public partial class frm_Compartimentos : Form
    {
        private CondoRepositorio repo = new CondoRepositorio();
        Ebox ebox = new Ebox();


        public static string port_Com;
        public string Data;
        public string user_login;
        public string id_login;
        //varial para verificar validação de campos
        bool validados;
        public frm_Compartimentos()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
            string digitado = txt_nomeEbox.Text.Trim();

            bool existeEbox = repo.ChecacaEbox(digitado);

            if (existeEbox)
            {
                MessageBox.Show("E-BOX INFORMADO JÁ CADASTRADO!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ValidaCampos_ebox();

                    if (validados)
                    {
                        MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS IDENTIFICADOS DEVE SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validados = false;
                    }
                    else
                    {
                        ebox.id_login = id_login;
                        ebox.num_ebox = txt_nomeEbox.Text;
                        ebox.tamanho = txt_tamanho.Text;
                        ebox.status_ebox = txt_situacao.Text;
                        ebox.data_cad = "";

                        var resultado = repo.InclusaoDadosEbox(ebox);

                        MessageBox.Show("O Ebox " + txt_nomeEbox.Text + " FOI CADASTRADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpar_ebox();
                        Lista_Dados_Ebox();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO AO CADSTRAR.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void ValidaCampos_ebox()
        {

            if (txt_nomeEbox.Text == "")
            {
                txt_nomeEbox.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_tamanho.Text == "")
            {
                txt_tamanho.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_situacao.Text == "")
            {
                txt_situacao.BackColor = Color.Bisque;
                validados = true;
            }
        }

        private void txt_perfilUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void limpar_ebox()
        {
            txt_idEbox.Text = "";
            txt_nomeEbox.Text = "";
            txt_tamanho.Text = "";
            txt_situacao.Text = "";

        }
        private void Lista_Dados_Ebox()
        {
            
            try
            {
                List<Ebox> eboxList = new List<Ebox>();

                eboxList = repo.GetAllEbox();
               
                dataGridView2.DataSource = eboxList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA DE EBOX. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // DataTable newDt = new DataTable();
            // newDt = (DataTable)dataGridView2.DataSource;
            // this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", newDt));
            //this.reportViewer1.RefreshReport();
        }

        private void frm_Compartimentos_Load(object sender, EventArgs e)
        {

            //this.PessoaTableAdapter.Fill(this.DataSetPessoa2.Pessoa);

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Sobrenome");

            dataTable.Rows.Add(1, "André", "Lima");
            dataTable.Rows.Add(2, "Fulano", "de Tal");
            dataTable.Rows.Add(3, "Beltrano", "da Silva");
            dataTable.Rows.Add(4, "Zé", "Ninguém");

            //   this.reportViewer1.LocalReport.DataSources.Clear();
            //   this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dataTable));

            //   this.reportViewer1.RefreshReport();

            Lista_Dados_Ebox();

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
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpar_ebox();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

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

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 1)
            {
                txt_idEbox.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txt_nomeEbox.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txt_tamanho.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txt_situacao.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                // txt_idEbox.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btn_alterarDados_Click(object sender, EventArgs e)
        {
            try
            {
                Ebox ebox = new Ebox();
                ebox.num_ebox = txt_nomeEbox.Text;
                ebox.tamanho = txt_tamanho.Text;
                ebox.status_ebox = txt_situacao.Text;
                ebox.id_ebox = txt_idEbox.Text;


                bool ret = repo.UpdateEbox(ebox);

                MessageBox.Show("O CADASTRO FOI ATUALIZADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar_ebox();
                Lista_Dados_Ebox();

            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL ATUALIZAR  OS DADOS DO USUARIOS. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                Ebox ebox = new Ebox();
                ebox.num_ebox = txt_nomeEbox.Text;
                ebox.tamanho = txt_tamanho.Text;
                ebox.status_ebox = "D";
                ebox.id_ebox = txt_idEbox.Text;
               
                bool ret = repo.ExcluirEbox(ebox);

                MessageBox.Show("O CADASTRO FOI EXCLUIDO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar_ebox();
                Lista_Dados_Ebox();

            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL ATUALIZAR  OS DADOS DO USUARIOS. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
