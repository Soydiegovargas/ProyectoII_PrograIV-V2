using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CATALOGOS
{
    public class cls_Contratas_DAL
    {

        #region VARIABLES PRIVADAS

        private char _cAxn;
        private string _sNombreCon, _sTelefono, _sMsjError, _sDireccion, _sCodJunta, _sCedula;
        private DataTable _dtDatos;
        #endregion

        #region VARIABLES PUBLICAS
        public char cAxn { get => _cAxn; set => _cAxn = value; }
        public string sNombreCon { get => _sNombreCon; set => _sNombreCon = value; }
        public string sTelefono { get => _sTelefono; set => _sTelefono = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public string sCedula { get => _sCedula; set => _sCedula = value; }
        public string sCodJunta { get => _sCodJunta; set => _sCodJunta = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public string sDireccion { get => _sDireccion; set => _sDireccion = value; }
        #endregion

    }
}
