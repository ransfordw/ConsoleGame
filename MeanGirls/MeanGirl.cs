using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanGirls
{
    public class MeanGirl
    {
        public MeanGirl() {}
        public MeanGirl( string name, int grade, bool makeup, int nailLength, int popularityPoints, int friends)
        {
            OpponentName = name;
            OpponentGrade = grade;
            HasMakeup = makeup;
            OpponentClaws = nailLength;
            PopularityPoints = popularityPoints;
            NumberOfFriends = friends;
        }

        public string OpponentName { get; set; }
        public int OpponentGrade { get; set; }
        public bool HasMakeup { get; set; }
        public int OpponentClaws { get; set; }
        public int PopularityPoints { get; set; }
        public int NumberOfFriends { get; set; }

    }
}
