using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanGirls
{
    public class Hero
    {
        public Hero() {}
        public Hero(string name, string grade, bool makeup, int claws, int popularityPoints, int friends)
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
        public int CharacterClaws { get; set; }
        public int PopularityPoints { get; set; }
        public int NumberOfFriends { get; set; }

    }
}
