
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Datos
{

    public class BajaStockDbCommand : DbCommand
    {
        public BajaStockDbCommand(ProductoReceiver producto, double cantidad, SqlConnection connection) : base(producto, cantidad, connection)
        {
        }

        public override void Ejecutar()
        {
            EjecutarConsulta();
        }

        public override void EjecutarConsulta()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = _connection;
            command.CommandText = "UPDATE computadora SET Marca = @Marca, Modelo = @Modelo, Procesador = @Procesador, MemoriaRam = @MemoriaRam, Almacenamiento = @Almacenamiento, SistemaOperativo = @SistemaOperativo, Cantidad = @Cantidad, AltaStock = @AltaStock, BajaStock = @BajaStock WHERE Id = @Id";
            command.Parameters.AddWithValue("@Marca", _producto.Marca);
            command.Parameters.AddWithValue("@Modelo", _producto.Modelo);
            command.Parameters.AddWithValue("@Procesador", _producto.Procesador);
            command.Parameters.AddWithValue("@MemoriaRam", _producto.MemoriaRam);
            command.Parameters.AddWithValue("@Almacenamiento", _producto.Almacenamiento);
            command.Parameters.AddWithValue("@SistemaOperativo", _producto.SistemaOperativo);
            command.Parameters.AddWithValue("@Cantidad", _producto.Cantidad);
            command.Parameters.AddWithValue("@AltaStock", _producto.AltaStock);
            command.Parameters.AddWithValue("@BajaStock", _producto.BajaStock);
            command.Parameters.AddWithValue("@Id", _producto.Id);
            command.ExecuteNonQuery();
        }
    }
}