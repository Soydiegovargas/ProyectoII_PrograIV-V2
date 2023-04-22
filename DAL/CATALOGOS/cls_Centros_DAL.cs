using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DAL.CATALOGOS
{
    public class cls_Centros_DAL
    {

        #region VARIABLES PRIVADAS
        private char _cAxn;
        private string _sNombreC, _sDirrecionC, _sMsjError, _sCodJunta, _sCedJur, _sCodCentro, _sDescripcion;
        private DataTable _dtDatos, _dtParametros;
        #endregion

        #region VARIABLES PUBLICAS
        public char cAxn { get => _cAxn; set => _cAxn = value; }
        public string sNombreC { get => _sNombreC; set => _sNombreC = value; }
        public string sDirrecionC { get => _sDirrecionC; set => _sDirrecionC = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public string sCodJunta { get => _sCodJunta; set => _sCodJunta = value; }
        public string sCedJur { get => _sCedJur; set => _sCedJur = value; }
        public string sCodCentro { get => _sCodCentro; set => _sCodCentro = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string sDescripcion { get => _sDescripcion; set => _sDescripcion = value; }
        #endregion
    }
}
