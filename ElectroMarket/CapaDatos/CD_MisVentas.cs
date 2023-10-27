using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_MisVentas
    {
        /*
        SELECT
        V.NumeroDocumento AS NumeroDocumento,
        U.Nombre AS NombreVendedor,
        V.DniCliente AS DNICliente,
        V.NombreCliente AS NombreCliente,
        V.ApellidoCliente AS ApellidoCliente,
        V.MontoTotal AS MontoTotal,
        FP.Descripcion AS FormaPago,
        V.FechaRegistro AS FechaVenta
        FROM VENTAS V
        INNER JOIN USUARIOS U ON V.IdUsuario = U.IdUsuario
        INNER JOIN FORMA_PAGO FP ON V.IdFormaPago = FP.IdFormaPago;
        */
    }
}
