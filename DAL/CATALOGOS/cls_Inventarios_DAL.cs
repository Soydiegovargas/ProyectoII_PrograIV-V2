using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CATALOGOS
{
   public class cls_Inventarios_DAL
    {
        #region VARIABLES PRIVADAS
        private char _cAxn;
        private string _sCod_Medicina, _sMsjError;
        private DataTable _dtDatos;
        private int _iCantidad;
        private DateTime _dt_Date;
        private string _sCod_Farmacia;


        #endregion

        #region VARIABLES PUBLICAS

        public char cAxn { get => _cAxn; set => _cAxn = value; }
        public string sCod_Medicina { get => _sCod_Medicina; set => _sCod_Medicina = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public int iCantidad { get => _iCantidad; set => _iCantidad = value; }
        public DateTime date { get => _dt_Date; set => _dt_Date = value; }
        public string sCod_Farmacia { get => _sCod_Farmacia; set => _sCod_Farmacia = value; }
        public object DtDatos { get; set; }

        public DataTable dtParametros;



        #endregion
    }
}
