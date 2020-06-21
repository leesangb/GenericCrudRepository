using GenericCrudRepository.DataAccess.Models;
using GenericCrudRepository.Interfaces;
using GenericCrudRepository.Models;

namespace GenericCrudRepository.Repositories.Mappers
{
    public class AnimalMapper : IMapper<Animal, AnimalDto>
    {
        public Animal Map(AnimalDto t2)
        {
            return new Animal
            {
                Name = t2.Name
            };
        }

        public AnimalDto Map(Animal t1)
        {
            return new AnimalDto
            {
                Id = t1.Id,
                Name = t1.Name
            };
        }

        public Animal Map(Animal t1, AnimalDto t2)
        {
            t1.Name = t2.Name ?? t1.Name;

            return t1;
        }
    }
}
