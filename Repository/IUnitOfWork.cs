namespace CasoPractico01.Repository;

public interface IUnitOfWork
{ 
    IClienteRepository Clientes { get;  }
    IFacturaRepository Facturas { get;  }
    IIngredientesRepository  Ingredientes { get;  }
    IMenuRepository  Menus { get;  }
    IMesaRepository Mesa { get;  }
    IPedidoRepository  Pedido { get;  }
    IReservaRepository  Reserva { get;  }
    ISucursalRepository  Sucursal { get;  }
    
    Task<int> SaveChangesAsync();
    
}