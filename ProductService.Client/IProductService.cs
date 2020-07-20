using ProductService.Client.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Client
{
    public interface IProductService
    {
        [Post("/api/product/create")]
        Task CreateProductAsync(ProductCreateModel model);

        [Get("/api/product/get/{id}")]
        Task<ProductGetModel> GetProductAsync(int id);
    }
}
