using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CATALOGOS;
using BLL.WCF;
using System.Configuration;

namespace BLL.CATALOGOS
{
    public class cls_Empleados_BLL
    {
        public void insertar_Empleados(ref cls_Empleados_DAL Obj_NuevoEmpleado_DAL)
        {


            WCF.BDClient Obj_WCF = new BDClient();

            Obj_NuevoEmpleado_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_NuevoEmpleado_DAL.dtParametros);

            Obj_NuevoEmpleado_DAL.dtParametros.Rows.Add("@CED_EMPLEADO", "7", Obj_NuevoEmpleado_DAL.sCed_Empleado);
            Obj_NuevoEmpleado_DAL.dtParametros.Rows.Add("@NOMBRE", "7", Obj_NuevoEmpleado_DAL.sNombre);
            Obj_NuevoEmpleado_DAL.dtParametros.Rows.Add("@TELEFONO", "4", Obj_NuevoEmpleado_DAL.iTelefono);
            Obj_NuevoEmpleado_DAL.dtParametros.Rows.Add("@DIRECCION", "7", Obj_NuevoEmpleado_DAL.sDireccion);
            Obj_NuevoEmpleado_DAL.dtParametros.Rows.Add("@COD_JUNTA", "7", Obj_NuevoEmpleado_DAL.sCod_Junta);

            Obj_NuevoEmpleado_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["insertar_Empleados"], "NORMAL", Obj_NuevoEmpleado_DAL.dtParametros);
            //Parametro "NORMAL" se usa solo para un UPDATE o un DELETE. Para un INSERT se usa algo diferente de "NORMAL",, puede ir vacio o nulo,o mejor aun poner IDENTITY
        }
        public void modificar_Empleados(ref cls_Empleados_DAL Obj_Emp_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();
            Obj_Emp_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Emp_DAL.dtParametros);

            Obj_Emp_DAL.dtParametros.Rows.Add("@CED_EMPLEADO", "7", Obj_Emp_DAL.sCed_Empleado);
            Obj_Emp_DAL.dtParametros.Rows.Add("@NOMBRE", "7", Obj_Emp_DAL.sNombre);
            Obj_Emp_DAL.dtParametros.Rows.Add("@TELEFONO", "1", Obj_Emp_DAL.iTelefono);
            Obj_Emp_DAL.dtParametros.Rows.Add("@DIRECCION", "7", Obj_Emp_DAL.sDireccion);
            Obj_Emp_DAL.dtParametros.Rows.Add("@COD_JUNTA", "7",Obj_Emp_DAL.sCod_Junta);

            Obj_Emp_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["modificar_Empleados"], "NORMAL", Obj_Emp_DAL.dtParametros);
            //Parametro "NORMAL" se usa solo para un UPDATE o un DELETE. Para un INSERT se usa algo diferente de "NORMAL",, puede ir vacio o nulo,o mejor aun poner IDENTITY

        }
        public void eliminar_Empleados(ref cls_Empleados_DAL Obj_Empleados_DAL)
        {


            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Empleados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Empleados_DAL.dtParametros);

            Obj_Empleados_DAL.dtParametros.Rows.Add("@CED_EMPLEADO", "7", Obj_Empleados_DAL.sCed_Empleado);

            Obj_Empleados_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["eliminar_Empleados"], "NORMAL", Obj_Empleados_DAL.dtParametros);

        }
        public void listar_filtrar_Empleados(ref cls_Empleados_DAL Obj_Empleados_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient(); // se crea el objeto de manejo de la BD

            if (Obj_Empleados_DAL.sCod_Junta == string.Empty) //Si el campo para el nombre de Centro está vacio
            {
                
                Obj_Empleados_DAL.dtParametros = null; //No habran parámetros
                Obj_Empleados_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_EMPLEADOS", ConfigurationManager.AppSettings["listar_Empleados"], null); //Se manda a ejecutar sin parámetros para filtrar todo
            }
            else
            {
                Obj_Empleados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Empleados_DAL.dtParametros);
                Obj_Empleados_DAL.dtParametros.Rows.Add("@Filtro", "7", Obj_Empleados_DAL.sCod_Junta);
                Obj_Empleados_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_EMPLEADOS", ConfigurationManager.AppSettings["filtrar_Empleados"], Obj_Empleados_DAL.dtParametros); //Se filtra por los parametros
            }

        }
      
    }
}
