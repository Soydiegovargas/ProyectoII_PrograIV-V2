using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.WCF;
using DAL.CATALOGOS;
using System.Configuration;


namespace BLL.CATALOGOS
{
    public class cls_Farmacias_BLL
    {

        public void listar_filtrarFarmacia(ref cls_Farmacias_DAL Obj_Farmacia_DAL) //LISTO
        {

            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Farmacia_DAL.sNombreFarmacia == string.Empty) //para listar
            {
                Obj_Farmacia_DAL.dtParametros = null;
                Obj_Farmacia_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_FARMACIAS", "Listar_Farmacia", Obj_Farmacia_DAL.dtParametros);
            }
            else // Para Filtrar
            {
                Obj_Farmacia_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Farmacia_DAL.dtParametros);
                Obj_Farmacia_DAL.dtParametros.Rows.Add("@FILTRO", "7", Obj_Farmacia_DAL.sNombreFarmacia);
                Obj_Farmacia_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_FARMACIAS", "Filtrar_Farmacia", Obj_Farmacia_DAL.dtParametros);
            }
        }
        public void insertar_Farmacia(ref cls_Farmacias_DAL Obj_Farmacia_DAL) //LISTO
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Farmacia_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Farmacia_DAL.dtParametros);

            Obj_Farmacia_DAL.dtParametros.Rows.Add("@COD_FARMACIA", "7", Obj_Farmacia_DAL.sCOD_Farmacia);
            Obj_Farmacia_DAL.dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Farmacia_DAL.sCOD_Centro);
            Obj_Farmacia_DAL.dtParametros.Rows.Add("@NOMBRE", "7", Obj_Farmacia_DAL.sNombreFarmacia);
            Obj_Farmacia_DAL.dtParametros.Rows.Add("@MEDICAMENTOS", "7", Obj_Farmacia_DAL.sMedicamentos);

            Obj_Farmacia_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Insertar_Farmacia"], "NORMAL", Obj_Farmacia_DAL.dtParametros);

        }
        public void modificar_Farmacia(ref cls_Farmacias_DAL Obj_Farmacia_DAL) //LISTO
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Farmacia_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Farmacia_DAL.dtParametros);

            Obj_Farmacia_DAL.dtParametros.Rows.Add("@COD_FARMACIA", "7", Obj_Farmacia_DAL.sCOD_Farmacia);
            Obj_Farmacia_DAL.dtParametros.Rows.Add("@COD_CENTRO", "7", Obj_Farmacia_DAL.sCOD_Centro);
            Obj_Farmacia_DAL.dtParametros.Rows.Add("@NOMBRE", "7", Obj_Farmacia_DAL.sNombreFarmacia);
            Obj_Farmacia_DAL.dtParametros.Rows.Add("@MEDICAMENTOS", "7", Obj_Farmacia_DAL.sMedicamentos);

            Obj_Farmacia_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Modificar_Farmacia"], "NORMAL", Obj_Farmacia_DAL.dtParametros);

        }
        public void Eliminar_Farmacia(ref cls_Farmacias_DAL Obj_Farmacia_DAL) //LISTO
        {

            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Farmacia_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Farmacia_DAL.dtParametros);

            Obj_Farmacia_DAL.dtParametros.Rows.Add("@COD_FARMACIA", "7", Obj_Farmacia_DAL.sCOD_Farmacia);

            Obj_Farmacia_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["Eliminar_Farmacia"], "NORMAL", Obj_Farmacia_DAL.dtParametros);


        }
        public void listar_filtrar_Centros(ref cls_Centros_DAL Obj_Centro_DAL) //LISTO

        {
            WCF.BDClient Obj_WCF = new BDClient(); //se crea el objeto de manejo de la BD

            if (Obj_Centro_DAL.sNombreC == string.Empty) //Si el campo para el nombre de Centro está vacio
            {
                Obj_Centro_DAL.dtParametros = null; //No habran parámetros
                Obj_Centro_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CENTROS", ConfigurationManager.AppSettings["listar_CENTROS"], null); //Se manda a ejecutar sin parámetros para filtrar todo
            }
            else
            {
                Obj_Centro_DAL.dtParametros = Obj_WCF.Get_DT_Param(Obj_Centro_DAL.dtParametros);
                Obj_Centro_DAL.dtParametros.Rows.Add("@FILTRO", "7", Obj_Centro_DAL.sCodCentro);
                Obj_Centro_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_CENTROS", ConfigurationManager.AppSettings["Filtrar_CENTROS"], Obj_Centro_DAL.dtParametros); //Se filtra por los parametros
            }
        }
    }
}