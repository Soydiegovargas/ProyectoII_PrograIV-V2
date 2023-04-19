using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using DAL.CATALOGOS;
using BLL.WCF;

namespace BLL.CATALOGOS
{
   public class cls_Departamentos_BLL
    {
       

        //public void listar_Departamentos(ref cls_Departamentos_DAL Obj_Departamentos_DAL)
        //{
        //    cls_Departamentos_DAL Obj_Departamentos = new cls_Departamentos_DAL();

        //    WCF.BDClient Obj_WCF = new WCF.BDClient();

        //    if (Obj_Departamentos_DAL.sEspecialidad == string.Empty)
        //    {
        //        Obj_Departamentos_DAL.dtParametros = null;
        //        Obj_Departamentos_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_DEPARTAMENTOS", ConfigurationManager.AppSettings["Listar_DEPARTAMENTOS"], null);
        //    }


        //    Obj_Departamentos_DAL.sNomSp = ConfigurationManager.AppSettings["Listar_DEPARTAMENTOS"].ToString();

        //    Obj_BD_DAL.sNomTabla = "T_Departamentos";


        //    Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

        //    if (Obj_BD_DAL.sMsjError == string.Empty)
        //    {
        //        Obj_Departamentos_DAL.sMsjError = string.Empty;
        //        Obj_Departamentos_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
        //    }
        //    else
        //    {
        //        Obj_Departamentos_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //        Obj_Departamentos_DAL.dtDatos = null;
        //    }

        //}

        //public void filtrar_Departamentos(ref cls_Departamentos_DAL Obj_Departamentos_DAL)
        //{
        //    WCF.BDClient Obj_WCF = new WCF.BDClient();

        //    if (Obj_Departamentos_DAL.sEspecialidad == string.Empty)
        //    {
        //        Obj_Departamentos_DAL.dtParametros = null;
        //        Obj_Departamentos_DAL.dtDatos = Obj_WCF.ListarFiltrar("ESPECIALIDAD",ConfigurationManager.AppSettings(""))
        //        Obj_Departamentos_DAL.sNomSp = ConfigurationManager.AppSettings["Listar_DEPARTAMENTOS"].ToString();

        //    }

        //    WCF.BDClient Obj_WCF = new BDClient();

        //    if (Obj_Departamentos_DAL.sEspecialidad == string.Empty)
        //    {
        //        Obj_Departamentos_DAL.dtParametros = null;
        //        Obj_Departamentos_DAL.dtDatos = Obj_WCF.ListarFiltrar("ESPECIALIDAD", ConfigurationManager.AppSettings["Filtrar_CENTROS"], null);
        //    }
        //    else
        //    {
        //        Obj_Centro_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Centro_DAL.dtParametros);
        //        Obj_Centro_DAL.dtParametros.Rows.Add("@FILTRO", "7", Obj_Centro_DAL.sCodCentro);
        //        Obj_Centro_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CENTROS", ConfigurationManager.AppSettings["Filtrar_CENTROS"], Obj_Centro_DAL.dtParametros);
        //    }


        //    else
        //    {

        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Filtrar_DEPARTAMENTOS"].ToString();
        //        Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@ESPECIALIDAD", "4", Obj_Departamentos_DAL.sEspecialidad); //Mando los parámetros del Store Procedure

        //    }

        //    Obj_BD_DAL.sNomTabla = "T_DEPARTAMENTOS";

        //    Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

        //    if (Obj_BD_DAL.sMsjError == string.Empty)
        //    {
        //        Obj_Departamentos_DAL.sMsjError = string.Empty;
        //        Obj_Departamentos_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
        //    }
        //    else
        //    {
        //        Obj_Departamentos_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //        Obj_Departamentos_DAL.dtDatos = null;
        //    }

        //}

        //public void eliminar_Departamentos(ref cls_Departamentos_DAL Obj_Departamentos_DAL)
        //{
        //    WCF.BDClient Obj_WCF = new WCF.BDClient();

        //    Obj_Departamentos_DAL.dtDatos = Obj_WCF.Get_DT_Param(Obj_Dep_DAL.)

        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["eliminar_DEPARTAMENTOS"].ToString();
        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_AREA", "4", Obj_Departamentos_DAL.sCodArea); //Mando los parámetros del Store Procedure


        //    Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //    Obj_Departamentos_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //}

        //public void insertar_Departamentos(ref cls_Departamentos_DAL Obj_Departamentos_DAL)
        //{
        //    cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //    cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["insertar_DEPARTAMENTOS"].ToString();

        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable


        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_AREA", "4", Obj_Departamentos_DAL.sCodArea); //Mando los parámetros del Store Procedure
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@ESPECIALIDAD", "4", Obj_Departamentos_DAL.sEspecialidad);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@TELEFONO", "1", Obj_Departamentos_DAL.sTelefono);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_CENTRO", 7, Obj_Departamentos_DAL.sCodCentro);

        //    Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //    Obj_Departamentos_DAL.sMsjError = Obj_BD_DAL.sMsjError;

        //}

        //public void modificar_Departamentos(ref cls_Departamentos_DAL Obj_Departamentos_DAL)
        //{
        //    cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //    cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["modificar_DEPARTAMENTOS"].ToString();

        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Departamentos_DAL.sCodCentro);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_AREA", "4", Obj_Departamentos_DAL.sCodArea);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@ESPECIALIDAD", "4", Obj_Departamentos_DAL.sEspecialidad);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@TELEFONO", "1", Convert.ToInt32(Obj_Departamentos_DAL.sTelefono));

        //    // Obj_BD_DAL.obj_dtParametros.Rows.Add("@TELEFONO", "1", Obj_Departamentos_DAL.sTel);

        //    Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //    Obj_Departamentos_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //}

        public void listar_filtrar_Centros(ref cls_Centros_DAL Obj_Centro_DAL) // LISTO

        {
            WCF.BDClient Obj_WCF = new BDClient();

            if( Obj_Centro_DAL.sNombreC == string.Empty)
            {
                Obj_Centro_DAL.dtParametros = null;
                Obj_Centro_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CENTROS", ConfigurationManager.AppSettings["listar_CENTROS"], null);
            }
            else
            {
                Obj_Centro_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Centro_DAL.dtParametros);
                Obj_Centro_DAL.dtParametros.Rows.Add("@FILTRO", "7", Obj_Centro_DAL.sCodCentro);
                Obj_Centro_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CENTROS", ConfigurationManager.AppSettings["Filtrar_CENTROS"], Obj_Centro_DAL.dtParametros);
            }
        }
    }
}
