using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "Sifu", Age = 50, Description = "I am Sifu" },
            new Animal { Id = 2, Name = "Pabu", Age = 8, Description = "I am cute" },
            new Animal { Id = 3, Name = "Red", Age = 10, Description = "I am red" },
        };
    }
}
