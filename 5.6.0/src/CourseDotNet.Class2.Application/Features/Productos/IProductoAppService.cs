using Abp.Application.Services;
using CourseDotNet.Class2.Features.Productos.Dto;
using CourseDotNet.Class2.Features.Productos.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDotNet.Class2.Features.Productos
{
    public interface IProductoAppService : IAsyncCrudAppService<
        ProductoDto,
        int,
        ProductoGetAllInput,
        ProductoCreateInput,
        ProductoUpdateInput,
        ProductoGetInput,
        ProductoDeleteInput>
    {
    }
}
