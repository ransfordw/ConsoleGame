using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MeanGirls.Hero;

namespace MeanGirls
{
    public class Program
    {
        static void Main(string[] args)
        {
            CharacterRepository charRepo = new CharacterRepository();
            var makeup = false;
            var nails = NailLength.Medium;
            var friends = 0;
            var popularity = 0;

            Console.WriteLine($"You find yourself transported back in time, to a terrible dark place... Middle School \n\n\n " +
                $"You're late and its your first day. You walk up to the office and are met by the Assistant Principal. \n" +
                $"Assitant Principal: You're late! You better have a good reason! What's you're name?");
            var characterName = Console.ReadLine();
            Console.WriteLine($"{characterName}... Oh you're the new student. I guess I can let it slide this time. Come this way please. \n\n" +
                $"He takes you into the office...\n \"Now, what grade are you in?\"\n" +
                $"\t 1. Sixth\n" +
                $"\t 2. Seventh\n" +
                $"\t 3. Eighth\n");
            var gradeResponse = Console.ReadLine();
            var characterGrade = charRepo.GetGrade(gradeResponse);
            Console.WriteLine($"AP:\"Ok so {characterGrade} grade. That will put you in {charRepo.GetClassroom(characterGrade)} Class. It's a very small school here. I'm sure you'll get along just fine...");
            Hero hero = new Hero(characterName, characterGrade, makeup, nails, popularity, friends);
            Console.WriteLine($"Congratulations! You have made your character!\n\n");
            charRepo.PrintCharacterDetails(hero);
            Console.WriteLine($"Your goal: Survive Middle School. Good Luck!");

            Console.ReadLine();
        }
    }
}
