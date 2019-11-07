﻿namespace RaysHotDogs.Core.Model
{
    using System.Collections.Generic;
    public class HotDogGroup
    {
        public HotDogGroup() { }
        public int HotDogGroupId { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public List<HotDog> HotDogs { get; set; }
    }
}
