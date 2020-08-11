using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting();


            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

        }

        public static void Greeting()
        {
            Console.WriteLine("Hello and  welcome to the TrueCoders Dojo where you will sharpen your \n\ncoding skills through repetition and gradual incremental development.");
            Console.WriteLine();
            Console.WriteLine("Your goal is to practice slowly until the code you desire to learn is mastered.");
            Console.WriteLine();
        }


        /// <summary>
        /// /////////////////////////////Menus///////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        private static bool MainMenu()
        {


            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) 'for' Loop");
            Console.WriteLine("2) 'foreach' Loop");
            Console.WriteLine("3) 'while' Loop");
            Console.WriteLine("4) 'do-while' Loop");
            Console.WriteLine("5) 'if' Statement");
            Console.WriteLine("6) 'if-else' Statement");
            Console.WriteLine("7) 'if-else' ternary Statement");
            Console.WriteLine("8) 'switch' Statement");
            Console.WriteLine("9) 'List' Practice");
            Console.WriteLine("10) 'Array' Practice");


            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    forLoop();
                    return true;
                case "2":
                    foreachLoop();
                    return true;
                case "3":
                    whileLoop();
                    return true;
                case "4":
                    doWhileLoop();
                    return true;
                case "5":
                    ifStatement();
                    return true;
                case "6":
                    ifElseStatement();
                    return true;
                case "7":
                    ifElseTernaryStatement();
                    return true;
                case "8":
                    switchStatement();
                    return true;
                case "9":
                    List();
                    return true;
                case "10":
                    arrayPractice();
                    return true;
                default:
                    return true;


            }
        }

        private static bool ListMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. List Practice");
            Console.WriteLine("2. Inferred vs. Explicit");
            Console.WriteLine("3. Types, Indexes & Values PART 1");
            Console.WriteLine("4. Types, Indexes & Values PART 2");
            Console.WriteLine("5. Advanced Tools - Controlling Your List");
            Console.WriteLine("6. Advanced Tools - Editing Your List");
            Console.WriteLine("7. Main Menu");

            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ListPractice();
                    return true;
                case "2":
                    InferredExplicit();
                    return true;
                case "3":
                    TypesIndexesValuesPart1();
                    return true;
                case "4":
                    TypesIndexesValuesPart2();
                    return true;
                case "5":
                    ListControl();
                    return true;
                case "6":
                    ListEdit();
                    return true;
                case "7":
                    MainMenu();
                    return true;
                default:
                    return true;
            }
        }

        private static bool ListControlOptions()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Count");
            Console.WriteLine("2. Sort");
            Console.WriteLine("3. Reverse");
            Console.WriteLine("4. Contains");
            Console.WriteLine("5. IndexOf");
            Console.WriteLine("6. List Menu");
            Console.WriteLine("7. Main Menu");


            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Count();
                    return true;
                case "2":
                    Sort();
                    return true;
                case "3":
                    Reverse();
                    return true;
                case "4":
                    Contains();
                    return true;
                case "5":
                    IndexOf();
                    return true;
                case "6":
                    ListMenu();
                    return true;
                case "7":
                    MainMenu();
                    return true;
                default:
                    return true;


            }
        }

        private static bool ListEdit()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Insert");
            Console.WriteLine("3. Remove");
            Console.WriteLine("4. RemoveAt");
            Console.WriteLine("5. List Menu");
            Console.WriteLine("6. Main Menu");


            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Add();
                    return true;
                case "2":
                    Insert();
                    return true;
                case "3":
                    Remove();
                    return true;
                case "4":
                    RemoveAt();
                    return true;
                case "5":
                    ListMenu();
                    return true;
                case "6":
                    MainMenu();
                    return true;
                default:
                    return true;


            }
        }

        /// <summary>
        /// ///////////////////////////////////Responces///////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        public static string Wrong()
        {
            var wrong = new Random();
            List<string> list = new List<string> { "*******************************************OPPS******************************************" };
            int index = wrong.Next(list.Count);
            return list[wrong.Next(list.Count)];

        }
        public static string Compliment()
        {
            var random = new Random();
            List<string> list = new List<string> { "Bravo!", "Excellent!", "Fantastic work!", "Fantastic!", "Good call!", "Good call!", "Good going!", "Good job!", "Good work!", "Good work!", "Great!", "I appreciate your hard work!", "I appreciate your hard work!", "I bet you sweat glitter!", "I like that!", "I like your style!", "I'm inspired by you!", "I'm very proud of you!", "I'm very proud of you!", "It’s surprising how well you perform, even under pressure!", "Keep up the great work!", "Nice going!", "Nice job!", "Nicely done!", "Now you've figured it out!", "Now you've figured it out!", "On a scale from 1 to 10, you're an 11!", "Perfect!", "Splendid!", "Superb!", "Terrific!", "That thing you don't like about yourself is what makes you so interesting!", "That's great!", "That's it!", "That's my person! (We are very PC, ha ha)", "That's right!", "There’s no one like you!", "Very good!", "Well done!", "Well look at you go!", "Well played!", "You always exceed our expectations!", "You are awesome!", "You are doing that much better today!", "You are making a difference!", "You are really good at what you do!", "You are really doing great work today!", "Think of all the people you will help with these skills!", "You are so talented!", "You are very good at that!", "You certainly are doing well today!", "You compute me!", "You deserve a raise!", "You deserve credit for everything I have accomplished!", "The work you do today will make for a better tomorrow!", "You are doing very fine job!", "You have a “Can Do” attitude!", "You must have been practicing!", "You must have been practicing!", "You should be proud of yourself!", "You were cool way before hipsters were cool!", "You’re a great example for your co-workers!", "You’re an awesome worker!", "You’re incredible!", "You’re so hardworking!", "You’re the best!", "Your hard work speaks for itself!", "Your work is unparalleled!", "Your work never ceases to amaze me!", "You're a smart cookie!", "You're all that and a super-size bag of chips!", "", "You're better than a triple-scoop ice cream cone! With sprinkles!", "You're doing a good job!", "You're learning fast!", "You're more amazing than a ball pit filled with candy! (And seriously, what could be more amazing than that?)", "You're one of a kind!", "You're really working hard today!", "You're wonderful!", "You've done a great job!", "You've just about got it!", "You've just about mastered that!" };
            int index = random.Next(list.Count);
            return list[random.Next(list.Count)];
        }

        /// <summary>
        /// //////////////////////////////////////Practice///////////////////////////////////////////////////////////////////////////
        /// </summary>
        public static void forLoop()
        {
            var answer1 = "for (int i = 0; i < 5; i++) {}";
            var answer2 = "for (int i = 0; i < 5; i++)";
            var answer3 = "{}";
            //var guess = "";
            //var wrongCount = 0;
            /////////////////"FOR" LOOP - ANSWERS FOR INTERMEDIATE////////////////////////
            var answer10 = "for (int i = 1; i < 5; i++)";
            var answer11 = "for (int i = 2; i < 5; i++) {}";
            var answer12 = "for (int i = 3; i < 5; i++) {}";
            var answer13 = "for (int i = 4; i < 5; i++) {}";
            var answer14 = "for (int i = 0; i < 6; i++) {}";
            var answer15 = "for (int i = 0; i < 7; i++) {}";
            var answer16 = "for (int i = 0; i < 8; i++) {}";
            var answer17 = "for (int i = 0; i < 9; i++) {}";
            var answer18 = "for (int i = 0; i < 5; i+=1) {}";
            var answer19 = "for (int i = 0; i < 5; i+=2) {}";
            var answer20 = "for (int i = 0; i < 5; i+=3) {}";
            var answer21 = "for (int i = 0; i < 5; i+=4) {}";

            var guess = "";
            var wrongCount = 0;

            Console.WriteLine($"You have chosen to practice 'for' loops!");

            Console.WriteLine("Which level would you say you are?");
            Console.WriteLine();

            string[] forWhichLevel = { "1 beginner", "2 intermediate", "3 proficient" };
            for (int i = 0; i < forWhichLevel.Length; i++)
            {
                var begIntPro = forWhichLevel[i];
                Console.WriteLine(begIntPro);
            }

            Console.WriteLine();
            forWhichLevel[0] = "1";
            forWhichLevel[1] = "2";
            forWhichLevel[2] = "3";

            string Level = Console.ReadLine();
            if (Level == forWhichLevel[0])
            {
                Console.WriteLine($"You have chosen beginner, where practice makes perfect!");
                Console.WriteLine("How many times would you like to practice the 'for' loop?\n");
                int copyNumber = int.Parse(Console.ReadLine());

                for (int i = 1; i <= copyNumber; i++)

                    do
                    {
                        Console.WriteLine("Copy this 'for' loop:\n\nfor (int i = 0; i < 5; i++) \n{}\n");
                        Console.WriteLine($"_______________________________________________________________________________");

                        guess = Console.ReadLine();
                        if (guess == answer2)
                        {
                            guess = Console.ReadLine();
                            if (guess == answer3)

                                //Console.WriteLine(Compliment());
                                Console.WriteLine($"\n{Compliment()}\n{i} of {copyNumber}");
                            Console.WriteLine($"********************************************************************************************");
                        }
                        else
                        {
                            Console.WriteLine("oops. Try again.");
                            wrongCount++;
                        }

                    } while (answer2 != guess && answer3 != guess);
            }

            if (Level == forWhichLevel[1])
            {
                Console.WriteLine();
                Console.WriteLine($"You have chosen  {forWhichLevel[1]}. Push through the increase your knowledge.");
                Console.WriteLine();
                Console.WriteLine("This code you have been copying has 5 parts: " +
                        "\n\n" +
                        "\n\n for         <--keyword" +
                        "\n\n(int i = 0;  <--initializer" +
                        "\n\ni < 5;       <--conditional" +
                        "\n\ni++)         <--increment" +
                        "\n\n{}           <--scope");

                do
                {
                    Console.WriteLine("Copy this code below but change the initializer from 0 to 1.\n\nfor (int i = 0; i < 5; i++)\n{}\n");
                    guess = Console.ReadLine();
                    if (guess == answer10)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer3)
                            Compliment();
                        Console.WriteLine($"{Compliment()}  1 of of 12");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("Try again, it should look like this:\n\nfor (int i = 1; i < 5; i++)\n{}\n");
                        wrongCount++;
                    }

                } while (answer10 != guess && answer3 != guess);


                do
                {
                    Console.WriteLine("Copy this code below but change the initializer from 0 to 2.\n\nfor (int i = 0; i < 5; i++)\n{}\n");
                    guess = Console.ReadLine();
                    if (guess == answer11)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer3)
                            Console.WriteLine($"{Compliment()}  2 of of 12");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("Try again, it should look like this:\n\nfor (int i = 2; i < 5; i++)\n{}\n");
                        wrongCount++;
                    }

                } while (answer11 != guess && answer3 != guess);

                do
                {
                    Console.WriteLine("Copy this code below but change the initializer from 0 to 3.\n\nfor (int i = 0; i < 5; i++)\n{}\n");
                    guess = Console.ReadLine();
                    if (guess == answer12)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer3)
                            Console.WriteLine($"{Compliment()}  3 of of 12");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("Try again, it should look like this:\n\nfor (int i = 3; i < 5; i++)\n{}\n");
                        wrongCount++;
                    }

                } while (answer12 != guess && answer3 != guess);


                do
                {
                    Console.WriteLine("Copy this code below but change the initializer from 0 to 4.\n\nfor (int i = 0; i < 5; i++)\n{}\n");
                    guess = Console.ReadLine();
                    if (guess == answer13)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer3)
                            Console.WriteLine($"{Compliment()}  4 of of 12");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("Try again, it should look like this:\n\nfor (int i = 4; i < 5; i++)\n{}\n");
                        wrongCount++;
                    }

                } while (answer13 != guess && answer3 != guess);


                do
                {
                    Console.WriteLine("Copy this but change the conditional from 5 to 6:\n\nfor (int i = 0; i < 5; i++)\n{}\n ");
                    guess = Console.ReadLine();
                    if (guess == answer14)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer3)
                            Console.WriteLine($"{Compliment()}  5 of of 12");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("Try again, it should look like this:\n\nfor (int i = 0; i < 6; i++)\n{}\n");
                        wrongCount++;
                    }

                } while (answer14 != guess && answer3 != guess);

                do
                {
                    Console.WriteLine("Copy this but change the conditional from 5 to 7:\n\nfor (int i = 0; i < 5; i++)\n{}\n ");
                    guess = Console.ReadLine();
                    if (guess == answer15)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer3)
                            Console.WriteLine($"{Compliment()}  6 of of 12");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("Try again, it should look like this:\n\nfor (int i = 0; i < 7; i++)\n{}\n");
                        wrongCount++;
                    }

                } while (answer15 != guess && answer3 != guess);


                do
                {
                    Console.WriteLine("Copy this but change the conditional from 5 to 8:\n\nfor (int i = 0; i < 5; i++)\n{}\n ");
                    guess = Console.ReadLine();
                    if (guess == answer16)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer3)
                            Console.WriteLine($"{Compliment()}  7 of of 12");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("Try again, it should look like this:\n\nfor (int i = 0; i < 8; i++)\n{}\n");
                        wrongCount++;
                    }

                } while (answer16 != guess && answer3 != guess);


                do
                {
                    Console.WriteLine("Copy this but change the conditional from 5 to 9:\n\nfor (int i = 0; i < 5; i++)\n{}\n ");
                    guess = Console.ReadLine();
                    if (guess == answer17)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer3)
                            Console.WriteLine($"{Compliment()}  8 of of 12");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("Try again, it should look like this:\n\nfor (int i = 0; i < 9; i++)\n{}\n");
                        wrongCount++;
                    }

                } while (answer17 != guess && answer3 != guess);

                do
                {
                    Console.WriteLine("Copy this but change the increment by 1:\n\nfor (int i = 0; i < 5; i++)\n{}\n ");
                    guess = Console.ReadLine();
                    if (guess == answer18)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer3)
                            Console.WriteLine($"{Compliment()}  9 of of 12");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("Try again, it should look like this:\n\nfor (int i = 0; i < 5; i+=1)\n{}\n");
                        wrongCount++;
                    }

                } while (answer18 != guess && answer3 != guess);

                do
                {
                    Console.WriteLine("Copy this but change the increment by 2:\n\nfor (int i = 0; i < 5; i++)\n{}\n ");
                    guess = Console.ReadLine();
                    if (guess == answer19)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer3)
                            Console.WriteLine($"{Compliment()}  10 of of 12");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("Try again, it should look like this:\n\nfor (int i = 0; i < 5; i+=2)\n{}\n");
                        wrongCount++;
                    }

                } while (answer19 != guess && answer3 != guess);

                do
                {
                    Console.WriteLine("Copy this but change the increment by 3:\n\nfor (int i = 0; i < 5; i++)\n{}\n ");
                    guess = Console.ReadLine();
                    if (guess == answer20)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer3)
                            Console.WriteLine($"{Compliment()}  11 of of 12");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("Try again, it should look like this:\n\nfor (int i = 0; i < 5; i+=3)\n{}\n");
                        wrongCount++;
                    }

                } while (answer20 != guess && answer3 != guess);


                do
                {
                    Console.WriteLine("Copy this but change the increment by 4:\n\nfor (int i = 0; i < 5; i++)\n{}\n ");
                    guess = Console.ReadLine();
                    if (guess == answer21)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer3)
                            Console.WriteLine($"{Compliment()}  12 of of 12");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("Try again, it should look like this:\n\nfor (int i = 0; i < 5; i+=4)\n{}\n");
                        wrongCount++;
                    }

                } while (answer21 != guess && answer3 != guess);



            }

            if (Level == forWhichLevel[2])
            {
                Console.WriteLine($"You have chosen  {forWhichLevel[2]}. Ready to master your skills?!");


                do
                {
                    Console.WriteLine("Copy this 'for' loop:\n\nfor (int i = 0; i < 5; i++) {}");
                    Console.WriteLine("This code you have been copying has five (5) parts:");

                    guess = Console.ReadLine();
                    if (guess == answer1)
                    {
                        Console.WriteLine("Correct! Do some more. 1 of 9");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("oops. Try again.");
                        wrongCount++;
                    }

                } while (answer1 != guess);

            }
            Console.WriteLine("Congragulations completing the 'for' loop practice. Would you like to practice something else?");

            MainMenu();
        }


        public static void foreachLoop()
        {

            ///////////////"FOREACH" LOOP - ANSWERS FOR BEGINNERS///////////////////////
            var answer200 = "int[] number = {1, 2, 3, 4};";
            var answer201 = "foreach (int i in numbers)";
            var answer3 = "{}";

            var guess = "";
            var wrongCount = 0;

            Console.WriteLine($"You have chosen the 'foreach' loop. Ready to master your skills?!");
            Console.WriteLine("How many times would you like to practice the 'foreach' loop?\n");
            int copyNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= copyNumber; i++)
                do
                {
                    Console.WriteLine("\nCopy this 'foreach' loop: \n\nint[] number = {1, 2, 3, 4};\nforeach (int i in numbers)\n{}");

                    guess = Console.ReadLine();
                    if (guess == answer200)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer201)
                            guess = Console.ReadLine();
                        if (guess == answer3)
                            Console.WriteLine($"\n{Compliment()}\n{i} of {copyNumber}");
                        Console.WriteLine($"********************************************************************************************");

                    }
                    else
                    {
                        Console.WriteLine("oops. Try again.");
                        wrongCount++;
                    }
                } while (answer200 != guess && answer201 != guess && answer3 != guess);


            Console.WriteLine("Congragulations completing the 'foreach' loop practice. Would you like to practice something else?");

            MainMenu();

        }

        public static void whileLoop()
        {
            var answer300 = "int i = 0;";
            var answer301 = "while (i < 5)";
            var answer302 = "{";
            var answer303 = "(i);";
            var answer304 = "i++;";
            var answer305 = "}";

            var guess = "";
            var wrongCount = 0;

            Console.WriteLine($"You have chosen the 'while' loop. Ready to master your skills?!");
            Console.WriteLine("How many times would you like to practice the 'while' loop?\n");
            int copyNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= copyNumber; i++) do
                {
                    Console.WriteLine("Copy this 'while' loop: \n\nint i = 0;\nwhile (i < 5)\n{\n(i);\ni++;\n}");
                    Console.WriteLine($"_______________________________________________________________________________");

                    guess = Console.ReadLine();
                    if (guess == answer300)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer301)
                            guess = Console.ReadLine();
                        if (guess == answer302)
                            guess = Console.ReadLine();
                        if (guess == answer303)
                            guess = Console.ReadLine();
                        if (guess == answer304)
                            guess = Console.ReadLine();
                        if (guess == answer305)

                            Console.WriteLine($"\n{Compliment()}\n{i} of {copyNumber}");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("oops. Try again.");
                        wrongCount++;
                    }
                } while (answer300 != guess && answer301 != guess && answer302 != guess && answer303 != guess && answer304 != guess && answer305 != guess);
            Console.WriteLine("Congragulations completing the 'while' loop practice. Would you like to practice something else?");

            MainMenu();
        }

        public static void doWhileLoop()
        {
            var answer400 = "int i = 0;";
            var answer401 = "do";
            var answer402 = "{";
            var answer403 = "(i);";
            var answer404 = "i++;";
            var answer405 = "}";
            var answer406 = "while (i < 5);";

            var guess = "";
            var wrongCount = 0;

            Console.WriteLine($"You have chosen the 'do-while' loop. Ready to master your skills?!");
            Console.WriteLine("How many times would you like to practice the 'do-while' loop?\n");
            int copyNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= copyNumber; i++) do
                {
                    Console.WriteLine("Copy this 'do-while' loop:\n\nint i = 0;\ndo\n{\n(i);\ni++;\n}\nwhile (i < 5);");
                    Console.WriteLine($"_______________________________________________________________________________");

                    guess = Console.ReadLine();
                    if (guess == answer400)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer401)
                            guess = Console.ReadLine();
                        if (guess == answer402)
                            guess = Console.ReadLine();
                        if (guess == answer403)
                            guess = Console.ReadLine();
                        if (guess == answer404)
                            guess = Console.ReadLine();
                        if (guess == answer405)
                            guess = Console.ReadLine();
                        if (guess == answer406)

                            Console.WriteLine($"\n{Compliment()}\n{i} of {copyNumber}");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("oops. Try again.");
                        wrongCount++;
                    }

                } while (answer400 != guess && answer401 != guess && answer402 != guess && answer403 != guess && answer404 != guess && answer405 != guess && answer406 != guess);
            Console.WriteLine("Congragulations completing the 'do-while' loop practice. Would you like to practice something else?");

            MainMenu();
        }

        public static void ifStatement()
        {
            var answer500 = "if (5 > 1)";
            var answer501 = "{";
            var answer502 = "Console.WriteLine(true);";
            var answer503 = "}";

            var guess = "";
            var wrongCount = 0;

            Console.WriteLine($"You have chosen 'if' statements to practice. Ready to master your skills?!");
            Console.WriteLine("How many times would you like to practice the 'if' statements?\n");
            int copyNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= copyNumber; i++) do
                {
                    Console.WriteLine("Copy this 'if' statement:\n\nif (5 > 1)\n{\nConsole.WriteLine(true);\n}");
                    Console.WriteLine($"_______________________________________________________________________________");

                    guess = Console.ReadLine();
                    if (guess == answer500)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer501)
                            guess = Console.ReadLine();
                        if (guess == answer502)
                            guess = Console.ReadLine();
                        if (guess == answer503)

                            Console.WriteLine($"\n{Compliment()}\n{i} of {copyNumber}");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("oops. Try again.");
                        wrongCount++;
                    }

                } while (answer500 != guess && answer501 != guess && answer502 != guess && answer503 != guess);

            Console.WriteLine("Congragulations completing the 'if' statement practice. Would you like to practice something else?");
            MainMenu();
        }

        public static void ifElseStatement()
        {

            var answer600 = "if (5 > 1)";
            var answer601 = "{";
            var answer602 = "Console.WriteLine(true);";
            var answer603 = "}";
            var answer604 = "else";
            var answer605 = "{";
            var answer606 = "Console.WriteLine(false);";
            var answer607 = "}";

            var guess = "";
            var wrongCount = 0;

            Console.WriteLine($"You have chosen 'if-else' statements to practice. Ready to master your skills?!");
            Console.WriteLine("How many times would you like to practice the 'if-else' statements?\n");
            int copyNumber = int.Parse(Console.ReadLine());


            for (int i = 1; i <= copyNumber; i++)
                do
                {
                    Console.WriteLine("Copy this 'if-else' statement:\n\nif (5 > 1)\n{\nConsole.WriteLine(true);\n}\nelse\n{\n(false);\n}");
                    Console.WriteLine($"_______________________________________________________________________________");

                    guess = Console.ReadLine();
                    if (guess == answer600)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer601)
                            guess = Console.ReadLine();
                        if (guess == answer602)
                            guess = Console.ReadLine();
                        if (guess == answer603)
                            guess = Console.ReadLine();
                        if (guess == answer604)
                            guess = Console.ReadLine();
                        if (guess == answer605)
                            guess = Console.ReadLine();
                        if (guess == answer606)
                            guess = Console.ReadLine();
                        if (guess == answer607)

                            Console.WriteLine($"\n{Compliment()}\n{i} of {copyNumber}");

                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("oops. Try again.");
                        wrongCount++;
                    }

                } while (answer600 != guess && answer601 != guess && answer602 != guess && answer603 != guess && answer604 != guess && answer605 != guess && answer606 != guess && answer607 != guess);


            Console.WriteLine("Congragulations completing the 'if-else' statement practice. Would you like to practice something else?");

            MainMenu();
        }

        public static void ifElseTernaryStatement()
        {
            var answer700 = "bool test = (5 > 1) ? true : false;";
            var answer701 = "Console.WriteLine(test);";
            var guess = "";
            var wrongCount = 0;

            Console.WriteLine($"You have chosen 'if-else' Ternary statements to practice. Ready to master your skills?!");
            Console.WriteLine("How many times would you like to practice the 'if-while' Ternary statements?\n");
            int copyNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= copyNumber; i++)
                do
                {
                    Console.WriteLine("Copy this 'if-else' Ternary statement:\n\nbool test = (5 > 1) ? true : false;\nConsole.WriteLine(test);");
                    Console.WriteLine($"_______________________________________________________________________________");

                    guess = Console.ReadLine();
                    if (guess == answer700)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer701)

                            Console.WriteLine($"\n{Compliment()}\n{i} of {copyNumber}");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("oops. Try again.");
                        wrongCount++;
                    }

                } while (answer700 != guess && answer701 != guess);


            Console.WriteLine("Congragulations completing the 'if-else' ternary statement practice. Would you like to practice something else?");
            MainMenu();
        }

        public static void switchStatement()
        {
            var answer800 = "switch (5)";
            var answer801 = "{";
            var answer802 = "case 5:";
            var answer803 = "Console.WriteLine(true);";
            var answer804 = "break;";
            var answer805 = "default:";
            var answer806 = "Console.WriteLine(false);";
            var answer807 = "break;";
            var answer808 = "}";

            var guess = "";
            var wrongCount = 0;

            Console.WriteLine($"You have chosen 'switch' statements to practice. Ready to master your skills?!");
            Console.WriteLine("How many times would you like to practice the 'switch' statements?\n");
            int copyNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= copyNumber; i++)
                do
                {
                    Console.WriteLine("Copy this 'switch' statement:\n\nswitch (5)\n{\ncase 5:\nConsole.WriteLine(true);\nbreak;\ndefault:\nConsole.WriteLine(false);\nbreak;\n};");
                    Console.WriteLine($"_______________________________________________________________________________");

                    guess = Console.ReadLine();
                    if (guess == answer800)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer801)
                            guess = Console.ReadLine();
                        if (guess == answer802)
                            guess = Console.ReadLine();
                        if (guess == answer803)
                            guess = Console.ReadLine();
                        if (guess == answer804)
                            guess = Console.ReadLine();
                        if (guess == answer805)
                            guess = Console.ReadLine();
                        if (guess == answer806)
                            guess = Console.ReadLine();
                        if (guess == answer807)
                            guess = Console.ReadLine();
                        if (guess == answer808)

                            Console.WriteLine($"\n{Compliment()}\n{i} of {copyNumber}");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("oops. Try again.");
                        wrongCount++;
                    }

                } while (answer800 != guess && answer801 != guess && answer802 != guess && answer803 != guess && answer804 != guess && answer805 != guess && answer806 != guess && answer807 != guess && answer808 != guess);


            Console.WriteLine("Congragulations completing the 'switch' statement practice. Would you like to practice something else?");
            MainMenu();
        }

        public static void List()
        {
            Console.Clear();
            Console.WriteLine($"You have chosen to practice 'Lists'!");

            Console.WriteLine("What would you like to practice today?");
            Console.WriteLine();

            ListMenu();
        }
        public static void ListPractice()
        {


            var answer900 = "var numbers = new List<int>();";


            var guess = "";
            var wrongCount = 0;

            Console.WriteLine($"You have chosen List Practice. Are you ready to master your skills?");
            Console.WriteLine("How many times would you like to practice the 'Lists'?\n");
            int copyNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= copyNumber; i++)
                do
                {
                    Console.WriteLine("\nCopy this 'List' with inferred typing named 'numbers' of type 'int': \n\nvar numbers = new List<int>();\n");

                    guess = Console.ReadLine();
                    if (guess == answer900)
                    {
                        Console.WriteLine($"\n{Compliment()}\n{i} of {copyNumber}");
                        Console.WriteLine($"********************************************************************************************");

                    }
                    else
                    {
                        Console.WriteLine("oops. Try again.");
                        wrongCount++;
                    }
                } while (answer900 != guess);


            Console.WriteLine("Congragulations completing the 'List'  practice. Would you like to practice something else?");

            ListControlOptions();


        }
        public static void InferredExplicit()
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"You have chosen Inferred vs. Explicit. Prepare to incrcease your skills!");

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\nThe List 'numbers' you have been copying was with INFERRED typing, " +
                "\nwhich means that you are telling the compiler to base the data type " +
                "\non the value you provided for the variable." +
                "\nYou are saying, \n \"Hey variable, I want this list to be a list of strings.\"" +
                "\n\nEXPLICIT typing is where we state at the beginning of the List exactly what" +
                "\ntype we intend to use." +
                "\n\nINFERRED -->\tvar teachers = new List<string>();" +
                "\nEXPLICIT -->\tList<string> teachers = new List<string>();" +
                "\n\nLet's now practice distinguishing inferred and explicit typing.");
            var answer01 = "inferred";
            var guess = "";

            do
            {
                Console.WriteLine("\n(Type your answer)Is this List using inferred or explicit typing?\n\n var myAddresses = new List<string>();");
                guess = Console.ReadLine();
                if (guess == answer01)
                {
                    Console.WriteLine($"{Compliment()}  1 of 10");
                    Console.WriteLine($"********************************************************************************************");
                }
                else
                {
                    Console.WriteLine("Try again, it is inferred because it begins with - var");
                }

            } while (answer01 != guess);

            ///"var teachers = new List<string>();";//////////////////////////////////////////
            ///"List<string> teachers = new List<string>();

            var answer02 = "explicit";

            do
            {
                Console.WriteLine("\n(Type your answer)Is this List using inferred or explicit typing?\n\n List<string> myAddresses = new List<string>();");
                guess = Console.ReadLine();
                if (guess == answer02)
                {
                    Compliment();
                    Console.WriteLine($"{Compliment()}  2 of 10");
                    Console.WriteLine($"********************************************************************************************");
                }
                else
                {
                    Console.WriteLine("Try again, it is explicit because it begins with - List<string>");
                }

            } while (answer02 != guess);

            ///"var teachers = new List<string>();";//////////////////////////////////////////
            ///"List<string> teachers = new List<string>();

            var answer03 = "explicit";

            do
            {
                Console.WriteLine("\n(Type your answer)Is this List using inferred or explicit typing?\n\nList<int> myNumbers = new List<int>();");
                guess = Console.ReadLine();
                if (guess == answer03)
                {
                    Compliment();
                    Console.WriteLine($"{Compliment()}  3 of 10");
                    Console.WriteLine($"********************************************************************************************");
                }
                else
                {
                    Console.WriteLine("Try again, it is explicit because it begins with - List<int>");
                }

            } while (answer03 != guess);

            ///"var teachers = new List<string>();";//////////////////////////////////////////
            ///"List<string> teachers = new List<string>();

            var answer04 = "explicit";

            do
            {
                Console.WriteLine("\n(Type your answer)Is this List using inferred or explicit typing?\n\nList<char> myChar = new List<char>();");
                guess = Console.ReadLine();
                if (guess == answer04)
                {
                    Compliment();
                    Console.WriteLine($"{Compliment()}  4 of 10");
                    Console.WriteLine($"********************************************************************************************");
                }
                else
                {
                    Console.WriteLine("Try again, it is explicit because it begins with - List<char>");
                }

            } while (answer04 != guess);

            ///"var teachers = new List<string>();";//////////////////////////////////////////
            ///"List<string> teachers = new List<string>();

            var answer05 = "inferred";

            do
            {
                Console.WriteLine("\n(Type your answer)Is this List using inferred or explicit typing?\n\nvar myLetter = new List<char>();");
                guess = Console.ReadLine();
                if (guess == answer05)
                {
                    Compliment();
                    Console.WriteLine($"{Compliment()}  5 0f 10");
                    Console.WriteLine($"********************************************************************************************");
                }
                else
                {
                    Console.WriteLine("Try again, it is inferred because it begins with - var");
                }

            } while (answer05 != guess);

            ///"var teachers = new List<string>();";//////////////////////////////////////////
            ///"List<string> teachers = new List<string>();


            var answer06 = "inferred";

            do
            {
                Console.WriteLine("\n(Type your answer)Is this List using inferred or explicit typing?\n\nvar anyDigit = new List<int>();");
                guess = Console.ReadLine();
                if (guess == answer06)
                {
                    Compliment();
                    Console.WriteLine($"{Compliment()}  6 of 10");
                    Console.WriteLine($"********************************************************************************************");
                }
                else
                {
                    Console.WriteLine("Try again, it is inferred because it begins with - var");
                }

            } while (answer06 != guess);

            ///"var teachers = new List<string>();";//////////////////////////////////////////
            ///"List<string> teachers = new List<string>();

            var answer07 = "explicit";

            do
            {
                Console.WriteLine("\n(Type your answer)Is this List using inferred or explicit typing?\nList<string> anyWord = new List<string>();");
                guess = Console.ReadLine();
                if (guess == answer07)
                {
                    Compliment();
                    Console.WriteLine($"{Compliment()}  7 of 10");
                    Console.WriteLine($"********************************************************************************************");
                }
                else
                {
                    Console.WriteLine("Try again, it is explicit because it begins with - List<string>");
                }

            } while (answer07 != guess);

            ///"var teachers = new List<string>();";//////////////////////////////////////////
            ///"List<string> teachers = new List<string>();

            var answer08 = "inferred";

            do
            {
                Console.WriteLine("\n(Type your answer)Is this List using inferred or explicit typing?\n\nvar hillTop = new List<bool>();");
                guess = Console.ReadLine();
                if (guess == answer08)
                {
                    Compliment();
                    Console.WriteLine($"{Compliment()}  8 of 10");
                    Console.WriteLine($"********************************************************************************************");
                }
                else
                {
                    Console.WriteLine("Try again, it is inferred because it begins with - var");
                }

            } while (answer08 != guess);

            ///"var teachers = new List<string>();";//////////////////////////////////////////
            ///"List<string> teachers = new List<string>();

            var answer09 = "explicit";

            do
            {
                Console.WriteLine("\n(Type your answer)Is this List using inferred or explicit typing?\n\nList<double> myDecimals = new List<double>();");
                guess = Console.ReadLine();
                if (guess == answer09)
                {
                    Compliment();
                    Console.WriteLine($"{Compliment()}  9 0f 10");
                    Console.WriteLine($"********************************************************************************************");
                }
                else
                {
                    Console.WriteLine("Try again, it is explicit because it begins with - List<double>");
                }

            } while (answer09 != guess);

            ///"var teachers = new List<string>();";//////////////////////////////////////////
            ///"List<string> teachers = new List<string>();

            var answer10 = "explicit";

            do
            {
                Console.WriteLine("\n(Type your answer)Is this List using inferred or explicit typing?\n\nList<decimal> myTenth = new List<decimal>();");
                guess = Console.ReadLine();
                if (guess == answer10)
                {
                    Compliment();
                    Console.WriteLine($"{Compliment()}  10 of 10");
                    Console.WriteLine($"********************************************************************************************");
                }
                else
                {
                    Console.WriteLine("Try again, it is explicit because it begins with - List<decimal>");
                }

            } while (answer10 != guess);

            ListControlOptions();




        }
        public static void TypesIndexesValuesPart1()
        {


            Console.Clear();
            Console.WriteLine("You have chosen to practice 'Types, Indexes & Values'!" +
            "\n\nWe have been making lists that have no values at all. Very sad." +
            "\nSo let's work with some lists that are populated with integers (int):" +
            "\n\nList<int> myNumbers = new List<int>() { 10, 20, 30, 40, 50};" +
            "\n\nAs you can see, this list is called \"myNumbers\" and is populated with 5 items that are integers (int)." +
            "\nIt is important to keep in mind that the values - whatever type(int, bool, string...) they are - are indexed beginning with 0" +
            "\nThis means that while there are clearly 5 numbers present in this collection, " +
            "\nthey only \'index\' up to 4." +
            "\n\nINDEX POSITION\t0\t1\t2\t3\t4" +
            "\n\tVALUE\t{10\t20\t30\t40\t50}" +
            "\nTherefore if we want to access value 50, we need to look at index 4." +
            "\nLet's practice identifying types, values, and indexes." +
            "\n_____________________________________________________________________________________________________");



            var answer11 = "inferred";
            var answer12 = "int";
            var answer13 = "4";
            var answer14 = "3";

            var guess = "";
            do
            {
                Console.WriteLine("\nLook at this list and answer the following questions:" +
                    "\n\nvar numberList = new List<int>(){ 2, 3, 5, 7 };" +
                    "\n\nDoes this code have inferred typing or explicit typing?" +
                    "");
                guess = Console.ReadLine();
                if (guess == answer11)
                {
                    Console.WriteLine("What type is this list?");
                    guess = Console.ReadLine();
                    if (guess == answer12)
                    {
                        Console.WriteLine("How many indexes are in this collection?");
                        guess = Console.ReadLine();
                        if (guess == answer13)
                        {
                            Console.WriteLine("At what index is nummber 7?");
                            guess = Console.ReadLine();
                            if (guess == answer14)
                            {
                                Compliment();
                                Console.WriteLine($"\n{Compliment()}\n1 of 10");
                                Console.WriteLine($"_________________________________________________________________________________________");
                            }
                            else
                            {
                                Console.WriteLine("************************************************OPPS**************************************");
                                Console.WriteLine("Try again! The answer is 3");
                            }
                        }
                        else
                        {
                            Console.WriteLine("************************************************OPPS**************************************");
                            Console.WriteLine("Try again! The answer is 4");
                        }
                    }
                    else
                    {
                        Console.WriteLine("************************************************OPPS**************************************");
                        Console.WriteLine("Try again! The answer is int");
                    }
                }
                else
                {
                    Console.WriteLine("************************************************OPPS**************************************");
                    Console.WriteLine("Try again! The answer is inferred");
                }

            } while (answer11 != guess && answer12 != guess && answer13 != guess && answer14 != guess);



            var answer15 = "explicit";
            var answer16 = "string";
            var answer17 = "3";
            var answer18 = "0";
            do
            {
                Console.WriteLine("\nLook at this list and answer the following questions:" +
                    "\n\nList<string> myWords = new List<string>(){ \"please\",\"code\",\"happily\" };" +
                    "\n\nDoes this code have inferred typing or explicit typing?" +
                    "");
                guess = Console.ReadLine();
                if (guess == answer15)
                {
                    Console.WriteLine("What type is this list?");
                    guess = Console.ReadLine();
                    if (guess == answer16)
                    {
                        Console.WriteLine("How many indexes are in this collection?");
                        guess = Console.ReadLine();
                        if (guess == answer17)
                        {
                            Console.WriteLine("At what index is \"please\"?");
                            guess = Console.ReadLine();
                            if (guess == answer18)
                            {
                                Compliment();
                                Console.WriteLine($"\n{Compliment()}\n2 of 10");
                                Console.WriteLine($"_________________________________________________________________________________________");
                            }
                            else
                            {
                                Console.WriteLine("************************************************OPPS**************************************");
                                Console.WriteLine("Try again! The answer is 0 - remember that the index begins at 0.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("************************************************OPPS**************************************");
                            Console.WriteLine("Try again! The answer is 3");
                        }
                    }
                    else
                    {
                        Console.WriteLine("************************************************OPPS**************************************");
                        Console.WriteLine("Try again! The answer is string");
                    }
                }
                else
                {
                    Console.WriteLine("************************************************OPPS**************************************");
                    Console.WriteLine("Try again! The answer is explicit");
                }

            } while (answer15 != guess && answer16 != guess && answer17 != guess && answer18 != guess);



            var answer19 = "inferred";
            var answer20 = "bool";
            var answer21 = "3";
            var answer22 = "2";

            do
            {
                Console.WriteLine("\nLook at this list and answer the following questions:" +
                "\n\nvar votes = new List<bool>{ false, false, true }; " +
                "\n\nIs this inferred or explicitly typed?" +
                    "");
                guess = Console.ReadLine();
                if (guess == answer19)
                {
                    Console.WriteLine("What type is this list?");
                    guess = Console.ReadLine();
                    if (guess == answer20)
                    {
                        Console.WriteLine("How many indexes are in this collection?");
                        guess = Console.ReadLine();
                        if (guess == answer21)
                        {
                            Console.WriteLine("At what index is \"true\"?");
                            guess = Console.ReadLine();
                            if (guess == answer22)
                            {
                                Compliment();
                                Console.WriteLine($"\n{Compliment()}\n1 of 10");
                                Console.WriteLine($"_________________________________________________________________________________________");
                            }
                            else
                            {
                                Console.WriteLine("************************************************OPPS**************************************");
                                Console.WriteLine("Try again! The answer is 2");
                            }
                        }
                        else
                        {
                            Console.WriteLine("************************************************OPPS**************************************");
                            Console.WriteLine("Try again! The answer is 3");
                        }
                    }
                    else
                    {
                        Console.WriteLine("************************************************OPPS**************************************");
                        Console.WriteLine("Try again! The answer is bool");
                    }
                }
                else
                {
                    Console.WriteLine("************************************************OPPS**************************************");
                    Console.WriteLine("Try again! The answer is inferred");
                }

            } while (answer19 != guess && answer20 != guess && answer21 != guess && answer22 != guess);



            var answer23 = "explicit";
            var answer24 = "decimal";
            var answer25 = "9";
            var answer26 = "8";

            do
            {
                Console.WriteLine("\nLook at this list and answer the following questions:" +
                    "\n\nList<decimal> myMoney = new List<decimal>(){ 29.9, 32.94, 3.132, 8.675, 3.09, 3.3, 2.03, 32.98, 12.34 };" +
                    "\n\nIs this inferred or explicitly typed?" +
                    "");
                guess = Console.ReadLine();
                if (guess == answer23)
                {
                    Console.WriteLine("What type is this list?");
                    guess = Console.ReadLine();
                    if (guess == answer24)
                    {
                        Console.WriteLine("How many indexes are in this collection?");
                        guess = Console.ReadLine();
                        if (guess == answer25)
                        {
                            Console.WriteLine("At what index is nummber 12.34?");
                            guess = Console.ReadLine();
                            if (guess == answer26)
                            {
                                Compliment();
                                Console.WriteLine($"\n{Compliment()}\n1 of 10");
                                Console.WriteLine($"_________________________________________________________________________________________");
                            }
                            else
                            {
                                Console.WriteLine("************************************************OPPS**************************************");
                                Console.WriteLine("Try again! The answer is 8");
                            }
                        }
                        else
                        {
                            Console.WriteLine("************************************************OPPS**************************************");
                            Console.WriteLine("Try again! The answer is 9");
                        }
                    }
                    else
                    {
                        Console.WriteLine("************************************************OPPS**************************************");
                        Console.WriteLine("Try again! The answer is decimal");
                    }
                }
                else
                {
                    Console.WriteLine("************************************************OPPS**************************************");
                    Console.WriteLine("Try again! The answer is explicit");
                }

            } while (answer23 != guess && answer24 != guess && answer25 != guess && answer26 != guess);



            var answer27 = "explicit";
            var answer28 = "string";
            var answer29 = "4";
            var answer30 = "fish";

            do
            {
                Console.WriteLine("\nLook at this list and answer the following questions:" +
                "\n\nList<string> animals = new List<string>(){ \"cat\", \"dog\", \"moose\", \"fish\", \"goat\" };" +
                "\n\nIs this inferred or explicitly typed?"); ;
                guess = Console.ReadLine();
                if (guess == answer27)
                {
                    Console.WriteLine("What type is this list?");
                    guess = Console.ReadLine();
                    if (guess == answer28)
                    {
                        Console.WriteLine("How many indexes are in this collection?");
                        guess = Console.ReadLine();
                        if (guess == answer29)
                        {
                            Console.WriteLine("What word is at index 3?");
                            guess = Console.ReadLine();
                            if (guess == answer30)
                            {
                                Compliment();
                                Console.WriteLine($"\n{Compliment()}\n1 of 10");
                                Console.WriteLine($"_________________________________________________________________________________________");
                            }
                            else
                            {
                                Console.WriteLine("************************************************OPPS**************************************");
                                Console.WriteLine("Try again! The answer is fish");
                            }
                        }
                        else
                        {
                            Console.WriteLine("************************************************OPPS**************************************");
                            Console.WriteLine("Try again! The answer is 4");
                        }
                    }
                    else
                    {
                        Console.WriteLine("************************************************OPPS**************************************");
                        Console.WriteLine("Try again! The answer is string");
                    }
                }
                else
                {
                    Console.WriteLine("************************************************OPPS**************************************");
                    Console.WriteLine("Try again! The answer is explicit");
                }

            } while (answer27 != guess && answer28 != guess && answer29 != guess && answer30 != guess);

            ListControlOptions();




        }
        public static void TypesIndexesValuesPart2()
        {


            var answer31 = "List<int> score = new List<int>(){ 1, 2, 3, 4, 5 };";
            var guess = "";
            do
            {
                Console.WriteLine("\nLet's change it up a bit and have you type:" +
                    "\n\nYou need an explicitely typed List named score with these five integers:{ 1, 2, 3, 4, 5 };");
                guess = Console.ReadLine();
                if (guess == answer31)
                {
                    Compliment();
                    Console.WriteLine($"\n{Compliment()}\n1 of 5");
                    Console.WriteLine($"_________________________________________________________________________________________");
                }
                else
                {
                    Console.WriteLine("************************************************OPPS**************************************");
                    Console.WriteLine("Try again! The answer is List<int> score = new List<int>(){ 1, 2, 3, 4, 5 };");
                }

            } while (answer31 != guess);


            var answer32 = "List<bool> isTrue = new List<bool>(){ true, false, true, true, false };";
            do
            {
                Console.WriteLine("\nHere is another one:" +
                    "\n\nYou need an explicitely typed List named isTrue with these five booleans: { true, false, true, true, false };");
                guess = Console.ReadLine();
                if (guess == answer32)
                {
                    Compliment();
                    Console.WriteLine($"\n{Compliment()}\n2 of 5");
                    Console.WriteLine($"_________________________________________________________________________________________");
                }
                else
                {
                    Console.WriteLine("************************************************OPPS**************************************");
                    Console.WriteLine("Try again! The answer is List<bool> isTrue = new List<bool>(){ true, false, true, true, false };");
                }

            } while (answer32 != guess);


            var answer33 = "var pets = new List<string>(){ \"Spot\", \"Hammy\", \"Whiskers\" };";
            do
            {
                Console.WriteLine("\nAnother:" +
                    "\n\nYou need an inferred typed List named pets with these three strings:{ \"Spot\", \"Hammy\", \"Whiskers\" };");
                guess = Console.ReadLine();
                if (guess == answer33)
                {
                    Compliment();
                    Console.WriteLine($"\n{Compliment()}\n3 of 5");
                    Console.WriteLine($"_________________________________________________________________________________________");
                }
                else
                {
                    Console.WriteLine("************************************************OPPS**************************************");
                    Console.WriteLine("Try again! The answer is var pets = new List<string>(){ \"Spot\", \"Hammy\", \"Whiskers\" };");
                }

            } while (answer33 != guess);


            var answer34 = "var myAccount = new List<double>(){ 1.2, 3.4, 5, 6.7, 0.89 };";
            do
            {
                Console.WriteLine("\nLet's change it up a bit and have you type:" +
                    "\n\nYou need an inferred typed List named myAccount with these five doubles: { 1.2, 3.4, 5, 6.7, 0.89 };");
                guess = Console.ReadLine();
                if (guess == answer34)
                {
                    Compliment();
                    Console.WriteLine($"\n{Compliment()}\n4 of 5");
                    Console.WriteLine($"_________________________________________________________________________________________");
                }
                else
                {
                    Console.WriteLine("************************************************OPPS**************************************");
                    Console.WriteLine("Try again! The answer is var myAccount = new List<double>(){ 1.2, 3.4, 5, 6.7, 0.89 };");
                }

            } while (answer34 != guess);


            var answer35 = "List<int> userAges = new List<int>(){ 21, 45, 63, 78, 100 };";
            do
            {
                Console.WriteLine("\nLet's change it up a bit and have you type:" +
                    "\n\nWrite an explicitely typed List named userAges with these five integers:{ 21, 45, 63, 78, 100 };");
                guess = Console.ReadLine();
                if (guess == answer35)
                {
                    Compliment();
                    Console.WriteLine($"\n{Compliment()}\n5 of 5");
                    Console.WriteLine($"_________________________________________________________________________________________");
                }
                else
                {
                    Console.WriteLine("************************************************OPPS**************************************");
                    Console.WriteLine("Try again! The answer is List<int> userAges = new List<int>(){ 21, 45, 63, 78, 100 };");
                }

            } while (answer35 != guess);



            Console.WriteLine("Congragulations completing the 'List'  practice. Would you like to practice something else?");

            ListControlOptions();


        }
        public static void ListControl()
        {
            ListControlOptions();
            Count();
        }
        public static void Count()
        {

            Console.Clear();
            Console.WriteLine("Wow! You made it this far. \nNow let's tell this List who is boss and show who is in control. You are!" +
              "\nWe will examine a total of 5 commands that let us manage the information in our List.\nOur goal isn't neccesarily " +
              "to memorize these, \nbut to let you know that they exist and what they do. \n\nChoose by number which you would like to practice." +
              "\nThese are:");

            Console.WriteLine("Examine this List: \n\nList<int> userAges = new List<int>(){ 21, 45, 63, 78, 100, 5, 46, 98, 42, 67 };\n\n" +
            "How do we find the total number of indexes in the collection?\nWe use the 'Count' property.\nA problem is that" +
            " we need to see it, so we need to call it on the console. Not only do we need the console, \nbut we also need to access this particlar List." +
            "\nWe do that by typing the NAME FIRST then '.Count', which looks like this:\n\nConsole.WriteLine(userAges.Count);\n\nSo it hase three " +
            "parts:\n1. Console.WriteLine();\n2. The name of the List\n3. Finally the command'.Count\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            var guess = "";
            var answer35 = "Console.WriteLine(userAges.Count);";
            do
            {

                Console.WriteLine("Now you try...\n\n We want to count the number of indexes in the collection." +
                    "\n\nList<int> userAges = new List<int>(){ 21, 45, 63, 78, 100, 5, 46, 98, 42, 67 }; " +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer35)
                {
                    Compliment();
                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: 10.");
                    Console.WriteLine($"_________________________________________________________________________________________");
                }
                else
                {
                    Console.WriteLine("************************************************OPPS**************************************");
                    Console.WriteLine("Console.WriteLine(userAges.Count);");
                }

            } while (answer35 != guess);


            var answer36 = "Console.WriteLine(pets.Count);";
            do
            {

                Console.WriteLine("\n\nCount the number of indexes in the collection." +
                    "\n\nvar pets = new List<string>(){ \"Spot\", \"Hammy\", \"Whiskers\" }; " +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer36)
                {
                    Compliment();
                    Console.WriteLine($"\n{Compliment()}\nThe Console would read:3.");
                    Console.WriteLine($"_________________________________________________________________________________________");
                }
                else
                {
                    Console.WriteLine("************************************************OPPS**************************************");
                    Console.WriteLine("Console.WriteLine(pets.Count);");
                }

            } while (answer36 != guess);


            var answer37 = "Console.WriteLine(myAddresses.Count);";
            do
            {

                Console.WriteLine("\n\nCount the number of indexes in the collection." +
                    "\n\nvar myAddresses = new List<string>();" +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer37)
                {
                    Compliment();
                    Console.WriteLine($"\n{Compliment()}\nThe Console would read:0.");
                    Console.WriteLine($"_________________________________________________________________________________________");
                }
                else
                {
                    Console.WriteLine("************************************************OPPS**************************************");
                    Console.WriteLine("Console.WriteLine(myAddresses.Count);");
                }

            } while (answer37 != guess);


            Console.WriteLine("What would you like to practice next?");
            ListControlOptions();

        }
        public static void Sort()
        {

            Console.Clear();
            Console.WriteLine("\n**NOTE** If you don't know your 'FOR loop' and the Count property above, \nyou will need to know them before using this tool." +
            "\n\nExamine this List: \n\nList<int> myNumbers = new List<int>(){ 21, 45, 63, 78, 100, 5, 46, 98, 42, 67 };\n\n" +
            "How do we sort this list from least to greatest or it was a string, in alphabetical order?" +
            "\nWe use the 'Sort' property." +
            "\nThis is another one we can call on the console but is a bit more involved. \n\n Press Enter to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("" +
            "\n1. We call on the List Name and the Sort property:\n\t\t myNumbers.Sort" +
            "\n2. We need a 'for loop' " +
            "\n3. Then we use the 'Count' property in the 'conditional' so that all of the numbers on the List are examined:\n\t\ti < numbers.Count;" +
            "\n4. In the Scope {}, we call on the console to display the list and the collection in order:\n\t\t Console.WriteLine(numbers[i]);" +
            "\n__________________________________________________________________________" +
            "\n\nAll together it looks like this: " +
            "\n\nList<int> numbers = new List<int>() { 29, 54, 12, 100, 2, 55, 99 };" +
            "\nnumbers.Sort();" +
            "\nfor (int i = 0; i < numbers.Count; i++)" +
            "\n{" +
                "\nConsole.WriteLine(numbers[i]);" +
            "\n}");

            var guess = "";
            var answer35 = "userAge.Sort();";
            var answer36 = "for (int i = 0; i < userAge.Count; i++)";
            var answer37 = "{";
            var answer38 = "Console.WriteLine(userAge[i]);";
            var answer39 = "}";

            do
            {
                Console.WriteLine("Now you try...\n\nSort the indexes in this collection." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                    "\n\nList<int> userAge = new List<int>(){ 21, 45, 63, 78, 100, 5, 46, 98, 42, 67 }; " +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer35)
                {
                    guess = Console.ReadLine();
                    if (guess == answer36)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer37)
                        {
                            guess = Console.ReadLine();
                            if (guess == answer38)
                            {
                                guess = Console.ReadLine();
                                if (guess == answer39)
                                {
                                    //guess = Console.ReadLine();
                                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: \n5\n21\n42\n45\n46\n63\n67\n78\n98\n100");
                                    Console.WriteLine($"_________________________________________________________________________________________");
                                    Console.WriteLine("\n\n Press Enter to continue...");
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Wrong()}\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\n{Wrong()}\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"\n{Wrong()}\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"\n{Wrong()}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{Wrong()}\n");
                }

            } while (answer35 != guess && answer36 != guess && answer37 != guess && answer38 != guess && answer39 != guess);


            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n________________________EXAMPLE___TO___HELP___YOU_________________________________________" +
            "\n\nList<int> numbers = new List<int>() { 29, 54, 12, 100, 2, 55, 99 };" +
            "\nnumbers.Sort();" +
            "\nfor (int i = 0; i < numbers.Count; i++)" +
            "\n{" +
                "\nConsole.WriteLine(numbers[i]);" +
            "\n}");

            var answer40 = "clubMember.Sort();";
            var answer41 = "for (int i = 0; i < clubMember.Count; i++)";
            var answer42 = "{";
            var answer43 = "Console.WriteLine(clubMember[i]);";
            var answer44 = "}";

            do
            {
                Console.WriteLine("Now you try...\n\nSort the indexes in this collection." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +
                    "\n\nList<string> clubMember = new List<string>(){ \"Sally\", \"Tom\", \"Alex\", \"Rand\", \"Warren\", \"Amy\", \"Rex\", \"Sara\" }; " +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer40)
                {
                    guess = Console.ReadLine();
                    if (guess == answer41)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer42)
                        {
                            guess = Console.ReadLine();
                            if (guess == answer43)
                            {
                                guess = Console.ReadLine();
                                if (guess == answer44)
                                {
                                    //guess = Console.ReadLine();
                                    Console.WriteLine($"\n{Compliment()}\nThe Console would read:\nAlex\nAmy\nRand\nRex\nSally\nSara\nTom\nWarren");
                                    Console.WriteLine($"_________________________________________________________________________________________");
                                    Console.WriteLine("\n\n Press Enter to continue...");
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Wrong()}\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\n{Wrong()}\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"\n{Wrong()}\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"\n{Wrong()}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{Wrong()}\n");
                }

            } while (answer40 != guess && answer41 != guess && answer42 != guess && answer43 != guess && answer44 != guess);



            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n________________________EXAMPLE___TO___HELP___YOU_________________________________________" +
            "\n\nList<int> numbers = new List<int>() { 29, 54, 12, 100, 2, 55, 99 };" +
            "\nnumbers.Sort();" +
            "\nfor (int i = 0; i < numbers.Count; i++)" +
            "\n{" +
                "\nConsole.WriteLine(numbers[i]);" +
            "\n}");

            var answer45 = "myBool.Sort();";
            var answer46 = "for (int i = 0; i < myBool.Count; i++)";
            var answer47 = "{";
            var answer48 = "Console.WriteLine(myBool[i]);";
            var answer49 = "}";

            do
            {
                Console.WriteLine("\n\nSort the indexes in this collection." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +
                    "\n\nList<bool> myBool = new List<bool>(){ true, true, false, false, true, false, true }; " +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer45)
                {
                    guess = Console.ReadLine();
                    if (guess == answer46)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer47)
                        {
                            guess = Console.ReadLine();
                            if (guess == answer48)
                            {
                                guess = Console.ReadLine();
                                if (guess == answer49)
                                {
                                    //guess = Console.ReadLine();
                                    Console.WriteLine($"\n{Compliment()}\nThe Console would read:\nFalse\nFalse\nFalse\nTrue\nTrue\nTrue\nTrue");
                                    Console.WriteLine($"_________________________________________________________________________________________");
                                    Console.WriteLine("\n\n Press Enter to continue...IF YOU DARE");
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Wrong()}\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\n{Wrong()}\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"\n{Wrong()}\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"\n{Wrong()}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{Wrong()}\n");
                }

            } while (answer45 != guess && answer46 != guess && answer47 != guess && answer48 != guess && answer49 != guess);

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n_______NO___EXAMPLE___THIS___TIME______HUAHAHAHA___HAHHAHAHA__(Echoing...Echoing...Use your imagination.)_____");

            var answer50 = "myDouble.Sort();";
            var answer51 = "for (int i = 0; i < myDouble.Count; i++)";
            var answer52 = "{";
            var answer53 = "Console.WriteLine(myDouble[i]);";
            var answer54 = "}";

            do
            {
                Console.WriteLine("\n\nSort the indexes in this collection." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +
                    "\n\nList<double> myDouble = new List<double>(){ 12.34, 56.78, 91.23, 45, 67, 89.12, 34.56 }; " +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer50)
                {
                    guess = Console.ReadLine();
                    if (guess == answer51)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer52)
                        {
                            guess = Console.ReadLine();
                            if (guess == answer53)
                            {
                                guess = Console.ReadLine();
                                if (guess == answer54)
                                {
                                    //guess = Console.ReadLine();
                                    Console.WriteLine($"\n{Compliment()}\nThe Console would read:\n12.34\n34.56\n45.67\n56.78\n89.12\n91.23");
                                    Console.WriteLine($"_________________________________________________________________________________________");
                                    Console.WriteLine("\n\n Press Enter to continue... I TRIPLE DOG DARE YOU!");
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Wrong()}\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\n{Wrong()}\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"\n{Wrong()}\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"\n{Wrong()}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{Wrong()}\n");
                }

            } while (answer50 != guess && answer51 != guess && answer52 != guess && answer53 != guess && answer54 != guess);



            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n_______YEP - GOOD LUCK!_____");


            var answer55 = "mySentence.Sort();";
            var answer56 = "for (int i = 0; i < mySentence.Count; i++)";
            var answer57 = "{";
            var answer58 = "Console.WriteLine(mySentence[i]);";
            var answer59 = "}";

            do
            {
                Console.WriteLine("\n\nSort the indexes in this collection." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +
                    "\n\nList<string> mySentence = new List<string>() { \"forth\", \"coder\", \"gigabyte\", \"it\", \"just\", \"bold\", \"every\", \"a\", \"however\", \"delivers\", \"keeps\", \"Lists\"};" +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer55)
                {
                    guess = Console.ReadLine();
                    if (guess == answer56)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer57)
                        {
                            guess = Console.ReadLine();
                            if (guess == answer58)
                            {
                                guess = Console.ReadLine();
                                if (guess == answer59)
                                {
                                    //guess = Console.ReadLine();
                                    Console.WriteLine($"\n{Compliment()}\nThe Console would read:\na\nbold\ncoder\ndelivers\nevery\nforth\ngigabyte\nhowever\nit\njust\nkeeps\nLists");
                                    Console.WriteLine($"_________________________________________________________________________________________");
                                    Console.WriteLine("\n\n Press Enter to continue...");
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Wrong()}\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\n{Wrong()}\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"\n{Wrong()}\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"\n{Wrong()}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{Wrong()}\n");
                }

            } while (answer55 != guess && answer56 != guess && answer57 != guess && answer58 != guess && answer59 != guess);
            ListControlOptions();

        }
        public static void Reverse()
        {
            Console.Clear();
            Console.WriteLine("\n Yes, this looks like the previous one, but it is different." +
            "\n**NOTE** If you don't know your 'FOREACH loop' " +
            "\nyou will need to know it before using this tool." +
            "\n\n**SPECIAL NOTE **What we do here can be used with Sort as well (I just didn't figure it out until now)." +
            "\n\nExamine this List: \n\nList<int> myNumbers = new List<int>(){ 29, 54, 12, 100, 2, 55, 99 };\n\n" +
            "How do we REVERSE this list from the last thing listed to the first thing?" +
            "\nWe use the 'REVERSE' property." +
            "\nThis is another one we can call on the console but is a bit less involved. \n\n Press Enter to continue...");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("" +
            "\n1. We call on the List Name and the REVERSE property:\n\t\t myNumbers.Reverse" +
            "\n2. We need a 'foreach loop' but change the word 'collection' to the name of the list\n\n foreach (var item in myNumbers)" +
            "\n3. In the Scope {}, we call on the console to display the list and the collection in order:\n\t\t Console.WriteLine(item);" +
            "\n\nAll together it looks like this: " +
            "\n__________________________________________________________________________" +
            "\n\nList<int> numbers = new List<int>() { 29, 54, 12, 100, 2, 55, 99 };" +
            "\nnumbers.Reverse();" +
            "\nforeach (var item in collection)" +
            "\n{" +
                "\nConsole.WriteLine(item);" +
            "\n}");

            var guess = "";
            var answer60 = "userAge.Reverse();";
            var answer61 = "foreach (var item in userAge)";
            var answer62 = "{";
            var answer63 = "Console.WriteLine(item);";
            var answer64 = "}";

            do
            {
                Console.WriteLine("\n__________________________________________________________________________" +
                    "\nNow you try...\nReverse the indexes in this collection." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                    "\n\nList<int> userAge = new List<int>(){ 100, 200, 300, 400, 500 }; " +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer60)
                {
                    guess = Console.ReadLine();
                    if (guess == answer61)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer62)
                        {
                            guess = Console.ReadLine();
                            if (guess == answer63)
                            {
                                guess = Console.ReadLine();
                                if (guess == answer64)
                                {
                                    //guess = Console.ReadLine();
                                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: \n500\n400\n300\n200\n100");
                                    Console.WriteLine($"_________________________________________________________________________________________");
                                    Console.WriteLine("\n\n Press Enter to continue...");
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Wrong()}\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\n{Wrong()}\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"\n{Wrong()}\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"\n{Wrong()}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{Wrong()}\n");
                }

            } while (answer60 != guess && answer61 != guess && answer62 != guess && answer63 != guess && answer64 != guess);

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n________________________EXAMPLE___TO___HELP___YOU_________________________________________" +
            "\n\nList<int> numbers = new List<int>() { 29, 54, 12, 100, 2, 55, 99 };" +
            "\nnumbers.Reverse();" +
            "\nforeach (var item in numbers)" +
            "\n{" +
                "\nConsole.WriteLine(item);" +
            "\n}");
            var answer65 = "myLyrics.Reverse();";
            var answer66 = "foreach (var item in myLyrics)";
            var answer67 = "{";
            var answer68 = "Console.WriteLine(item);";
            var answer69 = "}";

            do
            {
                Console.WriteLine("\n__________________________________________________________________________" +
                    "\nNow you try...\nReverse the indexes in this collection." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                    "\n\nList<string> myLyrics = new List<string>(){ \"Do\", \"Ti\", \"La\", \"So\", \"Fa\", \"Me\", \"Re\", \"Do\"};" +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer65)
                {
                    guess = Console.ReadLine();
                    if (guess == answer66)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer67)
                        {
                            guess = Console.ReadLine();
                            if (guess == answer68)
                            {
                                guess = Console.ReadLine();
                                if (guess == answer69)
                                {
                                    //guess = Console.ReadLine();
                                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: \nDo\nRe\nMe\nFa\nSo\nLa\nTi\nDo");
                                    Console.WriteLine($"_________________________________________________________________________________________");
                                    Console.WriteLine("\n\n Press Enter to continue...");
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Wrong()}\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\n{Wrong()}\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"\n{Wrong()}\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"\n{Wrong()}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{Wrong()}\n");
                }

            } while (answer65 != guess && answer66 != guess && answer67 != guess && answer68 != guess && answer69 != guess);

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n________________________EXAMPLE___TO___HELP___YOU_________________________________________" +
            "\n\nList<int> numbers = new List<int>() { 29, 54, 12, 100, 2, 55, 99 };" +
            "\nnumbers.Reverse();" +
            "\nforeach (var item in numbers)" +
            "\n{" +
                "\nConsole.WriteLine(item);" +
            "\n}");
            var answer70 = "myTruth.Reverse();";
            var answer71 = "foreach (var item in myTruth)";
            var answer72 = "{";
            var answer73 = "Console.WriteLine(item);";
            var answer74 = "}";

            do
            {
                Console.WriteLine("\n__________________________________________________________________________" +
                    "\nNow you try...\nReverse the indexes in this collection." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                    "\n\nList<bool> myTruth = new List<bool>(){ true, true, true, false, false, false };" +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer70)
                {
                    guess = Console.ReadLine();
                    if (guess == answer71)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer72)
                        {
                            guess = Console.ReadLine();
                            if (guess == answer73)
                            {
                                guess = Console.ReadLine();
                                if (guess == answer74)
                                {
                                    //guess = Console.ReadLine();
                                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: \nfalse\nfalse\nfalse\ntrue\ntrue\ntrue");
                                    Console.WriteLine($"_________________________________________________________________________________________");
                                    Console.WriteLine("\n\n Press Enter to continue...");
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Wrong()}\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\n{Wrong()}\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"\n{Wrong()}\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"\n{Wrong()}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{Wrong()}\n");
                }

            } while (answer70 != guess && answer71 != guess && answer72 != guess && answer73 != guess && answer74 != guess);

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n________________________No____Example____To____Test____You___________________________");

            var answer75 = "myDouble.Reverse();";
            var answer76 = "foreach (var item in myDouble)";
            var answer77 = "{";
            var answer78 = "Console.WriteLine(item);";
            var answer79 = "}";

            do
            {
                Console.WriteLine("\n__________________________________________________________________________" +
                    "\nNow you try...\nReverse the indexes in this collection." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                    "\n\nList<double> myDouble = new List<double>(){ 0.4, 0.03, 0.002, 0.0001 };" +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer75)
                {
                    guess = Console.ReadLine();
                    if (guess == answer76)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer77)
                        {
                            guess = Console.ReadLine();
                            if (guess == answer78)
                            {
                                guess = Console.ReadLine();
                                if (guess == answer79)
                                {
                                    //guess = Console.ReadLine();
                                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: \n0.0001\n0.002\n0.03\n0.4");
                                    Console.WriteLine($"_________________________________________________________________________________________");
                                    Console.WriteLine("\n\n Press Enter to continue...");
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Wrong()}\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\n{Wrong()}\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"\n{Wrong()}\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"\n{Wrong()}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{Wrong()}\n");
                }

            } while (answer75 != guess && answer76 != guess && answer77 != guess && answer78 != guess && answer79 != guess);

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n________________________Someday you will be all alone...to reverse a list all by yourself___________________________");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n_____________________________________________That day is today.______________________________________________________");

            var answer80 = "myLetters.Reverse();";
            var answer81 = "foreach (var item in myLetters)";
            var answer82 = "{";
            var answer83 = "Console.WriteLine(item);";
            var answer84 = "}";

            do
            {
                Console.WriteLine("\n__________________________________________________________________________" +
                    "\nNow you try...\nReverse the indexes in this collection." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                    "\n\nList<string> myLetters = new List<string>(){ \"k\", \"j\", \"i\", \"h\", \"g\", \"f\", \"e\", \"d\", \"c\", \"b\", \"a\", };" +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer80)
                {
                    guess = Console.ReadLine();
                    if (guess == answer81)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer82)
                        {
                            guess = Console.ReadLine();
                            if (guess == answer83)
                            {
                                guess = Console.ReadLine();
                                if (guess == answer84)
                                {
                                    //guess = Console.ReadLine();
                                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: \na\nb\nc\nd\ne\nf\ng\nh\ni\nj\nk");
                                    Console.WriteLine($"_________________________________________________________________________________________");
                                    Console.WriteLine("\n\n Press Enter to continue...");
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Wrong()}\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\n{Wrong()}\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"\n{Wrong()}\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"\n{Wrong()}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{Wrong()}\n");
                }

            } while (answer80 != guess && answer81 != guess && answer82 != guess && answer83 != guess && answer84 != guess);


            ListControlOptions();

        }
        public static void Contains()
        {

            Console.Clear();
            Console.WriteLine("\nThis little function is like a breath of fresh air." +
            "\nThis function is checking wheather an item is present in the list or not." +
            "\nIt will return True or False. Below is how this is accomplished." +
            "\n1. We call on the Console" +
            "\n\t\tConsole.WriteLine();" +
            "\n2. Next in the parenthesis we call on our particular list name\n\t\tConsole.WriteLine(userAge);" +
            "\n3. Then after the list name we call on the command Contains\n\t\tConsole.WriteLine(userAge.Contains);" +
            "\n4. Finally we write in a NEW SET OF PARENTHESIS what we are looking for\n\t\tConsole.WriteLine(userAge.Contains(26));" +
            "\n5. The console will then print True is the item is found or False if it is not found " +
            "\n\nAll together it looks like this: " +
            "\n__________________________________________________________________________" +
            "\n\nList<int> numbers = new List<int>() { 29, 54, 12, 100, 2, 55, 99 };" +
            "\nConsole.WriteLine(numbers.Contains(29));" +
            "\nTrue");

            var guess = "";
            var answer65 = "Console.WriteLine(userAge.Contains(200));";
            do
            {
                Console.WriteLine("\n__________________________________________________________________________" +
                    "\nNow you try...\nDoes this collection include the number 200?." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                    "\n\nList<int> userAge = new List<int>(){ 100, 200, 300, 400, 500 }; " +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer65)
                {
                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: True");
                    Console.WriteLine($"_________________________________________________________________________________________");
                    Console.WriteLine("\n\n Press Enter to continue...");
                }
                else
                {

                    Console.WriteLine($"\n{Wrong()}\n");

                }

            } while (answer65 != guess);

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n________________________EXAMPLE___TO___HELP___YOU_________________________________________" +
            "\n\nList<int> numbers = new List<int>() { 29, 54, 12, 100, 2, 55, 99 };" +
            "\nConsole.WriteLine(numbers.Contains(29))" +
            "\nTrue");

            var answer66 = "Console.WriteLine(myLyrics.Contains(\"Bo\"));";
            do
            {
                Console.WriteLine("\n__________________________________________________________________________" +
                    "\nNow you try...\nDoes this collection include the string Bo?." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                    "\n\nList<string> myLyrics = new List<string>(){ \"Do\", \"Ti\", \"La\", \"So\", \"Fa\", \"Me\", \"Re\", \"Do\"};" +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer66)
                {
                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: False");
                    Console.WriteLine($"_________________________________________________________________________________________");
                    Console.WriteLine("\n\n Press Enter to continue...");
                }
                else
                {

                    Console.WriteLine($"\n{Wrong()}\n");

                }

            } while (answer66 != guess);

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n________________________EXAMPLE___TO___HELP___YOU_________________________________________" +
            "\n\nList<int> numbers = new List<int>() { 29, 54, 12, 100, 2, 55, 99 };" +
            "\nConsole.WriteLine(numbers.Contains(29))" +
            "\nTrue");

            var answer67 = "Console.WriteLine(pets.Contains(\"Spot\"));";
            do
            {
                Console.WriteLine("\n__________________________________________________________________________" +
                    "\nNow you try...\nDoes this collection include the string Spot?." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                    "\n\nvar pets = new List<string>(){ \"Spot\", \"Hammy\", \"Whiskers\" }; " +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer67)
                {
                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: True");
                    Console.WriteLine($"_________________________________________________________________________________________");
                    Console.WriteLine("\n\n Press Enter to continue...");
                }
                else
                {

                    Console.WriteLine($"\n{Wrong()}\n");

                }

            } while (answer67 != guess);


            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n__________Yep, this is what it will be like.____It's ok,  you can ask Sally for help again for the millinth time today._______________");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n_________________________________________________You could Google it.___________________________________________");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n__________________________________Or you can be the MASTER that I know is in you!___________________________________");


            var answer68 = "Console.WriteLine(crazyList.Contains(22.213));";
            do
            {
                Console.WriteLine("\n__________________________________________________________________________" +
                    "\nNow you try...\nDoes this collection include the double 22.213?." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                "\nList<double> crazyList = new List<double>() { 2.2, 20.2, 22.2, 22.22, 222.22, 222.2, 0.2, 0.22, 0.222, 21.21, 11.22, 211.12, 111.222, 2.3, 30.3, 33.3, 22.213, 33.33, 333.33, 333.3, 0.3, 0.33, 0.333, 0.3313, 31.31, 11.33, 311.13, 111.333, 4.4, 40.4, 44.4, 44.44, 444.44, 444.4, 0.4, 0.44, 0.444, 41.41, 11.44, 411.14, 111.444, 4.3, 30.3, 33.3, 44.413, 33.33, 333.33, 333.3, 0.3, 0.33, 0.333, 0.3313, 31.31, 11.33, 311.13, 111.333 "+
                "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer68)
                {
                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: True");
                    Console.WriteLine($"_________________________________________________________________________________________");
                    Console.WriteLine("\n\n Press Enter to continue...");
                }
                else
                {

                    Console.WriteLine($"\n{Wrong()}\n");

                }

            } while (answer68 != guess);


            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n____________________________________________________________________");


            var answer69 = "Console.WriteLine(easyOut.Contains(55));";
            do
            {
                Console.WriteLine("\n__________________________________________________________________________" +
                    "\nNow you try...\nDoes this collection include the int 55?." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +
                    "\nList<int> easyOut = new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }"+
                "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer69)
                {
                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: False");
                    Console.WriteLine($"_________________________________________________________________________________________");
                    Console.WriteLine("\n\n Press Enter to continue...");
                }
                else
                {

                    Console.WriteLine($"\n{Wrong()}\n");

                }

            } while (answer69 != guess);

            ListControlOptions();
        }
        public static void IndexOf()
        {
            Console.Clear();
            Console.WriteLine("\nThis little function is like the CONTAINS." +
            "\nExcept this function is finding the INDEX location of a particular item." +
            "\nRemember how the INDEX begins with 0 and NOT 1." +
            "\nIt will return the index location number to the console. Below is how this is accomplished." +
            "\n1. We call on the Console" +
            "\n\t\tConsole.WriteLine();" +
            "\n2. Next in the parenthesis we call on our particular list name\n\t\tConsole.WriteLine(userAge);" +
            "\n3. Then after the list name we call on the command IndexOf\n\t\tConsole.WriteLine(userAge.IndexOf);" +
            "\n4. Finally we write in a NEW SET OF PARENTHESIS what we are looking for\n\t\tConsole.WriteLine(userAge.Contains(26));" +
            "\n5. The console will then print index number of the item looked for." +
            "\n\nPress Enter to continue... ");
             Console.ReadKey();
            Console.Clear();
            Console.WriteLine("All together it looks like this: " +
            "\n__________________________________________________________________________" +
            "\n\nList<int> numbers = new List<int>() { 29, 54, 12, 100, 2, 55, 99 };" +
            "\nConsole.WriteLine(numbers.IndexOf(29));" +
            "\nConsole prints: 0 (Because 29 is in the 0 position.)");
          

            var guess = "";
            var answer65 = "Console.WriteLine(userAge.IndexOf(200));";
            do
            {
                Console.WriteLine("\n__________________________________________________________________________" +
                    "\nNow you try...\nWhat is the index number of 200?." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                    "\n\nList<int> userAge = new List<int>(){ 100, 200, 300, 400, 500 }; " +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer65)
                {
                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: 1");
                    Console.WriteLine($"_________________________________________________________________________________________");
                    Console.WriteLine("\n\n Press Enter to continue...");
                }
                else
                {

                    Console.WriteLine($"\n{Wrong()}\n");

                }

            } while (answer65 != guess);












            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n________________________EXAMPLE___TO___HELP___YOU_________________________________________" +
            "\n\nList<int> numbers = new List<int>() { 29, 54, 12, 100, 2, 55, 99 };" +
            "\nConsole.WriteLine(numbers.IndexOf(29))" +
            "\0");

            var answer66 = "Console.WriteLine(myLyrics.IndexOf(\"Me\"));";
            do
            {
                Console.WriteLine("\n__________________________________________________________________________" +
                    "\nNow you try...\nDoes this collection include the string Bo?." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                    "\n\nList<string> myLyrics = new List<string>(){ \"Do\", \"Ti\", \"La\", \"So\", \"Fa\", \"Me\", \"Re\", \"Do\"};" +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer66)
                {
                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: 5");
                    Console.WriteLine($"_________________________________________________________________________________________");
                    Console.WriteLine("\n\n Press Enter to continue...");
                }
                else
                {

                    Console.WriteLine($"\n{Wrong()}\n");

                }

            } while (answer66 != guess);



            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n________________________EXAMPLE___TO___HELP___YOU_________________________________________" +
            "\n\nList<int> numbers = new List<int>() { 29, 54, 12, 100, 2, 55, 99 };" +
            "\nConsole.WriteLine(numbers.IndexOf(12))" +
            "\n2");

            var answer67 = "Console.WriteLine(pets.IndexOf(\"Whiskers\"));";
            do
            {
                Console.WriteLine("\n__________________________________________________________________________" +
                    "\nNow you try...\nWhat is the index number of Whiskers?." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                    "\n\nvar pets = new List<string>(){ \"Spot\", \"Hammy\", \"Whiskers\" }; " +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer67)
                {
                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: 2");
                    Console.WriteLine($"_________________________________________________________________________________________");
                    Console.WriteLine("\n\n Press Enter to continue...");
                }
                else
                {

                    Console.WriteLine($"\n{Wrong()}\n");

                }

            } while (answer67 != guess);


            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n_______________________________________No Example_______________________________________________");



            var answer68 = "Console.WriteLine(crazyList.IndexOf(22.213));";
            do
            {
                Console.WriteLine("\n__________________________________________________________________________" +
                    "\nNow you try...\nWhere is the index location of the double 22.213?." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                "\nList<double> crazyList = new List<double>() { 2.2, 20.2, 22.2, 22.22, 222.22, 222.2, 0.2, 0.22, 0.222, 21.21, 11.22, 211.12, 111.222, 2.3, 30.3, 33.3, 22.213, 33.33, 333.33, 333.3, 0.3, 0.33, 0.333, 0.3313, 31.31, 11.33, 311.13, 111.333, 4.4, 40.4, 44.4, 44.44, 444.44, 444.4, 0.4, 0.44, 0.444, 41.41, 11.44, 411.14, 111.444, 4.3, 30.3, 33.3, 44.413, 33.33, 333.33, 333.3, 0.3, 0.33, 0.333, 0.3313, 31.31, 11.33, 311.13, 111.333 " +
                "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer68)
                {
                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: 44");
                    Console.WriteLine($"_________________________________________________________________________________________");
                    Console.WriteLine("\n\n Press Enter to continue...");
                }
                else
                {

                    Console.WriteLine($"\n{Wrong()}\n");

                }

            } while (answer68 != guess);




            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n____________________________________________________________________");


            var answer69 = "Console.WriteLine(easyOut.IndexOf(8));";
            do
            {
                Console.WriteLine("\n__________________________________________________________________________" +
                    "\nNow you try...\nWhat is the index location of int 8?." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +
                    "\nList<int> easyOut = new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }" +
                "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer69)
                {
                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: 7");
                    Console.WriteLine($"_________________________________________________________________________________________");
                    Console.WriteLine("\n\n Press Enter to continue...");
                }
                else
                {

                    Console.WriteLine($"\n{Wrong()}\n");

                }

            } while (answer69 != guess);



            ListControlOptions();

        }
     /// <summary>
     /// ///////////////////////////////////////////////////////////////////////////////////////////
     /// </summary>
        public static void Add()
        {
            Console.Clear();
            Console.WriteLine("\n**NOTE** If you don't know your 'FOR loop' and the Count property above, \nyou will need to know them before using this tool." +
            "\n\nExamine this List: \n\nList<int> numbers = new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9 };\n\n" +
            "How do we ADD to this list?" +
            "\nWe use the 'Add' property. This will add an item to the END of our List." +
            "\nIn this one, you don't need to call on the console, but you won't be able to see your work unless you do.\n\n Press Enter to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("" +
            "\n1. We call on the List Name, and the Add property, and include what we want to add in the parameters(parenthesis).\n\t\t myNumbers.Add(10);" +
            "\n2. We need a 'for loop' " +
            "\n3. Then we use the 'Count' property in the 'conditional' so that all of the numbers on the List are examined:\n\t\ti < numbers.Count;" +
            "\n4. In the Scope {}, we call on the console to display the list and the collection in order:\n\t\t Console.WriteLine(numbers[i]);" +
            "\n__________________________________________________________________________" +
            "\n\nAll together it looks like this: " +
            "\n\nList<int> numbers = new List<int>() { 29, 54, 12, 100, 2, 55, 99 };" +
            "\nnumbers.Add(10);" +
            "\nfor (int i = 0; i < numbers.Count; i++)" +
            "\n{" +
                "\nConsole.WriteLine(numbers[i]);" +
            "\n}" +
            "The console will print now the numbers 1 through 10.");

            var guess = "";
            var answer35 = "myLevel.Add(1);";
            var answer36 = "for (int i = 0; i < myLevel.Count; i++)";
            var answer37 = "{";
            var answer38 = "Console.WriteLine(myLevel[i]);";
            var answer39 = "}";

            do
            {
                Console.WriteLine("Now you try...\n\nAdd the number 1 to the end of this list." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                    "\n\nList<int> myLevel = new List<int>(){ 10, 9, 8, 7, 6, 5, 4, 3, 2 }; " +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer35)
                {
                    guess = Console.ReadLine();
                    if (guess == answer36)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer37)
                        {
                            guess = Console.ReadLine();
                            if (guess == answer38)
                            {
                                guess = Console.ReadLine();
                                if (guess == answer39)
                                {
                                    //guess = Console.ReadLine();
                                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: \n10\n9\n8\n7\n6\n5\n4\n3\n2\n1 <--this is new");
                                    Console.WriteLine($"_________________________________________________________________________________________");
                                    Console.WriteLine("\n\n Press Enter to continue...");
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Wrong()}\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\n{Wrong()}\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"\n{Wrong()}\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"\n{Wrong()}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{Wrong()}\n");
                }

            } while (answer35 != guess && answer36 != guess && answer37 != guess && answer38 != guess && answer39 != guess);



            ListControlOptions();
        }
      
        public static void Insert()
        {
            Console.Clear();
            Console.WriteLine("\n**NOTE** If you don't know your 'FOR loop' and the Count property above, \nyou will need to know them before using this tool." +
            "\n\nExamine this List: \n\nList<int> numbers = new List<int>(){ 1, 2, 3, 4, 6, 7, 8, 9, 10 };\n\n" +
            "How do we INSERT A NUMBER into this list?" +
            "\nWe use the 'Insert' property. This will add an item wherever you want to put it in the list." +
            "\nIn this one, you don't need to call on the console, but you won't be able to see your work unless you do.\n\n Press Enter to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("" +
            "\n1. We call on the List Name, the Insert property, and include THREE things parameters(parenthesis)." +
            "\n\t\ta) The index number WHERE we want our item to go. "+
            "\n\t\tb) a comma ',' " +
            "\n\t\tc) The item we want to insert. " +
            "\nIt Looks like this:"+
            "\n\t\t myNumbers.Add(4, 5);" +
            "\n2. We need a 'for loop' " +
            "\n3. Then we use the 'Insert' property in the 'conditional' so that all of the numbers on the List are examined:\n\t\ti < numbers.Count;" +
            "\n4. In the Scope {}, we call on the console to display the list and the collection in order:\n\t\t Console.WriteLine(numbers[i]);" +
            "\n__________________________________________________________________________" +
            "\n\nAll together it looks like this: " +
            "\n\nList<int> numbers = new List<int>() { 1, 2, 3, 4, 6, 7, 8, 9, 10};" +
            "\nnumbers.Insert(4, 5);" +
            "\nfor (int i = 0; i < numbers.Count; i++)" +
            "\n{" +
                "\nConsole.WriteLine(numbers[i]);" +
            "\n}" +
            "The console will print now the numbers 1 through 10.");

            var guess = "";
            var answer35 = "myLevel.Insert(5, 5);";
            var answer36 = "for (int i = 0; i < myLevel.Count; i++)";
            var answer37 = "{";
            var answer38 = "Console.WriteLine(myLevel[i]);";
            var answer39 = "}";

            do
            {
                Console.WriteLine("Now you try...\n\nSort the indexes in this collection." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                    "\n\nList<int> myLevel = new List<int>(){ 10, 9, 8, 7, 6, 4, 3, 2, 1 }; " +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer35)
                {
                    guess = Console.ReadLine();
                    if (guess == answer36)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer37)
                        {
                            guess = Console.ReadLine();
                            if (guess == answer38)
                            {
                                guess = Console.ReadLine();
                                if (guess == answer39)
                                {
                                    //guess = Console.ReadLine();
                                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: \n10\n9\n8\n7\n6\n5 <--this is new\n4\n3\n2\n1");
                                    Console.WriteLine($"_________________________________________________________________________________________");
                                    Console.WriteLine("\n\n Press Enter to continue...");
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Wrong()}\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\n{Wrong()}\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"\n{Wrong()}\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"\n{Wrong()}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{Wrong()}\n");
                }

            } while (answer35 != guess && answer36 != guess && answer37 != guess && answer38 != guess && answer39 != guess);
            ListControlOptions();
        }


        public static void Remove()
        {
            Console.Clear();
            Console.WriteLine("\n**NOTE** If you don't know your 'FOREACH loop', \nyou will need to know it before using this tool." +
            "\n\nExamine this List: \n\nList<int> numbers = new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };\n\n" +
            "How do we REMOVE from this list?" +
            "\nWe use the 'Remove' property. This will delete the first occurence of the item from the list." +
            "\nIn this one, you don't need to call on the console, but you won't be able to see your work unless you do.\n\n Press Enter to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("" +
            "\n1. We call on the List Name, and the Remove property, and include what we want to remove in the parameters(parenthesis).\n\t\t myNumbers.Remove(4);" +
            "\n2. We need a 'foreach loop' " +
            "\n3. Then we use the 'Count' property in the 'conditional' so that all of the numbers on the List are examined:\n\t\ti < numbers.Count;" +
            "\n4. In the Scope {}, we call on the console to display the list and the collection in order:\n\t\t Console.WriteLine(item);" +

            "\n__________________________________________________________________________" +
            "\n\nAll together it looks like this: " +
            "\n\nList<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };" +
            "\nnumbers.Remove(4);" +
            "\nforeach (var item in numbers)" +
            "\n{" +
                "\nConsole.WriteLine(item);" +
            "\n}" +
            "The console will print now the numbers 1, 2, 3, 5, 6, 7, 8, 9, 10");

            var guess = "";
            var answer35 = "myLevel.Remove(4);";
            var answer36 = "foreach (var item in myLevel)";
            var answer37 = "{";
            var answer38 = "Console.WriteLine(item);";
            var answer39 = "}";

            do
            {
                Console.WriteLine("Now you try...\n\nRemove the number 4 from this list." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                    "\n\nList<int> myLevel = new List<int>(){ 10, 9, 8, 7, 6, 5, 4, 3, 2, 1}; " +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer35)
                {
                    guess = Console.ReadLine();
                    if (guess == answer36)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer37)
                        {
                            guess = Console.ReadLine();
                            if (guess == answer38)
                            {
                                guess = Console.ReadLine();
                                if (guess == answer39)
                                {
                                    //guess = Console.ReadLine();
                                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: \n10\n9\n8\n7\n6\n5\n3\n2\n1");
                                    Console.WriteLine($"_________________________________________________________________________________________");
                                    Console.WriteLine("\n\n Press Enter to continue...");
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Wrong()}\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\n{Wrong()}\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"\n{Wrong()}\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"\n{Wrong()}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{Wrong()}\n");
                }

            } while (answer35 != guess && answer36 != guess && answer37 != guess && answer38 != guess && answer39 != guess);

            ListControlOptions();
        }

       
        public static void RemoveAt()
        {

            Console.Clear();
            Console.WriteLine("\n**NOTE** If you don't know your 'FOREACH loop', \nyou will need to know it before using this tool." +
            "\n\nExamine this List: \n\nList<int> numbers = new List<int>(){ 1, 2, 3, 4, 6, 7, 8, 9, 10 };\n\n" +
            "How do we REMOVE from a specific location on this list?" +
            "\nWe use the 'RemoveAt' property. This will Remove an item from a specific place on the list." +
            "\nIn this one, you don't need to call on the console, but you won't be able to see your work unless you do.\n\n Press Enter to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("" +
            "\n1. We call on the List Name, the RemoveAt property." +
            "\nIt Looks like this:" +
            "\n\t\tnumbers.RemoveAt(4);" +
            "\n2. We need a 'foreach loop' " +


            "\n3. Change the word 'collection' to whatever the name of your string is:\n\t\tforeach (var item in numbers);" +
            "\n4. In the Scope {}, we call on the console to display the list and the collection in order:\n\t\t Console.WriteLine(item);" +

            "\n__________________________________________________________________________" +
            "\n\nAll together it looks like this: " +
            "\n\nList<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };" +
            "\nnumbers.RemoveAt(4);" +
            "\nforeach (var item in numbers)" +
            "\n{" +
                "\nConsole.WriteLine(item);" +
            "\n}" +
            "The console will print now the numbers 1, 2, 3, 4, 6, 7, 8, 9, 10");

            var guess = "";
            var answer35 = "myLevel.RemoveAt(4);";
            var answer36 = "foreach (var item in myLevel)";
            var answer37 = "{";
            var answer38 = "Console.WriteLine(item);";
            var answer39 = "}";

            do
            {
                Console.WriteLine("Now you try...\n\nRemove whatever indexes at number 4." +
                    "\n__________________________________________________________________________" +
                    "\n__________________________________________________________________________" +

                    "\n\nList<int> myLevel = new List<int>(){ 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }; " +
                    "\n\nWhat do you write?");
                guess = Console.ReadLine();
                if (guess == answer35)
                {
                    guess = Console.ReadLine();
                    if (guess == answer36)
                    {
                        guess = Console.ReadLine();
                        if (guess == answer37)
                        {
                            guess = Console.ReadLine();
                            if (guess == answer38)
                            {
                                guess = Console.ReadLine();
                                if (guess == answer39)
                                {
                                    //guess = Console.ReadLine();
                                    Console.WriteLine($"\n{Compliment()}\nThe Console would read: \n10\n9\n8\n7\n5\n4\n3\n2\n1");
                                    Console.WriteLine($"_________________________________________________________________________________________");
                                    Console.WriteLine("\n\n Press Enter to continue...");
                                }
                                else
                                {
                                    Console.WriteLine($"\n{Wrong()}\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\n{Wrong()}\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"\n{Wrong()}\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"\n{Wrong()}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{Wrong()}\n");
                }

            } while (answer35 != guess && answer36 != guess && answer37 != guess && answer38 != guess && answer39 != guess);

            ListControlOptions();
        }

      
        public static void arrayPractice()
        {
            ///////////////"ARRAY - ANSWERS FOR BEGINNERS///////////////////////
            var answer1000 = "int[] newRay = new int[5];";
            var guess = "";
            var wrongCount = 0;

            Console.WriteLine($"You have chosen to practice 'Arrays'. Ready to master your skills?!");
            Console.WriteLine("How many times would you like to practice 'Arrays'\n");
            int copyNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= copyNumber; i++)
                do
                {
                    Console.WriteLine("Copy this int 'array' named 'newRay' with 5 intergers:\n\nint[] newRay = new int[5];\n");
                    Console.WriteLine($"_______________________________________________________________________________");

                    guess = Console.ReadLine();
                    if (guess == answer1000)
                    {
                        Console.WriteLine($"\n{Compliment()}\n{i} of {copyNumber}");
                        Console.WriteLine($"********************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("oops. Try again.");
                        wrongCount++;
                    }

                } while (answer1000 != guess);


            Console.WriteLine("Congragulations completing the 'Arrays' practice! Would you like to practice something else?");
            MainMenu();
        }

    }










}
