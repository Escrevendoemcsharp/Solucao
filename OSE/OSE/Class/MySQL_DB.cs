using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace OSE.Class
{   
    /// <summary>
    /// MySQL_DB Rafael Fernandes
    /// </summary>
    public partial class MySQL_DB
    { 
        
        public bool Testar_Conexao_MySQL()
        {
            CConexao = new MySqlConnection(_Conexao_String_MySQL);
            try
            {
                CConexao.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            if (CConexao.State == System.Data.ConnectionState.Open) { return true; }
            else
            {
                return false;
            }
        }
        #region DECLARE
        private string _Conexao_String_MySQL 
        {
            get
            { return
                "SERVER=" + OSE_BASE.OSE_MySQL_Server +
                ";DATABASE=" + OSE_BASE.OSE_MySQL_Database +
                ";UID=" + OSE_BASE.OSE_MySQL_Uid +
                ";PASSWORD=" +  OSE_BASE.OSE_MySQL_Password + ";";
            }
        }
        private MySqlConnection CConexao;

        #endregion
    }
}
