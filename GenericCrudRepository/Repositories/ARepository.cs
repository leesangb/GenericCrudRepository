using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericCrudRepository.DataAccess;
using GenericCrudRepository.DataAccess.Models;
using GenericCrudRepository.Interfaces;
using GenericCrudRepository.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericCrudRepository.Repositories
{
    public abstract class ARepository<TEntity, TDto> : IRepository<TDto>
        where TEntity : class, IEntity
        where TDto : class, IDto
    {
        protected DbSet<TEntity> DbSet { get; set; }
        protected MyContext Context { get; set; }
        protected IMapper<TEntity, TDto> Mapper { get; set; }

        protected ARepository(MyContext context, IMapper<TEntity, TDto> mapper)
        {
            DbSet = context.Set<TEntity>();
            Context = context;
            Mapper = mapper;
        }

        public async Task<List<TDto>> Get()
        {
            return await DbSet.Select(entity => Mapper.Map(entity)).ToListAsync();
        }

        public async Task<TDto> Get(int id)
        {
            var entity = await DbSet.FirstOrDefaultAsync(e => e.Id == id);

            return entity == null ? null : Mapper.Map(entity);
        }

        public async Task<TDto> Update(TDto model)
        {
            var entity = await DbSet.FirstOrDefaultAsync(e => e.Id == model.Id);
            if (entity == null)
                return null;


            entity = Mapper.Map(entity, model);
            var result = DbSet.Update(entity);
            await Context.SaveChangesAsync();

            return Mapper.Map(result.Entity);
        }

        public async Task<TDto> Add(TDto model)
        {
            var entity = Mapper.Map(model);
            var result = await DbSet.AddAsync(entity);
            await Context.SaveChangesAsync();
            return Mapper.Map(result.Entity);
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await DbSet.FirstOrDefaultAsync(e => e.Id == id);
            if (entity == null)
                return false;

            DbSet.Remove(entity);
            await Context.SaveChangesAsync();

            return true;
        }
    }
}
