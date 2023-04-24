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
   public class cls_Incapacidades_BLL
    {


        public void listar_Filtrar_Incapacidades(ref cls_Incapacidades_DAL Obj_Incapacidades_DAL) //LISTO
        {

            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Incapacidades_DAL.sCOD_Area == string.Empty)
            {
                Obj_Incapacidades_DAL.dtParametros = null;
                Obj_Incapacidades_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_INCAPACIDADES", ConfigurationManager.AppSettings["Listar_INCAPACIDADES"], null);
            }
            else
            {
                Obj_Incapacidades_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Incapacidades_DAL.dtParametros);
                Obj_Incapacidades_DAL.dtParametros.Rows.Add("@Filtro", "4", Obj_Incapacidades_DAL.sCOD_Area);
                Obj_Incapacidades_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_INCAPACIDADES", ConfigurationManager.AppSettings["Filtrar_INCAPACIDADES"], Obj_Incapacidades_DAL.dtParametros);

            }

        }
        public void insertar_Incapacidades(ref cls_Incapacidades_DAL Obj_Incapacidades_DAL) // LISTO
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Incapacidades_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Incapacidades_DAL.dtParametros);

            Obj_Incapacidades_DAL.dtParametros.Rows.Add("@COD_AREA", "5", Obj_Incapacidades_DAL.sCOD_Area);
            Obj_Incapacidades_DAL.dtParametros.Rows.Add("@NUM_INCAP", "4", Obj_Incapacidades_DAL.sNum_Incap);
            Obj_Incapacidades_DAL.dtParametros.Rows.Add("@NOMBRE", "35", Obj_Incapacidades_DAL.sNombre);
            Obj_Incapacidades_DAL.dtParametros.Rows.Add("@DIAS", "1", Convert.ToInt32(Obj_Incapacidades_DAL.iDias));
            Obj_Incapacidades_DAL.dtParametros.Rows.Add("@MOTIVO", "30", Obj_Incapacidades_DAL.sMotivo);

            Obj_Incapacidades_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["insertar_INCAPACIDADES"], "IDENTITY", Obj_Incapacidades_DAL.dtParametros);
            //Parametro "NORMAL" se usa solo para un UPDATE o un DELETE. Para un INSERT se usa algo diferente de "NORMAL",, puede ir vacio o nulo,o mejor aun poner IDENTITY

        }
        public void modificar_Incapacidades(ref cls_Incapacidades_DAL Obj_Incapacidades_DAL) // LISTO
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Incapacidades_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Incapacidades_DAL.dtParametros);

            Obj_Incapacidades_DAL.dtParametros.Rows.Add("@COD_AREA", "5", Obj_Incapacidades_DAL.sCOD_Area);
            Obj_Incapacidades_DAL.dtParametros.Rows.Add("@NUM_INCAP", "4", Obj_Incapacidades_DAL.sNum_Incap);
            Obj_Incapacidades_DAL.dtParametros.Rows.Add("@NOMBRE", "35", Obj_Incapacidades_DAL.sNombre);
            Obj_Incapacidades_DAL.dtParametros.Rows.Add("@DIAS", "1", Convert.ToInt32(Obj_Incapacidades_DAL.iDias));
            Obj_Incapacidades_DAL.dtParametros.Rows.Add("@MOTIVO", "30", Obj_Incapacidades_DAL.sMotivo);

            Obj_Incapacidades_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Modificar_INCAPACIDADES"], "NORMAL", Obj_Incapacidades_DAL.dtParametros);
        }
        public void eliminar_Incapacidades(ref cls_Incapacidades_DAL Obj_Incapacidades_DAL) // LISTO
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Incapacidades_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Incapacidades_DAL.dtParametros);

            Obj_Incapacidades_DAL.dtParametros.Rows.Add("@COD_AREA", "4", Obj_Incapacidades_DAL.sCOD_Area);

            Obj_Incapacidades_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Eliminar_INCAPACIDADES"], "NORMAL", Obj_Incapacidades_DAL.dtParametros);
        }
        public void listar_filtrar_Incapacidades(ref cls_Incapacidades_DAL Obj_Incapacidades_DAL) // LISTO

        {
            WCF.BDClient Obj_WCF = new BDClient(); // se crea el objeto de manejo de la BD

            if (Obj_Incapacidades_DAL.sCOD_Area == string.Empty) //Si el campo para el nombre de Centro está vacio
            {
                Obj_Incapacidades_DAL.dtParametros = null; //No habran parámetros
                Obj_Incapacidades_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_INCAPACIDADES", ConfigurationManager.AppSettings["listar_INCAPACIDADES"], null); //Se manda a ejecutar sin parámetros para filtrar todo
            }
            else
            {
                Obj_Incapacidades_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Incapacidades_DAL.dtParametros);
                Obj_Incapacidades_DAL.dtParametros.Rows.Add("@FILTRO", "7", Obj_Incapacidades_DAL.sCOD_Area);
                Obj_Incapacidades_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CENTROS", ConfigurationManager.AppSettings["Filtrar_CENTROS"], Obj_Incapacidades_DAL.dtParametros); //Se filtra por los parametros
            }
        }
    }
}
