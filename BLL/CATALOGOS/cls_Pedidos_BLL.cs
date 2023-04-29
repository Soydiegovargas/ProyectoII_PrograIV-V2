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
    public class cls_Pedidos_BLL
    {
        public void listar_filtrar_Pedidos(ref cls_Pedidos_DAL Obj_Pedidos_DAL)
        {
           WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Pedidos_DAL.scodpedido == string.Empty)
            {
                Obj_Pedidos_DAL.dtparametros = null;
                Obj_Pedidos_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_PEDIDOS", "listar_Pedidos", Obj_Pedidos_DAL.dtparametros);



            }
            else
            {


                Obj_Pedidos_DAL.dtparametros = Obj_WCF.Get_DT_Param(Obj_Pedidos_DAL.dtparametros);
                Obj_Pedidos_DAL.dtparametros.Rows.Add("@Filtro", "7", Obj_Pedidos_DAL.scodpedido);
                Obj_Pedidos_DAL.dtDatos = Obj_WCF.ListarFiltrar("T_PEDIDOS", ConfigurationManager.AppSettings["filtrar_Pedidos"], Obj_Pedidos_DAL.dtparametros);



            }


        }
        public void insertar_Pedidos(ref cls_Pedidos_DAL Obj_pedidos_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_pedidos_DAL.dtparametros = Obj_WCF.Get_DT_Param(Obj_pedidos_DAL.dtparametros);



            Obj_pedidos_DAL.dtparametros.Rows.Add("@COD_PEDIDO", "7", Obj_pedidos_DAL.scodpedido);
            Obj_pedidos_DAL.dtparametros.Rows.Add("@COD_FARMACIA", "7", Obj_pedidos_DAL.scodfarmacia);
            Obj_pedidos_DAL.dtparametros.Rows.Add("@MEDICAMENTOS", "7", Obj_pedidos_DAL.sMedicamnetos);


            Obj_pedidos_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["insertar_Pedidos"], "IDENTITY", Obj_pedidos_DAL.dtparametros);
        }



        public void eliminar_Pedidos(ref cls_Pedidos_DAL Obj_pedidos_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_pedidos_DAL.dtparametros = Obj_WCF.Get_DT_Param(Obj_pedidos_DAL.dtparametros);

            Obj_pedidos_DAL.dtparametros.Rows.Add("@COD_FARMACIA", "7", Obj_pedidos_DAL.scodfarmacia);

            Obj_pedidos_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["eliminar_Pedidos"], "NORMAL", Obj_pedidos_DAL.dtparametros);
        }
    

    public void modificar_Pedidos(ref cls_Pedidos_DAL Obj_pedidos_DAL)
    {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_pedidos_DAL.dtparametros = Obj_WCF.Get_DT_Param(Obj_pedidos_DAL.dtparametros);



            Obj_pedidos_DAL.dtparametros.Rows.Add("@COD_PEDIDO", "7", Obj_pedidos_DAL.scodpedido);
            Obj_pedidos_DAL.dtparametros.Rows.Add("@COD_FARMACIA", "7", Obj_pedidos_DAL.scodfarmacia);
            Obj_pedidos_DAL.dtparametros.Rows.Add("@MEDICAMENTOS", "7", Obj_pedidos_DAL.sMedicamnetos);


            Obj_pedidos_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["insertar_Pedidos"], "NORMAL", Obj_pedidos_DAL.dtparametros);
        }

    }
}



