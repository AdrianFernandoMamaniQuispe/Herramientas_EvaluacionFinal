using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionFinal
{
    public class clsCliente
    {
        public List<OBTENER_CLIENTES_Result> obtenerCliente(string nombreP)
        {
            try
            {
                using (HERRAMIENTAS_EX_FINALEntities bd = new HERRAMIENTAS_EX_FINALEntities())
                {
                    var consulta = bd.OBTENER_CLIENTES(null, nombreP).ToList();
                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsertarCliente(string dni, string nombre, string direccion, string telefono)
        {
            try
            {

                using (HERRAMIENTAS_EX_FINALEntities bd = new HERRAMIENTAS_EX_FINALEntities())
                {
                    bd.INSERTAR_CLIENTE(dni, nombre, direccion, telefono);
                    bd.SaveChanges();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void modificarCliente(string dni, string nombre, string direccion, string telefono)
        {
            try
            {
                using (HERRAMIENTAS_EX_FINALEntities bd = new HERRAMIENTAS_EX_FINALEntities())
                {
                    bd.MODIFICAR_CLIENTE(dni, nombre, direccion, telefono);
                    bd.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void eliminarCliente(string dni)
        {
            using (HERRAMIENTAS_EX_FINALEntities bd = new HERRAMIENTAS_EX_FINALEntities())//instaciar la base de datos
            {
                Cliente cli = bd.Cliente.Find(dni);

                bd.Cliente.Remove(cli);
                bd.SaveChanges();
            }
        }

    }
}
