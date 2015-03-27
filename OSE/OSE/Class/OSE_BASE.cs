using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSE.Class
{
    public class OSE_BASE
    {
        public string OSE_SOLUCAO_VERSAO { get { return " Master OSE 6.96.10 ©"; } }
        public string OSE_SOLUCAO_ARQUIVO_CONFIG_XML { get { return _GetConfFile(); } }

        #region Static
        public static string OSE_MySQL_Server { get; set; }
        public static string OSE_MySQL_Database { get; set; }
        public static string OSE_MySQL_Uid { get; set; }
        public static string OSE_MySQL_Password { get; set; }
        public static string OSE_SOLUCAO_CHAVE_VERSAO { get; set; }
        #endregion
        static string _GetConfFile()
        {
            return
                AppDomain.CurrentDomain.BaseDirectory + "\\OSE_SOLUCAO_CONFIG.XML";

        }
    }
}
