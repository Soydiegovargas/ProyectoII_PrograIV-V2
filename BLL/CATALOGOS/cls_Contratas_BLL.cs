using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CATALOGOS;
using System.Configuration;
using BLL.WCF;

namespace BLL.CATALOGOS
{
   public class cls_Contratas_BLL
    {
        public void listar_filtrar_Contratas(ref cls_Contratas_DAL Obj_Contratas_DAL)
        {

            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Contratas_DAL.sCedula == string.Empty) // Para Listar si esta vacio
            {
                Obj_Contratas_DAL.dtParametros = null;
                Obj_Contratas_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CONTRATAS", "listar_CONTRATAS", Obj_Contratas_DAL.dtParametros);
            }
            else // Para filtrar
            {
                Obj_Contratas_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Contratas_DAL.dtParametros);
                Obj_Contratas_DAL.dtParametros.Rows.Add("@Filtro", "5", Obj_Contratas_DAL.sCedula);
                Obj_Contratas_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CONTRATAS", ConfigurationManager.AppSettings["Filtrar_CONTRATAS"], Obj_Contratas_DAL.dtParametros);
            }


        }

        public void eliminar_Contratas(ref cls_Contratas_DAL Obj_Contratas_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Contratas_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Contratas_DAL.dtParametros);

            Obj_Contratas_DAL.dtParametros.Rows.Add("@CED_PERSONAL", "7", Obj_Contratas_DAL.sCedula);



            Obj_Contratas_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Eliminar_CONTRATAS"], "NORMAL", Obj_Contratas_DAL.dtParametros);


        }

        public void insertar_Contratas(ref cls_Contratas_DAL Obj_Contratas_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Contratas_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Contratas_DAL.dtParametros);



            Obj_Contratas_DAL.dtParametros.Rows.Add("@CED_PERSONAL", "7", Obj_Contratas_DAL.sCedula);
            Obj_Contratas_DAL.dtParametros.Rows.Add("@NOMBRE", "7", Obj_Contratas_DAL.sNombreCon);
            Obj_Contratas_DAL.dtParametros.Rows.Add("@TELEFONO", "4", Obj_Contratas_DAL.sTelefono);
            Obj_Contratas_DAL.dtParametros.Rows.Add("@DIRECCION", "7", Obj_Contratas_DAL.sDireccion);
            Obj_Contratas_DAL.dtParametros.Rows.Add("@COD_JUNTA", "7", Obj_Contratas_DAL.sCodJunta);

            Obj_Contratas_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Insertar_CONTRATAS"], "IDENTITY", Obj_Contratas_DAL.dtParametros);
        }

        public void modificar_Contratas(ref cls_Contratas_DAL Obj_Contratas_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Contratas_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Contratas_DAL.dtParametros);

            Obj_Contratas_DAL.dtParametros.Rows.Add("@CED_PERSONAL", "7", Obj_Contratas_DAL.sCedula);
            Obj_Contratas_DAL.dtParametros.Rows.Add("@NOMBRE", "7", Obj_Contratas_DAL.sNombreCon);
            Obj_Contratas_DAL.dtParametros.Rows.Add("@TELEFONO", "4", Obj_Contratas_DAL.sTelefono);
            Obj_Contratas_DAL.dtParametros.Rows.Add("@DIRECCION", "7", Obj_Contratas_DAL.sDireccion);
            Obj_Contratas_DAL.dtParametros.Rows.Add("@COD_JUNTA", "7", Obj_Contratas_DAL.sCodJunta);

            Obj_Contratas_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Modificar_CONTRATAS"], "NORMAL", Obj_Contratas_DAL.dtParametros);
        }

    }
}
