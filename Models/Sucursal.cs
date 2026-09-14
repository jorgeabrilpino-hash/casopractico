using System;
using System.Collections.Generic;

namespace CasoPractico01.Models;

public partial class Sucursal
{
    public int IdSucursal { get; set; }

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string? Telefono { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<Ingrediente> Ingredientes { get; set; } = new List<Ingrediente>();

    public virtual ICollection<Mesa> Mesas { get; set; } = new List<Mesa>();
}
