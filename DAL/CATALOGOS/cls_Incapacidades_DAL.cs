using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CATALOGOS
{
    public class cls_Incapacidades_DAL
    {
        public object dtParametros;
        #region VARIABLES PRIVADAS
        private char _cAxn;
        private string _sCOD_Area, _sNum_Incap, _sNombre, _sMotivo, _sMsjError;
        private int _iDias;
        private DataTable _dtDatos, _dtParametros;
        #endregion

        #region VARIABLES PUBLICAS
        public char cAxn { get => _cAxn; set => _cAxn = value; }
        public string sCOD_Area { get => _sCOD_Area; set => _sCOD_Area = value; }
        public string sNum_Incap { get => _sNum_Incap; set => _sNum_Incap = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sMotivo { get => _sMotivo; set => _sMotivo = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public int iDias { get => _iDias; set => _iDias = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        #endregion
    }
}
