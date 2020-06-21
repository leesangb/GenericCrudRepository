using GenericCrudRepository.DataAccess;
using GenericCrudRepository.DataAccess.Models;
using GenericCrudRepository.Interfaces;
using GenericCrudRepository.Models;

namespace GenericCrudRepository.Repositories
{
    public class AnimalRepository : ARepository<Animal, AnimalDto>, IRepository<AnimalDto>
    {
        public AnimalRepository(MyContext context, IMapper<Animal, AnimalDto> mapper) : base(context, mapper)
        {
        }
    }
}
