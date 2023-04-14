using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CATALOGOS
{
  public class cls_CCSS_DAL
    {
        #region VARIABLES PRIVADAS
        private string _sCed_Jur, _sPagina, _sDescripcion, _sMsgError;
        private int _iTelefono;
        private DataTable _dtDatos;
        private char _cOpcion;
        #endregion

        #region VARIABLES PUBLICAS
        public string sCed_Jur { get => _sCed_Jur; set => _sCed_Jur = value; }
        public string sPagina { get => _sPagina; set => _sPagina = value; }
        public string sDescripcion { get => _sDescripcion; set => _sDescripcion = value; }
        public int iTelefono { get => _iTelefono; set => _iTelefono = value; }
        public char cOpcion { get => _cOpcion; set => _cOpcion = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public string sMsgError { get => _sMsgError; set => _sMsgError = value; }
        #endregion
    }
}
