using Microsoft.EntityFrameworkCore;
using ShoppingListApp.Contracts;
using ShoppingListApp.Data;
using ShoppingListApp.ViewModels;

namespace ShoppingListApp.Services
{
    public class ProductService : IProductService
    {
        private readonly ShoppingListDbContext dbContext;

        public ProductService(ShoppingListDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public Task AddAsync(ProductViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductViewModel>> GetAllAsync()
        {
            var products = dbContext.Products.Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name
            }).ToList();

            return products;
    }

    public Task<ProductViewModel> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ProductViewModel viewModel)
    {
        throw new NotImplementedException();
    }
}
}
