using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CATALOGOS
{
    public class cls_Asegurados_DAL
    {
        #region VARIABLES PRIVADAS
        private char _cAxn;
        private string _sCedAsegurado, _sNombre, _sMsjError, _sTelefono, _sDireccion;
        private string _sCodCentro;
        private DataTable _dtDatos, _dtParametros;
        #endregion

        #region VARIABLES PUBLICAS
        public char cAxn { get => _cAxn; set => _cAxn = value; }
        public string sCedAsegurado { get => _sCedAsegurado; set => _sCedAsegurado = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public string sTelefono { get => _sTelefono; set => _sTelefono = value; }
        public string sDireccion { get => _sDireccion; set => _sDireccion = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        
        public string sCodCentro { get => _sCodCentro; set => _sCodCentro = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        #endregion




    }
}
