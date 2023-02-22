using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//For this project, models are characters in the game that is built as example in this course
//Below models are defined

namespace _1.dotnet_rpg.Models
{
    public class Character
    {
        //Add properties for the model
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo"; //set default name
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
         public int Defense { get; set; } = 10;
          public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
        

    }
}