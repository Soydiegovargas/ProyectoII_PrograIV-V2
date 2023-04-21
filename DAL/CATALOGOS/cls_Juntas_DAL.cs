using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CATALOGOS
{
    public class cls_Juntas_DAL
    {

        #region VARIABLES PRIVADAS
        private char _cAxn;
        private string _sCod_Junta, _sCod_Centro, _sNombre, _sMsjError;
        private DataTable _dtDatos, _dtparametros;
        private int _iTelefono;
        #endregion

        #region VARIABLES PUBLICAS
        public char cAxn { get => _cAxn; set => _cAxn = value; }
        public string sCod_Junta { get => _sCod_Junta; set => _sCod_Junta = value; }
        public string sCod_Centro { get => _sCod_Centro; set => _sCod_Centro = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public int iTelefono { get => _iTelefono; set => _iTelefono = value; }
        public DataTable dtparametros { get => _dtparametros; set => _dtparametros = value; }

        #endregion
    }
}
