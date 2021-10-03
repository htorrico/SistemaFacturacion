using Business;
using Entidad;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SistemaFacturacion
{
    /// <summary>
    /// Interaction logic for ListarFacturas.xaml
    /// </summary>
    public partial class ListarFacturas : MetroWindow
    {
        BCliente bCliente = new BCliente();
        BVenta bVenta = new BVenta();
        public ListarFacturas()
        {
            InitializeComponent();

            ddlClientes.ItemsSource = bCliente.GetClientes();
            dpFechaInicio.SelectedDate =DateTime.Now.AddDays(-365);
            dpFechaFin.SelectedDate = DateTime.Now.AddDays(1);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ventas = bVenta.GetVentas(
                new Venta
                {
                    IdCliente = 0,
                    FechaInicio = dpFechaInicio.SelectedDate.Value,
                    FechaFin = dpFechaFin.SelectedDate.Value,
                    NumeroFactura = txtNumeroFactura.Text
                }

                );
            dgVentas.ItemsSource = ventas;           
        }
    }
}
