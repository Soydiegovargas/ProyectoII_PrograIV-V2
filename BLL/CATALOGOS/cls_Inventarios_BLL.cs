using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.WCF;
using DAL.CATALOGOS;

namespace BLL.CATALOGOS
{
    public class cls_Inventarios_BLL
    {
        public void listar_Filtrar_Inventarios(ref cls_Inventarios_DAL Obj_Inventarios_DAL) //LISTO
        {

            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Inventarios_DAL.sCod_Medicina == string.Empty)
            {
                Obj_Inventarios_DAL.dtParametros = null;
                Obj_Inventarios_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_DEPARTAMENTOS", ConfigurationManager.AppSettings["Listar_DEPARTAMENTOS"], null);
            }
            else
            {
                Obj_Inventarios_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Inventarios_DAL.dtParametros);
                Obj_Inventarios_DAL.dtParametros.Rows.Add("@Filtro", "4", Obj_Inventarios_DAL.sCod_Medicina);
                Obj_Inventarios_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_INVENTARIOS", ConfigurationManager.AppSettings["Filtrar_INVENTARIOS"], Obj_Inventarios_DAL.dtParametros);

            }

        }
        public void insertar_Inventarios(ref cls_Inventarios_DAL Obj_Inventarios_DAL) // LISTO
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Inventarios_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Inventarios_DAL.dtParametros);

            Obj_Inventarios_DAL.dtParametros.Rows.Add("@COD_MEDICINA", "8", Obj_Inventarios_DAL.sCod_Medicina);
            Obj_Inventarios_DAL.dtParametros.Rows.Add("@FECHA_VENC", "7", Obj_Inventarios_DAL.date);
            Obj_Inventarios_DAL.dtParametros.Rows.Add("@COD_FARMACIA", "4", Obj_Inventarios_DAL.sCod_Farmacia);
            Obj_Inventarios_DAL.dtParametros.Rows.Add("@CANTIDAD", "1", Convert.ToInt32(Obj_Inventarios_DAL.iCantidad));

            Obj_Inventarios_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["insertar_INVENTARIOS"], "IDENTITY", Obj_Inventarios_DAL.dtParametros);
            //Parametro "NORMAL" se usa solo para un UPDATE o un DELETE. Para un INSERT se usa algo diferente de "NORMAL",, puede ir vacio o nulo,o mejor aun poner IDENTITY

        }
        public void modificar_Inventarios(ref cls_Inventarios_DAL Obj_Inventarios_DAL) // LISTO
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Inventarios_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Inventarios_DAL.dtParametros);

            Obj_Inventarios_DAL.dtParametros.Rows.Add("@COD_MEDICINA", "8", Obj_Inventarios_DAL.sCod_Medicina);
            Obj_Inventarios_DAL.dtParametros.Rows.Add("@FECHA_VENC", "7", Obj_Inventarios_DAL.date);
            Obj_Inventarios_DAL.dtParametros.Rows.Add("@COD_FARMACIA", "4", Obj_Inventarios_DAL.sCod_Farmacia);
            Obj_Inventarios_DAL.dtParametros.Rows.Add("@CANTIDAD", "1", Convert.ToInt32(Obj_Inventarios_DAL.iCantidad));

            Obj_Inventarios_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Modificar_INVENTARIOS"], "NORMAL", Obj_Inventarios_DAL.dtParametros);
        }
        public void eliminar_Inventarios(ref cls_Inventarios_DAL Obj_Inventarios_DAL) // LISTO
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Inventarios_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Inventarios_DAL.dtParametros);

            Obj_Inventarios_DAL.dtParametros.Rows.Add("@COD_MEDICINA", "8", Obj_Inventarios_DAL.sCod_Medicina);

            Obj_Inventarios_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["eliminar_INVENTARIOS"], "NORMAL", Obj_Inventarios_DAL.dtParametros);
        }
        public void listar_filtrar_Centros(ref cls_Inventarios_DAL Obj_Inventarios_DAL) // LISTO

        {
            WCF.BDClient Obj_WCF = new BDClient(); // se crea el objeto de manejo de la BD

            if (Obj_Inventarios_DAL.sCod_Medicina == string.Empty) //Si el campo para el nombre de Centro está vacio
            {
                Obj_Inventarios_DAL.dtParametros = null; //No habran parámetros
                Obj_Inventarios_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_INVENTARIOS", ConfigurationManager.AppSettings["listar_INVENTARIOS"], null); //Se manda a ejecutar sin parámetros para filtrar todo
            }
            else
            {
                Obj_Inventarios_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Inventarios_DAL.dtParametros);
                Obj_Inventarios_DAL.dtParametros.Rows.Add("@FILTRO", "7", Obj_Inventarios_DAL.sCod_Medicina);
                Obj_Inventarios_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_INVENTARIOS", ConfigurationManager.AppSettings["Filtrar_INVENTARIOS"], Obj_Inventarios_DAL.dtParametros); //Se filtra por los parametros
            }
        }
    }
}

