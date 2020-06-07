using System.Threading.Tasks;
using GenericCrudRepository.Models;
using GenericCrudRepository.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GenericCrudRepository.Controllers
{
    [Route("api/[controller]")]
    public abstract class AController<TDto> : ControllerBase
        where TDto : IDto
    {
        protected readonly IRepository<TDto> Repository;

        protected AController(IRepository<TDto> repository)
        {
            Repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var results = await Repository.Get();

            return Ok(results);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await Repository.Get(id);

            if (result == null)
                return NotFound(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] TDto model)
        {
            var result = await Repository.Add(model);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] TDto model)
        {
            model.Id = id;
            var result = await Repository.Update(model);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await Repository.Delete(id);

            if (!result)
                return NotFound();

            return Ok();
        }
    }
}
