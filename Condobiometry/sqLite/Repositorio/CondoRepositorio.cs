using CondoBiometry.Class;
using CondoBiometry.sqLite.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBiometry.sqLite.Repositorio
{
    public class CondoRepositorio
    {
        CondoDatabase _CondoDatabase = new CondoDatabase();

        public CondoRepositorio() { }

        public List<string> CarregaNomesLogin()
        {
            return _CondoDatabase.CarregaNomesLogin();
        }

        internal string GetUltimaPorta()
        {
            return _CondoDatabase.GetUltimaPorta();
        }

        internal void InsereLog_Conexao(string Porta, string acao)
        {
            _CondoDatabase.InsereLog_Conexao(Porta, acao);
        }

        public bool Verifica_Login(Modelo mod)
        {

            return _CondoDatabase.Verifica_Login(mod);
        }

        public List<Modelo> ListarTabela_DGV()
        {
            return _CondoDatabase.ListarTabela_DGV();
        }

        public bool InsertUsuario(Modelo mod)
        {
            return _CondoDatabase.InsertUsuario(mod);
        }

        public bool ChecacaEbox(string ebox)
        {
            return _CondoDatabase.ChecacaEbox(ebox);
        }

        public bool InsertTblLogin(Modelo mod)
        {
            return _CondoDatabase.InsertTblLogin(mod);
        }

        internal List<Modelo> PesquisarMorador(string digitado)
        {
            return _CondoDatabase.PesquisarMorador(digitado);
        }

        public string getMaxIdUsuario()
        {
            return _CondoDatabase.getMaxIdUsuario();
        }

        internal Condominio GetCondominio()
        {
            throw new NotImplementedException();
        }

        public bool UpdateUsuario(Modelo mod)
        {
            return _CondoDatabase.UpdateUsuario(mod);
        }

        public bool UpdateUsuarioStatus(Modelo mod)
        {
            return _CondoDatabase.UpdateUsuarioStatus(mod);
        }

        public bool InclusaoDadosEbox(Ebox ebox)
        {
            return _CondoDatabase.InclusaoDadosEbox(ebox);
        }

        internal List<Ebox> GetAllEbox()
        {
            return _CondoDatabase.GetAllEbox();
        }

        public bool UpdateEbox(Ebox ebox)
        {
            return _CondoDatabase.UpdateEbox(ebox);
        }

        public bool ExcluirEbox(Ebox ebox)
        {
            return _CondoDatabase.ExcluirEbox(ebox);
        }



        internal List<Ebox> GetListagemEboxAbertos()
        {
            return _CondoDatabase.GetListagemEboxAbertos();
        }

        internal List<Ebox> GetListagemEboxEntregues(string param = "")
        {
            return _CondoDatabase.GetListagemEboxEntregues(param);
        }

        internal List<Ebox> GetListagemEncomendasByCodigo(string param = "")
        {
            return _CondoDatabase.GetListagemEncomendasByCodigo(param);
        }

        public Login GetLoginDataByPass(Login login)
        {
            return _CondoDatabase.GetLoginDataByPass(login);
        }

        internal Login GetLoginByBiometry(Login login)
        {
            return _CondoDatabase.GetLoginByBiometry(login);
        }

        public Modelo GetMorador(Modelo mod)
        {
            return _CondoDatabase.GetMorador(mod);
        }

        public List<Ebox> GetCaixasPequenas()
        {
            return _CondoDatabase.GetCaixasBySize("Pequena");
        }

        internal List<Entrega> GetAllEntregas()
        {
            return _CondoDatabase.GetAllEntregas();
        }

        public List<Ebox> GetCaixasMedias()
        {
            return _CondoDatabase.GetCaixasBySize("Media");
        }

        public List<Ebox> GetCaixasGrandes()
        {
            return _CondoDatabase.GetCaixasBySize("Grande");
        }

        internal Condominio GetMaxCondominioById()
        {
            return _CondoDatabase.GetMaxCondominioById();
        }

        public Entrega InsertTblEntrega(Entrega entrega)
        {
            return _CondoDatabase.InsertTblEntrega(entrega);
        }

        internal bool InserLogAbertura(LogAbertura logabertura)
        {
            return _CondoDatabase.InserLogAbertura(logabertura);
        }

        public bool InsertServico(Servico servico)
        {
            return _CondoDatabase.InsertServico(servico);
        }

        internal bool InsertLogConexao(LogConexao logconexao)
        {
            return _CondoDatabase.InsertLogConexao(logconexao);
        }

        internal bool UpdateEboxStatus(Ebox ebox)
        {
            return _CondoDatabase.UpdateEboxStatus(ebox);
        }

        internal object UpdateServicoConclusao(Servico serv)
        {
            throw new NotImplementedException();
        }

        public List<Servico> GetAllServicos()
        {
            return _CondoDatabase.GetAllServicos();
        }

        internal List<LogAbertura> GetAllLogAbertura()
        {
            return _CondoDatabase.GetAllLogAbertura();
        }

        internal List<BackupRestore> GetAllBackupRestore()
        {
            return _CondoDatabase.GetAllBackupRestore();
        }

        internal object InsertBackUpRestore(BackupRestore backupRestore)
        {
            return _CondoDatabase.InsertBackUpRestore(backupRestore);
        }

        internal List<Usuarios> GETAllUsuarios()
        {
            return _CondoDatabase.GETAllUsuarios();
        }

        internal object GetEntregadores()
        {
            return _CondoDatabase.GetEntregadores();
        }

        internal List<Usuarios> GETAllUsuariosPorMes(string v)
        {
            return _CondoDatabase.GETAllUsuariosPorMes(v);
        }

        internal List<Encomendas> GETAllEncomendas()
        {
            return _CondoDatabase.GETAllEncomendas();
        }

    }

}
