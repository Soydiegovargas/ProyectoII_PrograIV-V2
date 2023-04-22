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
    public class cls_Centros_BLL
    {

        public void listar_filtrar_Centros(ref cls_Centros_DAL Obj_Centros_DAL) //LISTO
        {

            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Centros_DAL.sCodCentro == string.Empty) // Para Listar si esta vacio
            {
                Obj_Centros_DAL.dtParametros = null;
                Obj_Centros_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CENTROS", "listar_CENTROS", Obj_Centros_DAL.dtParametros);
            }
            else // Para filtrar
            {
                Obj_Centros_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Centros_DAL.dtParametros);
                Obj_Centros_DAL.dtParametros.Rows.Add("@Filtro", "5", Obj_Centros_DAL.sCodCentro);
                Obj_Centros_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CENTROS", ConfigurationManager.AppSettings["Filtrar_CENTROS"], Obj_Centros_DAL.dtParametros);
            }
        }
        public void eliminar_Centros(ref cls_Centros_DAL Obj_Centros_DAL) //listo
        {

            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Centros_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Centros_DAL.dtParametros);

            Obj_Centros_DAL.dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Centros_DAL.sCodCentro);



            Obj_Centros_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Eliminar_CENTRO"], "NORMAL", Obj_Centros_DAL.dtParametros);

        }
        public void insertar_Centros(ref cls_Centros_DAL Obj_Centros_DAL) //listo
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Centros_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Centros_DAL.dtParametros);

            Obj_Centros_DAL.dtParametros.Rows.Add("@COD_JUNTA", "7", Obj_Centros_DAL.sCodJunta);
            Obj_Centros_DAL.dtParametros.Rows.Add("@CED_JUR", "7", Obj_Centros_DAL.sCedJur);
            Obj_Centros_DAL.dtParametros.Rows.Add("@NOMBRE", "7", Obj_Centros_DAL.sNombreC);
            Obj_Centros_DAL.dtParametros.Rows.Add("@DIRECCION", "7", Obj_Centros_DAL.sDirrecionC);
            Obj_Centros_DAL.dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Centros_DAL.sCodCentro);

            Obj_Centros_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Insertar_CENTROS"], "IDENTITY", Obj_Centros_DAL.dtParametros);


        }
        public void modificar_Centros(ref cls_Centros_DAL Obj_Centros_DAL) //listo
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Centros_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Centros_DAL.dtParametros);

            Obj_Centros_DAL.dtParametros.Rows.Add("@COD_JUNTA", "7", Obj_Centros_DAL.sCodJunta);
            Obj_Centros_DAL.dtParametros.Rows.Add("@CED_JUR", "7", Obj_Centros_DAL.sCedJur);
            Obj_Centros_DAL.dtParametros.Rows.Add("@NOMBRE", "7", Obj_Centros_DAL.sNombreC);
            Obj_Centros_DAL.dtParametros.Rows.Add("@DIRECCION", "7", Obj_Centros_DAL.sDirrecionC);
            Obj_Centros_DAL.dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Centros_DAL.sCodCentro);


            Obj_Centros_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Modificar_CENTROS"], "NORMAL", Obj_Centros_DAL.dtParametros);

        }
        public void listar_filtrar_CCSS(ref cls_CCSS_DAL Obj_CCSS_DAL) //listo
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_CCSS_DAL.sDescripcion == string.Empty) // Para Listar si esta vacio
            {
                Obj_CCSS_DAL.dtParametros = null;
                Obj_CCSS_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CCSS", "listar_CCSS", Obj_CCSS_DAL.dtParametros);
            }
            else // Para filtrar
            {
                Obj_CCSS_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_CCSS_DAL.dtParametros);
                Obj_CCSS_DAL.dtParametros.Rows.Add("@Filtro", "5", Obj_CCSS_DAL.sCed_Jur);
                Obj_CCSS_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CCSS", ConfigurationManager.AppSettings["filtrar_CCSS"], Obj_CCSS_DAL.dtParametros);
            }

        }
        public void Listar_JUNTA(ref cls_Juntas_DAL Obj_Juntas_DAL)//listar
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Juntas_DAL.sNombre == string.Empty) // Para Listar si esta vacio
            {
                Obj_Juntas_DAL.dtparametros = null;
              

                Obj_Juntas_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_JUNTAS", ConfigurationManager.AppSettings["listar_Juntas"], Obj_Juntas_DAL.dtparametros);
            }

        }
    }
}
