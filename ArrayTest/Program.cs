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

        public static string Compliment()
        {
            var random = new Random();
            List<string> list = new List<string> { "Bravo!", "Excellent!", "Fantastic work!", "Fantastic!", "Good call!", "Good call!", "Good going!", "Good job!", "Good work!", "Good work!", "Great!", "I appreciate your hard work!", "I appreciate your hard work!", "I bet you sweat glitter!", "I like that!", "I like your style!", "I'm inspired by you!", "I'm very proud of you!", "I'm very proud of you!", "It’s surprising how well you perform, even under pressure!", "Keep up the great work!", "Nice going!", "Nice job!", "Nicely done!", "Now you've figured it out!", "Now you've figured it out!", "On a scale from 1 to 10, you're an 11!", "Perfect!", "Splendid!", "Superb!", "Terrific!", "That thing you don't like about yourself is what makes you so interesting!", "That's great!", "That's it!", "That's my person! (We are very PC, ha ha)", "That's right!", "There’s no one like you!", "Very good!", "Well done!", "Well look at you go!", "Well played!", "You always exceed our expectations!", "You are awesome!", "You are doing that much better today!", "You are making a difference!", "You are really good at what you do!", "You are really doing great work today!", "Think of all the people you will help with these skills!", "You are so talented!", "You are very good at that!", "You certainly are doing well today!", "You compute me!", "You deserve a raise!", "You deserve credit for everything I have accomplished!", "The work you do today will make for a better tomorrow!", "You are doing very fine job!", "You have a “Can Do” attitude!", "You must have been practicing!", "You must have been practicing!", "You should be proud of yourself!", "You were cool way before hipsters were cool!", "You’re a great example for your co-workers!", "You’re an awesome worker!", "You’re incredible!", "You’re so hardworking!", "You’re the best!", "Your hard work speaks for itself!", "Your work is unparalleled!", "Your work never ceases to amaze me!", "You're a smart cookie!", "You're all that and a super-size bag of chips!", "", "You're better than a triple-scoop ice cream cone! With sprinkles!", "You're doing a good job!", "You're learning fast!", "You're more amazing than a ball pit filled with candy! (And seriously, what could be more amazing than that?)", "You're one of a kind!", "You're really working hard today!", "You're wonderful!", "You've done a great job!", "You've just about got it!", "You've just about mastered that!" };
            int index = random.Next(list.Count);
            return list[random.Next(list.Count)];
        }


        #region"FOR" LOOP
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
            #region beginner
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
            #endregion
            #region intermediate
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
            #endregion
            #region advanced
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
        #endregion
        #endregion
        #region FOREACH LOOP
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
        #endregion
        #region WHILE LOOP
        public static void whileLoop()//DONE While Loop
        {
            /////////////// "WHILE" LOOP - ANSWERS FOR BEGINNERS///////////////////////
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
        #endregion
        #region DO-WHILE LOOP
        public static void doWhileLoop()//DONE Do-While Loop
        {
            ///////////////"DO-WHILE" LOOP - ANSWERS FOR BEGINNERS///////////////////////
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
        #endregion
        #region IF STATEMENT
        public static void ifStatement()//DONE IF Statement
        {
            ///////////////"IF" STATEMENT - ANSWERS FOR BEGINNERS///////////////////////
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
        #endregion
        #region IF-ELSE STATEMENT
        public static void ifElseStatement()
        {

            ///////////////"IF-ELSE" STATEMENT - ANSWERS FOR BEGINNERS///////////////////////
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
        #endregion
        #region IF-ELSE TERNARY STATEMENT
        public static void ifElseTernaryStatement()
        {
            ///////////////"IF-ELSE" (TERNARY) STATEMENT - ANSWERS FOR BEGINNERS///////////////////////
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
        #endregion
        #region SWITCH STATEMENT
        public static void switchStatement()
        {
            ///////////////"SWITCH" STATEMENT - ANSWERS FOR BEGINNERS///////////////////////
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
        #endregion
        #region LIST PRACTICE




        public static void List()//List Practice
        {
            Console.Clear();
            Console.WriteLine($"You have chosen to practice 'Lists'!");

            Console.WriteLine("What would you like to practice today?");
            Console.WriteLine();

            string[] forWhichLevel = { "1 List Practice", "2 Inferred vs. Explicit", "3 Types, Indexes & Values PART 1",
                "4 Types, Indexes & Values PART 2", "5 Advanced Tools - Controlling Your List", "6 Advanced Tools - Editing Your List" };
            for (int i = 0; i < forWhichLevel.Length; i++)
            {
                var begIntPro = forWhichLevel[i];
                Console.WriteLine(begIntPro);
            }

            Console.WriteLine();
            forWhichLevel[0] = "1";
            forWhichLevel[1] = "2";
            forWhichLevel[2] = "3";
            forWhichLevel[3] = "4";
            forWhichLevel[4] = "5";
            forWhichLevel[5] = "6";




            string Level = Console.ReadLine();
            #region 1 List Practice
            if (Level == forWhichLevel[0])
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

                MainMenu();
            }
            #endregion
            #region 2 Inferred vs. Explicit
            if (Level == forWhichLevel[1])
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
                #region Question 1
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
                #endregion
                #region Question 2
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
                #endregion
                #region Question 3
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
                #endregion
                #region Question 4
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
                #endregion
                #region Question 5
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
                #endregion
                #region Question 6
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
                #endregion
                #region Question 7
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
                #endregion
                #region Question 8
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
                #endregion
                #region Question 9
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
                #endregion
                #region Question 10 
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


                #endregion
            }
            #endregion
            #region 3 Type, Index & Value - PART 1
            if (Level == forWhichLevel[2])
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



                #region Question 11
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


                #endregion
                #region Question 12
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


                #endregion
                #region Question 13
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


                #endregion
                #region Question 14
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


                #endregion
                #region Question 15
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


                #endregion
            }
            #endregion
            #region 4 Type, Index & Value - PART 2

            if (Level == forWhichLevel[3])
            {
                #region Question 16
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

                #endregion
                #region Question 17
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

                #endregion
                #region Question 18
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

                #endregion
                #region Question 19
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

                #endregion
                #region Question 20
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

                #endregion

                Console.WriteLine("Congragulations completing the 'List'  practice. Would you like to practice something else?");

                MainMenu();
            }
            #endregion
            #region 5 Advanced Tools - Controlling Your List
            if (Level == forWhichLevel[4])
            {
                Console.Clear();
                Console.WriteLine("Wow! You made it this far. \nNow let's tell this List who is boss and show who is in control. You are!" +
                  "\nWe will examine a total of 5 commands that let us manage the information in our List." +
                  "\nThese are:\n\tCount\n\tSort\n\tReverse\n\tContains\n\tIdexOf" +
                  "\n\nOur goal isn't neccesarily to memorize these, but to let you know that they exist and what they do.\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Examine this List: \n\nList<int> userAges = new List<int>(){ 21, 45, 63, 78, 100, 5, 46, 98, 42, 67 };\n\n" +
                    "How do we find the total number of indexes in the collection?\nWe use the 'Count' property.\nA problem is that" +
                    " we need to see it, so we need to call it on the console. Not only do we need the console, \nbut we also need to access this particlar List." +
                    "\nWe do that by typing the NAME FIRST then '.Count', which looks like this:\n\nConsole.WriteLine(userAges.Count);\n\nSo it hase three " +
                    "parts:\n1. Console.WriteLine();\n2. The name of the List\n3. Finally the command'.Count\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                #region Question 21
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

                #endregion
                #region Question 22
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

                #endregion
                #region Question 23
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

                #endregion

                Console.WriteLine("Congragulations completing the 'List'  practice. Would you like to practice something else?");

                MainMenu();
            }

            #endregion
            #region 6 Advanced Tools - Editing your list
            if (Level == forWhichLevel[5])
            {

                #region Question 20
                var guess = "";
                var answer35 = "List<int> userAges = new List<int>(){ 21, 45, 63, 78, 100 };";
                do
                {
                    Console.WriteLine("\n\nWrite an explicitely typed List named userAges with these five integers:{ 21, 45, 63, 78, 100 };");
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

                #endregion


                Console.WriteLine("Congragulations completing the 'List'  practice. Would you like to practice something else?");

                MainMenu();
            }
            #endregion









        }
        #endregion
        #region ARRAY PRACTICE
        public static void arrayPractice()//Array Practice
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
        #endregion
    }
}

