namespace GenericCrudRepository.DataAccess.Models
{
    public class Animal : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
