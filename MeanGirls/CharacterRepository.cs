using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MeanGirls.Hero;

namespace MeanGirls
{
    public class CharacterRepository
    {
        private string grade;
        private string room;
        private string makeupStatus;

        public string GetGrade(string response)
        {
            if (response == "1")
                return grade = "Sixth";

            else if (response == "2")
                return grade = "Seventh";

            else
                return grade = "Eighth";
        }
        public string GetClassroom(string response)
        {
            if (response == "Sixth")
                return room = "Mrs. Nesbitt's";
            else if (response == "Seventh")
                return room = "Mr. Pinkman's";
            else
                return room = "Mr. Deadgut's";
        }
        public string GetMakeupStatus(bool makeup)
        {
            if (makeup == false)
                return makeupStatus = "None";
            else
                return makeupStatus = "Basic foundation";
        }
       public void PrintCharacterDetails(Hero character)
        {
            Console.WriteLine( $"\t Character Name : {character.CharacterName}\n" +
                $"\t Grade: {character.CharacterGrade}\n" +
                $"\t Classroom: {GetClassroom(character.CharacterGrade)}\n" +
                $"\t Makeup: {GetMakeupStatus(character.HasMakeup)}\n" +
                $"\t Nails: {character.CharacterClaws}\n" +
                $"\t Friends: {character.NumberOfFriends}\n" +
                $"\t Popularity: {character.PopularityPoints}\n\n");
        }
        public void FirstAction(string response)
        {
            if (response == "1")
            {
                 bool makeup = true;
                GetMakeupStatus(makeup);
                Console.WriteLine("First impressions are everything in a new school. Better put on some makeup.");
            }
            else if (response == "2")
            {
                Console.WriteLine("Good idea, you're already late, best not to be any later.");
            }
            else if (response == "3")
            {
                Console.WriteLine("It'll be better to start fresh tommorrow on time.");
            }
            else
            {
                Console.WriteLine("You have chosen poorly.");
                Console.WriteLine("Game Over");
            }

        }
    }
}
