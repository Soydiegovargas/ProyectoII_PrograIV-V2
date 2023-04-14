using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CATALOGOS;

namespace BLL.CATALOGOS
{
    public class cls_Especialidades_BLL
    {

        #region VARIABLES GLOBALES
        cls_Especialidades_DAL Obj_especialidades = new cls_Especialidades_DAL();
        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        #endregion

        #region Metodos
        public void listar_filtrar_especialidades(ref cls_Especialidades_DAL Obj_especidades_DAL)
        {


            if (Obj_especidades_DAL.sespecialidad == string.Empty)
            {
                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_especialidades"].ToString();

            }
            else
            {

                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["filtrar_especialidades"].ToString();
                Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@FILTRO", "5", Obj_especidades_DAL.sespecialidad);

            }

            Obj_BD_DAL.sNomTabla = "T_ESPECIALIDADES";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_especidades_DAL.sMsjError = string.Empty;
                Obj_especidades_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_especidades_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_especidades_DAL.dtDatos = null;
            }
        }

        public void listar_especialidades(ref cls_Especialidades_DAL Obj_especialidades_DAL)
        {



            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_especialidades"].ToString();

            Obj_BD_DAL.sNomTabla = "T_ESPECIALIDADES";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_especialidades_DAL.sMsjError = string.Empty;
                Obj_especialidades_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_especialidades.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_especialidades.dtDatos = null;
            }

        }

        public void listar_empleados(ref cls_Especialidades_DAL Obj_empleados_DAL)
        {

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_Empleados"].ToString();

            Obj_BD_DAL.sNomTabla = "T_EMPLEADOS";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_empleados_DAL.sMsjError = string.Empty;
                Obj_empleados_DAL.dtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_especialidades.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_especialidades.dtDatos = null;
            }

        }

        public void eliminar_especialidades(ref cls_Especialidades_DAL Obj_especialidades_DAL)
        {



            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["eliminar_especialidades"].ToString();
            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@ESPECIALIDAD", "4", Obj_especialidades_DAL.sespecialidad);

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            Obj_especialidades_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void insertar_especialidades(ref cls_Especialidades_DAL Obj_especialidad_DAL)
        {

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["insertar_especialidades"].ToString();

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

            Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_EMPLEADO", "7", Obj_especialidad_DAL.scedempleado);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@ESPECIALIDAD", "4", Obj_especialidad_DAL.sespecialidad);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@DEPARTAMENTO", "4", Obj_especialidad_DAL.sdepartamento);

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            Obj_especialidad_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void modificar_especialidades(ref cls_Especialidades_DAL Obj_especialidad_DAL)
        {

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["modificar_especialidades"].ToString();

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

            Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_EMPLEADO", "7", Obj_especialidad_DAL.scedempleado);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@ESPECIALIDAD", "4", Obj_especialidad_DAL.sespecialidad);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@DEPARTAMENTO", "4", Obj_especialidad_DAL.sdepartamento);

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            Obj_especialidad_DAL.sMsjError = Obj_BD_DAL.sMsjError;


        }
        #endregion
    }
}
