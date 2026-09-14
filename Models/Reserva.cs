using System;
using System.Collections.Generic;

namespace CasoPractico01.Models;

public partial class Reserva
{
    public int IdReserva { get; set; }

    public int IdCliente { get; set; }

    public int IdMesa { get; set; }

    public DateOnly FechaReserva { get; set; }

    public TimeOnly HoraReserva { get; set; }

    public int CantidadPersonas { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Mesa IdMesaNavigation { get; set; } = null!;
}
