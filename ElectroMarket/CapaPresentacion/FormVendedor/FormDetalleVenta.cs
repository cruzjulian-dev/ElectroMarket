using CapaEntidades;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;


namespace CapaPresentacion
{
    public partial class FormDetalleVenta : Form
    {
        private int idVenta;
        public FormDetalleVenta(int idVenta)
        {
            InitializeComponent();
            this.idVenta = idVenta;
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            CN_Venta cnVenta = new CN_Venta(); 
            CN_DetalleVenta cnDetalleVenta = new CN_DetalleVenta(); 

            Venta cabeceraVenta = cnVenta.buscarVenta(idVenta);
            List<DetalleVenta> detalle = cnDetalleVenta.buscarDetalle(idVenta);


            // Limpia el DataGridView antes de agregar nuevos detalles
            DGDetalle.Rows.Clear();

            // Relleno cabecera de venta
            TIdVenta.Text = cabeceraVenta.NumeroDocumento.ToString();
            TVendedor.Text = cabeceraVenta.oUsuario.Nombre + " " + cabeceraVenta.oUsuario.Apellido;
            TFormaPago.Text = cabeceraVenta.oFormaPago.Descripcion;
            TFecha.Text = Convert.ToDateTime(cabeceraVenta.FechaRegistro).ToString("dd-MM-yyyy");
            TNombre.Text = cabeceraVenta.NombreCliente;
            TApellido.Text = cabeceraVenta.ApellidoCliente;
            TDocumento.Text = Convert.ToInt32(cabeceraVenta.DniCliente).ToString();
            TTotal.Text = cabeceraVenta.MontoTotal.ToString();
            TCambio.Text = cabeceraVenta.MontoCambio.ToString();
            TPago.Text = cabeceraVenta.MontoPago.ToString();

            // Relleno detalle de venta
            foreach (DetalleVenta item in detalle)
            {

                DGDetalle.Rows.Add(new object[] { item.oProducto.Nombre, item.oProducto.Descripcion, item.PrecioVenta, item.Cantidad, item.SubTotal
                });
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(TIdVenta.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //agregar aca if si es factura o presupuesto

            string Texto_html = Properties.Resources.PlantillaVenta.ToString();

            Texto_html = Texto_html.Replace("tipodocumento", "Factura");
            Texto_html = Texto_html.Replace("numerodocumento", TIdVenta.Text.ToUpper());

            Texto_html = Texto_html.Replace("@doccliente", TDocumento.Text);
            Texto_html = Texto_html.Replace("@nombrecliente", TNombre.Text + " " + TApellido.Text);
            Texto_html = Texto_html.Replace("@fecharegistro", TFecha.Text);
            Texto_html = Texto_html.Replace("@vendedorregistro", TVendedor.Text);
            Texto_html = Texto_html.Replace("@formapago", TFormaPago.Text);

            string filas = string.Empty;
            foreach(DataGridViewRow row in DGDetalle.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Cproducto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["CDescripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cprecio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Ccantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Csubtotal"].Value.ToString() + "</td>";
                filas += "</tr>"; 
            }

            Texto_html = Texto_html.Replace("@filas", filas);
            Texto_html = Texto_html.Replace("@montototal", TTotal.Text);
            Texto_html = Texto_html.Replace("@pagocon", TPago.Text);
            Texto_html = Texto_html.Replace("@cambio", TCambio.Text);

            DateTime fechaActual = DateTime.Now;
            int anio = fechaActual.Year;
            int mes = fechaActual.Month;
            int dia = fechaActual.Day;

            SaveFileDialog savefile = new SaveFileDialog();

            savefile.FileName = string.Format("Venta_{0}__" + dia + "-" + mes + "-" + anio + ".pdf", TIdVenta.Text);
            savefile.Filter = "pdf Files|*.pdf";

            if(savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4,25,25,25,25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteimage;

                    // Acceder a la imagen desde los recursos
                    System.Drawing.Image imageFromResources = Properties.Resources.logo_electromarket;

                    // Convertir la imagen en un array de bytes
                    using (MemoryStream ms = new MemoryStream())
                    {
                        imageFromResources.Save(ms, ImageFormat.Png); // Puedes cambiar el formato según el de tu imagen
                        byteimage = ms.ToArray();
                    }

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteimage);
                        img.ScaleToFit(200, 200); // Aumenta el tamaño de la imagen
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        // Posiciona la imagen en la parte superior
                        img.SetAbsolutePosition(pdfDoc.Left + (pdfDoc.Right - pdfDoc.Left - img.ScaledWidth) / 2, pdfDoc.Top - img.ScaledHeight - 10);

                        pdfDoc.Add(img);
                    }


                    using (StringReader sr =  new StringReader(Texto_html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer,pdfDoc,sr);
                    }

                    pdfDoc.Close();
                    stream.Close();

                    // Preguntar si el usuario desea abrir el PDF
                    DialogResult result = MessageBox.Show("Factura guardada. ¿Desea visualizar la factura recién creada?", "Abrir PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Abrir el archivo PDF con la aplicación predeterminada
                        System.Diagnostics.Process.Start(savefile.FileName);
                    }
                }
            }
        }
    }
}
