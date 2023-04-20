using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CATALOGOS;

namespace BLL.CATALOGOS
{
    public class cls_Empleados_BLL
    {

        //public void insertar_Empleados(ref cls_Empleados_DAL Obj_NuevoEmpleado_DAL)
        //{
        //    //cls_Empleados_DAL Obj_Empleados = new cls_Empleados_DAL();
        //    cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //    cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["insertar_Empleados"].ToString();

        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_EMPLEADO", "7", Obj_NuevoEmpleado_DAL.sCed_Empleado); //Mando los parámetros del Store Procedure
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@NOMBRE", "7", Obj_NuevoEmpleado_DAL.sNombre); //Mando los parámetros del Store Procedure
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@TELEFONO", "4", Obj_NuevoEmpleado_DAL.iTelefono); //Mando los parámetros del Store Procedure
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@DIRECCION", "7", Obj_NuevoEmpleado_DAL.sDireccion);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_JUNTA", "7", Obj_NuevoEmpleado_DAL.sCod_Junta);

        //    Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);
        //    Obj_NuevoEmpleado_DAL.sMsgError = Obj_BD_DAL.sMsjError;

        //}

        //public void modificar_Empleados(ref cls_Empleados_DAL Obj_Emp_DAL)
        //{

        //    cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //    cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["modificar_Empleados"].ToString();

        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable

        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_EMPLEADO", "7", Obj_Emp_DAL.sCed_Empleado); //Mando los parámetros del Store Procedure
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@NOMBRE", "7", Obj_Emp_DAL.sNombre); //Mando los parámetros del Store Procedure
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@TELEFONO", "4", Obj_Emp_DAL.iTelefono); //Mando los parámetros del Store Procedure
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@DIRECCION", "7", Obj_Emp_DAL.sDireccion);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_JUNTA", "7", Obj_Emp_DAL.sCod_Junta);

        //    Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);
        //    Obj_Emp_DAL.sMsgError = Obj_BD_DAL.sMsjError;

        //}

        //public void eliminar_Empleados(ref cls_Empleados_DAL Obj_Empleados_DAL)
        //{
        //    cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //    cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();


        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["eliminar_Empleados"].ToString();
        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable porque se tiene que recibir un parámetro 
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_EMPLEADO", "7", Obj_Empleados_DAL.sCed_Empleado); //Mando los parámetros del Store Procedure

        //    Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //    Obj_Empleados_DAL.sMsgError = Obj_BD_DAL.sMsjError;

        //}

        //public void listar_Empleados(ref cls_Empleados_DAL Obj_Empleados_DAL)
        //{
        //    cls_Empleados_DAL Obj_Empleados = new cls_Empleados_DAL();
        //    cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //    cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        //    if (Obj_Empleados_DAL.sNombre == string.Empty)
        //    {

        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_Empleados"].ToString();
        //    }
        //    else
        //    {
        //        Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["filtrar_Empleados"].ToString();
        //        Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL); //Crea el Datatable
        //        Obj_BD_DAL.obj_dtParametros.Rows.Add("@Filtro", "5", Obj_Empleados_DAL.sNombre);
        //    }

        //    Obj_BD_DAL.sNomTabla = "T_EMPLEADOS";

        //    Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

        //    if (Obj_BD_DAL.sMsjError == string.Empty)
        //    {
        //        Obj_Empleados_DAL.sMsgError = string.Empty;
        //        Obj_Empleados_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
        //    }
        //    else
        //    {
        //        Obj_Empleados.sMsgError = Obj_BD_DAL.sMsjError;
        //        Obj_Empleados.dtDatos = null;
        //    }

        //}

        //public void listar_filtrar_Juntas(ref cls_Empleados_DAL Obj_Juntas_DAL)

        //{
        //    cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        //    cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_Juntas"].ToString();


        //    Obj_BD_DAL.sNomTabla = "T_JUNTAS";

        //    Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

        //    if (Obj_BD_DAL.sMsjError == string.Empty)
        //    {
        //        Obj_Juntas_DAL.sMsgError = string.Empty;
        //        Obj_Juntas_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
        //    }
        //    else
        //    {
        //        Obj_Juntas_DAL.sMsgError = Obj_BD_DAL.sMsjError;
        //        Obj_Juntas_DAL.dtDatos = null;
        //    }

        //}
    }
}
