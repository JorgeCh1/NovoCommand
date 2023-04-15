
using MySql.Data.MySqlClient;

namespace Datos
{
    /*public class AltaStockCommand : OrdenCommand
    {
        // Constructor para realiazar la agregación
        public AltaStockCommand(ProductoReceiver producto, double cantidad) : base(producto, cantidad)
        {
        }

        public override void Ejecutar()
        {
            _producto.SumarStock(_cantidad);
        }
    }*/
    public class AltaStockDbCommand : DbCommand
    {
        public AltaStockDbCommand(ProductoReceiver producto, double cantidad, MySqlConnection connection) : base(producto, cantidad, connection)
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
            command.CommandText = "INSERT INTO stock (producto, cantidad) VALUES (@producto, @cantidad)";
            command.Parameters.AddWithValue("@producto", _producto.Nombre);
            command.Parameters.AddWithValue("@cantidad", _cantidad);
            command.ExecuteNonQuery();
        }
    }
}