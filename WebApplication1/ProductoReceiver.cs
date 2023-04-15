using System;

namespace Datos
{
    public class ProductoReceiver
    {
        // Producto
        public double Cantidad { get; set; }
        public string Nombre { get; set; }

        // Operaciones propias del producto

        public void RestarStock(double cant)
        {
            Cantidad = Cantidad - cant;
            //Console.WriteLine(string.Format("Quitando {0} unidades", cant));
        }

        public void SumarStock(double cant)
        {
            Cantidad = Cantidad + cant;
            //Console.WriteLine(string.Format("Agregando {0} unidades", cant));
        }
    }
}