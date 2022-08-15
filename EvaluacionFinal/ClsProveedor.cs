using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionFinal
{
    internal class ClsProveedor
    {




        //============================== FUNCIÓN LISTAR PROVEEDORES ================================================
        public List<Proveedor> ListarProveedores()
        {
            using (ExamenFinalEntities bd = new ExamenFinalEntities())
            {
                return bd.Proveedor.ToList();
            }
        }
        //=======================================================================================================================



        //============================== FUNCIÓN AGREGAR PROVEEDORES ================================================
        public void ingresarProveedor(string PCod, string PDato, string PDireccion)
        {
            using (ExamenFinalEntities bd = new ExamenFinalEntities())
            {
                //================================== INSTANCIAMOS datosDelivery DEL TIPO Delivery ================================
                Proveedor datoProveedor = new Proveedor();
                //datosEDelivery.id_delivey = idDelivery;
                datoProveedor.CODP = PCod;
                datoProveedor.DATPRO = PDato;
                datoProveedor.DIRPRO = PDireccion;
                //========================= ENVIAMOS LOS DATOS A LA BASE DE DATOS > DELIVERY, LOS DATOS GUARDADOS EN datosDelivery======
                bd.Proveedor.Add(datoProveedor);
                bd.SaveChanges();
            }
        }
        //=======================================================================================================================



        //============================================== FUNCIÓN MODIFICAR PROVEEDORES ================================================
        public void modificarProveedor(string PCod, string PDato, string PDireccion)
        {
            using (ExamenFinalEntities bd = new ExamenFinalEntities())
            {
                //====================================== INSTANCIAMOS datoProveedor DEL TIPO Proveedor ================================
                Proveedor datoProveedor = new Proveedor();
                //datosEDelivery.id_delivey = idDelivery;
                datoProveedor.CODP = PCod;
                datoProveedor.DATPRO = PDato;
                datoProveedor.DIRPRO = PDireccion;
                //========== ENVIAMOS LOS DATOS MODIFICADOS A LA BASE DE DATOS -> PROVEEDOR, LOS DATOS GUARDADOS EN datoProveedor======
                bd.Entry(datoProveedor).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
        }
        //==============================================================================================================================



        public void eliminar(string Pcod)
        {
            using (ExamenFinalEntities bd = new ExamenFinalEntities())
            {
                Proveedor pre = bd.Proveedor.Find(Pcod);
                bd.Proveedor.Remove(pre);
                bd.SaveChanges();
            }
        }




        public int validarCodigoProveedorRelaciado(string codp)
        {
            int relacionado;
            using (ExamenFinalEntities bd = new ExamenFinalEntities())
            {
                var lst = from FC in bd.FacturaCompra
                          where FC.CODP == codp
                          select new
                          {
                              FC.CODP,
                          };
                relacionado = lst.Count();
            }
            return relacionado;
        }





        public int validarCodigoProveedorRepetido(string codp)
        {
            int repetido;
            using (ExamenFinalEntities bd = new ExamenFinalEntities())
            {
                var lst = from P in bd.Proveedor
                          where P.CODP == codp
                          select new
                          {
                              P.CODP,
                          };
                repetido = lst.Count();
            }
            return repetido;
        }




    }
}
