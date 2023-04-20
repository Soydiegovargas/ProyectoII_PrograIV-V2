using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CATALOGOS;

namespace BLL.CATALOGOS
{
    public class cls_Juntas_BLL
    {


        //    #region Globales
        //    //cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //    //cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        //    #endregion
        //    public void Listar_Juntas(ref cls_Juntas_DAL Obj_Juntas_DAL)
        //    {


        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_Juntas"].ToString();
        //        Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
        //        Obj_BD_DAL.sNomTabla = "T_JUNTAS";

        //        Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);


        //        if (Obj_BD_DAL.sMsjError == string.Empty)
        //        {
        //            Obj_Juntas_DAL.sMsjError = string.Empty;
        //            Obj_Juntas_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
        //        }
        //        else
        //        {
        //            Obj_Juntas_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //            Obj_Juntas_DAL.dtDatos = null;
        //        }


        //    }
        //    public void Filtrar_Juntas(ref cls_Juntas_DAL OBJ_Juntas_DAL)
        //    {



        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["filtrar_Juntas"].ToString();
        //        Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
        //        Obj_BD_DAL.sNomTabla = "Juntas";

        //        Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@Filtro", "7", OBJ_Juntas_DAL.sCod_Junta);
        //        Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

        //        if (Obj_BD_DAL.sMsjError == string.Empty)
        //        {
        //            OBJ_Juntas_DAL.sMsjError = string.Empty;
        //            OBJ_Juntas_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
        //        }
        //        else
        //        {
        //            OBJ_Juntas_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //            OBJ_Juntas_DAL.dtDatos = null;
        //        }

        //    }
        //    public void insertar_Juntas(ref cls_Juntas_DAL Obj_Juntas_DAL)
        //    {


        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["insertar_Juntas"].ToString();

        //        Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable

        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_JUNTA", "7", Obj_Juntas_DAL.sCod_Junta);
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Juntas_DAL.sCod_Centro);
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@NOMBRE", "7", Obj_Juntas_DAL.sNombre);
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@TELEFONO", "1", Obj_Juntas_DAL.iTelefono);

        //        Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //        Obj_Juntas_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //    }
        //    public void modificar_Juntas(ref cls_Juntas_DAL Obj_Juntas_DAL)
        //    {


        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["modificar_Juntas"].ToString();

        //        Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable

        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_JUNTA", "7", Obj_Juntas_DAL.sCod_Junta);
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Juntas_DAL.sCod_Centro);
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@NOMBRE", "7", Obj_Juntas_DAL.sNombre);
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@TELEFONO", "1", Obj_Juntas_DAL.iTelefono);

        //        Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //        Obj_Juntas_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //    }
        //    public void Listar_Centros(ref cls_Juntas_DAL Obj_Juntas_DAL)
        //    {

        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_Centros"].ToString();


        //        Obj_BD_DAL.sNomTabla = "T_CENTROS";

        //        Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

        //        if (Obj_BD_DAL.sMsjError == string.Empty)
        //        {
        //            Obj_Juntas_DAL.sMsjError = string.Empty;
        //            Obj_Juntas_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
        //        }
        //        else
        //        {
        //            Obj_Juntas_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //            Obj_Juntas_DAL.dtDatos = null;
        //        }




        //    }
        //    public void eliminar_Juntas(ref cls_Juntas_DAL Obj_Juntas_DAL)
        //    {



        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["eliminar_Juntas"].ToString();
        //        Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable porque se tiene que recibir un parámetro 
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_JUNTA", "7", Obj_Juntas_DAL.sCod_Junta); //Mando los parámetros del Store Procedure

        //        Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //        Obj_Juntas_DAL.sMsjError = Obj_BD_DAL.sMsjError;

        //    }
        //}
    }
}
