using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CATALOGOS
{
    public class cls_Empleados_DAL
    {
        #region VARIABLES PRIVADAS
        private string _sCed_Empleado, _sNombre, _sDireccion, _sCod_Junta, _sMsjError;
        private int _iTelefono;
        private DataTable _dtDatos, _dtParametros;
        private char _cOpcion;
        #endregion

        #region VARIABLES PUBLICAS
        public string sCed_Empleado { get => _sCed_Empleado; set => _sCed_Empleado = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sDireccion { get => _sDireccion; set => _sDireccion = value; }
        public string sCod_Junta { get => _sCod_Junta; set => _sCod_Junta = value; }
        public int iTelefono { get => _iTelefono; set => _iTelefono = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public char cOpcion { get => _cOpcion; set => _cOpcion = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        #endregion
    }
}
