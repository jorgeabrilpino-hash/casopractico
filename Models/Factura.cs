using System;
using System.Collections.Generic;

namespace CasoPractico01.Models;

public partial class Factura
{
    public int IdFactura { get; set; }

    public int IdPedido { get; set; }

    public int IdCliente { get; set; }

    public string TipoComprobante { get; set; } = null!;

    public string NumeroFactura { get; set; } = null!;

    public DateTime FechaEmision { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Igv { get; set; }

    public decimal Total { get; set; }

    public string MetodoPago { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Pedido IdPedidoNavigation { get; set; } = null!;
}
