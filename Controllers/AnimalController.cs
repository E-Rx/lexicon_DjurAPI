using Microsoft.AspNetCore.Mvc;

namespace DjurAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AnimalController : ControllerBase

    {
        [HttpGet]
        public async Task<List<Models.Animal>> GetAllAnimalsAsync()
        {
            return await DAL.AnimalManager.GetAllAnimalsAsync();
        }

        [HttpGet("{id}")]
        public async Task<Models.Animal> GetAnimalByIdAsync(int id)
        {
            return await DAL.AnimalManager.GetAnimalByIdAsync(id); ;
        }

        [HttpPost]
        public async Task<Models.Animal> AddAnimalAsync([FromBody] Models.Animal animal)
        {
            return await DAL.AnimalManager.CreateAnimalAsync(animal);
        }

        [HttpPut("{id}")]
        public async Task<Models.Animal> UpdateAnimalAsync(int id, [FromBody] Models.Animal animal)
        {
            return await DAL.AnimalManager.UpdateAnimalAsync(id, animal);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAnimalAsync(int id)
        {
            await DAL.AnimalManager.DeleteAnimalAsync(id);

        }
    }
}
