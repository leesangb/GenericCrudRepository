using GenericCrudRepository.Models;
using GenericCrudRepository.Repositories;

namespace GenericCrudRepository.Controllers
{
    public class PersonController : AController<PersonDto>
    {
        public PersonController(IRepository<PersonDto> repository) : base(repository)
        {
        }
    }
}
