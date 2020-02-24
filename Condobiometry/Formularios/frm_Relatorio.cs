using CondoBiometry.Class;
using CondoBiometry.DataSet_Report;
using CondoBiometry.Relatorios;
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
    public partial class frm_Relatorio : Form
    {
        private CondoRepositorio repo = new CondoRepositorio();
        Modelo mod = new Modelo();


        public static string port_Com;
        public string Data;
        public string user_login;
        public string id_login;
        public static string Instrucao_Sql, Nome_relatorio;

        public frm_Relatorio()
        {
            InitializeComponent();
        }
        public string InstrucaoSql
        {
            get { return Instrucao_Sql; }
        }
        public string NomeRelatorio
        {
            get { return Nome_relatorio; }
        }

        private void frm_Relatorio_Load(object sender, EventArgs e)
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_tipo_relatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_filtro.Items.Clear();

            if (txt_tipo_relatorio.Text == "Usuarios")
            {
                txt_filtro.Items.Add("Todos");
                txt_filtro.Items.Add("Nome");
                txt_filtro.Items.Add("Bloco");
                txt_filtro.Items.Add("Bloco e Apto");
                txt_filtro.Items.Add("Entregador");
                txt_filtro.Items.Add("Período");
                txt_filtro.Items.Add("Quantidade");

            }
            else if (txt_tipo_relatorio.Text == "Encomendas")
            {
                txt_filtro.Items.Add("Código");
                txt_filtro.Items.Add("Entregue");
                txt_filtro.Items.Add("Não entregue");
                txt_filtro.Items.Add("Bloco e Apto");
                txt_filtro.Items.Add("Retirada em atraso");
                txt_filtro.Items.Add("Período");

            }
            else if (txt_tipo_relatorio.Text == "Compartimentos")
            {
                txt_filtro.Items.Add("Livre");
                txt_filtro.Items.Add("Ocupado");
                txt_filtro.Items.Add("Interditado");
                txt_filtro.Items.Add("Ocupado Com Atraso");
                txt_filtro.Items.Add("Mais utilizado");
                txt_filtro.Items.Add("Mais interditado");

            }
            else if (txt_tipo_relatorio.Text == "Manutenção")
            {
                txt_filtro.Items.Add("Em aberto");
                txt_filtro.Items.Add("Finalizado");
                txt_filtro.Items.Add("Compartimento");
                txt_filtro.Items.Add("Responsável");
                txt_filtro.Items.Add("Período");

            }
            else if (txt_tipo_relatorio.Text == "Aberturas")
            {
                txt_filtro.Items.Add("Compartimento");
                txt_filtro.Items.Add("Responsável");
                txt_filtro.Items.Add("Motivo");
                txt_filtro.Items.Add("Periodo");

            }
            else if (txt_tipo_relatorio.Text == "Auditoria")
            {
                txt_filtro.Items.Add("Selecione");

            }
        }

        private void txt_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_filtro.Text == "Bloco")
            {
                txt_apto.Enabled = false;
            }
            else
            {
                txt_apto.Enabled = true;
            }
            if (txt_tipo_relatorio.Text == "Usuarios")
            {
                if (txt_filtro.Text == "Todos")
                {
                    panel_nome.Visible = false;
                    panel_periodo.Visible = false;
                    panel_bloco.Visible = false;
                }
                else if (txt_filtro.Text == "Nome")
                {
                    txt_entrada_busca.Text = "Nome usuário:";
                    panel_nome.Visible = true;
                    panel_periodo.Visible = false;
                    panel_bloco.Visible = false;
                }
                else if (txt_filtro.Text == "Bloco")
                {
                    panel_nome.Visible = false;
                    panel_periodo.Visible = false;
                    panel_bloco.Visible = true;
                    txt_apto.Enabled = false;
                }
                else if (txt_filtro.Text == "Bloco e Apto")
                {
                    panel_nome.Visible = false;
                    panel_periodo.Visible = false;
                    panel_bloco.Visible = true;
                }
                else if (txt_filtro.Text == "Entregador")
                {
                    panel_nome.Visible = true;
                    txt_entrada_busca.Text = "Nome entregador:";
                    panel_periodo.Visible = false;
                    panel_bloco.Visible = false;
                }
                else if (txt_filtro.Text == "Período")
                {
                    panel_nome.Visible = false;
                    panel_periodo.Visible = true;
                    panel_bloco.Visible = false;
                }
                else if (txt_filtro.Text == "Quantidade")
                {
                    panel_nome.Visible = false;
                    panel_periodo.Visible = false;
                    panel_bloco.Visible = false;
                }

            }
            else if (txt_tipo_relatorio.Text == "Encomendas")
            {
                if (txt_filtro.Text == "Código")
                {
                    panel_nome.Visible = true;
                    panel_periodo.Visible = false;
                    panel_bloco.Visible = false;
                    txt_entrada_busca.Text = "Código";
                }
                else if (txt_filtro.Text == "Bloco e Apto")
                {
                    panel_nome.Visible = false;
                    panel_periodo.Visible = false;
                    panel_bloco.Visible = true;
                }
                else if (txt_filtro.Text == "Período")
                {
                    panel_nome.Visible = false;
                    panel_periodo.Visible = true;
                    panel_bloco.Visible = false;
                }
                else
                {
                    panel_nome.Visible = false;
                    panel_periodo.Visible = false;
                    panel_bloco.Visible = false;
                }
            }
            else if (txt_tipo_relatorio.Text == "Compartimentos")
            {
                panel_nome.Visible = false;
                panel_periodo.Visible = false;
                panel_bloco.Visible = false;

            }
            else if (txt_tipo_relatorio.Text == "Manutenção")
            {
                if (txt_filtro.Text == "Compartimento")
                {
                    panel_nome.Visible = true;
                    panel_periodo.Visible = false;
                    panel_bloco.Visible = false;
                    txt_entrada_busca.Text = "Compartimento:";
                }
                else if (txt_filtro.Text == "Período")
                {
                    panel_nome.Visible = false;
                    panel_periodo.Visible = true;
                    panel_bloco.Visible = false;
                }
                if (txt_filtro.Text == "Responsável")
                {
                    panel_nome.Visible = true;
                    panel_periodo.Visible = false;
                    panel_bloco.Visible = false;
                    txt_entrada_busca.Text = "Responsável:";
                }
                else
                {
                    panel_nome.Visible = false;
                    panel_periodo.Visible = false;
                    panel_bloco.Visible = false;
                }
            }
            else if (txt_tipo_relatorio.Text == "Aberturas")
            {
                if (txt_filtro.Text == "Compartimento")
                {
                    panel_nome.Visible = true;
                    panel_periodo.Visible = false;
                    panel_bloco.Visible = false;
                    txt_entrada_busca.Text = "Compartimento:";
                }
                else if (txt_filtro.Text == "Responsável")
                {
                    panel_nome.Visible = true;
                    panel_periodo.Visible = false;
                    panel_bloco.Visible = false;
                    txt_entrada_busca.Text = "Responsável:";
                }
                else if (txt_filtro.Text == "Motivo")
                {
                    panel_nome.Visible = true;
                    panel_periodo.Visible = false;
                    panel_bloco.Visible = false;
                    txt_entrada_busca.Text = "Motivo:";
                }
                else if (txt_filtro.Text == "Período")
                {
                    panel_nome.Visible = false;
                    panel_periodo.Visible = true;
                    panel_bloco.Visible = false;
                }
            }
            else if (txt_tipo_relatorio.Text == "Auditoria")
            {

            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            try
            {
                List<Usuarios> ListUsuarios = repo.GETAllUsuarios();

                var moradores = (from n in ListUsuarios
                                 where n.Perfil == "Morador" && n.Status == string.Empty
                                 select new Usuarios
                                 {
                                     Codigo = n.id_user.ToString(),
                                     nome = n.nome,
                                     Bloco = n.Bloco,
                                     Apartamento = n.Apartamento,
                                     id_biometria = n.id_biometria,
                                     Cadastro = n.Data_cad.ToString(),
                                     Operador = n.id_login.ToString(),
                                 });


                List<Encomendas> encomendas = repo.GETAllEncomendas();

                List<Ebox> eboxes = repo.GetAllEbox();

                List<Servico> servicos = repo.GetAllServicos();

                List<LogAbertura> aberturas = repo.GetAllLogAbertura(); 

                if (txt_tipo_relatorio.Text == "Usuarios")
                {
                    if (txt_filtro.Text == "Todos")
                    {


                        //// retorna todos usuarios cadastrados perfil morador
                        //mod.sql = "select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,DATE_FORMAT(data_cad,'%d/%m/%Y') as Cadastro,id_login as Operador from tbl_usuario where perfil = 'Morador' and status = ''";
                        //Nome_relatorio = "Relatório todos os moradores ";
                        //Instrucao_Sql = mod.sql;

                        dataGridView1.DataSource = moradores;
                    }
                    else if (txt_filtro.Text == "Nome")
                    {
                        if (txt_entrada.Text == "")
                        {
                            MessageBox.Show("O DEFINA O NOME DO USUÁRIO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var ListMoradorPorNome = moradores.Select(m => m.nome.Contains(txt_entrada.Text)).SingleOrDefault();

                            //retorna todos usuarios cadastrados por nome
                            mod.sql = "select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,DATE_FORMAT(data_cad,'%d/%m/%Y') as Cadastro,id_login as Operador from tbl_usuario where(nome like '%" + txt_entrada.Text + "%') and status = '' ";

                            Nome_relatorio = "Relatório dados morador";

                            dataGridView1.DataSource = ListMoradorPorNome;
                        }
                    }
                    else if (txt_filtro.Text == "Bloco")
                    {
                        if (txt_bloco.Text == "")
                        {
                            MessageBox.Show("O DEFINA O NUMERO DO BLOCO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var ListMoradorPorBloco = moradores.Select(m => m.Bloco == txt_bloco.Text).ToList();

                            // -- retorna todos usuarios cadastrados por bloco
                            //mod.sql = "select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,DATE_FORMAT(data_cad,'%d/%m/%Y') as Cadastro,id_login as Operador from tbl_usuario where(bloco like '%" + txt_bloco.Text + "%') and status = ''";


                            Nome_relatorio = "Relatório todos moradores do bloco " + txt_bloco.Text;

                            dataGridView1.DataSource = ListMoradorPorBloco;

                        }
                    }
                    else if (txt_filtro.Text == "Bloco e Apto")
                    {
                        if ((txt_bloco.Text == "") || (txt_apto.Text == ""))
                        {
                            MessageBox.Show("O DEFINA O NUMERO DO BLOCO E APTO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var ListMoradoresBlocoApartamento = (from mor in moradores
                                                                 where mor.Bloco.Contains(txt_bloco.Text)
                                                                 && mor.Apartamento.Contains(txt_apto.Text)
                                                                 select mor).ToList();

                            //retorna todos usuarios cadastrados por bloco e Apto
                            //mod.sql = "select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,DATE_FORMAT(data_cad,'%d/%m/%Y') as Cadastro,id_login as Operador from tbl_usuario where(bloco like '%" + txt_bloco.Text + "%')and (Apto like '%" + txt_apto.Text + "%') and status = ''";

                            Nome_relatorio = "Relatório morador do bloco " + txt_bloco.Text;

                            
                            dataGridView1.DataSource = ListMoradoresBlocoApartamento;
                        }
                    }
                    else if (txt_filtro.Text == "Entregador")
                    {
                        if (txt_entrada.Text == "")
                        {
                            MessageBox.Show("O DEFINA O NOME DO ENTREGADOR. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var ListPorEntregador = repo.GetEntregadores(); 

                            // retorna todos usuarios cadastrados por nome do entregador
                           
                            //mod.sql = "select u.id_user as Codigo,u.Nome,u.Bloco,u.Apto,u.id_biometria as Biometria,DATE_FORMAT(u.data_cad,'%d/%m/%Y') as Cadastro,u.id_login as Operador from tbl_usuario u inner join tbl_login l   where l.id_login = u.id_login and (l.nome like '%" + txt_entrada.Text + "%') and status = ''";

                            Nome_relatorio = "Relatório de moradores cadastrado por " + txt_entrada.Text;

                            dataGridView1.DataSource = ListPorEntregador;
                        }
                        // -- retorna todos usuarios cadastrados perfil entregador
                        // mod.sql = "select id_user as Codigo,Nome,Perfil,funcao,empresa,id_biometria as Biometria,data_cad as Cadastro,id_login as Operador from tbl_usuario where perfil != 'Morador'";
                        // dataGridView1.DataSource = ObjDao.ListarTabela_DGV(mod); 
                    }
                    else if (txt_filtro.Text == "Período")
                    {
                        if (txt_periodo.Text == "Mensal")
                        {
                           var usuariosPorMes = repo.GETAllUsuariosPorMes("Mensal");
                           

                            //retorna todos usuarios cadastrados no ultimo mes
                            //mod.sql = "select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,DATE_FORMAT(data_cad,'%d/%m/%Y') as Cadastro,id_login as Operador from tbl_usuario " +
                            //        "where data_cad  BETWEEN CURDATE() - INTERVAL 1 month AND CURDATE()";

                            Nome_relatorio = "Relatório usuários cadastrados nos ultimos 30 dias";


                            dataGridView1.DataSource = usuariosPorMes;
                        }
                        else if (txt_periodo.Text == "Trimestral")
                        {
                           var usuariosPorTrimestre = repo.GETAllUsuariosPorMes("Trimestral");

                            //retorna todos usuarios cadastrados no ultimo 3 mes
                            mod.sql = "select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,DATE_FORMAT(data_cad,'%d/%m/%Y') as Cadastro,id_login as Operador from tbl_usuario " +
                                      "where data_cad  BETWEEN CURDATE() - INTERVAL 3 month AND CURDATE()";

                            Nome_relatorio = "Relatório usuários cadastrados nos ultimos 90 dias";


                            dataGridView1.DataSource = usuariosPorTrimestre;
                        }
                        else if (txt_periodo.Text == "Semestral")
                        {
                            var usuariosPorSemestre = repo.GETAllUsuariosPorMes("Semestral");
                            //retorna todos usuarios cadastrados no ultimo 6 mes
                            mod.sql = "select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,DATE_FORMAT(data_cad,'%d/%m/%Y') as Cadastro,id_login as Operador from tbl_usuario " +
                                      "where data_cad  BETWEEN CURDATE() - INTERVAL 6 month AND CURDATE()";

                            Nome_relatorio = "Relatório usuários cadastrados nos ultimos 6 meses";
                            ;
                            dataGridView1.DataSource = usuariosPorSemestre;
                        }
                        else if (txt_periodo.Text == "Anual")
                        {
                            var usuariosPorAno = repo.GETAllUsuariosPorMes("Anual");
                            //retorna todos usuarios cadastrados no ultimo 12 mes
                            mod.sql = "select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,DATE_FORMAT(data_cad,'%d/%m/%Y') as Cadastro,id_login as Operador from tbl_usuario " +
                                      "where data_cad  BETWEEN CURDATE() - INTERVAL 12 month AND CURDATE()";

                            Nome_relatorio = "Relatório usuários cadastrados no ultimo ano";

                            dataGridView1.DataSource = usuariosPorAno;
                        }

                    }
                    else if (txt_filtro.Text == "Quantidade")
                    {
                        var quantidade = moradores.Count();
                        //-- retorna a quantidade de moradores por bloco
                        mod.sql = "SELECT COUNT(*) AS Morador,Bloco from tbl_usuario where perfil = 'Morador' and status = ''GROUP BY Bloco ORDER BY Morador desc ";
                        dataGridView1.DataSource = quantidade;
                    }
                }
                //*******************************************************************************************************************************************************************
                else if (txt_tipo_relatorio.Text == "Encomendas")
                {

                    if (txt_filtro.Text == "Código")
                    {
                        if (txt_entrada.Text == "")
                        {
                            MessageBox.Show("O DEFINA O CÓDIGO DA ENCOMENDA. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var encomendasPorCodigo = encomendas;

                            //-- retorna encomenda por codigo 
                            mod.sql = "select e.num_encomenda as Codigo,e.id_ebox as Ebox,e.Bloco,e.Apto,DATE_FORMAT(e.Data_inclusao,'%d/%m/%Y')as Data_inclusao,e.Status_retirada,e.Nome_morador as Morador," +
                                     "DATE_FORMAT(e.data_retirada,'%d/%m/%Y') as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login and (Num_encomenda like '%" + txt_entrada.Text + "%')";

                            Nome_relatorio = "Relatório encomenda morador";
                           
                            dataGridView1.DataSource = encomendas;
                        }
                    }
                    else if (txt_filtro.Text == "Entregue")
                    {
                        var encomendasEntregues = encomendas;
                        // -- retorna encomendas entregue
                        mod.sql = "select e.num_encomenda as Codigo,e.id_ebox as Ebox,e.Bloco,e.Apto,DATE_FORMAT(e.Data_inclusao,'%d/%m/%Y')as Data_inclusao,e.Status_retirada,e.nome_morador as Morador," +
                                 "DATE_FORMAT(e.data_retirada,'%d/%m/%Y') as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login and  processo = 'Concluido'";
                        Nome_relatorio = "Relatório das encomendas entregue";
                        Instrucao_Sql = mod.sql;
                        dataGridView1.DataSource = encomendas;
                    }
                    else if (txt_filtro.Text == "Não entregue")
                    {
                        var encomendasNaoEntregues = encomendas;
                        // -- retorna encomendas entregue
                        mod.sql = "select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,DATE_FORMAT(e.Data_inclusao,'%d/%m/%Y')as Data_inclusao,e.Status_retirada,e.nome_morador as Morador," +
                                   "DATE_FORMAT(e.data_retirada,'%d/%m/%Y') as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login and  processo = 'Aberto'";
                        Nome_relatorio = "Relatório das encomendas não entregue";
                        Instrucao_Sql = mod.sql;
                        dataGridView1.DataSource = encomendasNaoEntregues;
                    }
                    else if (txt_filtro.Text == "Bloco e Apto")
                    {
                        if ((txt_bloco.Text == "") || (txt_apto.Text == ""))
                        {
                            MessageBox.Show("O DEFINA O NÚMERO BLOCO E APTO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var encomendasBlocoApartamento = encomendas;
                            //-- retorna encomenda por bloco e Apto entregue e nao entregue
                            mod.sql = "select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,DATE_FORMAT(e.Data_inclusao,'%d/%m/%Y')as Data_inclusao,e.Status_retirada,e.nome_morador as Morador," +
                                     "DATE_FORMAT(e.data_retirada,'%d/%m/%Y') as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login and(e.bloco like '%" + txt_bloco.Text + "%')and (e.Apto like '%" + txt_apto.Text + "%') ";
                            Nome_relatorio = "Relatório das encomendas do bloco " + txt_bloco.Text;
                            dataGridView1.DataSource = encomendasBlocoApartamento;
                        }
                    }
                    else if (txt_filtro.Text == "Retirada em atraso")
                    {
                        var encomendasEmAtraso = encomendas;
                        // -- retorna encomenda data retirada em atraso
                        mod.sql = "select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,DATE_FORMAT(e.Data_inclusao,'%d/%m/%Y')as Data_inclusao,e.Status_retirada,e.nome_morador as Morador," +
                                   "DATE_FORMAT(e.data_retirada,'%d/%m/%Y') as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login and curdate() > data_retirada ";

                        Nome_relatorio = "Relatório das encomendas com retirada em atraso";

                        dataGridView1.DataSource = encomendasEmAtraso;
                    }
                    else if (txt_filtro.Text == "Período")
                    {
                        if (txt_periodo.Text == "Mensal")
                        {
                            var encomendasPorPeriodoMens = encomendas;

                            // -- retorna todos encomendas registradas no ultimo mes
                            mod.sql = "select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,DATE_FORMAT(e.Data_inclusao,'%d/%m/%Y')as Data_inclusao,e.Status_retirada,e.nome_morador as Morador," +
                                        "DATE_FORMAT(e.data_retirada,'%d/%m/%Y')as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login and e.data_inclusao  BETWEEN CURDATE() - INTERVAL 1 month AND CURDATE() ";
                            Nome_relatorio = "Relatório das encomendas nos últimos 30 dias";

                            dataGridView1.DataSource = encomendasPorPeriodoMens;
                        }
                        else if (txt_periodo.Text == "Trimestral")
                        {
                            var encomendasPorPeriodoTrim = encomendas;

                            // -- retorna todos encomendas registradas no ultimo  3 mes
                            mod.sql = "select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,DATE_FORMAT(e.Data_inclusao,'%d/%m/%Y')as Data_inclusao,e.Status_retirada,e.nome_morador as Morador," +
                                          "DATE_FORMAT(e.data_retirada,'%d/%m/%Y') as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login and e.data_inclusao  BETWEEN CURDATE() - INTERVAL 3 month AND CURDATE() ";

                            Nome_relatorio = "Relatório das encomendas nos últimos 90 dias";

                            dataGridView1.DataSource = encomendasPorPeriodoTrim;
                        }
                        else if (txt_periodo.Text == "Semestral")
                        {
                            var encomendasPorPeriodoSem = encomendas;
                            // -- retorna todos encomendas registradas no ultimo 6 mes
                            mod.sql = "select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,DATE_FORMAT(e.Data_inclusao,'%d/%m/%Y')as Data_inclusao,e.Status_retirada,e.nome_morador as Morador," +
                                          "DATE_FORMAT(e.data_retirada,'%d/%m/%Y') as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login and e.data_inclusao  BETWEEN CURDATE() - INTERVAL 6 month AND CURDATE() ";

                            Nome_relatorio = "Relatório das encomendas nos últimos 6 mses";

                            dataGridView1.DataSource = encomendasPorPeriodoSem;
                        }
                        else if (txt_periodo.Text == "Anual")
                        {
                            var encomendasPorPeriodoAnual = encomendas;

                            // -- retorna todos encomendas registradas no ultimo 12 mes
                            mod.sql = "select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,DATE_FORMAT(e.Data_inclusao,'%d/%m/%Y')as Data_inclusao,e.Status_retirada,e.nome_morador as Morador," +
                                         "DATE_FORMAT(e.data_retirada,'%d/%m/%Y') as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login and e.data_inclusao  BETWEEN CURDATE() - INTERVAL 12 month AND CURDATE() ";

                            Nome_relatorio = "Relatório das encomendas no último ano";

                            dataGridView1.DataSource = encomendasPorPeriodoAnual;
                        }
                    }
                }
                //**********************************************************************************************************************************************
                else if (txt_tipo_relatorio.Text == "Compartimentos")
                {
                    if (txt_filtro.Text == "Livre")
                    {
                        var compartimentosLivres = eboxes;

                        //-- retorna a lista de compartimentos e seus status
                        mod.sql = "select id_ebox as Codigo, num_ebox as Compartimento,Tamanho,DATE_FORMAT(data_cad,'%d/%m/%Y') as Cadastro from tbl_ebox where status_ebox = 'Livre'";

                        Nome_relatorio = "Relatório dos compartimentos livres ";
                     
                        dataGridView1.DataSource = compartimentosLivres ;

                    }
                    else if (txt_filtro.Text == "Ocupado")
                    {
                        var compartimentosOcupados = eboxes;

                        //-- retorna a lista de compartimentos e seus status
                        mod.sql = "select id_ebox as Codigo, num_ebox as Compartimento,Tamanho,DATE_FORMAT(data_cad,'%d/%m/%Y') as Cadastro from tbl_ebox where status_ebox = 'Ocupado'";
                        Nome_relatorio = "Relatório dos compartimentos ocupado";
                        Instrucao_Sql = mod.sql;
                        dataGridView1.DataSource = compartimentosOcupados;
                    }
                    else if (txt_filtro.Text == "Interditado")
                    {
                        var compartimentosInterditados = eboxes;

                        //-- retorna a lista de compartimentos e seus status
                        mod.sql = "select id_ebox as Codigo, num_ebox as Compartimento,Tamanho,DATE_FORMAT(data_cad,'%d/%m/%Y') as Cadastro from tbl_ebox where status_ebox = 'Interditado'";
                        Nome_relatorio = "Relatório dos compartimentos interditado";
                        Instrucao_Sql = mod.sql;
                        dataGridView1.DataSource = compartimentosInterditados;
                    }
                    else if (txt_filtro.Text == "Ocupado Com Atraso")
                    {
                        var compartimentosOcupadosAtraso = eboxes;

                        //-- retorna a lista de compartimentos e seus status ocupado atraso
                        mod.sql = "select c.id_ebox as Codigo, c.num_ebox as Compartimento,c.Tamanho,DATE_FORMAT(c.data_cad,'%d/%m/%Y') as Cadastro from tbl_ebox c inner join tbl_entrega e  where c.id_ebox = e.id_ebox and curdate() > e.data_retirada and e.processo = 'Aberto'";

                        Nome_relatorio = "Relatório dos compartimentos ocupado com atraso";
                       
                        dataGridView1.DataSource = compartimentosOcupadosAtraso;
                    }
                    else if (txt_filtro.Text == "Mais utilizado")
                    {
                        var compartimentosMaisUtilizados = eboxes;

                        //-- retorna cmparimentos mais utilizados
                        mod.sql = "SELECT COUNT(*) AS Qtde,id_ebox from tbl_entrega GROUP BY id_ebox ORDER BY Qtde desc ";
                        Nome_relatorio = "Relatório dos compartimentos mais utilizado";
                        Instrucao_Sql = mod.sql;
                        dataGridView1.DataSource = compartimentosMaisUtilizados;
                    }
                    else if (txt_filtro.Text == "Mais interditado")
                    {
                        var compartimentosMaisInterditados = eboxes;

                        //-- retorna cmparimentos mais interditado
                        mod.sql = "SELECT COUNT(*) AS Qtde,id_ebox from tbl_servico GROUP BY id_ebox ORDER BY Qtde desc ";
                        Nome_relatorio = "Relatório dos compartimentos mais interditado";
                       
                        dataGridView1.DataSource = compartimentosMaisInterditados;
                    }
                }
                //**********************************************************************************************************************************************
                else if (txt_tipo_relatorio.Text == "Manutenção")
                {
                    if (txt_filtro.Text == "Em aberto")
                    {
                        var servicosAbertos = servicos;

                        // -- retorna  servicos em aberto
                        mod.sql = "select id_servico as Codigo,resp_abertura as Responsavel,id_ebox as Compartimento,Motivo,DATE_FORMAT(Data_ocorrencia,'%d/%m/%Y') as Data_ocorrencia," +
                        "resp_conclusao as Concluinte,Observacao,DATE_FORMAT(Data_conclusao,'%d/%m/%Y') as Data_conclusao,status_os as Status from tbl_servico where status_os = 'Aberto'";
                        Nome_relatorio = "Relatório ordem de serviços em aberto ";
                        Instrucao_Sql = mod.sql;
                        dataGridView1.DataSource = servicosAbertos;
                    }
                    else if (txt_filtro.Text == "Finalizado")
                    {
                        var servicosFinalizados = servicos;

                        //-- retorna  servicos fechado
                        mod.sql = "select id_servico as Codigo,resp_abertura as Responsavel,id_ebox as Compartimento,Motivo,DATE_FORMAT(Data_ocorrencia,'%d/%m/%Y') as Data_ocorrencia," +
                                    "resp_conclusao as Concluinte,Observacao,DATE_FORMAT(Data_conclusao,'%d/%m/%Y') as Data_conclusao,status_os as Status from tbl_servico where status_os = 'Finalizado'";
                        Nome_relatorio = "Relatório ordem de serviços finalizada";
                        Instrucao_Sql = mod.sql;
                        dataGridView1.DataSource = servicosFinalizados;
                    }
                    else if (txt_filtro.Text == "Compartimento")
                    {
                        if (txt_entrada.Text == "")
                        {
                            MessageBox.Show("O DEFINA O NUMERO DO COMPARTIMENTO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var servicosPorCompartimento = servicos;

                            //-- retorna  servicos por id
                            mod.sql = "select id_servico as Codigo,resp_abertura as Responsavel,id_ebox as Compartimento,Motivo,DATE_FORMAT(Data_ocorrencia,'%d/%m/%Y') as Data_ocorrencia," +
                           "resp_conclusao as Concluinte,Observacao,DATE_FORMAT(Data_conclusao,'%d/%m/%Y') as Data_conclusao,status_os as Status from tbl_servico where id_ebox = '" + txt_entrada.Text + "'";

                            Nome_relatorio = "Relatório ordem de serviços por compartimento";
                           
                            dataGridView1.DataSource = servicosPorCompartimento;
                        }
                    }
                    else if (txt_filtro.Text == "Responsável")
                    {
                        if (txt_entrada.Text == "")
                        {
                            MessageBox.Show("O DEFINA O NOME DO RESPONSÁVEL. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var servicoPorResponsavel = servicos;

                            //-- retorna  servicos por responsavel
                            mod.sql = "select id_servico as Codigo,resp_abertura as Responsavel,id_ebox as Compartimento,Motivo,DATE_FORMAT(Data_ocorrencia,'%d/%m/%Y') as Data_ocorrencia," +
                           "resp_conclusao as Concluinte,Observacao,DATE_FORMAT(Data_conclusao,'%d/%m/%Y') as Data_conclusao,status_os as Status from tbl_ servico where (resp_abertura like '%" + txt_entrada.Text + "%')";

                            Nome_relatorio = "Relatório ordem de serviços por responsavel";
                          
                            dataGridView1.DataSource = servicoPorResponsavel;
                        }
                    }
                    else if (txt_filtro.Text == "Período")
                    {
                        var servicosPorperiodo = servicos;

                        //-- retorna  servicos por periodo
                        mod.sql = "select id_servico as Codigo,resp_abertura as Responsavel,id_ebox as Compartimento,Motivo,DATE_FORMAT(Data_ocorrencia,'%d/%m/%Y') as Data_ocorrencia," +
                                    "resp_conclusao as Concluinte,Observacao,DATE_FORMAT(Data_conclusao,'%d/%m/%Y') as Data_conclusao,status_os as Status from tbl_ servico where data_ocorrencia  BETWEEN CURDATE() - INTERVAL 6 month AND CURDATE()";
                        Nome_relatorio = "Relatório ordem de serviços nos últimos 6 meses";
                        Instrucao_Sql = mod.sql;
                        dataGridView1.DataSource = servicosPorperiodo;
                    }
                }
                //**********************************************************************************************************************************************
                else if (txt_tipo_relatorio.Text == "Aberturas")
                {
                    if (txt_filtro.Text == "Compartimento")
                    {
                        if (txt_entrada.Text == "")
                        {
                            MessageBox.Show("O DEFINA O NUMERO DO COMPARTIMENTO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var logAbeturasEbox = aberturas;

                            mod.sql = "select a.id_log_abertura as Codigo, l.Nome as Responsavel,a.Ebox,a.Motivo,a.data_log as Data_abertura,a.hora_log as Hora from tbl_log_abertura a inner join tbl_login l where a.id_login = l.id_login and (a.Ebox like '%" + txt_entrada.Text + "%')";

                            Nome_relatorio = "Relatório de aberturas de compartimentos";
                         
                            dataGridView1.DataSource = logAbeturasEbox;
                        }
                    }
                    else if (txt_filtro.Text == "Responsável")
                    {
                        if (txt_entrada.Text == "")
                        {
                            MessageBox.Show("O DEFINA O NOME DO RESPONSÁVEL. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var logAbeturasEboxResponsavel = aberturas;

                            //-- retorna historico por responsavel
                            mod.sql = "select a.id_log_abertura as Codigo, l.Nome as Responsavel,a.Ebox,a.Motivo,a.data_log as Data_abertura,a.hora_log as Hora from tbl_log_abertura a inner join tbl_login l where a.id_login = l.id_login and (l.nome like '%" + txt_entrada.Text + "%')";
                            Nome_relatorio = "Relatório de aberturas de compartimentos";
                            Instrucao_Sql = mod.sql;
                            dataGridView1.DataSource = logAbeturasEboxResponsavel;
                        }
                    }
                    else if (txt_filtro.Text == "Motivo")
                    {
                        if (txt_entrada.Text == "")
                        {
                            MessageBox.Show("O DEFINA O MOTIVO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var logAbeturasEboxMotivo = aberturas;

                            //-- retorna historico por motivo
                            mod.sql = "select a.id_log_abertura as Codigo, l.Nome as Responsavel,a.Ebox,a.Motivo,a.data_log as Data_abertura,a.hora_log as Hora from tbl_log_abertura a inner join tbl_login l where a.id_login = l.id_login and (a.motivo like '%" + txt_entrada.Text + "%')";

                            Nome_relatorio = "Relatório de aberturas de compartimentos";
                            Instrucao_Sql = mod.sql;
                            dataGridView1.DataSource = logAbeturasEboxMotivo;
                        }
                    }
                    else if (txt_filtro.Text == "Período")
                    {
                        if (txt_periodo.Text == "Mensal")
                        {
                            var logAbeturasEboxMensal = aberturas;

                            // -- retorna historico por periodo 1 mes
                            mod.sql = "select a.id_log_abertura as Codigo, l.Nome as Responsavel,a.Ebox,a.Motivo,a.data_log as Data_abertura," +
                                    "a.hora_log as Hora from tbl_log_abertura a inner join tbl_login l where a.id_login = l.id_login and data_log BETWEEN CURDATE() - INTERVAL 1 month AND CURDATE()";
                            Nome_relatorio = "Relatório de aberturas de compartimentos";
                            Instrucao_Sql = mod.sql;
                            dataGridView1.DataSource = logAbeturasEboxMensal;
                        }
                        else if (txt_periodo.Text == "Trimestral")
                        {
                            var logAbeturasEboxTrimestral = aberturas;

                            // -- retorna historico por periodo 3 mes
                            mod.sql = "select a.id_log_abertura as Codigo, l.Nome as Responsavel,a.Ebox,a.Motivo,a.data_log as Data_abertura," +
                                    "a.hora_log as Hora from tbl_log_abertura a inner join tbl_login l where a.id_login = l.id_login and data_log BETWEEN CURDATE() - INTERVAL 3 month AND CURDATE()";
                            Nome_relatorio = "Relatório de aberturas de compartimentos";
                            Instrucao_Sql = mod.sql;
                            dataGridView1.DataSource = logAbeturasEboxTrimestral;
                        }
                        else if (txt_periodo.Text == "Semestral")
                        {
                            var logAbeturasEboxSemestral = aberturas;

                            // -- retorna historico por periodo 6 mes
                            mod.sql = "select a.id_log_abertura as Codigo, l.Nome as Responsavel,a.Ebox,a.Motivo,a.data_log as Data_abertura," +
                                    "a.hora_log as Hora from tbl_log_abertura a inner join tbl_login l where a.id_login = l.id_login and data_log BETWEEN CURDATE() - INTERVAL 6 month AND CURDATE()";
                            Nome_relatorio = "Relatório de aberturas de compartimentos";
                            Instrucao_Sql = mod.sql;
                            dataGridView1.DataSource = logAbeturasEboxSemestral;
                        }
                        else if (txt_periodo.Text == "Anual")
                        {
                            var logAbeturasEboxAnual = aberturas;

                            // -- retorna historico por periodo 12 mes
                            mod.sql = "select a.id_log_abertura as Codigo, l.Nome as Responsavel,a.Ebox,a.Motivo,a.data_log as Data_abertura," +
                                    "a.hora_log as Hora from tbl_log_abertura a inner join tbl_login l where a.id_login = l.id_login and data_log BETWEEN CURDATE() - INTERVAL 12 month AND CURDATE()";
                            Nome_relatorio = "Relatório de aberturas de compartimentos";
                            Instrucao_Sql = mod.sql;
                           dataGridView1.DataSource = logAbeturasEboxAnual;
                        }
                    }
                }
                //**********************************************************************************************************************************************
                else if (txt_tipo_relatorio.Text == "Auditoria")
                {


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA DE USUARIOS. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_gerar_Relatorio_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                if (txt_tipo_relatorio.Text == "Usuarios")
                {
                    frm_RelatorioUsuario frm = new frm_RelatorioUsuario();
                    frm.dataGridView1.DataSource = dataGridView1.DataSource;
                    frm.ShowDialog();
                }
                else if (txt_tipo_relatorio.Text == "Encomendas")
                {
                    frm_RelatorioEncomendas frm = new frm_RelatorioEncomendas();
                    frm.dataGridView1.DataSource = dataGridView1.DataSource;
                    frm.ShowDialog();
                }
                else if (txt_tipo_relatorio.Text == "Compartimentos")
                {
                    frm_RelatorioCompartimentos frm = new frm_RelatorioCompartimentos();
                    frm.dataGridView1.DataSource = dataGridView1.DataSource;
                    frm.ShowDialog();
                }
                else if (txt_tipo_relatorio.Text == "Manutenção")
                {
                    frm_RelatorioManutencao frm = new frm_RelatorioManutencao();
                    frm.dataGridView1.DataSource = dataGridView1.DataSource;
                    frm.ShowDialog();
                }
                else if (txt_tipo_relatorio.Text == "Aberturas")
                {
                    frm_RlatorioAberturas frm = new frm_RlatorioAberturas();
                    frm.dataGridView1.DataSource = dataGridView1.DataSource;
                    frm.ShowDialog();
                }
                else if (txt_tipo_relatorio.Text == "Auditoria")
                {
                    MessageBox.Show("RELATORIO EM CONSTRUÇÃO");
                }

            }
            else
            {
                MessageBox.Show("O RELATÓRIO AINDA NÃO FOI DEFINIDO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
