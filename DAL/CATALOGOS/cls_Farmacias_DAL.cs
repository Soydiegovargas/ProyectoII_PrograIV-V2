using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CATALOGOS
{
   public class cls_Farmacias_DAL
    {
        #region VARIABLES PRIVADAS
        private char _cAxn;
        private string _sCOD_Farmacia, _sCOD_Centro, _sNombreFarmacia, _sMedicamentos, _sMsjError;
        private DataTable _dtFarmacia;
        #endregion

        #region VARIABLES PUBLICAS
        public char cAxn { get => _cAxn; set => _cAxn = value; }
        public string sCOD_Farmacia { get => _sCOD_Farmacia; set => _sCOD_Farmacia = value; }
        public string sCOD_Centro { get => _sCOD_Centro; set => _sCOD_Centro = value; }
        public string sNombreFarmacia { get => _sNombreFarmacia; set => _sNombreFarmacia = value; }
        public string sMedicamentos { get => _sMedicamentos; set => _sMedicamentos = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtFarmacia { get => _dtFarmacia; set => _dtFarmacia = value; }



        #endregion
    }
}
