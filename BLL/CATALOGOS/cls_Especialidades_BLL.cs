using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CATALOGOS;
using System.Configuration;
using BLL.WCF;


namespace BLL.CATALOGOS
{
    public class cls_Especialidades_BLL
    {
        public void listar_filtrar_especialidades(ref cls_Especialidades_DAL Obj_especidades_DAL)//listo
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_especidades_DAL.sdepartamento == string.Empty) // Para Listar si esta vacio
            {
                Obj_especidades_DAL.dtParametros = null;
                Obj_especidades_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_ESPECIALIDADES", ConfigurationManager.AppSettings["listar_especialidades"], Obj_especidades_DAL.dtParametros);
            }
            else // Para filtrar
            {
                Obj_especidades_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_especidades_DAL.dtParametros);
                Obj_especidades_DAL.dtParametros.Rows.Add("@Filtro", "5", Obj_especidades_DAL.sdepartamento);
                Obj_especidades_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_ESPECIALIDADES", ConfigurationManager.AppSettings["filtrar_especialidades"], Obj_especidades_DAL.dtParametros);
            }
        }
        public void eliminar_especialidades(ref cls_Especialidades_DAL Obj_especialidades_DAL)//listo
        {

            WCF.BDClient Obj_WCF = new BDClient();

            Obj_especialidades_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_especialidades_DAL.dtParametros);

            Obj_especialidades_DAL.dtParametros.Rows.Add("@ESPECIALIDAD", "7", Obj_especialidades_DAL.sespecialidad);

            Obj_especialidades_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["eliminar_especialidades"], "NORMAL", Obj_especialidades_DAL.dtParametros);

        }
        public void insertar_especialidades(ref cls_Especialidades_DAL Obj_especialidad_DAL) //LISTO
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_especialidad_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_especialidad_DAL.dtParametros);

            Obj_especialidad_DAL.dtParametros.Rows.Add("@CED_EMPLEADO", "7", Obj_especialidad_DAL.scedempleado);
            Obj_especialidad_DAL.dtParametros.Rows.Add("@ESPECIALIDAD", "4", Obj_especialidad_DAL.sespecialidad);
            Obj_especialidad_DAL.dtParametros.Rows.Add("@DEPARTAMENTO", "4", Obj_especialidad_DAL.sdepartamento);


            Obj_especialidad_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["insertar_especialidades"], "IDENTITY", Obj_especialidad_DAL.dtParametros);


        }
        public void modificar_especialidades(ref cls_Especialidades_DAL Obj_especialidad_DAL)//listo
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_especialidad_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_especialidad_DAL.dtParametros);


            Obj_especialidad_DAL.dtParametros.Rows.Add("@CED_EMPLEADO", "7", Obj_especialidad_DAL.scedempleado);
            Obj_especialidad_DAL.dtParametros.Rows.Add("@ESPECIALIDAD", "4", Obj_especialidad_DAL.sespecialidad);
            Obj_especialidad_DAL.dtParametros.Rows.Add("@DEPARTAMENTO", "4", Obj_especialidad_DAL.sdepartamento);


            Obj_especialidad_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["modificar_especialidades"], "NORMAL", Obj_especialidad_DAL.dtParametros);


        }
        public void listar_filtrar_Empleados(ref cls_Empleados_DAL Obj_Empleados_DAL) //listo
        {
            WCF.BDClient Obj_WCF = new BDClient(); // se crea el objeto de manejo de la BD

            if (Obj_Empleados_DAL.sNombre == string.Empty) //Si el campo para el nombre de Centro está vacio
            {
                Obj_Empleados_DAL.dtParametros = null; //No habran parámetros
                Obj_Empleados_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_EMPLEADOS", ConfigurationManager.AppSettings["listar_Empleados"], null); //Se manda a ejecutar sin parámetros para filtrar todo
            }
            else
            {
                Obj_Empleados_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Empleados_DAL.dtParametros);
                Obj_Empleados_DAL.dtParametros.Rows.Add("@Filtro", "5", Obj_Empleados_DAL.sNombre);
                Obj_Empleados_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_EMPLEADOS", ConfigurationManager.AppSettings["modificar_Empleados"], Obj_Empleados_DAL.dtParametros); //Se filtra por los parametros
            }

        }

    }
}
