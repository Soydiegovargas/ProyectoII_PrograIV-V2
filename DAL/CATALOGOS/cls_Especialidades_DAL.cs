using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CATALOGOS
{
    public class cls_Especialidades_DAL
    {
        #region VARIABLES PRIVADAS
        private char _cAxn;
        private string _scedempleado, _sespecialidad, _sdepartamento, _sMsjError;
        private DataTable _dtDatos, _dtParametros;
        #endregion
        
        #region VARIABLES PUBLICAS
        public char cAxn { get => _cAxn; set => _cAxn = value; }
        public string scedempleado { get => _scedempleado; set => _scedempleado = value; }
        public string sespecialidad { get => _sespecialidad; set => _sespecialidad = value; }
        public string sdepartamento { get => _sdepartamento; set => _sdepartamento = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        #endregion
    }
}
