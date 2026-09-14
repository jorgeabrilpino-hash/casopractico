using System;
using System.Collections.Generic;

namespace CasoPractico01.Models;

public partial class Menu
{
    public int IdMenu { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Categoria { get; set; } = null!;

    public decimal Precio { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
