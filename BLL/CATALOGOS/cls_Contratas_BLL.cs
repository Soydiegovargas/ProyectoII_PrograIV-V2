using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CATALOGOS;

namespace BLL.CATALOGOS
{
   public class cls_Contratas_BLL
    {
        //public void listar_filtrar_Contratas(ref cls_Contratas_DAL Obj_Contratas_DAL)
        //{
        //    cls_Contratas_DAL Obj_Contratas = new cls_Contratas_DAL();
        //    cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //    cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        //    if (Obj_Contratas_DAL.sCedula == string.Empty)
        //    {
        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_CONTRATAS"].ToString();

        //    }
        //    else
        //    {

        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Filtrar_CONTRATAS"].ToString();
        //        Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@FILTRO", "5", Obj_Contratas_DAL.sCedula); //Mando los parámetros del Store Procedure

        //    }

        //    Obj_BD_DAL.sNomTabla = "T_CONTRATAS";

        //    Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

        //    if (Obj_BD_DAL.sMsjError == string.Empty)
        //    {
        //        Obj_Contratas_DAL.sMsjError = string.Empty;
        //        Obj_Contratas_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
        //    }
        //    else
        //    {
        //        Obj_Contratas_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //        Obj_Contratas_DAL.dtDatos = null;
        //    }

        //}

        //public void eliminar_Contratas(ref cls_Contratas_DAL Obj_Contratas_DAL)
        //{
        //    cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //    cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Eliminar_CONTRATAS"].ToString();
        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_PERSONAL", "7", Obj_Contratas_DAL.sCedula); //Mando los parámetros del Store Procedure

        //    Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //    Obj_Contratas_DAL.sMsjError = Obj_BD_DAL.sMsjError;


        //}

        //public void insertar_Contratas(ref cls_Contratas_DAL Obj_Contratas_DAL)
        //{
        //    cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //    cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Insertar_CONTRATAS"].ToString();

        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable

        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_PERSONAL", "7", Obj_Contratas_DAL.sCedula);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@NOMBRE", "7", Obj_Contratas_DAL.sNombreCon);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@TELEFONO", "4", Obj_Contratas_DAL.sTelefono);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@DIRECCION", "7", Obj_Contratas_DAL.sDireccion);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_JUNTA", "7", Obj_Contratas_DAL.sCodJunta);

        //    Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //    Obj_Contratas_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //}

        //public void modificar_Contratas(ref cls_Contratas_DAL Obj_Contratas_DAL)
        //{
        //    cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //    cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Modificar_CONTRATAS"].ToString();

        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable

        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_PERSONAL", "7", Obj_Contratas_DAL.sCedula);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@NOMBRE", "7", Obj_Contratas_DAL.sNombreCon);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@TELEFONO", "4", Obj_Contratas_DAL.sTelefono);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@DIRECCION", "7", Obj_Contratas_DAL.sDireccion);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_JUNTA", "7", Obj_Contratas_DAL.sCodJunta);

        //    Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //    Obj_Contratas_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //}

    }
}
