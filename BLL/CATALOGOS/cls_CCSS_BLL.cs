using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.WCF;
using DAL.CATALOGOS;
using System.Configuration;

namespace BLL.CATALOGOS
{
    public class cls_CCSS_BLL
    {
        //PRUEBA
        public void insertar_CCSS(ref cls_CCSS_DAL Obj_CCSS_DAL) // Listo
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_CCSS_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_CCSS_DAL.dtParametros);

            Obj_CCSS_DAL.dtParametros.Rows.Add("@CED_JUR", "7", Obj_CCSS_DAL.sCed_Jur);
            Obj_CCSS_DAL.dtParametros.Rows.Add("@TELEFONO ", "1", Obj_CCSS_DAL.iTelefono);
            Obj_CCSS_DAL.dtParametros.Rows.Add("@PAGINA", "5", Obj_CCSS_DAL.sPagina);
            Obj_CCSS_DAL.dtParametros.Rows.Add("@DESCRIPCION", "5", Obj_CCSS_DAL.sDescripcion);

            Obj_CCSS_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["insertar_CCSS"], "IDENTITY", Obj_CCSS_DAL.dtParametros);

        }
        public void modificar_CCSS(ref cls_CCSS_DAL Obj_CCSS_DAL) // Listo
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_CCSS_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_CCSS_DAL.dtParametros);

            Obj_CCSS_DAL.dtParametros.Rows.Add("@CED_JUR", "7", Obj_CCSS_DAL.sCed_Jur);
            Obj_CCSS_DAL.dtParametros.Rows.Add("@TELEFONO ", "1", Obj_CCSS_DAL.iTelefono);
            Obj_CCSS_DAL.dtParametros.Rows.Add("@PAGINA", "5", Obj_CCSS_DAL.sPagina);
            Obj_CCSS_DAL.dtParametros.Rows.Add("@DESCRIPCION", "5", Obj_CCSS_DAL.sDescripcion);

            Obj_CCSS_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["modificar_CCSS"], "NORMAL", Obj_CCSS_DAL.dtParametros);

        }
        public void eliminar_CCSS(ref cls_CCSS_DAL Obj_CCSS_DAL) // Listo
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_CCSS_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_CCSS_DAL.dtParametros);

            Obj_CCSS_DAL.dtParametros.Rows.Add("@CED_JUR", "7", Obj_CCSS_DAL.sCed_Jur);

            Obj_CCSS_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["eliminar_CCSS"], "NORMAL", Obj_CCSS_DAL.dtParametros);


        }
        public void listar_filtrar_CCSS(ref cls_CCSS_DAL Obj_CCSS_DAL) // Listo
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_CCSS_DAL.sDescripcion == string.Empty) // Para Listar
            {
                Obj_CCSS_DAL.dtParametros = null;
                Obj_CCSS_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CCSS", "listar_CCSS", Obj_CCSS_DAL.dtParametros);
            }
            else // Para filtrar
            {
                Obj_CCSS_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_CCSS_DAL.dtParametros);
                Obj_CCSS_DAL.dtParametros.Rows.Add("@Filtro", "5", Obj_CCSS_DAL.sCed_Jur);
                Obj_CCSS_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CCSS", ConfigurationManager.AppSettings["listar_CCSS"], Obj_CCSS_DAL.dtParametros);
            }
        }
    }
   }

