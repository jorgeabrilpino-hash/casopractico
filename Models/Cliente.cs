using System;
using System.Collections.Generic;

namespace CasoPractico01.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Documento { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
