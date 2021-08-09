using CleanArchtecture.Application.InputModels;
using CleanArchtecture.Application.ViewModels;

namespace CleanArchtecture.Application.Interfaces
{
    public interface IProductService
    {
        void Add(ProductInputModel productInputModel);
        ProductViewModel GetById(int id);
    }
}
