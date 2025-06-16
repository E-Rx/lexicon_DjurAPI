namespace DjurAPI.Models
{
    public class Animal
    {
        public int? Id { get; set; } 
        public string Species { get; set; } = string.Empty;
        public int Weight { get; set; }

        public bool Flying { get; set; }

    }
}
