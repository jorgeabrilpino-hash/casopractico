using System;
using System.Collections.Generic;

namespace CasoPractico01.Models;

public partial class Ingrediente
{
    public int IdIngrediente { get; set; }

    public int IdSucursal { get; set; }

    public string Nombre { get; set; } = null!;

    public string UnidadMedida { get; set; } = null!;

    public decimal Stock { get; set; }

    public decimal StockMinimo { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public bool Estado { get; set; }

    public virtual Sucursal IdSucursalNavigation { get; set; } = null!;
}
