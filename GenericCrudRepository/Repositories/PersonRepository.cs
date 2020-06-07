using GenericCrudRepository.DataAccess;
using GenericCrudRepository.Interfaces;
using GenericCrudRepository.Models;

namespace GenericCrudRepository.Repositories
{
    public class PersonRepository : ARepository<DataAccess.Models.Person, PersonDto>
    {
        public PersonRepository(MyContext context, IMapper<DataAccess.Models.Person, PersonDto> mapper)
            : base(context, mapper)
        {
        }
    }
}
