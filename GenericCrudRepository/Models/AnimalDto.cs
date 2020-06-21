namespace GenericCrudRepository.Models
{
    public class AnimalDto : IDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
