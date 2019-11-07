namespace RaysHotDogs.Core.Service
{
    using Core.Model;
    using Core.Repository;
    using System.Collections.Generic;

    public class HotDogService
    {
        private HotDogRepository hotDogRepo;
        public HotDogService()
        {
            this.hotDogRepo = new HotDogRepository();
        } 
        public HotDog GetHotDogById(int hotDogId)
        {
            return this.hotDogRepo.GetHotDogById(hotDogId);
        }

        public IEnumerable<HotDog> GetAllHotDogs()
        {
            return hotDogRepo.GetAllHotDogs();
        }


        public List<HotDogGroup> GetGroupedHotDogs()
        {
            return hotDogRepo.GetGroupedHotDogs();
        }

        public List<HotDog> GetHotDogsForGroup(int hotDogGroupId)
        {
            return hotDogRepo.GetHotDogsForGroup(hotDogGroupId);
        }

        public IEnumerable<HotDog> GetFavoriteHotDogs()
        {
            return hotDogRepo.GetFavoriteHotDogs();
        }
    }
}
