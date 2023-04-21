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
   public class cls_Departamentos_BLL
    {
        public void listar_Filtrar_Departamentos(ref cls_Departamentos_DAL Obj_Departamentos_DAL) //LISTO
        {

            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Departamentos_DAL.sEspecialidad == string.Empty)
            {
                Obj_Departamentos_DAL.dtParametros = null;
                Obj_Departamentos_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_DEPARTAMENTOS", "Listar_DEPARTAMENTOS", null);
            }
            else
            {
                Obj_Departamentos_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Departamentos_DAL.dtParametros);
                Obj_Departamentos_DAL.dtParametros.Rows.Add("@Filtro", "4", Obj_Departamentos_DAL.sEspecialidad);
                Obj_Departamentos_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_DEPARTAMENTOS", ConfigurationManager.AppSettings["Filtrar_DEPARTAMENTOS"], Obj_Departamentos_DAL.dtParametros);
                
            }

        }
        public void insertar_Departamentos(ref cls_Departamentos_DAL Obj_Departamentos_DAL) // LISTO
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Departamentos_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Departamentos_DAL.dtParametros);

            Obj_Departamentos_DAL.dtParametros.Rows.Add("@COD_AREA", "4", Obj_Departamentos_DAL.sCodArea);
            Obj_Departamentos_DAL.dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Departamentos_DAL.sCodCentro);
            Obj_Departamentos_DAL.dtParametros.Rows.Add("@ESPECIALIDAD", "4", Obj_Departamentos_DAL.sEspecialidad);
            Obj_Departamentos_DAL.dtParametros.Rows.Add("@TELEFONO", "1", Convert.ToInt32(Obj_Departamentos_DAL.sTelefono));

            Obj_Departamentos_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["insertar_DEPARTAMENTOS"], "IDENTITY", Obj_Departamentos_DAL.dtParametros);
            //Parametro "NORMAL" se usa solo para un UPDATE o un DELETE. Para un INSERT se usa algo diferente de "NORMAL",, puede ir vacio o nulo,o mejor aun poner IDENTITY

        }
        public void modificar_Departamentos(ref cls_Departamentos_DAL Obj_Departamentos_DAL) // LISTO
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Departamentos_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Departamentos_DAL.dtParametros);

            Obj_Departamentos_DAL.dtParametros.Rows.Add("@COD_AREA", "4", Obj_Departamentos_DAL.sCodArea);
            Obj_Departamentos_DAL.dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Departamentos_DAL.sCodCentro);
            Obj_Departamentos_DAL.dtParametros.Rows.Add("@ESPECIALIDAD", "4", Obj_Departamentos_DAL.sEspecialidad);
            Obj_Departamentos_DAL.dtParametros.Rows.Add("@TELEFONO", "1", Convert.ToInt32(Obj_Departamentos_DAL.sTelefono));

            Obj_Departamentos_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Modificar_DEPARTAMENTOS"], "NORMAL", Obj_Departamentos_DAL.dtParametros);
        }
        public void eliminar_Departamentos(ref cls_Departamentos_DAL Obj_Departamentos_DAL) // LISTO
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Departamentos_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Departamentos_DAL.dtParametros);

            Obj_Departamentos_DAL.dtParametros.Rows.Add("@COD_AREA", "4", Obj_Departamentos_DAL.sCodArea);

            Obj_Departamentos_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Eliminar_DEPARTAMENTOS"], "NORMAL", Obj_Departamentos_DAL.dtParametros);
        }
        public void listar_filtrar_Centros(ref cls_Centros_DAL Obj_Centro_DAL) // LISTO

        {
            WCF.BDClient Obj_WCF = new BDClient(); // se crea el objeto de manejo de la BD

            if (Obj_Centro_DAL.sNombreC == string.Empty) //Si el campo para el nombre de Centro está vacio
            {
                Obj_Centro_DAL.dtParametros = null; //No habran parámetros
                Obj_Centro_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CENTROS", ConfigurationManager.AppSettings["listar_CENTROS"], null); //Se manda a ejecutar sin parámetros para filtrar todo
            }
            else
            {
                Obj_Centro_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Centro_DAL.dtParametros);
                Obj_Centro_DAL.dtParametros.Rows.Add("@FILTRO", "7", Obj_Centro_DAL.sCodCentro);
                Obj_Centro_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CENTROS", ConfigurationManager.AppSettings["Filtrar_CENTROS"], Obj_Centro_DAL.dtParametros); //Se filtra por los parametros
            }
        }

    }
}
