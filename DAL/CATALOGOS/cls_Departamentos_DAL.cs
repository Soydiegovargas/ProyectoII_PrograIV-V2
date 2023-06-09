﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace DAL.CATALOGOS
{
    public class cls_Departamentos_DAL
    {
        public object sCod_Medicina;
        #region VARIABLES PRIVADAS
        private char _cAxn;
        private string _sEspecialidad, _sMsjError, _sTelefono, _sCodCentro, _sCodArea;
        private int _iCodArea, _iTelef;
        private DataTable _dtDatos, _dtParametros;
        #endregion

        #region VARIABLES PUBLICAS
        public char cAxn { get => _cAxn; set => _cAxn = value; }
        public string sEspecialidad { get => _sEspecialidad; set => _sEspecialidad = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public string sTelefono { get => _sTelefono; set => _sTelefono = value; }
        public int iCodArea { get => _iCodArea; set => _iCodArea = value; }
        public string sCodCentro { get => _sCodCentro; set => _sCodCentro = value; }
        public string sCodArea { get => _sCodArea; set => _sCodArea = value; }
        public int iTelef { get => _iTelef; set => _iTelef = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }

        #endregion

    }
}
