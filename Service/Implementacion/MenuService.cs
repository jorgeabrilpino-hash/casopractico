using CasoPractico01.Models;
using CasoPractico01.Repository;

namespace CasoPractico01.Service.Implementacion;

public class MenuService : IMenuService
{
    private readonly IUnitOfWork _unitOfWork;

    public MenuService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<IEnumerable<Menu>> GetAll()
    {
        return await _unitOfWork.Menu.GetAll();
    }

    public async Task<Menu?> GetById(int id)
    {
        return await _unitOfWork.Menu.GetById(id);
    }

    public async Task Post(Menu menu)
    {
        await _unitOfWork.Menu.Post(menu);
        await _unitOfWork.Guardar();
    }
    public async Task Put(Menu menu)
    {
        _unitOfWork.Menu.Put(menu);
        await _unitOfWork.Guardar();
    }

    public async Task Delete(int id)
    {
        var menu = await _unitOfWork.Menu.GetById(id);

        if (menu != null)
        {
            _unitOfWork.Menu.Delete(menu);
            await _unitOfWork.Guardar();
        }
    }
}