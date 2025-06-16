


namespace DjurAPI.DAL
{
    public class AnimalManager
    {
        private static int dbSpeed = 1000; // Simulated database speed in milliseconds

        public static async Task<List<Models.Animal>> GetAllAnimalsAsync()
        {

            await Task.Delay(dbSpeed);
            return DB.Animals;
        }

        public static async Task<Models.Animal> GetAnimalByIdAsync(int id)
        {
            await Task.Delay(dbSpeed);
            return DB.Animals.SingleOrDefault(a => a.Id == id);
        }

        public static async Task<Models.Animal> CreateAnimalAsync(Models.Animal animal)
        {
            await Task.Delay(dbSpeed);
            if (animal.Id == null)
            {
                animal.Id = DB.Animals.Max(a => a.Id) + 1;
            }
            DB.Animals.Add(animal);
            return animal;
        }

        public static async Task<Models.Animal> UpdateAnimalAsync(int id, Models.Animal animal)
        {
            await Task.Delay(dbSpeed);
            var existingAnimal = DB.Animals.Where(a => a.Id == id).SingleOrDefault();
            if (existingAnimal != null)
            {
                existingAnimal.Species = animal.Species;
                existingAnimal.Weight = animal.Weight;
                existingAnimal.Flying = animal.Flying;
                return existingAnimal; 
            }

            return null;
        }

        public static async Task DeleteAnimalAsync(int id)
        {
            await Task.Delay(dbSpeed);
            var existingAnimal = DB.Animals.Where(a => a.Id == id).SingleOrDefault();
            if (existingAnimal != null)
            {
                DB.Animals.Remove(existingAnimal);
            }
        }
    }
}
