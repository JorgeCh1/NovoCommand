using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Datos
{
    public abstract class DbCommand : OrdenCommand
    {
        protected MySqlConnection _connection;

        public DbCommand(ProductoReceiver producto, double cantidad, MySqlConnection connection) : base(producto, cantidad)
        {
            _connection = connection;
        }

        public abstract void EjecutarConsulta();
    }

}