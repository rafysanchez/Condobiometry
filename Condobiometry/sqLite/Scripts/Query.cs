using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CondoBiometry.Class;

namespace CondoBiometry.sqLite.Scripts
{
    public class Query
    {
        private static Query _instance;
        public static Query Instance { get { if (_instance == null) _instance = new Query(); return _instance; } }

        public string CarregaNomesLogin()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select nome from tbl_login where perfil = 'Administrador';");

            return sb.ToString();
        }

        public string GetUltimaPorta()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Select port_conection from tbl_log_conexao where id_log = (select max(id_log) from tbl_log_conexao);");
            return sb.ToString();
        }

        public string InsereLog_Conexao(string Porta, string acao)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO tbl_log_conexao(port_conection,log_acao,data_log,hora_log) VALUES ('" + Porta + "','" + acao + "',current_date,current_time");

            return sb.ToString();


        }

        public string Verifica_Login(Modelo mod)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM tbl_login WHERE nome = '" + mod.nome + "' AND senha = '" + mod.senha + "' and perfil = 'Administrador' ");

            return sb.ToString();
        }

        internal string InsertTblLogin(Modelo mod)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Insert into tbl_login(nome,perfil,funcao,empresa,senha,id_biometria,data_cad) values('");

            sb.Append(mod.nome + "','");
            sb.Append(mod.Perfil + "','");
            sb.Append(mod.Funcao + "','");
            sb.Append(mod.Apartamento + "','");
            sb.Append(mod.Empresa + "','");
            sb.Append(mod.senha + "','");
            sb.Append(mod.Id_biometria + "','");
            sb.Append("current_date','");


            return sb.ToString();
        }

        public string ChecacaEbox(string ebox)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("select id_ebox, num_ebox, tamanho from tbl_ebox where num_ebox = '" + ebox + "'");

            return sb.ToString();
        }

        public string InclusaoDadosEbox(Ebox ebox)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Insert into tbl_ebox(id_login,num_ebox,tamanho,status_ebox,data_cad)" +
                               " values ( '" + ebox.id_login + "','" + ebox.num_ebox + "','" + ebox.tamanho + "','" + ebox.status_ebox + "',current_date)");
            return sb.ToString();
        }

        public string InsertUsuario(Modelo mod)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Insert into tbl_usuario id_login,nome,perfil,apto,bloco,funcao,empresa,senha,id_biometria,data_cad) values('");
            sb.Append(mod.user_logado + "','");
            sb.Append(mod.nome + "','");
            sb.Append(mod.Perfil + "','");
            sb.Append(mod.Apartamento + "','");
            sb.Append(mod.Bloco + "','");
            sb.Append(mod.Funcao + "','");
            sb.Append(mod.Empresa + "','");
            sb.Append(mod.senha + "','");
            sb.Append(mod.Id_biometria + "','");
            sb.Append("current_date','");


            return sb.ToString();
        }

        internal string GetListagemEboxEntregues(string param = "")
        {
            StringBuilder sb = new StringBuilder();
            if (param == "")
            {
                sb.Append("select e.id_entrega as Codigo, u.nome as Entregador, e.id_ebox as Compart, e.num_encomenda, e.bloco, e.apto, e.data_inclusao, e.data_retirada, nome_morador, e.status_retirada  from tbl_entrega e inner join tbl_login u where e.processo = 'Concluido' and e.id_login = u.id_login");
            }
            else
            {
                sb.Append("select e.id_entrega as Codigo,u.nome as Entregador,e.id_ebox as Compart,e.num_encomenda,e.bloco, e.apto,e.data_inclusao,e.status_retirada,e.data_retirada,e.nome_morador from tbl_entrega e inner join tbl_login u                                  where  e.processo = 'Concluido'and e.id_login = u.id_login and (e.num_encomenda like '%" + param + "%')");
            }

            return sb.ToString();
        }

        internal string GetMorador(Modelo mod)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("select Nome, bloco, apto from tbl_usuario where bloco ='" + mod.Bloco + "' and apto ='" + mod.Apartamento + "'and status = '' ");

            return sb.ToString();
        }

        internal string InsertTblEntrega(Entrega entrega)
        {
            //mod.sql = "insert into tbl_entrega(id_login,id_ebox,num_encomenda,apto,bloco,data_inclusao,data_retirada,id_morador,nome_morador)" +
            //         "values('" + id_login + "','" + id_ebox + "','" + txt_codigo.Text + "','" + txt_apartamento.Text + "','" + txt_bloco.Text + "',current_date,'" + data_retirada + "',0,0)";

            StringBuilder sb = new StringBuilder();
            sb.Append("insert into tbl_entrega(id_login, id_ebox, num_encomenda, apto, bloco, data_inclusao, data_retirada, id_morador, nome_morador) values('" + entrega.id_login + "','" + entrega.id_ebox + "','" + entrega.num_encomenda + "','" + entrega.Apartamento + "','" + entrega.Bloco + "',current_date,'" + entrega.data_retirada + "',0,0)");
            return sb.ToString();
        }

        internal string GetCaixasBySize(string v)
        {
            StringBuilder sb = new StringBuilder();
            if (v == "Pequena")
            {
                sb.Append("select  id_ebox from tbl_ebox where tamanho = 'pequeno' and status_ebox = 'Livre'");
            }
            else if (v == "Media")
            {
                sb.Append("select count(num_ebox) from tbl_ebox where tamanho = 'Medio' and status_ebox = 'Livre'");
            }
            else
            {
                sb.Append("select count(num_ebox) from tbl_ebox where tamanho = 'Grande' and status_ebox = 'Livre'");
            }

            return sb.ToString();
        }

        internal string GetLoginDataByPass(Login mod)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Select id_login,nome,perfil from tbl_login where senha = '" + mod.senha + "' and perfil != 'Morador' ");

            return sb.ToString();
        }

        public string GetLoginByBiometry(Login _login)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Select id_login, nome, perfil, id_biometria from tbl_login where id_biometria = '" + _login.id_biometria + "' and perfil != 'Morador' ");

            return sb.ToString();
        }

        public string GetListagemEncomendasByCodigo(string param)
        {
            StringBuilder sb = new StringBuilder();

            if (param == "")
            {
                sb.Append("select e.id_entrega as Codigo, u.nome as Entregador, e.id_ebox as Compart, e.num_encomenda, e.bloco, e.apto, e.data_inclusao,                       e.status_retirada from tbl_entrega e inner join tbl_login u where e.id_login = u.id_login )");
            }
            else
            {
                sb.Append("select e.id_entrega as Codigo,u.nome as Entregador,e.id_ebox as Compart,e.num_encomenda,e.bloco,e.apto,e.data_inclusao,                     e.status_retirada from tbl_entrega e inner join tbl_login u where e.id_login = u.id_login and (e.num_encomenda like '%" + param + "%')");
            }

            return sb.ToString();

        }

        public string GetListagemEboxAbertos(string param = "")
        {
            StringBuilder sb = new StringBuilder();

            if (param == "")
            {
                sb.Append("select e.id_entrega as Codigo, u.nome as Entregador, e.id_ebox as Compart, e.num_encomenda, e.bloco, e.apto, e.data_inclusao, e.status_retirada                           from tbl_entrega e inner join tbl_login u where  e.processo = 'Aberto' and e.id_login = u.id_login ");
            }
            else
            {
                sb.Append("select e.id_entrega as Codigo,u.nome as Entregador,e.id_ebox as Compart,e.num_encomenda,e.bloco,e.apto,e.data_inclusao,                  e.status_retirada from tbl_entrega e inner join tbl_login u where  e.processo = 'Aberto'and e.id_login = u.id_login and (e.num_encomenda like '%" + param + "%')");
            }



            return sb.ToString();
        }

        public string ExcluirEbox(Ebox ebox)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Update tbl_ebox set num_ebox = '" + ebox.num_ebox + "',tamanho = '"
                + ebox.tamanho + "',status_ebox = 'D' where id_ebox = '" + ebox.id_ebox + "' ");

            return sb.ToString();
        }

        internal string UpdateEbox(Ebox ebox)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Update tbl_ebox set num_ebox = '" + ebox.num_ebox + "', tamanho = '" + ebox.tamanho + "', status_ebox = '" + ebox.status_ebox
                     + "' where id_ebox = '" + ebox.id_ebox + "' ");

            return sb.ToString();

        }

        internal string GetAllEbox()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("select id_ebox as Codigo, num_ebox as Ebox, Tamanho, status_ebox, data_cad from tbl_ebox");

            return sb.ToString();
        }

        internal string PesquisarMorador(string digitado)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("select id_user as Codigo, Nome, apto as Apartamento,Bloco,data_cad from tbl_usuario where perfil = 'Morador'");

            sb.Append(" and nome like %" + digitado + "%') and status = '' ");

            return sb.ToString();
        }

        public string ListarTabela_DGV()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("select id_user as Codigo,Nome,apto as Apartamento,Bloco,senha,id_biometria,data_cad  from tbl_usuario where perfil = 'Morador'and  (nome like '%");

            return sb.ToString();
        }

        internal string UpdateUsuarioStatus(Modelo mod)
        {

            StringBuilder sb = new StringBuilder();

            sb.Append("Update tbl_usuario set status = 'D' WHERE id_user = '" + mod.id + "' ");

            return sb.ToString();

        }

        internal string UpdateUsuario(Modelo mod)
        {

            StringBuilder sb = new StringBuilder();

            sb.Append("Update tbl_usuario set nome = '" + mod.nome + "'," +
                " apto = '" + mod.Apartamento + "'" +
                ", bloco = '" + mod.Bloco + "', senha = '" + mod.senha + "',id_biometria = '" + mod.Id_biometria
                + "' WHERE id_user = '" + mod.id + "' ");

            return sb.ToString();

        }

        public string getMaxIdUsuario()
        {

            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT MAX(id_user) + 1 FROM tbl_usuario");

            return sb.ToString();

        }

        public string GetMaxCondominioById()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT * FROM tbl_condominio WHERE id_condo =(select max(id_condo) from tbl_condominio)");

            return sb.ToString();
        }


    }
}
