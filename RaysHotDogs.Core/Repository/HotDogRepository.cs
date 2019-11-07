using RaysHotDogs.Core.Model;
using System.Collections.Generic;
using System.Linq;

namespace RaysHotDogs.Core.Repository
{
    public class HotDogRepository
    {
        private static List<HotDog> meatHotDogs = new List<HotDog>
        {
            new HotDog
            {
                HotDogId = 1,
                Name = "Haute Dogg",
                ShortDescription = "Shorty Dog",
                Description = "Goog delicious hot-dog",
                ImagePath = "hotdog2",
                IsAvailible = true,
                PrepTime  = 12,
                Ingredients = new List<string>{ "salt", "3 peppers", "bread", "meat stick" },
                Price = 10,
                IsFavorite = false
            },
                  new HotDog
            {
                HotDogId = 1,
                Name = "Extra Long",
                ShortDescription = "LOOOOnggg Dog",
                Description = "Goog delicious enormously big hot-dog",
                ImagePath = "hotdog2",
                IsAvailible = true,
                PrepTime  = 12,
                Ingredients = new List<string>{ "salt", "3 peppers", "big bread", "2 meat sticks" },
                Price = 10,
                IsFavorite = true
            }
        };

        private static List<HotDog> VeggyHotDogs = new List<HotDog>
        {
            new HotDog
            {
                HotDogId = 1,
                Name = "Haute Dogg",
                ShortDescription = "Shorty Dog",
                Description = "Goog delicious hot-dog",
                ImagePath = "hotdog2",
                IsAvailible = true,
                PrepTime  = 12,
                Ingredients = new List<string>{ "salt", "3 peppers", "bread" },
                Price = 10,
                IsFavorite = false
            },
                  new HotDog
            {
                HotDogId = 1,
                Name = "Extra Long",
                ShortDescription = "LOOOOnggg Dog",
                Description = "Goog delicious enormously big hot-dog",
                ImagePath = "hotdog2",
                IsAvailible = true,
                PrepTime  = 12,
                Ingredients = new List<string>{ "salt", "3 peppers", "big bread" },
                Price = 10,
                IsFavorite = true
            }
        };

        private static List<HotDogGroup> hotDogGroups = new List<HotDogGroup>
        {
            meatLovers,
            veggyLovers
        };

        private static HotDogGroup meatLovers = new HotDogGroup
        {
            HotDogGroupId = 1,
            Title = "Meat Lovers",
            ImagePath = "imagePath",
            HotDogs = meatHotDogs
        };

        private static HotDogGroup veggyLovers = new HotDogGroup
        {
            HotDogGroupId = 2,
            Title = "Vegy Lovers",
            ImagePath = "imagePath",
            HotDogs = meatHotDogs
        };

        public IEnumerable<HotDog> GetAllHotDogs ()
        {
            return
            from hotDogGroup in hotDogGroups
            from HotDog in hotDogGroup.HotDogs

            select HotDog;
        }

        public HotDog GetHotDogById(int hotDogId)
        {
           return
            (from hotDogGroup in hotDogGroups
             from HotDog in hotDogGroup.HotDogs
             where HotDog.HotDogId == hotDogId
             select HotDog)
             .FirstOrDefault<HotDog>();
        }

        public List<HotDogGroup> GetGroupedHotDogs() 
        {
            return hotDogGroups;
        }

        public List<HotDog> GetHotDogsForGroup(int hotDogGroupId)
        {
            HotDogGroup hotDogGroup = hotDogGroups
                .Where(hdg => hdg.HotDogGroupId == hotDogGroupId)
                .FirstOrDefault();

            if (hotDogGroup != null)
            {
                return hotDogGroup.HotDogs;
            }
            return null;
        }

        public IEnumerable<HotDog> GetFavoriteHotDogs()
        {
            List<HotDog> favoriteHotDogs = this.GetAllHotDogs()
                .Where(hd => hd.IsFavorite == true)
                .ToList();

            if (favoriteHotDogs != null)
            {
                return favoriteHotDogs;
            }
            
            return null;
        }

    }
}
