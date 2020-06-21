using GenericCrudRepository.Models;
using GenericCrudRepository.Repositories;

namespace GenericCrudRepository.Controllers
{
    public class AnimalsController : AController<AnimalDto>
    {
        public AnimalsController(IRepository<AnimalDto> repository) : base(repository)
        {
        }
    }
}
