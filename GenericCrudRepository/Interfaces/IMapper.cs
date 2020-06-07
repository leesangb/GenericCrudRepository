namespace GenericCrudRepository.Interfaces
{
    public interface IMapper<T1, T2> 
        where T1 : class
        where T2 : class
    {
        public T1 Map(T2 t2);
        public T2 Map(T1 t1);
        public T1 Map(T1 t1, T2 t2);
    }
}
