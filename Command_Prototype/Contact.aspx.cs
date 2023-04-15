using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using MySql.Data.MySqlClient;

namespace Command_Prototype
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Hecho_Click(object sender, EventArgs e)
        {
            var cantidadAlta = Int32.Parse(txtAlta.Text);
            var cantidadBaja = Int32.Parse(txtBaja.Text);

            // Conexión a la base de datos
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            connection.Open();

            //Instancia de la Empresa
            EmpresaInvoker empresa = new EmpresaInvoker(connection);
            var producto = new ProductoReceiver
            {
                Cantidad = int.Parse(txtCantidadProducto.Text),
                Nombre = "Producto"
            };

            var ordenAlta = new AltaStockDbCommand(producto, cantidadAlta, connection);
            empresa.TomarOrden(ordenAlta);
            var ordenBaja = new BajaStockDbCommand(producto, cantidadBaja, connection);
            empresa.TomarOrden(ordenBaja);
            empresa.ProcesarOrdenes();

            // Cierre de la conexión a la base de datos
            connection.Close();

            lblAltaStock.Text = $"Agregando { cantidadAlta } de Computadoras";
            lblAltaStock.Visible = true;
            lblBajaStok.Text = $"Quitando { cantidadBaja } de Computadoras";
            lblBajaStok.Visible = true;
            // Imprime la cantidad disponible del producto
            lblResultado.Text = $"Total de computadoras es { producto.Cantidad }";
            lblResultado.Visible = true;


        }

        protected void BajaStock_Click(object sender, EventArgs e)
        {
            //var cantidad = Int32.Parse(txtAltayBaja.Text);



            ///*// Instancia empresa
            //var empresa = new EmpresaInvoker();
            //*/
            //// Instancia producto
            //var producto = new ProductoReceiver();
            //producto.Cantidad = producto.Cantidad;

            //var ordenBaja = new BajaStockCommand(producto, cantidad);
            //empresa.TomarOrden(ordenBaja);
            ////empresa.ProcesarOrdenes();

            //lblBajaStok.Text = $"Quitando { cantidad } de Computadoras";
            //lblBajaStok.Visible = true;
            //// Imprime la cantidad disponible del producto
            //lblResultado.Text = $"Total de computadoras es { producto.Cantidad }";
            //lblResultado.Visible = true;


        }

    }
}
