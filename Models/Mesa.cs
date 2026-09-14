using System;
using System.Collections.Generic;

namespace CasoPractico01.Models;

public partial class Mesa
{
    public int IdMesa { get; set; }

    public int IdSucursal { get; set; }

    public int NumeroMesa { get; set; }

    public int Capacidad { get; set; }

    public string? Ubicacion { get; set; }

    public string Estado { get; set; } = null!;

    public virtual Sucursal IdSucursalNavigation { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
