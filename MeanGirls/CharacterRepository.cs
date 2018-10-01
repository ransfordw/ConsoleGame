using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MeanGirls.Hero;
using System.Speech.Synthesis;


namespace MeanGirls
{
    public class CharacterRepository
    {
        private Hero hero = new Hero();
        private SpeechSynthesizer _synth = new SpeechSynthesizer();

        public string GetGrade(string response)
        {
            if (response == "1")
                return "Sixth";
            else if (response == "2")
                return "Seventh";
            else
                return "Eighth";
        }
        public string GetClassroom(string response)
        {
            if (response == "Sixth")
                return "Mrs. Nesbitt";
            else if (response == "Seventh")
                return "Mr. Pinkman";
            else
                return "Mr. Deadgut";
        }
        public Hero CreateCharacter(string name, string grade, bool makeup, int claws, int popularity, int friends)
        {
            hero.CharacterName = name;
            hero.CharacterGrade = grade;
            hero.HasMakeup = makeup;
            hero.CharacterClaws = claws;
            hero.PopularityPoints = popularity;
            hero.NumberOfFriends = friends;
            return hero;
        }
        public string GetMakeupStatus(bool makeup)
        {
            if (makeup == false)
                return "None";
            else
                return "Basic foundation";
        }
        public void PrintCharacterDetails(Hero hero)
        {
            Console.WriteLine($"\t Character Name : {hero.CharacterName}\n" +
                $"\t Grade: {hero.CharacterGrade}\n" +
                $"\t Classroom: {GetClassroom(hero.CharacterGrade)}\n" +
                $"\t Makeup: {GetMakeupStatus(hero.HasMakeup)}\n" +
                $"\t Nails: {hero.CharacterClaws}\n" +
                $"\t Friends: {hero.NumberOfFriends}\n" +
                $"\t Popularity: {hero.PopularityPoints}\n\n");
        }
        public void FirstAction(int responseOne)
        {
            switch (responseOne)
            {
                case 1:
                    hero.HasMakeup = true;
                    Console.WriteLine("First impressions are everything in a new school. Better put on some makeup.");
                    break;
                case 2:
                    Console.WriteLine("Good idea, you're already late, best not to be any later.");
                    break;
                case 3:
                    Console.WriteLine("It'll be better to start fresh tommorrow on time. But you didn't survive your first day.");
                    Console.WriteLine("You have chosen poorly.");
                    break;
                default:
                    break;
            }
        }
        public void SecondAction(int responseTwo)
        {
            MeanGirl samantha = new MeanGirl("Samantha", 1, false, 3, 45, 2);
            switch (responseTwo)
            {
                case 1:
                    Console.WriteLine("You don't respond. You don't want to cause a scene and quietly try to pay attention to the teacher.");
                    break;
                case 2:
                    Console.WriteLine($"You ask what her problem is. She stops staring, smirks a little bit and says \"You're spunky. My name is Samantha.\"\n" +
                    $"You have made a friend!");
                    hero.NumberOfFriends += 1;
                    hero.PopularityPoints += 5;
                    break;
                case 3:
                    Console.WriteLine("You introduce yourself. She keeps staring. You introduce yourself again, but a little bit louder. The teacher interrupts \"Excuse me miss. Could you please come up here?\" \n" +
                    "People are starting to notice you...");
                    hero.PopularityPoints -= 10;
                    break;
                case 4:
                    Console.WriteLine("You stare back. After a moment she flicks you on the forehead, right between your eyes. She slaps you across the face.");
                    if (hero.CharacterClaws < samantha.OpponentClaws)
                    {
                        Console.WriteLine("You lost the fight!");
                        hero.PopularityPoints -= 15;
                    }
                    else
                    {
                        Console.WriteLine("You won the fight!");
                        hero.PopularityPoints += 5;
                    }
                    break;
                case 5:
                    Console.WriteLine("You say its not polite to stare. She gets offened and scoffs at you, but you get the feeling that most of the class doesn't like her. You feel like you've made a step in the right direction.");
                    hero.PopularityPoints += 10;
                    break;
                default:
                    break;
            }
        }
        public void ThirdAction(int responseThree)
        {
                MeanGirl haelga = new MeanGirl("Haelga", 1, true, 3, 60, 3);
            switch (responseThree)
            {
                case 1: //make a friend
                    Console.WriteLine($"You rush in. That's so much public recognition at once! You immediately regret your desicion, they probably all think you're weird now.\n\n" +
                        $"\"Hey new girl!\"\n \n" +
                        $"Oh no! Not in here too! Is nowhere safe?\n" +
                        $"\"Don't worry, I've been in your shoes. I'll show you around.\"");
                    Console.WriteLine("You have made a new friend!");
                    hero.NumberOfFriends += 1;
                    hero.PopularityPoints += 10;
                    break;
                case 2: //lose popularity
                    Console.WriteLine($"You walk straight past her and kind of look out the side of your eye.\n\n");
                    if (hero.HasMakeup == false)
                    {
                        Console.WriteLine($"\"Pssht! New Girl's shy. Figures. I would be too if I forgot my makeup.");
                        hero.PopularityPoints -= 10;
                    }
                    else
                    {
                        Console.WriteLine($"\"Yeah keep walking. No one wants to see that outfit.\"");
                    hero.PopularityPoints -= 5;
                    };
                    break;
                case 3: //catfight
                    Console.WriteLine($"My name is {hero.CharacterName}.\"" +
                        $"\"I'm sorry what was that? You'll have to speak up doll.\"\n" +
                        $"You say your name louder...\n" +
                        $"She makes a swipe at your face.");
                    if (hero.CharacterClaws < haelga.OpponentClaws)
                    {
                        Console.WriteLine("You lost the fight!");
                        hero.PopularityPoints -= 10;
                    }
                    else
                    {
                        Console.WriteLine("You won the fight!");
                        hero.PopularityPoints -= 10;
                    }
                    break;     
                case 4: //plus pop points
                    Console.WriteLine($"\"Ohhhh {haelga.OpponentName}, she told you! You go girl.\"\n" +
                        $"You feel you face flush with a little more confidence.");
                    hero.PopularityPoints += 15;
                    break;
                case 5: // nothing
                    Console.WriteLine("You say nothing. She looks at you, confused, and walks away.");
                    break;
                default:
                    break;
            }
        }
        public void FourthAction(int responseFour)
        {
            switch (responseFour)
            {
            case 1:
                    Console.WriteLine($"\"Oh, we understand. The school anticipates students forgetting their lunch on the first day. Just let one of the lunch ladies knw.\"");
                break;
            case 2:
                    Console.WriteLine($"Sure! I packed an extra lunch hoping to make a friend.\n" +
                        $"\n\tYou make a friend!");
                    hero.NumberOfFriends += 1;
                    hero.PopularityPoints += 5;
                break;
            case 3:
                    Console.WriteLine("You hide in the bathroom.Rumors start to spread about you...");
                    hero.PopularityPoints -= 5;
                break;
            default:
                break;
            }
        }
        public void FifthAction(int responseFive)
        {

        }
    }
}