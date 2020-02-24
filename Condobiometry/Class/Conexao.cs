using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBiometry
{
    class Conexao
    {

        private String StrConection; //armazena a string de conexao
        private MySqlConnection ObjConn;

        public Conexao(String DadosConexao)               //metodo construtor
        {
            ////           instancia o dado privado conexao
            //this.StrConection = DadosConexao;                //define a string de conexao
            //this.ObjConn.ConnectionString = DadosConexao;     //define qual string o camino do BD vai ser urilizada
        }

        //metodos construtores
        public String _StrConection
        {
            get { return this._StrConection; }
            set { this._StrConection = value; }
        }

        public MySqlConnection Conection
        {
            get { return this.ObjConn; }
            set { this.ObjConn = value; }
        }

        //funcao para abrir conexao
        public void Abrir()
        {
            try
            {
                this.ObjConn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi possivel se conectar base de dados" + "ERROS DE COMANDOS:" + ex.Message);
            }
            finally
            {
            }
        }

        //funcao para fechar conexao
        public void Fechar()
        {
            try
            {
                this.ObjConn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi possivel se conectar base de dados" + "ERROS DE COMANDOS:" + ex.Message);
            }
            finally
            {
            }
        }
    }
}
