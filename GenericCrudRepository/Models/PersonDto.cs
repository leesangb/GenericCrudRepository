﻿using System;

namespace GenericCrudRepository.Models
{
    public class PersonDto : IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Initials { get; set; }
    }
}
