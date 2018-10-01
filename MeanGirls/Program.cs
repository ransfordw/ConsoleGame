using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MeanGirls.Hero;
using System.Speech.Synthesis;


namespace MeanGirls
{
    public class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            CharacterRepository charRepo = new CharacterRepository();
            var makeup = false;
            var nails = 2;
            var friends = 0;
            var popularity = 0;
            bool endGame = false;

            //synth.Speak("You find yourself transported back in time, to a terrible dark place... Middle School ");
            Console.WriteLine($"You find yourself transported back in time, to a terrible dark place... Middle School \n\n\n " +
                $"You're late and its your first day. You walk up to the office and are met by the Assistant Principal. \n" +
                $"Assistant Principal: You're late! You better have a good reason! What yo name is?");
            var characterName = Console.ReadLine();
            Console.WriteLine($"{characterName}... Oh you're the new student. I guess I can let it slide this time. Come this way please. \n\n" +
                $"He takes you into the office...\n \"Now, what grade are you in?\"\n" +
                $"\t 1. Sixth\n" +
                $"\t 2. Seventh\n" +
                $"\t 3. Eighth\n");
            var gradeResponse = Console.ReadLine();
            var characterGrade = charRepo.GetGrade(gradeResponse);
            var teacherName = charRepo.GetClassroom(characterGrade);
            Console.Clear();

            Console.WriteLine($"AP:\"Ok so {characterGrade} grade. That will put you in {teacherName}'s Class. It's a very small school here. I'm sure you'll get along just fine...");
            Hero hero = charRepo.CreateCharacter(characterName, characterGrade, makeup, nails, popularity, friends);
            Console.WriteLine($"Congratulations! You have made your character!\n\n");
            charRepo.PrintCharacterDetails(hero);
            Console.WriteLine($"Your goal: Survive your first day of Middle School. Good Luck!");
            Console.WriteLine($"\nPress \"Enter\" to continue.");
            Console.ReadLine();
            Console.Clear();

            if (characterGrade == "Sixth")
            {
                while (endGame == false)
                {
                    Console.WriteLine($"Great. Just Great. It's your first day at a new school and you're late! \n\n" +
                        $"What do you want to do?\n" +
                        $"\t 1. Run to the bathroom to put on some makeup\n" +
                        $"\t 2. Go straight to class\n" +
                        $"\t 3. Turn around and go home");
                    var responseOne = Int32.Parse(Console.ReadLine());
                    Console.Clear();

                    charRepo.FirstAction(responseOne);

                    if (responseOne == 3)
                    {
                        endGame = true;
                        break;
                    }
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine($"You make it to class and walk in. {teacherName} is in the middle of class introductions. She has you find a seat and the girl next to you is staring at you. What do you do?\n" +
                        $"\t 1. Do nothing.\n" +
                        $"\t 2. Ask what her problem is.\n" +
                        $"\t 3. Introduce yourself.\n" +
                        $"\t 4. Stare back.\n" +
                        $"\t 5. Say \"You know, it's not polite to stare.\"\n");
                    var responseTwo = Int32.Parse(Console.ReadLine());
                    charRepo.SecondAction(responseTwo);
                    charRepo.PrintCharacterDetails(hero);
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine($"Your first class is over. Good. One down but how many to go? \n" +
                        $"{teacherName} let the class go for a short break. In the hall way a girl approaches you. \"Hey new girl!\"\n\n" +
                        $"What do you do?\n" +
                        $"\t 1. Dart in the bathroom.\n" +
                        $"\t 2. Pretend you don't hear her and walk back to class.\n" +
                        $"\t 3. You sheepishly tell them your name.\"\n" +
                        $"\t 4. Say \"That's my name, don't wear it out.\"\n" +
                        $"\t 5. Say nothing.\n");
                    var responseThree = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    charRepo.ThirdAction(responseThree);
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine($"You get back to class. {teacherName} informs the class that its time for lunch. You were running late this morning and forgot to pack your lunch.\n\n" +
                        $"What do you do?\n\n" +
                        $"\t1. Ask {teacherName} if there is a way for you to go home to eat.\n" +
                        $"\t2. Ask the girl next to you if she would mind sharing er lunch.\n" +
                        $"\t3. Pretend you feel sick and hide in the bathroom until lunch is over.");
                    var responseFour = Int32.Parse(Console.ReadLine());
                    charRepo.FourthAction(responseFour);
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine($"After lunch you make you way back to class. );

                    endGame = true;
                }
            }
            else if (characterGrade == "Seventh")
            {

            }
            else
            {

            }
            charRepo.PrintCharacterDetails(hero);
            if (endGame == true && hero.PopularityPoints < 30)
            {
                synth.Speak("Game Over. You lose. Better luck next time. The cake is a lie.");
            }
            else
            {
                synth.Speak("Good job. 179 days of middle school left...ugh");
            }

            Console.ReadLine();
        }
    }
}