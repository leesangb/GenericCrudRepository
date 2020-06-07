using System;
using GenericCrudRepository.DataAccess.Models;
using GenericCrudRepository.Interfaces;
using GenericCrudRepository.Models;

namespace GenericCrudRepository.Repositories.Mappers
{
    public class PersonMapper : IMapper<Person, PersonDto>
    {
        public PersonDto Map(Person t1)
        {
            return new PersonDto
            {
                Id = t1.Id,
                FirstName = t1.FirstName,
                LastName = t1.LastName,
                Email = t1.Email,
                Birthdate = t1.Birthdate,
                FullName = $"{t1.FirstName} {t1.LastName}",
                Initials = $"{t1.FirstName[0]}{t1.LastName[0]}",
                Age = DateTime.Now.Year - t1.Birthdate.Year,
            };
        }

        public Person Map(PersonDto t2)
        {
            return new Person
            {
                FirstName = t2.FirstName,
                LastName = t2.LastName,
                Birthdate = t2.Birthdate,
                Email = t2.Email,
            };
        }


        public Person Map(Person t1, PersonDto t2)
        {
            t1.FirstName = t2.FirstName ?? t1.FirstName;
            t1.LastName = t2.LastName ?? t1.LastName;
            t1.Email = t2.Email ?? t1.Email;
            t1.Birthdate = t2.Birthdate != DateTime.MinValue ? t2.Birthdate : t1.Birthdate;
            return t1;
        }
    }
}
