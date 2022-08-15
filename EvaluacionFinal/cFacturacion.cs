using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionFinal
{
    public class cFacturacion
    {
        /*public void insertardfactura(DetalleFactura factura)
        {
            try
            {
                using (HERRAMIENTAS_EX_FINALEntities1 bd = new HERRAMIENTAS_EX_FINALEntities1())
                {
                    bd.DetalleFactura.Add(factura);
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<DFACTURAS1_Result> visualizar(int numFacturaCompra)
        {
            try
            {
                using (HERRAMIENTAS_FINALEntities2 bd = new HERRAMIENTAS_FINALEntities2())
                {
                    var consulta = bd.DFACTURAS1(null).ToList();

                    if (numFacturaCompra > 0)
                    {
                        consulta = bd.DFACTURAS1(numFacturaCompra).ToList();
                    }
                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*public string obtenerNombreCliente(string cdc)
        {
            string cliente = "";
            using (HERRAMIENTAS_EX_FINALEntities1 bd = new HERRAMIENTAS_EX_FINALEntities1())
            {
                var consulta = from d in bd.Cliente where d.DNI == cdc select d;
                foreach (Cliente d in consulta)
                {
                    cliente = d.NOMBRE;
                }
            }
            return cliente;
        }
        public string obtenerprecio(string pp)
        {
            double precio = 0;
            using (HERRAMIENTAS_EX_FINALEntities1 bd = new HERRAMIENTAS_EX_FINALEntities1())
            {
                var consulta = from d in bd.Producto where d.Descripcion == pp select d;
                foreach (Producto d in consulta)
                {
                    precio = (double)d.Precio;
                }
            }
            return precio.ToString();
        }*/
    }
}
