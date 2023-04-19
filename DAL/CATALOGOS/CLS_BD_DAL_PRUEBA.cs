using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL.CATALOGOS
{
    public  class CLS_BD_DAL_PRUEBA
    {

        #region VARIABLES PRIVADAS
        private SqlConnection _obj_Sqlcnx;
        private SqlDataAdapter _obj_Sqldap;
        private SqlCommand _obj_Sqlcmd;
        private DataSet _obj_ds;
        private DataTable _obj_dtParametros;
        private char _cAxn;
        private string _sNomTabla, _sNomSp, _sValorScalar, _sMsjError;



        #endregion

        #region VARIABLES PUBLICAS
        public SqlConnection obj_Sqlcnx { get => _obj_Sqlcnx; set => _obj_Sqlcnx = value; }
        public SqlDataAdapter obj_Sqldap { get => _obj_Sqldap; set => _obj_Sqldap = value; }
        public SqlCommand obj_Sqlcmd { get => _obj_Sqlcmd; set => _obj_Sqlcmd = value; }
        public DataSet obj_ds { get => _obj_ds; set => _obj_ds = value; }
        public DataTable obj_dtParametros { get => _obj_dtParametros; set => _obj_dtParametros = value; }
        public char cAxn { get => _cAxn; set => _cAxn = value; }
        public string sNomTabla { get => _sNomTabla; set => _sNomTabla = value; }
        public string sNomSp { get => _sNomSp; set => _sNomSp = value; }
        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        #endregion


    }
}
