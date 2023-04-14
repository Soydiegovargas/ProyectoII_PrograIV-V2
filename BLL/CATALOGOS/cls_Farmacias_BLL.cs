using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CATALOGOS;

namespace BLL.CATALOGOS
{
    public class cls_Farmacias_BLL
    {

        public void listar_filtrarFarmacia(ref cls_Farmacias_DAL Obj_Farmacia_DAL)
        {
            cls_Farmacias_DAL Obj_Farmacia = new cls_Farmacias_DAL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            if (Obj_Farmacia_DAL.sNombreFarmacia == string.Empty)
            {
                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Listar_Farmacia"].ToString();
            }
            else
            {
                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Filtrar_Farmacia"].ToString();
                Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Filtro", "5", Obj_Farmacia_DAL.sNombreFarmacia);
            }

            Obj_BD_DAL.sNomTabla = "T_FARMACIAS";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Farmacia_DAL.sMsjError = string.Empty;
                Obj_Farmacia_DAL.dtFarmacia = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_BD_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Farmacia_DAL.dtFarmacia = null;
            }
        }

        public void insertar_Farmacia(ref cls_Farmacias_DAL Obj_Farmacia_DAL)
        {
            cls_Farmacias_DAL Obj_Nuevo_Farmacia = new cls_Farmacias_DAL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();


            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Insertar_Farmacia"].ToString();
            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_FARMACIA", "7", Obj_Farmacia_DAL.sCOD_Farmacia);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Farmacia_DAL.sCOD_Centro);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@NOMBRE", "7", Obj_Farmacia_DAL.sNombreFarmacia);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@MEDICAMENTOS", "7", Obj_Farmacia_DAL.sMedicamentos);



            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            Obj_Farmacia_DAL.sMsjError = Obj_BD_DAL.sMsjError;

        }

        public void modificar_Farmacia(ref cls_Farmacias_DAL Obj_Farmacia_DAL)
        {
            cls_Farmacias_DAL Obj_Farmacia = new cls_Farmacias_DAL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();


            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Modificar_farmacia"].ToString();
            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_FARMACIA", "7", Obj_Farmacia_DAL.sCOD_Farmacia);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Farmacia_DAL.sCOD_Centro);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@NOMBRE", "7", Obj_Farmacia_DAL.sNombreFarmacia);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@MEDICAMENTOS", "7", Obj_Farmacia_DAL.sMedicamentos);


            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);
            Obj_Farmacia_DAL.sMsjError = Obj_BD_DAL.sMsjError;

        }

        public void Eliminar_Farmacia(ref cls_Farmacias_DAL Obj_Farmacia_DAL)
        {

            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();


            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["Eliminar_Farmacia"].ToString();
            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@COD_FARMACIA", "7", Obj_Farmacia_DAL.sCOD_Farmacia);

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);
            Obj_BD_DAL.sMsjError = Obj_BD_DAL.sMsjError;


        }

        public void listar_filtrarCentros(ref cls_Farmacias_DAL Obj_Farmacia_DAL)
        {
            cls_Farmacias_DAL Obj_Territorios = new cls_Farmacias_DAL();
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();


            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_centros"].ToString();


            Obj_BD_DAL.sNomTabla = "T_CENTROS";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Farmacia_DAL.sMsjError = string.Empty;
                Obj_Farmacia_DAL.dtFarmacia = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_BD_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Farmacia_DAL.dtFarmacia = null;
            }

        }
    }
}
