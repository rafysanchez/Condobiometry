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
    public partial class frm_Cadastro : Form
    {

        Modelo mod = new Modelo();
        private CondoRepositorio repo = new CondoRepositorio();

        public static string port_Com;
        public string Data;
        public string user_login, Serial_read, comando;
        public string id_login;
        bool validados;
        public frm_Cadastro()
        {
            InitializeComponent();
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

        private void frm_Cadastro_Load(object sender, EventArgs e)
        {
            frm_principal frm = new frm_principal();
            txt_usuario.Text = "0" + frm.id_usuario + " " + frm.nome_usuario;
            user_login = frm.nome_usuario;
            id_login = frm.id_usuario;
            port_Com = frm.port_Conect;

            tabControl1.Controls.Remove(tabPage2);
            tabControl1.Controls.Remove(tabPage3);
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
        private void ValidaCampos()
        {
            if (txt_nomeUsuario.Text == "")
            {
                txt_nomeUsuario.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_apto.Text == "")
            {
                txt_apto.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_bloco.Text == "")
            {
                txt_bloco.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_senha.Text == "")
            {
                txt_senha.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_idBiometria.Text == "")
            {
                txt_idBiometria.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_funcao.Text == "")
            {
                txt_funcao.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_empresa.Text == "")
            {
                txt_empresa.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_perfilUsuario.Text == "")
            {
                txt_perfilUsuario.BackColor = Color.Bisque;
                validados = true;
            }
        }
        private void Limpa_Campos()
        {
            txt_perfilUsuario.Text = "";
            txt_idUsuario.Text = "";
            txt_nomeUsuario.Text = "";
            txt_bloco.Text = "";
            txt_apto.Text = "";
            txt_senha.Text = "";
            txt_idBiometria.Text = "0";
            txt_funcao.Text = "";
            txt_empresa.Text = "";
            txt_empresa.Enabled = false;
            txt_funcao.Visible = false;
            label2.Visible = false;
            txt_bloco.Enabled = true;
            txt_apto.Enabled = true;
            validados = false;
            picture_biometria.Image = Properties.Resources.semdigital;
            btn_salvar.Enabled = true;

        }

        private void txt_funcao_TextChanged(object sender, EventArgs e)
        {

        }
        private void Select_tab(int index)
        {
            tabControl1.Controls.RemoveAt(0);
            TabPage[] tabPag = { tabPage1, tabPage2, tabPage3 };
            tabControl1.Controls.Add(tabPag[index]);
            tabControl1.SelectedTab = tabPag[index];
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Limpa_Campos();
        }
        private void Lista_Dados()
        {

            try
            {

                List<Modelo> listaMoradores = new List<Modelo>();
                listaMoradores = repo.ListarTabela_DGV();

                dataGridView1.DataSource = listaMoradores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA DE MORADORES. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {

            Modelo mod = new Modelo();
            mod.id = id_login;
            mod.nome = txt_nomeUsuario.Text.ToUpper();
            mod.Perfil = txt_perfilUsuario.Text;
            mod.Apartamento = txt_apto.Text;
            mod.Bloco = txt_bloco.Text;
            mod.Funcao = txt_funcao.Text;
            mod.Empresa = txt_empresa.Text;
            mod.senha = txt_senha.Text;
            mod.Id_biometria = txt_idBiometria.Text.ToString();
            mod.dataCad = DateTime.Now.ToString();

            try
            {

                if (txt_perfilUsuario.Text == "Morador")
                {
                    ValidaCampos();
                    if (validados)
                    {
                        MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS IDENTIFICADOS DEVEM SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validados = false;
                    }
                    else if (txt_senha.Text.Length < 8)
                    {
                        MessageBox.Show("SENHA DEVE CONTER 8 DIGITOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        var ret = repo.InsertUsuario(mod);

                        MessageBox.Show("O USUARIO " + txt_nomeUsuario.Text + " FOI CADASTRADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpa_Campos();
                        Lista_Dados();
                    }

                }
                else if ((txt_perfilUsuario.Text == "Entregador") || (txt_perfilUsuario.Text == "Administrador"))
                {
                    if (validados)
                    {
                        MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS IDENTIFICADOS DEVEM SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validados = false;
                    }
                    else if (txt_senha.Text.Length < 8)
                    {
                        MessageBox.Show("SENHA DEVE CONTER 8 DIGITOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        var ret = repo.InsertUsuario(mod);

                        var ret2 = repo.InsertTblLogin(mod);


                        MessageBox.Show("O USUARIO " + txt_nomeUsuario.Text + " FOI CADASTRADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpa_Campos();
                        Lista_Dados();
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADSTRAR.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Select_tab(0);

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

            string digitado = txt_buscar.Text.Trim();

            try
            {
                List<Modelo> lista = repo.PesquisarMorador(digitado);

                dataGridView1.DataSource = lista;

            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA DE USUARIOS. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Select_tab(1);
        }

        private void btn_alterarDados_Click(object sender, EventArgs e)
        {


            ValidaCampos();

            if (validados)
            {
                MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS IDENTIFICADOS DEVEM SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validados = false;
            }
            else
            {
                try
                {
                    repo.UpdateUsuario(mod);

                    MessageBox.Show("O CADASTRO FOI ATUALIZADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpa_Campos();
                    Lista_Dados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("NÃO FOI POSSIVEL ATUALIZAR  OS DADOS DO USUARIOS. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("REALMENTE DESEJA EXCLUIR USUARIO" + txt_nomeUsuario.Text + " ?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
            {
                ValidaCampos();
                if (validados)
                {
                    MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS IDENTIFICADOS DEVEM SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validados = false;
                }
                else
                {
                    try
                    {

                        repo.UpdateUsuarioStatus(mod);

                        MessageBox.Show("O CADASTRO FOI EXCLUIDO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpa_Campos();

                        Lista_Dados();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("NÃO FOI POSSÍVEL EXCLUIR O USUARIO. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txt_nomeUsuario_Click(object sender, EventArgs e)
        {

            string num = repo.getMaxIdUsuario();

            txt_idUsuario.Text = num;

            if (txt_idUsuario.Text == "") txt_idUsuario.Text = "1";
        }

        private void txt_perfilUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_perfilUsuario.SelectedItem.ToString() == "Morador")
            {
                txt_funcao.Text = "Morador";
                txt_empresa.Text = "Morador";
                txt_bloco.Text = "";
                txt_apto.Text = "";
                txt_empresa.Enabled = false;
                txt_funcao.Visible = false;
                label2.Visible = false;
            }
            if ((txt_perfilUsuario.SelectedItem.ToString() == "Administrador") || (txt_perfilUsuario.SelectedItem.ToString() == "Entregador"))
            {
                txt_bloco.Text = "Entregador";
                txt_apto.Text = "Entregador";
                txt_funcao.Text = "";
                txt_empresa.Text = "";
                txt_empresa.Enabled = true;
                txt_funcao.Visible = true;
                label2.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

        private void btn_cadastrar_biometria_Click(object sender, EventArgs e)
        {
            txt_msgBox.Text = "";

            txt_msgBox.Visible = true;

            if (txt_idUsuario.Text.Length == 1)
            {
                comando = "00" + txt_idUsuario.Text;
            }
            else if (txt_idUsuario.Text.Length == 2)
            {
                comando = "0" + txt_idUsuario.Text;
            }
            else if (txt_idUsuario.Text.Length == 3)
            {
                comando = txt_idUsuario.Text;
            }
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(comando);
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(Read_serial));   //chama outra thread para escrever o dado no text box 
        }
        private void Read_serial(object sender, EventArgs e)
        {
            //Serial_read = serialPort1.ReadLine();
            Serial_read = serialPort1.ReadExisting();

            txt_msgBox.Text = Serial_read;

            if (Serial_read.IndexOf("#") > 0)
            {
                txt_idBiometria.Text = Serial_read.Substring(0, (Serial_read.IndexOf("#")));

                picture_biometria.Image = CondoBiometry.Properties.Resources.digital;

                txt_msgBox.Visible = false;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.btn_pesquisar_Click(sender, e);
        }

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                this.btn_pesquisar_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA DE USUARIOS. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_alterarDados.Enabled = true;
            btn_salvar.Enabled = false;

            txt_idUsuario.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_nomeUsuario.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_apto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_bloco.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_senha.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_funcao.Text = "Morador";
            txt_empresa.Text = "Morador";
            txt_perfilUsuario.Text = "Morador";
            txt_idBiometria.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            if (txt_idBiometria.Text != "")
            {
                picture_biometria.Image = CondoBiometry.Properties.Resources.digital;
            }
            else
            {
                picture_biometria.Image = CondoBiometry.Properties.Resources.semdigital;
            }
            Select_tab(0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}