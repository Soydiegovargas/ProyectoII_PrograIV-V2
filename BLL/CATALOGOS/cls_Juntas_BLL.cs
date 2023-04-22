using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CATALOGOS;
using BLL.WCF;
using System.Configuration;

namespace BLL.CATALOGOS
{
    public class cls_Juntas_BLL
    {



        public void Listar_Filtrar_Juntas(ref cls_Juntas_DAL Obj_Juntas_DAL)
        {


            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Juntas_DAL.sNombre == string.Empty)
            {
                Obj_Juntas_DAL.dtparametros = null;
                Obj_Juntas_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_JUNTAS", ConfigurationManager.AppSettings["listar_Juntas"], null);
            }
            else
            {
                Obj_Juntas_DAL.dtparametros = Obj_WCF.Get_DT_Param(Obj_Juntas_DAL.dtparametros);
                Obj_Juntas_DAL.dtparametros.Rows.Add("@Filtro", "7", Obj_Juntas_DAL.sNombre);
                Obj_Juntas_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_JUNTAS", ConfigurationManager.AppSettings["filtrar_Juntas"], Obj_Juntas_DAL.dtparametros);
            }


        }

        public void insertar_Juntas(ref cls_Juntas_DAL Obj_Juntas_DAL)
        {

            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Juntas_DAL.dtparametros = Obj_WCF.Get_DT_Param(Obj_Juntas_DAL.dtparametros);

            Obj_Juntas_DAL.dtparametros.Rows.Add("@COD_JUNTA", "7", Obj_Juntas_DAL.sCod_Junta);
            Obj_Juntas_DAL.dtparametros.Rows.Add("@COD_CENTRO", "7", Obj_Juntas_DAL.sCod_Centro);
            Obj_Juntas_DAL.dtparametros.Rows.Add("@NOMBRE", "7", Obj_Juntas_DAL.sNombre);
            Obj_Juntas_DAL.dtparametros.Rows.Add("@TELEFONO", "1", Obj_Juntas_DAL.iTelefono);

            Obj_Juntas_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["insertar_Juntas"], "IDENTITY", Obj_Juntas_DAL.dtparametros);
        }
        public void modificar_Juntas(ref cls_Juntas_DAL Obj_Juntas_DAL)
        {


            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Juntas_DAL.dtparametros = Obj_WCF.Get_DT_Param(Obj_Juntas_DAL.dtparametros);

            Obj_Juntas_DAL.dtparametros.Rows.Add("@COD_JUNTA", "7", Obj_Juntas_DAL.sCod_Junta);
            Obj_Juntas_DAL.dtparametros.Rows.Add("@COD_CENTRO", "7", Obj_Juntas_DAL.sCod_Centro);
            Obj_Juntas_DAL.dtparametros.Rows.Add("@NOMBRE", "7", Obj_Juntas_DAL.sNombre);
            Obj_Juntas_DAL.dtparametros.Rows.Add("@TELEFONO", "1", Obj_Juntas_DAL.iTelefono);

            Obj_Juntas_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["modificar_Juntas"], "NORMAL", Obj_Juntas_DAL.dtparametros); ;
        }

        public void eliminar_Juntas(ref cls_Juntas_DAL Obj_Juntas_DAL)
        {


            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Juntas_DAL.dtparametros = Obj_WCF.Get_DT_Param(Obj_Juntas_DAL.dtparametros);

            Obj_Juntas_DAL.dtparametros.Rows.Add("@COD_JUNTA", "7", Obj_Juntas_DAL.sCod_Junta);

            Obj_Juntas_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["eliminar_Juntas"], "NORMAL", Obj_Juntas_DAL.dtparametros);

        }
    }
}

