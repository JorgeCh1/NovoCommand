
using MySql.Data.MySqlClient;

namespace Datos
{
    /*public class BajaStockCommand : OrdenCommand
    {
        // Constructor para realizar la agregación
        public BajaStockCommand(ProductoReceiver producto, double cantidad) : base(producto, cantidad)
        {
        }

        public override void Ejecutar()
        {
            _producto.RestarStock(_cantidad);
        }        
    }*/

    public class BajaStockDbCommand : DbCommand
    {
        public BajaStockDbCommand(ProductoReceiver producto, double cantidad, MySqlConnection connection) : base(producto, cantidad, connection)
        {
        }

        public override void Ejecutar()
        {
            //base.Ejecutar();
            EjecutarConsulta();
        }

        public override void EjecutarConsulta()
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;
            command.CommandText = "UPDATE stock SET cantidad = cantidad - @cantidad WHERE producto = @producto";
            command.Parameters.AddWithValue("@producto", _producto.Nombre);
            command.Parameters.AddWithValue("@cantidad", _cantidad);
            command.ExecuteNonQuery();
        }
    }
}