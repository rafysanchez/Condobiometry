using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBiometry
{
  public  class Modelo
    {
       

        /// <summary>
        private string _sql;
        private string _nome;
        private string _string_1;
        private string _string_2;
        private string _string_3;
        private string _string_4;
        private string _string_5;
        private string _id;
        private string _idlogin;
        private string _login;
        private string _senha;
        private string _port;
        /// </summary>

        public string sql
        {
            get { return _sql; }
            set { _sql = value; }
        }

        public string user_logado
        {
            get { return _idlogin; }
            set { _idlogin = value; }
        }

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
        public string port
        {
            get { return _port; }
            set { _port = value; }
        }
        public string string_1
        {
            get { return _string_1; }
            set { _string_1 = value; }
        }
        public string string_2
        {
            get { return _string_2; }
            set { _string_2 = value; }
        }
        public string string_3
        {
            get { return _string_3; }
            set { _string_3 = value; }
        }
        public string string_4
        {
            get { return _string_4; }
            set { _string_4 = value; }
        }
        public string string_5
        {
            get { return _string_5; }
            set { _string_5 = value; }
        }

        public string Apartamento { get; set; }
        public string Bloco { get;  set; }
        public string dataCad { get; set; }
        public string Perfil { get;  set; }
        public string Funcao { get;  set; }
        public string Empresa { get;  set; }
        public string Id_biometria { get;  set; }
    }
}
