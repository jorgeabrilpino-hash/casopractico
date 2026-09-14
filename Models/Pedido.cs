using System;
using System.Collections.Generic;

namespace CasoPractico01.Models;

public partial class Pedido
{
    public int IdPedido { get; set; }

    public int IdCliente { get; set; }

    public int? IdMesa { get; set; }

    public int IdMenu { get; set; }

    public DateTime FechaPedido { get; set; }

    public int Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }

    public decimal Total { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual Factura? Factura { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Menu IdMenuNavigation { get; set; } = null!;

    public virtual Mesa? IdMesaNavigation { get; set; }
}
