using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CATALOGOS;
using System.Configuration;


namespace BLL.CATALOGOS
{
    public class cls_Especialidades_BLL
    {
        public void listar_filtrar_especialidades(ref cls_Especialidades_DAL Obj_especidades_DAL)//
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_especidades_DAL.sCodCentro == string.Empty) // Para Listar si esta vacio
            {
                Obj_especidades_DAL.dtParametros = null;
                Obj_especidades_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_ESPECIALIDADES", "listar_CENTROS", Obj_especidades_DAL.dtParametros);
            }
            else // Para filtrar
            {
                Obj_especidades_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_especidades_DAL.dtParametros);
                Obj_especidades_DAL.dtParametros.Rows.Add("@Filtro", "5", Obj_especidades_DAL.sCodCentro);
                Obj_especidades_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_ESPECIALIDADES", ConfigurationManager.AppSettings["filtrar_especialidades"], Obj_especidades_DAL.dtParametros);
            }
        }

        public void listar_especialidades(ref cls_Especialidades_DAL Obj_especialidades_DAL)//
        {

            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_especialidades_DAL.sNombre == string.Empty) // Para Listar si esta vacio
            {
                Obj_especialidades_DAL.dtparametros = null;
                Obj_especialidades_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_ESPECIALIDADES", "listar_especialidades", Obj_especialidades_DAL.dtparametros);
            }
        }

        public void listar_empleados(ref cls_Especialidades_DAL Obj_empleados_DAL)//
        {

            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_empleados_DAL.sNombre == string.Empty) // Para Listar si esta vacio
            {
                Obj_empleados_DAL.dtparametros = null;
                Obj_empleados_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_ESPECIALIDADES", "listar_Empleados", Obj_empleados_DAL.dtparametros);
            }
        }

        public void eliminar_especialidades(ref cls_Especialidades_DAL Obj_especialidades_DAL)//
        {

            WCF.BDClient Obj_WCF = new BDClient();

            Obj_especialidades_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_especialidades_DAL.dtParametros);

            Obj_especialidades_DAL.dtParametros.Rows.Add("@ESPECIALIDAD", "7", Obj_especialidades_DAL.sCodCentro);

            Obj_especialidades_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["eliminar_especialidades"], "NORMAL", Obj_especialidades_DAL.dtParametros);

        }

        public void insertar_especialidades(ref cls_Especialidades_DAL Obj_especialidad_DAL) //
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_especialidad_DAL.dtparametros = Obj_WCF.Get_DT_Param(Obj_especialidad_DAL.dtParametros);

            Obj_especialidad_DAL.dtparametros.Rows.Add("@CED_EMPLEADO", "7", Obj_especialidad_DAL.scedempleado);
            Obj_especialidad_DAL.dtparametros.Rows.Add("@ESPECIALIDAD", "4", Obj_especialidad_DAL.sespecialidad);
            Obj_especialidad_DAL.dtparametros.Rows.Add("@DEPARTAMENTO", "4", Obj_especialidad_DAL.sdepartamento);


            Obj_especialidad_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["insertar_especialidades"], "IDENTITY", Obj_especialidad_DAL.dtparametros);


        }

        public void modificar_especialidades(ref cls_Especialidades_DAL Obj_especialidad_DAL)//
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_especialidad_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_especialidad_DAL.dtParametros);


            Obj_especialidad_DAL.dtParametros.Rows.Add("@CED_EMPLEADO", "7", Obj_especialidad_DAL.scedempleado);
            Obj_especialidad_DAL.dtParametros.Rows.Add("@ESPECIALIDAD", "4", Obj_especialidad_DAL.sespecialidad);
            Obj_especialidad_DAL.dtParametros.Rows.Add("@DEPARTAMENTO", "4", Obj_especialidad_DAL.sdepartamento);


            Obj_especialidad_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["modificar_especialidades"], "NORMAL", Obj_especialidad_DAL.dtParametros);


        }
       
    }
}
