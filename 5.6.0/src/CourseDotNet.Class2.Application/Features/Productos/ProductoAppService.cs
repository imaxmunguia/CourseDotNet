using Abp.Application.Services;
using Abp.Domain.Repositories;
using CourseDotNet.Class2.Features.Productos.Dto;
using CourseDotNet.Class2.Features.Productos.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDotNet.Class2.Features.Productos
{
    public class ProductoAppService : AsyncCrudAppService<
        Producto,
        ProductoDto,
        int,
        ProductoGetAllInput,
        ProductoCreateInput,
        ProductoUpdateInput,
        ProductoGetInput,
        ProductoDeleteInput>,
        IProductoAppService
    {
        public ProductoAppService(IRepository<Producto> repository) : base(repository)
        {

        }

        public override Task<ProductoDto> CreateAsync(ProductoCreateInput input)
        {
            try
            {
                return base.CreateAsync(input);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
    }
}
