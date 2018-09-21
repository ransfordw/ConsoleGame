using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanGirls
{
    public class Hero
    {
        public enum NailLength { Short = 1, Medium, Long, ScaryHagLong }

        public Hero() {}
        public Hero(string name, string grade, bool makeup, NailLength claws, int popularityPoints, int friends)
        {
            CharacterName = name;
            CharacterGrade = grade;
            HasMakeup = makeup;
            CharacterClaws = claws;
            PopularityPoints = popularityPoints;
            NumberOfFriends = friends;
        }

        public string CharacterName { get; set; }
        public string CharacterGrade { get; set; }
        public bool HasMakeup { get; set; }
        public NailLength CharacterClaws { get; set; }
        public int PopularityPoints { get; set; }
        public int NumberOfFriends { get; set; }

    }
}
