namespace RaysHotDogs.Core.Model
{
    using System.Collections.Generic;

    public class HotDog
    {
        public HotDog() { }
        public string Name { get; set; }
        public int HotDogId { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public double Price { get; set; }
        public double PrepTime { get; set; }
        public List<string> Ingredients { get; set; }
        public bool IsAvailible { get; set; }
        public bool IsFavorite { get; set; }
        public string GroupName { get; set; }
    }
}
