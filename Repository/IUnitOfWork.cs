using CasoPractico01.Models;

namespace CasoPractico01.Repository;

public interface IUnitOfWork
{ 
    IGenericoRepository<Sucursal> Sucursal { get;  }
    IGenericoRepository<Factura> Factura { get;  }
    IGenericoRepository<Ingrediente> Ingrediente { get;  }
    IGenericoRepository<Menu> Menu { get;  }
    IGenericoRepository<Mesa> Mesa { get;  }
    IGenericoRepository<Pedido> Pedido { get;  }
    IGenericoRepository<Reserva> Reserva { get;  }
    
    IGenericoRepository<Cliente> Cliente { get;  }
    
    Task Guardar();
}