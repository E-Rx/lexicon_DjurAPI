using DjurAPI.Models;

namespace DjurAPI.DAL
{
    public class DB
    {
        public static List<Models.Animal> Animals { get; set; } = new List<Models.Animal>()
         {
            new Animal { Id = 1, Species = "Cat", Weight = 4, Flying = false },
            new Animal { Id = 2, Species = "Fish", Weight = 2, Flying = false },
            new Animal { Id = 3, Species = "Bird", Weight = 1, Flying = true }
        };
    }
}
