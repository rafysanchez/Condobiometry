using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using SOW.Foundation.Database.SQLLITE;
using CondoBiometry.Class;
using CondoBiometry.sqLite.Scripts;

namespace CondoBiometry.sqLite.Database
{

    public class CondoDatabase : AbstractSQLLiteDataBase
    {
       // string ConnectionString = ConfigurationManager.ConnectionStrings["SQLLite"].ToString();
        // string ConnectionString = ConfigurationManager.ConnectionStrings["SQLLiteProd"].ToString();

        string ConnectionString =  string.Format(@"Data Source = {0}\{1}\{2}", System.Environment.CurrentDirectory, "Data", "condo_biometry.db");

        internal string GetUltimaPorta()
        {

            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.GetUltimaPorta()))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            return dr["port_conection"].ToString();
                        }
                    }
                }
            }
            return string.Empty;
        }

        public bool ChecacaEbox(string ebox)
        {
            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.ChecacaEbox(ebox)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool InclusaoDadosEbox(Ebox ebox)
        {
            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.InclusaoDadosEbox(ebox)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public List<Ebox> GetListagemEboxEntregues(string param)
        {
            this.setConnection(ConnectionString);

            List<Ebox> lista = new List<Ebox>();

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.GetListagemEboxEntregues(param)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            lista.Add(FillEboxEntregues(dr));
                        }
                    }
                }
            }
            return lista;
        }

        public Modelo GetMorador(Modelo mod)
        {
            this.setConnection(ConnectionString);

            Modelo mode = new Modelo();

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.GetMorador(mod)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        mode.user_logado = dr["user_logado"].ToString();
                        mode.nome = dr["nome"].ToString();
                        mode.Perfil = dr["perfil"].ToString();
                    }
                }
            }
            return mode;
        }

        internal List<Entrega> GetAllEntregas()
        {
            throw new NotImplementedException();
        }

        internal Entrega InsertTblEntrega(Entrega entrega)
        {
            Entrega ent = new Entrega();
            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.InsertTblEntrega(entrega)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        return ent;
                    }
                }
            }
            return ent;
        }

        internal bool UpdateEboxStatus(Ebox ebox)
        {
            throw new NotImplementedException();
        }

        internal List<BackupRestore> GetAllBackupRestore()
        {
            throw new NotImplementedException();
        }

        public List<LogAbertura> GetAllLogAbertura()
        {
            throw new NotImplementedException();
        }

        internal List<Servico> GetAllServicos()
        {
            throw new NotImplementedException();
        }

        internal object InsertBackUpRestore(BackupRestore backupRestore)
        {
            throw new NotImplementedException();
        }

        internal Condominio GetMaxCondominioById()
        {
            this.setConnection(ConnectionString);

            Condominio condo = new Condominio();

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.GetMaxCondominioById()))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        condo.rua = dr["rua"].ToString();
                        condo.numero = dr["numero"].ToString();
                        condo.cidade = dr["cidade"].ToString();
                        condo.estado = dr["estado"].ToString();
                    }
                }
            }
            return condo;
        }

        internal List<Usuarios> GETAllUsuarios()
        {
            throw new NotImplementedException();
        }

        internal object GetEntregadores()
        {
            throw new NotImplementedException();
        }

        internal List<Usuarios> GETAllUsuariosPorMes(string v)
        {
            throw new NotImplementedException();
        }

        internal List<Encomendas> GETAllEncomendas()
        {
            throw new NotImplementedException();
        }

        internal List<Ebox> GetCaixasBySize(string valor)
        {
            this.setConnection(ConnectionString);

            List<Ebox> lista = new List<Ebox>();

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.GetCaixasBySize(valor)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            lista.Add(FillEboxEntregues(dr));
                        }
                    }
                }
            }
            return lista;
        }
        public Ebox FillEboxEntregues(SQLiteDataReader sr)
        {
            Ebox ebox = new Ebox();
            ebox.id_ebox = sr["Codigo"].ToString();
            ebox.num_ebox = sr["Ebox"].ToString().ToUpper();
            ebox.tamanho = sr["Tamanho"].ToString().ToUpper();
            ebox.status_ebox = sr["status_ebox"].ToString().ToUpper();
            ebox.data_cad = sr["data_cad"].ToString();
            return ebox;
        }

        internal Login GetLoginByBiometry(Login logi)
        {
            this.setConnection(ConnectionString);

            Login _login = new Login();

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.GetLoginByBiometry(logi)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        _login.id_login = dr["id_login"].ToString();
                        _login.nome = dr["nome"].ToString();
                        _login.perfil = dr["perfil"].ToString();
                    }
                }
            }
            return _login;
        }

        public Login GetLoginDataByPass(Login mod)
        {
            this.setConnection(ConnectionString);

            Login _login = new Login();

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.GetLoginDataByPass(mod)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        _login.id_login =dr["id_login"].ToString();
                        _login.nome = dr["nome"].ToString();
                        _login.perfil = dr["perfil"].ToString();
                    }
                }
            }
            return _login;
        }

        public Login FillLogin(SQLiteDataReader sr)
        {
            Login _login = new Login();
            _login.id_login = sr["id_login"].ToString();
            _login.nome = sr["nome"].ToString().ToUpper();
            _login.perfil = sr["perfil"].ToString().ToUpper();

            return _login;
        }

        internal List<Ebox> GetListagemEncomendasByCodigo(string param)
        {
            this.setConnection(ConnectionString);

            List<Ebox> lista = new List<Ebox>();

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.GetListagemEncomendasByCodigo(param)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            lista.Add(FillEboxEntregues(dr));
                        }
                    }
                }
            }
            return lista;
        }

        public List<Ebox> GetListagemEboxAbertos(string param = "")
        {
            this.setConnection(ConnectionString);

            List<Ebox> lista = new List<Ebox>();

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.GetListagemEboxAbertos(param)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            lista.Add(FillEboxEntregues(dr));
                        }
                    }
                }
            }
            return lista;
        }





        public bool ExcluirEbox(Ebox ebox)
        {
            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.ExcluirEbox(ebox)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        internal bool UpdateEbox(Ebox ebox)
        {
            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.UpdateEbox(ebox)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        internal List<Ebox> GetAllEbox()
        {
            List<Ebox> ret = new List<Ebox>();

            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.GetAllEbox()))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ret.Add(FillEbox(dr));
                        }
                    }
                }
            }
            return ret;
        }
        public Ebox FillEbox(SQLiteDataReader sr)
        {
            Ebox ebox = new Ebox();
            ebox.id_ebox = sr["Codigo"].ToString();
            ebox.num_ebox = sr["Ebox"].ToString().ToUpper();
            ebox.tamanho = sr["Tamanho"].ToString().ToUpper();
            ebox.status_ebox = sr["status_ebox"].ToString().ToUpper();
            ebox.data_cad = sr["data_cad"].ToString();
            return ebox;
        }

        public bool InsertTblLogin(Modelo mod)
        {
            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.InsertTblLogin(mod)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        return true;
                    }
                }
            }
            return false;
        }



        public List<Modelo> PesquisarMorador(string digitado)
        {
            List<Modelo> ret = new List<Modelo>();

            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.PesquisarMorador(digitado)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ret.Add(FillMoradores(dr));
                        }
                    }
                }
            }
            return ret;
        }

        public bool InsertUsuario(Modelo mod)
        {
            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.InsertUsuario(mod)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public List<Modelo> ListarTabela_DGV()
        {
            List<Modelo> ret = new List<Modelo>();

            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.ListarTabela_DGV()))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ret.Add(FillMoradores(dr));
                        }
                    }
                }
            }
            return ret;
        }

        public Modelo FillMoradores(SQLiteDataReader sr)
        {
            Modelo modelo = new Modelo();
            modelo.id = sr["Codigo"].ToString();
            modelo.nome = sr["Nome"].ToString().ToUpper();
            modelo.Apartamento = sr["Apartamento"].ToString().ToUpper();
            modelo.Bloco = sr["Bloco"].ToString().ToUpper();
            modelo.dataCad = sr["data_cad"].ToString();
            return modelo;
        }

        public bool Verifica_Login(Modelo mod)
        {

            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.Verifica_Login(mod)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void InsereLog_Conexao(string Porta, string acao)
        {
            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.InsereLog_Conexao(Porta, acao)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);


                }
            }
        }




        public List<string> CarregaNomesLogin()
        {
            List<string> ret = new List<string>();

            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.CarregaNomesLogin()))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ret.Add(FillNome(dr));
                        }
                    }
                }
            }
            return ret;
        }
        public string FillNome(SQLiteDataReader sr)
        {
            string nome = string.Empty;
            nome = sr["nome"].ToString();
            return nome;
        }

        public string getMaxIdUsuario()
        {

            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.getMaxIdUsuario()))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        return dr[0].ToString();
                    }
                }
            }
            return string.Empty;
        }

        internal bool UpdateUsuarioStatus(Modelo mod)
        {


            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.UpdateUsuarioStatus(mod)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        internal bool UpdateUsuario(Modelo mod)
        {
            this.setConnection(ConnectionString);

            using (var conn = GetConnection())
            {
                conn.Open();

                using (var comm = CreateCommandQuery(Query.Instance.UpdateUsuario(mod)))
                {
                    comm.Connection = conn;

                    var dr = comm.ExecuteReader(System.Data.CommandBehavior.Default);

                    if (dr.HasRows)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        internal bool InsertServico(Servico servico)
        {
            throw new NotImplementedException();
        }

        internal bool InserLogAbertura(LogAbertura logabertura)
        {
            throw new NotImplementedException();
        }

        internal bool InsertLogConexao(LogConexao logconexao)
        {
            throw new NotImplementedException();
        }
    }

}