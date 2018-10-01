//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MeanGirls
//{
//    class ProgramUI
//    {
//        CharacterRepository charRepo = new CharacterRepository();
//        var makeup = false;
//        var nails = 2;
//        var friends = 0;
//        var popularity = 0;

//        Console.WriteLine($"You find yourself transported back in time, to a terrible dark place... Middle School \n\n\n " +
//                $"You're late and its your first day. You walk up to the office and are met by the Assistant Principal. \n" +
//                $"Assitant Principal: You're late! You better have a good reason! What's you're name?");
//            var characterName = Console.ReadLine();
//        Console.WriteLine($"{characterName}... Oh you're the new student. I guess I can let it slide this time. Come this way please. \n\n" +
//                $"He takes you into the office...\n \"Now, what grade are you in?\"\n" +
//                $"\t 1. Sixth\n" +
//                $"\t 2. Seventh\n" +
//                $"\t 3. Eighth\n");
//            var gradeResponse = Console.ReadLine();
//        var characterGrade = charRepo.GetGrade(gradeResponse);
//        Console.WriteLine($"AP:\"Ok so {characterGrade} grade. That will put you in {charRepo.GetClassroom(characterGrade)} Class. It's a very small school here. I'm sure you'll get along just fine...");
//            Hero hero = new Hero(characterName, characterGrade, makeup, nails, popularity, friends);
//        Console.WriteLine($"Congratulations! You have made your character!\n\n");
//            charRepo.PrintCharacterDetails(hero);
//            Console.WriteLine($"Your goal: Survive your first day of Middle School. Good Luck!");
//            Console.ReadLine();
//            Console.Clear();

//            if (characterGrade == "Sixth")
//            {
//                Console.WriteLine($"Great. Just Great. It's your first day at a new school and you're late! \n\n" +
//                    $"What do you want to do?\n" +
//                    $"\t 1. Run to the bathroom to put on some makeup\n" +
//                    $"\t 2. Go straight to class\n" +
//                    $"\t 3. Turn around and go home");
//                var responseOne = Int32.Parse(Console.ReadLine());
//        Console.Clear();

//                charRepo.FirstAction(responseOne);

//                Console.WriteLine($"You make it to class and walk in. The teacher is in the middle of class introductions. She has you find a seat and the girl next to you is staring at you. What do you do?\n" +
//                    $"\t 1. Do nothing." +
//                    $"\t 2. Ask what her problem is." +
//                    $"\t 3. Introduce yourself." +
//                    $"\t 4. Stare back." +
//                    $"\t 5. Say \"You know, it's not polite to stare.\"");
//                var responseTwo = Int32.Parse(Console.ReadLine());
//        charRepo.SecondAction(responseTwo);
//                charRepo.PrintCharacterDetails(hero);
//            } else if (characterGrade == "Seventh")
//            {

//            } else
//            {

//            }




//            Console.ReadLine();
//        }
//    }
//}
