using CondoBiometry.Class;
using CondoBiometry.sqLite.Repositorio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondoBiometry
{
    public partial class frm_Manutencao : Form
    {
        private CondoRepositorio repo = new CondoRepositorio();
        Modelo mod = new Modelo();
 

        public static string port_Com;
        public string Data;
        public string user_login;
        public string id_login;
        public string abrir_ebox;
        String[] comandSerial = { "Ç", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "X", "W", "Y", "Z" };

        public static string script_backup;//passa  valor para class
        public static string local_backup;
        public static string local_restore;
        public static string caminho_instalacao_Mysql;


        public string Caminho_backup
        {
            get { return local_backup; }
        }
        public string Caminho_restore
        {
            get { return local_restore; }
        }
        public string Arquivo_sql
        {
            get { return script_backup; }
        }
        public string local_instalacao
        {
            get { return caminho_instalacao_Mysql; }
        }
        public frm_Manutencao()
        {
            InitializeComponent();
        }

        private void frm_Manutencao_Load(object sender, EventArgs e)
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
            tabControl1.Controls.Remove(tabPage2);
            tabControl1.Controls.Remove(tabPage2);
            tabControl1.Controls.Remove(tabPage3);
            tabControl1.Controls.Remove(tabPage4);
            tabControl1.Controls.Remove(tabPage5);
            tabControl1.Controls.Remove(tabPage6);
            Select_tab(0);

            id_responsavel.Text = id_login;
            txt_nomeUsuario.Text = user_login;
            Lista_bloqueio();
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
        private void Select_tab(int index)
        {
            tabControl1.Controls.RemoveAt(0);
            TabPage[] tabPag = { tabPage1, tabPage2, tabPage3, tabPage4, tabPage5, tabPage6 };
            tabControl1.Controls.Add(tabPag[index]);
            tabControl1.SelectedTab = tabPag[index];
            Button[] botao = { btn_abertura, btn_bloqueio, btn_desbloqueio, btn_conexao, btn_historico, btn_backup };
            for (int i = 0; i < 6; i++)
            {
                if (i == index)
                {
                    botao[i].BackColor = Color.Gold;
                    botao[i].ForeColor = Color.MidnightBlue;
                }
                else
                {
                    botao[i].BackColor = Color.MidnightBlue;
                    botao[i].ForeColor = Color.Gold;
                }
            }
        }
        private void Select_button(int index)
        {
            Button[] botao = { button1, button2, button3 };
            for (int i = 0; i < 3; i++)
            {
                if (i == index)
                {
                    botao[i].BackColor = Color.Gold;
                    botao[i].ForeColor = Color.MidnightBlue;
                }
                else
                {
                    botao[i].BackColor = Color.MidnightBlue;
                    botao[i].ForeColor = Color.Gold;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            limpar();
            Select_tab(0);
            id_responsavel.Text = id_login;
            txt_nomeUsuario.Text = user_login;
            Lista_LogAbertura();
        }

        private void btn_bloqueio_Click(object sender, EventArgs e)
        {
            limpar();
            Select_tab(1);
            txt_responsavelBloqueio.Text = id_login;
            txt_nomeResponsavel.Text = user_login;
            Lista_bloqueio();
        }

        private void btn_desbloqueio_Click(object sender, EventArgs e)
        {
            limpar();
            Select_tab(2);
            txt_idRespDesbloqueio.Text = id_login;
            txt_nomeRespDesbloqueio.Text = user_login;
            Lista_desbloqueio();
        }

        private void btn_conexao_Click(object sender, EventArgs e)
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                txt_ListPort.Items.Add(s);
            }

            try
            {
                if (txt_ListPort.Items.Count > 0)
                {
                    txt_ListPort.SelectedIndex = 0; // seleciona primeira linha
                }
            }
            catch
            {
                MessageBox.Show("ERRO DE CONEXÃO." + "\n" + "VERIFIQUE SE O CABO USB ESTA CONECTADO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Select_tab(3);
        }

        private void btn_historico_Click(object sender, EventArgs e)
        {
            Select_tab(4);
        }

        private void btn_confirmaAbertura_Click(object sender, EventArgs e)
        {
            LogAbertura logabertura = new LogAbertura();

            try
            {


                if ((txt_num.Text == "") || (txt_motivo.Text == "") || (txt_selecioneAbertura.Text == "") || (txt_nomeebox.Text == ""))
                {
                    MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS DEVEM SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (txt_selecioneAbertura.Text == "Abrir todos")
                    {
                        abrir_ebox = "b";

                        logabertura.id_login = id_login;
                        logabertura.ebox = "Todos";
                        logabertura.motivo = txt_motivo.Text;
                        logabertura.data_log = "current_dat";
                        logabertura.hora_log = "current_time";


                        var ret = repo.InserLogAbertura(logabertura);

                        //mod.sql = "insert into tbl_log_abertura (id_login,ebox,motivo,data_log,hora_log)Values('" + id_login + "','Todos','"+txt_motivo.Text 
                        //          + "',current_date,current_time)";
                    }
                    else
                    {
                        abrir_ebox = comandSerial[int.Parse(txt_num.Text)];
                        logabertura = new LogAbertura();
                        logabertura.id_login = id_login;
                        logabertura.ebox = txt_nomeebox.Text;
                        logabertura.motivo = txt_motivo.Text;
                        logabertura.data_log = "current_dat";
                        logabertura.hora_log = "current_time";


                        //mod.sql = "insert into tbl_log_abertura (id_login,ebox,motivo,data_log,hora_log)Values('" + id_login + "','"+txt_nomeebox.Text+"','" +
                        //            txt_motivo.Text + "',current_date,current_time)";
                    }
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Write(abrir_ebox);
                        var ret = repo.InserLogAbertura(logabertura);

                        MessageBox.Show("O COMPARTIMENTO SELECIONADO FOI ABERTO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpar();
                        //Lista_LogAbertura();
                    }
                    else
                    {
                        MessageBox.Show("A CONEXÃO COM O ARDUINO FOI PERDIDA.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO AO CADSTRAR.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void limpar()
        {
            txt_selecioneAbertura.Text = "";
            txt_num.Text = "";
            txt_nomeebox.Text = "";
            txt_motivo.Text = "";
            txt_nomeUsuario.Text = "";
            id_responsavel.Text = "";
            txt_numBloqueio.Text = "";
            txt_nomeCompartimento.Text = "";
            txt_motivoBloqueio.Text = "";
            txt_responsavelBloqueio.Text = "";
            txt_nomeResponsavel.Text = "";
            txt_obs.Text = "";
            txt_numDesbloqueio.Text = "";
            txt_nomeDesbloqueio.Text = "";
            txt_idRespDesbloqueio.Text = "";
            txt_nomeRespDesbloqueio.Text = "";
        }

        private void btn_comfirmaDesbloqueio_Click(object sender, EventArgs e)
        {

            try
            {
                if ((txt_numDesbloqueio.Text == "") || (txt_nomeRespDesbloqueio.Text == "") || (txt_obs.Text == ""))
                {
                    MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS DEVEM SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Servico serv = new Servico() { id_ebox = "1", id_login = id_login, data_conclusao = "", resp_conclusao = txt_nomeRespDesbloqueio.Text, observacao = txt_obs.Text, status_os = "Fechado" };

                    var retor = repo.UpdateServicoConclusao(serv);

                    //mod.sql = "update tbl_servico SET data_conclusao = current_date,resp_conclusao = '" + txt_nomeRespDesbloqueio.Text + "',observacao = '" + txt_obs.Text + "',status_os = 'Fechado' ";


                    Ebox ebox = new Ebox() { id_ebox = txt_numDesbloqueio.Text };
                    bool ret = repo.UpdateEboxStatus(ebox);

                    //mod.sql = "Update tbl_ebox set status_ebox = 'Livre' where id_ebox = '" + txt_numDesbloqueio.Text + "'";


                    MessageBox.Show("O COMPARTIMENTO " + txt_nomeDesbloqueio.Text + " FOI DESBLOQUEADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DADOS " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelarAbertura_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn_cancelaBloqueio_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn_cancelarDesbloqueio_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn_confirmaBloqueio_Click(object sender, EventArgs e)
        {

            try
            {
                // Data = Data.Substring(6, 4) + Data.Substring(2, 3) + "/" + Data.Substring(0, 2); //converte para padrao Mysql 

                if ((txt_numBloqueio.Text == "") || (txt_motivoBloqueio.Text == ""))
                {
                    MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS DEVEM SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Servico servico = new Servico();
                    servico.id_login = id_login;
                    servico.resp_abertura = txt_responsavelBloqueio.Text;
                    servico.id_ebox = txt_numBloqueio.Text;
                    servico.motivo = txt_motivoBloqueio.Text;
                    servico.data_ocorrencia = "current_date";
                    servico.data_conclusao = "current_date";
                    servico.resp_conclusao = "";
                    servico.observacao = "";

                    var ret = repo.InsertServico(servico);

                    //mod.sql = "insert into tbl_servico(id_login,resp_abertura,id_ebox,motivo,data_ocorrencia,data_conclusao,resp_conclusao,observacao) values('" +
                    //           id_login + "','" + txt_responsavelBloqueio.Text + "','"+txt_numBloqueio.Text+"','"+txt_motivoBloqueio.Text + "',current_date,current_date,'null','null')";



                    MessageBox.Show("O COMPARTIMENTO " + txt_nomeCompartimento.Text + " FOI BLOQUEADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DE DADOS.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void txt_ListPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            port_Com = txt_ListPort.SelectedItem.ToString();
        }

        private void txt_ListPort_Click(object sender, EventArgs e)
        {
            txt_ListPort.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                txt_ListPort.Items.Add(s);
            }
        }

        private void btn_ConfirmarPage5_Click(object sender, EventArgs e)
        {
            if (btn_CONECTAR.Text == "Conectar")
            {
                if (txt_ListPort.Text == "")
                {
                    MessageBox.Show("PRIMEIRO SELECIONA A PORTA PARA CONEXÃO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                                txt_estadoPorta.Text = "Conectado  " + port_Com;
                                txt_statusPort.Text = "Conectado  " + port_Com;
                                btn_CONECTAR.Text = "Desconectar";
                                frm_principal frm = new frm_principal();
                                Salva_log();
                            }
                        }

                    }
                    catch
                    {
                        MessageBox.Show("ERRO DE CONEXÃO." + "\n" + " O HARDWARE ESPECIFICADO NÃO FOI LOCALIZADO." + "\n" + "VERIFIQUE SE O CABO USB ESTA CONECTADO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else if (btn_CONECTAR.Text == "Desconectar")
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close();
                        if (serialPort1.IsOpen != true)
                        {
                            txt_estadoPorta.Text = "Não conectado ****";
                            txt_statusPort.Text = "Não conectado ****";
                            btn_CONECTAR.Text = "Conectar";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("ERRO DE CONEXÃO." + "\n" + " O HARDWARE ESPECIFICADO NÃO FOI LOCALIZADO." + "\n" + "VERIFIQUE SE O CABO USB ESTA CONECTADO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            frm.Show();
            this.Hide();
        }
        private void Salva_log()
        {
            LogConexao logconexao = new LogConexao();
            logconexao.port_conection = port_Com;
            logconexao.log_acao = "Conexao";
            logconexao.data_log = "current_date";
            logconexao.hora_log = "current_time";

            bool ret = repo.InsertLogConexao(logconexao);

            //mod.sql = "INSERT INTO tbl_log_conexao(port_conection,log_acao,data_log,hora_log) VALUES ('" + port_Com + "','Conexao',current_date,current_time)";


        }

        private void txt_nomeebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                mod.sql = " SELECT id_ebox from tbl_ebox where num_ebox = '" + txt_nomeebox.SelectedItem + "' ";

            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DE DADOS.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_nomeebox_Click(object sender, EventArgs e)
        {
            txt_nomeebox.Items.Clear();
            try
            {

               // string sql = "SELECT distinct num_ebox from tbl_ebox";

                List<Ebox> listEbox = new List<Ebox>();
                listEbox = repo.GetAllEbox();


                for (int i = 0; i < listEbox.Count; i++)
                {
                    txt_nomeebox.Items.Insert(i, listEbox[i].ToString());
                }

                id_responsavel.Text = id_login;

                txt_nomeUsuario.Text = user_login;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DE DADOS.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_nomeCompartimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try

            {
                var numEbox = txt_nomeCompartimento.SelectedItem;

                Ebox ebox = repo.GetAllEbox().Where(x => x.num_ebox == numEbox.ToString()).SingleOrDefault();
            
                txt_numBloqueio.Text = ebox.id_ebox;

            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DE DADOS.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_nomeCompartimento_Click(object sender, EventArgs e)
        {
            txt_nomeCompartimento.Items.Clear();
            try
            {

               

                var EboxLivres = repo.GetAllEbox().Where(x => x.status_ebox == "Livre").ToList();

                for (int i = 0; i < EboxLivres.Count; i++)
                {
                    txt_nomeCompartimento.Items.Insert(Convert.ToInt16(EboxLivres[i].id_ebox), EboxLivres[i].num_ebox.ToString());
                }
                txt_responsavelBloqueio.Text = id_login;

                txt_nomeResponsavel.Text = user_login;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DE DADOS.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txt_nomeDesbloqueio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string  NomeDesbloqueio = txt_nomeDesbloqueio.SelectedItem.ToString();

                var ebox = repo.GetAllEbox().Where(x => x.num_ebox == NomeDesbloqueio).SingleOrDefault();
           
                txt_numDesbloqueio.Text = ebox.id_ebox;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DE DADOS.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_nomeDesbloqueio_Click(object sender, EventArgs e)
        {
            txt_nomeDesbloqueio.Items.Clear();
            try
            {
                var EboxInterditado = repo.GetAllEbox().Where(x => x.status_ebox == "Interditado").ToList();

                for (int i = 0; i < EboxInterditado.Count; i++)
                {
                    txt_nomeDesbloqueio.Items.Insert(Convert.ToInt32(EboxInterditado[i].id_ebox), EboxInterditado[i].num_ebox.ToString());
                }
                txt_idRespDesbloqueio.Text = id_login;

                txt_nomeRespDesbloqueio.Text = user_login;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DE DADOS.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }
        public void Lista_bloqueio()
        {

    
            try
            {
                List<Servico> ServicosAbertos = repo.GetAllServicos().Where(x=>x.status_os== "Aberto").ToList();
                //mod.sql = "Select * from tbl_servico where status_os = 'Aberto'";
                dataGridView1.DataSource = ServicosAbertos;

            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DE DADOS.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Lista_desbloqueio()
        {
           
            try
            {
                List<Servico> ServicosFechados = repo.GetAllServicos().Where(x => x.status_os == "Fechado").ToList();

                dataGridView1.DataSource = ServicosFechados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DE DADOS.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Lista_LogAbertura()
        {
            
            try
            {
                List<LogAbertura> listLogAbertura = new List<LogAbertura>();

                listLogAbertura = repo.GetAllLogAbertura();

                mod.sql = "select a.id_log_abertura as Codigo, l.Nome as Responsavel,a.Ebox,a.Motivo,a.data_log as Data_abertura," +
                          "a.hora_log as Hora from tbl_log_abertura a inner join tbl_login l where a.id_login = l.id_login";

                dataGridView1.DataSource = listLogAbertura;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DE DADOS.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txt_selecioneAbertura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_selecioneAbertura.SelectedItem.ToString() == "Abrir todos")
            {
                txt_nomeebox.Text = "Todos";
                txt_nomeebox.Enabled = false;
                txt_num.Text = "0";
            }
            else
            {
                txt_num.Text = "";
                txt_nomeebox.Text = "";
                txt_nomeebox.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Select_button(0);
            Lista_LogAbertura();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Select_button(1);
            Lista_bloqueio();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Select_button(2);
            Lista_desbloqueio();
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            Select_tab(5);
            try
            {
                List<BackupRestore> backupRestores = new List<BackupRestore>();

                backupRestores = repo.GetAllBackupRestore();

                mod.sql = "Select local_bd, freq_backup, local_backup from tbl_backup_restore where id_backup = (Select max(id_backup) from tbl_backup_restore)";

                mod.string_1 = "local_bd";
                mod.string_2 = "freq_backup";
                mod.string_3 = "local_backup";

               

                txt_local_instalacaoMsql.Text = mod.string_1.Replace("#", "\\");
                txt_freq_backup.Text = mod.string_2;
                txt_local_backup.Text = mod.string_3.Replace("#", "\\");

                caminho_instalacao_Mysql = mod.string_1.Replace("#", "\\");
                local_backup = mod.string_3.Replace("#", "\\");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DADOS " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void btn_configBackup_Click(object sender, EventArgs e)
        {
            try
            {
                painel_backup.Visible = true;
                txt_horaRestore.Visible = false;

                List<BackupRestore> backupRestores = new List<BackupRestore>();

                backupRestores = repo.GetAllBackupRestore();

                mod.sql = "Select local_bd,freq_backup,local_backup from tbl_backup_restore where id_backup = (Select max(id_backup) from tbl_backup_restore)";
                mod.string_1 = "local_bd";
                mod.string_2 = "freq_backup";
                mod.string_3 = "local_backup";

              

                txt_local_instalacaoMsql.Text = mod.string_1.Replace("#", "\\");
                txt_freq_backup.Text = mod.string_2;
                txt_local_backup.Text = mod.string_3.Replace("#", "\\");

                caminho_instalacao_Mysql = mod.string_1.Replace("#", "\\");
                local_backup = mod.string_3.Replace("#", "\\");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DADOS " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Config_restore_Click(object sender, EventArgs e)
        {
            try
            {
                painel_backup.Visible = false;
                txt_horaRestore.Visible = true;

                List<BackupRestore> backupRestores = new List<BackupRestore>();

                backupRestores = repo.GetAllBackupRestore();


                mod.sql = "Select u.nome,b.data_cad,b.hora from tbl_backup_restore b inner join tbl_login u where" +
                       " id_backup = (Select max(id_backup) from tbl_backup_restore) and u.id_login = b.id_login and execucao = 'Restore'";
                mod.string_1 = "u.nome";
                mod.string_2 = "b.data_cad";
                mod.string_3 = "b.hora";


                txt_resp_backup_anterior.Text = mod.string_1;
                txt_dataRestore.Text = mod.string_2;
                txt_hora.Text = mod.string_3;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL SE CONECTAR A BASE DADOS " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_alterarLocalInstalacao_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "CAMINHO DA INSTALAÇÃO DO BANCO DE DADOS.";
            //abre caixa de diálogo para a busca de uma pasta para se salvar os arquivos
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_local_instalacaoMsql.Text = folderBrowserDialog1.SelectedPath;
                caminho_instalacao_Mysql = txt_local_instalacaoMsql.Text;

            }
        }

        private void btn_alterarLocal_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "LOCAL PARA FAZER O BACKUP.";
            //abre caixa de diálogo para a busca de uma pasta para se salvar os arquivos
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_local_backup.Text = folderBrowserDialog1.SelectedPath;
                local_backup = txt_local_backup.Text;

            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {

                id_login = "1";

                BackupRestore backupRestore = new BackupRestore()
                {
                    id_login = id_login,
                    local_bd = txt_local_instalacaoMsql,
                    freq_backup = txt_freq_backup.Text,
                    local_backup = txt_local_backup.Text.Replace(@"\", "#"),
                    local_restore = txt_localRestore.Text.Replace(@"\", "#"),
                    data_cad = "current_date",
                    hora = "current_time",
                    execucao = "Restore"
                };

                var ret = repo.InsertBackUpRestore(backupRestore);

                //mod.sql = "Insert into tbl_backup_restore(id_login,local_bd,freq_backup,local_backup,local_restore,data_cad,hora) Values('" + id_login + "','" + txt_local_instalacaoMsql.Text.Replace(@"\", "#")
                //          + "','" + txt_freq_backup.Text + "','" + txt_local_backup.Text.Replace(@"\", "#") + "','" + txt_localRestore.Text.Replace(@"\", "#") + "',current_date,current_time)";


                MessageBox.Show("OS DADOS FORAM SALVOS COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO AO CADSTRAR.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salvarBackup_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.Realizar_Backup();
        }

        private void btn_buscarArquivo_Click(object sender, EventArgs e)
        {
            txt_localRestore.Text = "";
            //define as propriedades do controle 
            //OpenFileDialog
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "SELECIONE ARQUIVO DE RECUPERAÇAO";
            openFileDialog1.InitialDirectory = "C:\\";
            //filtra para exibir somente arquivos .sql    
            openFileDialog1.Filter = "Arquivo SQL(*.sql)|*.sql";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in openFileDialog1.FileNames)
                {
                    txt_localRestore.Text += arquivo;
                    script_backup = txt_localRestore.Text;
                    caminho_instalacao_Mysql = txt_local_instalacaoMsql.Text;
                    // script_backup = System.IO.Path.GetFileName(openFileDialog1.FileName);
                }
            }
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            if (script_backup == null)
            {
                MessageBox.Show("SELECIONE O ARQUIVO PARA RESTAURAÇÃO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Backup bk = new Backup();
                bk.Realizar_Restore();
                Resgistra_restore();//salva no bd
            }
        }
        private void Resgistra_restore()
        {
            try
            {
                BackupRestore backupRestore = new BackupRestore()
                {
                    id_login = id_login,
                    local_bd = txt_local_instalacaoMsql,
                    freq_backup = txt_freq_backup.Text,
                    local_backup = txt_local_backup.Text.Replace(@"\", "#"),
                    local_restore = txt_localRestore.Text.Replace(@"\", "#"),
                    data_cad = "current_date",
                    hora = "current_time",
                    execucao = "Restore"
                };
                var ret = repo.InsertBackUpRestore(backupRestore);

                //mod.sql = "Insert into tbl_backup_restore(id_login,local_bd,freq_backup,local_backup,local_restore,data_cad,hora,execucao) Values('" + id_login + "','" + txt_local_instalacaoMsql.Text.Replace(@"\", "#")
                //            + "','" + txt_freq_backup.Text + "','" + txt_local_backup.Text.Replace(@"\", "#") + "','" + txt_localRestore.Text.Replace(@"\", "#") + "',current_date,current_time,'Restore')";

               
                MessageBox.Show("OS DADOS FORAM SALVOS COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADSTRAR.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
