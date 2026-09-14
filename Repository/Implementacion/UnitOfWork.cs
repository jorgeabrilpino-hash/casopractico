using CasoPractico01.Data;
using CasoPractico01.Models;

namespace CasoPractico01.Repository.Implementacion;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public IGenericoRepository<Sucursal> Sucursal { get; }

    public IGenericoRepository<Cliente> Cliente { get; }

    public IGenericoRepository<Reserva> Reserva { get; }

    public IGenericoRepository<Mesa> Mesa { get; }

    public IGenericoRepository<Pedido> Pedido { get; }

    public IGenericoRepository<Ingrediente> Ingrediente { get; }
    public IGenericoRepository<Menu> Menu { get; }

    public IGenericoRepository<Factura> Factura { get; }

    public UnitOfWork(AppDbContext context)
    {
        _context = context;

        Sucursal = new Generico<Sucursal>(_context);
        Cliente = new Generico<Cliente>(_context);
        Reserva = new Generico<Reserva>(_context);
        Mesa = new Generico<Mesa>(_context);
        Pedido = new Generico<Pedido>(_context);
        Menu = new Generico<Menu>(_context);
        Ingrediente = new Generico<Ingrediente>(_context);
        Factura = new Generico<Factura>(_context);
    }

    public async Task Guardar()
    {
        await _context.SaveChangesAsync();
    }
}