using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CATALOGOS
{
    public class cls_Pedidos_DAL
    {
        #region VARIABLES PRIVADAS

        private char _cAxn;
        private string _scodfarmacia, _scodpedido, _sMedicamnetos, _sMsjError;
        private DataTable _dtDatos, _dtparametros;
        #endregion

        #region VARIABLES PUBLICAS
        public char cAxn { get => _cAxn; set => _cAxn = value; }
        public string scodfarmacia { get => _scodfarmacia; set => _scodfarmacia = value; }
        public string scodpedido { get => _scodpedido; set => _scodpedido = value; }
        public string sMedicamnetos { get => _sMedicamnetos; set => _sMedicamnetos = value; }
        public DataTable dtDatos { get => DtDatos; set => DtDatos = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtparametros { get => _dtparametros; set => _dtparametros = value; }
        #endregion
    }
}
