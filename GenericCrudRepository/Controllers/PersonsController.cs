using GenericCrudRepository.Models;
using GenericCrudRepository.Repositories;

namespace GenericCrudRepository.Controllers
{
    public class PersonsController : AController<PersonDto>
    {
        public PersonsController(IRepository<PersonDto> repository) : base(repository)
        {
        }
    }
}
