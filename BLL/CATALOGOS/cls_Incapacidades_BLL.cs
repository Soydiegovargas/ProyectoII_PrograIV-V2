using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CATALOGOS;


namespace BLL.CATALOGOS
{
   public class cls_Incapacidades_BLL
    {


        //public void Listar_Filtrar_Incapacidades(ref cls_Incapacidades_DAL Obj_Incapacidades_DAL)
        //{
        //    cls_Incapacidades_DAL Obj_Incapacidades = new cls_Incapacidades_DAL();
        //    cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        //    cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();


        //    if (Obj_Incapacidades_DAL.sCOD_Area == string.Empty)
        //    {
        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Listar_Incapacidades"].ToString();

        //    }
        //    else
        //    {

        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Filtrar_Incapacidades"].ToString();
        //        Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@Filtro", "5", Obj_Incapacidades_DAL.sCOD_Area);

        //    }

        //    Obj_BD_DAL.sNomTabla = "T_INCAPACIDADES";

        //    Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

        //    if (Obj_BD_DAL.sMsjError == string.Empty)
        //    {
        //        Obj_Incapacidades_DAL.sMsjError = string.Empty;
        //        Obj_Incapacidades_DAL.dtIncapacidades = Obj_BD_DAL.obj_ds.Tables[0];
        //    }
        //    else
        //    {
        //        Obj_Incapacidades_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //        Obj_Incapacidades_DAL.dtIncapacidades = null;
        //    }
        //}
        //public void Insertar_Incapacidades(ref cls_Incapacidades_DAL Obj_Incapacidades_DAL)
        //{

        //    cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        //    cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Insertar_Incapacidades"].ToString();
        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_AREA", "5", Obj_Incapacidades_DAL.sCOD_Area);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@NUM_INCAP", "5", Obj_Incapacidades_DAL.sNum_Incap);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@NOMBRE", "7", Obj_Incapacidades_DAL.sNombre);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@DIAS", "1", Obj_Incapacidades_DAL.iDias);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@MOTIVO", "7", Obj_Incapacidades_DAL.sMotivo);

        //    Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //    Obj_Incapacidades_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //}
        //public void Modificar_Incapacidades(ref cls_Incapacidades_DAL Obj_Incapacidades_DAL)
        //{

        //    cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        //    cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Modificar_Incapacidades"].ToString();
        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_AREA", "4", Obj_Incapacidades_DAL.sCOD_Area);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@NUM_INCAP", "4", Obj_Incapacidades_DAL.sNum_Incap);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@NOMBRE", "7", Obj_Incapacidades_DAL.sNombre);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@DIAS", "1", Obj_Incapacidades_DAL.iDias);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@MOTIVO", "7", Obj_Incapacidades_DAL.sMotivo);

        //    Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);
        //    Obj_Incapacidades_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //}
        //public void Eliminar_Incapacidades(ref cls_Incapacidades_DAL Obj_Incapacidades_DAL)
        //{
        //    cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        //    cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Eliminar_Incapacidades"].ToString();
        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_AREA", "5", Obj_Incapacidades_DAL.sCOD_Area);

        //    Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);
        //    Obj_BD_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //}
        //public void listar_filtrarDepartamentos(ref cls_Incapacidades_DAL Obj_Incapacidades_DAL)
        //{
        //    cls_Incapacidades_DAL Obj_Incapacidades = new cls_Incapacidades_DAL();
        //    cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        //    cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_departamentos"].ToString();

        //    Obj_BD_DAL.sNomTabla = "T_DEPARTAMENTOS";

        //    Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

        //    if (Obj_BD_DAL.sMsjError == string.Empty)
        //    {
        //        Obj_Incapacidades_DAL.sMsjError = string.Empty;
        //        Obj_Incapacidades_DAL.dtIncapacidades = Obj_BD_DAL.obj_ds.Tables[0];
        //    }
        //    else
        //    {
        //        Obj_BD_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //        Obj_Incapacidades_DAL.dtIncapacidades = null;
        //    }
        //}
    }
}
