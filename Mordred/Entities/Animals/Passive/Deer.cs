﻿using GoRogue;
using Microsoft.Xna.Framework;

namespace Mordred.Entities.Animals
{
    public class Deer : PassiveAnimal
    {
        public Deer(Coord position, Gender gender) : base(Color.SaddleBrown, 'D', gender, 80) 
        {
            Position = position;
            HungerTickRate = 6;
        }
    }
}
