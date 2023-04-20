using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DAL.CATALOGOS;

namespace BLL.CATALOGOS
{
    public class cls_Asegurados_BLL
    {
        //cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        //public void listar_Asegurados(ref cls_Asegurados_DAL Obj_Asegurados_DAL)
        //{

        //    //cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //    //cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Listar_ASEGURADOS"].ToString();
        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
        //    Obj_BD_DAL.sNomTabla = "T_Asegurados";


        //    Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

        //    if (Obj_BD_DAL.sMsjError == string.Empty)
        //    {
        //        Obj_Asegurados_DAL.sMsjError = string.Empty;
        //        Obj_Asegurados_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
        //    }
        //    else
        //    {
        //        Obj_Asegurados_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //        Obj_Asegurados_DAL.dtDatos = null;
        //    }


        //}
        //public void filtrar_Asegurados(ref cls_Asegurados_DAL Obj_Asegurados_DAL)
        //{
        //    // cls_Asegurados_DAL Obj_Asegurados = new cls_Asegurados_DAL();



        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Filtrar_ASEGURADOS"].ToString();
        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
        //    Obj_BD_DAL.sNomTabla = "T_ASEGURADOS";

        //    Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@Filtro", "7", Obj_Asegurados_DAL.sCedAsegurado);
        //    Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);






        //    if (Obj_BD_DAL.sMsjError == string.Empty)
        //    {
        //        Obj_Asegurados_DAL.sMsjError = string.Empty;
        //        Obj_Asegurados_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
        //    }
        //    else
        //    {
        //        Obj_Asegurados_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //        Obj_Asegurados_DAL.dtDatos = null;
        //    }

        //}

        //public void eliminar_Asegurados(ref cls_Asegurados_DAL Obj_Asegurados_DAL)
        //{


        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Eliminar_ASEGURADOS"].ToString();
        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_ASEGURADO", "7", Obj_Asegurados_DAL.sCedAsegurado);

        //    Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //    Obj_Asegurados_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //}

        //public void insertar_Asegurados(ref cls_Asegurados_DAL Obj_Asegurados_DAL)
        //{

        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Insertar_ASEGURADOS"].ToString();

        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_ASEGURADO", "7", Obj_Asegurados_DAL.sCedAsegurado);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@NOMBRE", "7", Obj_Asegurados_DAL.sNombre);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@TELEFONO", "7", Obj_Asegurados_DAL.sTelefono);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@DIRECCION", "7", Obj_Asegurados_DAL.sDireccion);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Asegurados_DAL.sCodCentro);

        //    Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //    Obj_Asegurados_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //}

        //public void modificar_Asegurados(ref cls_Asegurados_DAL Obj_Asegurados_DAL)
        //{


        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Modificar_ASEGURADOS"].ToString();

        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_ASEGURADO", "7", Obj_Asegurados_DAL.sCedAsegurado);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@NOMBRE", "7", Obj_Asegurados_DAL.sNombre);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@TELEFONO", "7", Obj_Asegurados_DAL.sTelefono);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@DIRECCION", "7", Obj_Asegurados_DAL.sDireccion);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Asegurados_DAL.sCodCentro);

        //    Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //    Obj_Asegurados_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //}

        //public void listar_filtrar_Centro(ref cls_Asegurados_DAL Obj_Centro_DAL)

        //{

        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_CENTROS"].ToString();


        //    Obj_BD_DAL.sNomTabla = "T_listar_CENTROS";

        //    Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

        //    if (Obj_BD_DAL.sMsjError == string.Empty)
        //    {
        //        Obj_Centro_DAL.sMsjError = string.Empty;
        //        Obj_Centro_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
        //    }
        //    else
        //    {
        //        Obj_Centro_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //        Obj_Centro_DAL.dtDatos = null;
        //    }

        //}

    }
}
