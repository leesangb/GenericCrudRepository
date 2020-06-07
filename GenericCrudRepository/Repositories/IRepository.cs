using System.Collections.Generic;
using System.Threading.Tasks;
using GenericCrudRepository.Models;

namespace GenericCrudRepository.Repositories
{
    public interface IRepository<TDto>
        where TDto : IDto
    {
        Task<List<TDto>> Get();

        Task<TDto> Get(int id);

        Task<TDto> Update(TDto model);

        Task<TDto> Add(TDto model);

        Task<bool> Delete(int id);
    }
}
