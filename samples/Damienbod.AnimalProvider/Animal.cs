﻿using System;

namespace Damienbod.BusinessLayer.DomainModel
{
    public class Animal
    {
        public const string SearchIndex = "animals";

        public int Id { get; set; }
        public string AnimalType { get; set; }
        public string TypeSpecificForAnimalType { get; set; }
        public string Description { get; set; }
        public string Gender { get; set; }
        public string LastLocation { get; set; }
		public DateTimeOffset DateOfBirth { get; set; }
		public DateTimeOffset CreatedTimestamp { get; set; }
		public DateTimeOffset UpdatedTimestamp { get; set; }
    }
}
