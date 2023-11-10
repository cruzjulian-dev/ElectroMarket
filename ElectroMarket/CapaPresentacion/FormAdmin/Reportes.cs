﻿using CapaEntidades;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in DGVentas.Columns)
            {
                if (columna.Visible == true && columna.HeaderText != "Fecha de Venta" && columna.HeaderText != "Ver detalle")
                {
                    CBBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            CBBusqueda.DisplayMember = "Texto";
            CBBusqueda.ValueMember = "Valor";
            CBBusqueda.SelectedIndex = 0;


            CN_Venta cnVenta = new CN_Venta();

            List<Venta> listaVentas = cnVenta.traerVentas();

            // Pregunto si hay ventas
            if (listaVentas != null)
            {
                // Relleno el datagrid con las ventas
                foreach (Venta item in listaVentas)
                {
                        DGVentas.Rows.Add(new object[] { item.IdVenta, item.NumeroDocumento, item.oUsuario.Nombre + " " + item.oUsuario.Apellido, item.DniCliente, item.NombreCliente, item.ApellidoCliente,
                    item.MontoTotal, item.oFormaPago.Descripcion, Convert.ToDateTime(item.FechaRegistro).ToString("dd-MM-yyyy"), "Ver Detalle"
                    });

                }
            }
            calcularDatos();
        }

        private void calcularDatos()
        {
            decimal montoTotal = 0;
            int cantidad = 0;

            foreach (DataGridViewRow row in DGVentas.Rows)
            {
                if (row.Visible == true)
                {
                    decimal montoVenta = Convert.ToDecimal(row.Cells[6].Value);
                    montoTotal += montoVenta;
                    cantidad++;
                }
                
            }

            LTotal.Text = montoTotal.ToString();
            LVentas.Text = cantidad.ToString();


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            string fechaDesde = DTDesde.Value.ToString("dd-MM-yyyy");
            string fechaHasta = DTHasta.Value.ToString("dd-MM-yyyy");

            if (Convert.ToDateTime(fechaDesde) <= Convert.ToDateTime(fechaHasta))
            {
                limpiarTabla();
                CN_Venta cnVenta = new CN_Venta();

                List<Venta> listaVentas = cnVenta.traerVentasFechas(fechaDesde, fechaHasta);

                // Pregunto si hay ventas
                if (listaVentas != null)
                {
                    // Relleno el datagrid con las ventas
                    foreach (Venta item in listaVentas)
                    {
                        DGVentas.Rows.Add(new object[] { item.IdVenta, item.NumeroDocumento, item.oUsuario.Nombre + " " + item.oUsuario.Apellido, item.DniCliente, item.NombreCliente, item.ApellidoCliente,
                    item.MontoTotal, item.oFormaPago.Descripcion, Convert.ToDateTime(item.FechaRegistro).ToString("dd-MM-yyyy"), "Ver Detalle"
                    });

                    }
                }
                calcularDatos();
            }
            else
            {
                MessageBox.Show("La fecha 'Desde' debe ser menor o igual que la fecha 'Hasta'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarTabla()
        {
            DGVentas.Rows.Clear();
        }

        private void DGVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVentas.Columns[e.ColumnIndex].Name == "CDetalle")
            {
                FormDetalleVenta detalleForm = new FormDetalleVenta(Convert.ToInt32(DGVentas.Rows[e.RowIndex].Cells["CIdVenta"].Value.ToString()), new Venta());
                detalleForm.ShowDialog();
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)CBBusqueda.SelectedItem).Valor.ToString();

            if (DGVentas.Rows.Count > 0)  // pregunta si hay filas
            {
                foreach (DataGridViewRow row in DGVentas.Rows) // recorro cada fila del datagrid
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(TBusqueda.Text.Trim().ToUpper()) && row.Visible == true) //obtengo el valor de la fila que estoy recorriendo
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }

                }
            }
            calcularDatos();
        }

        private void BMostrar_Click(object sender, EventArgs e)
        {
            TBusqueda.Text = "";
            VaciarTabla();
            ActualizarTabla();
            calcularDatos();
        }

        private void ActualizarTabla()
        {

            CN_Venta cnVenta = new CN_Venta();

            List<Venta> listaVentas = cnVenta.traerVentas();

            // Pregunto si hay ventas
            if (listaVentas != null)
            {
                // Relleno el datagrid con las ventas
                foreach (Venta item in listaVentas)
                {
                    DGVentas.Rows.Add(new object[] { item.IdVenta, item.NumeroDocumento, item.oUsuario.Nombre + " " + item.oUsuario.Apellido, item.DniCliente, item.NombreCliente, item.ApellidoCliente,
                    item.MontoTotal, item.oFormaPago.Descripcion, Convert.ToDateTime(item.FechaRegistro).ToString("dd-MM-yyyy"), "Ver Detalle"
                    });

                }
            }
            calcularDatos();
        }

        private void VaciarTabla()
        {
            DGVentas.Rows.Clear();
        }

    }
}
