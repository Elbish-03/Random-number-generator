// See https://aka.ms/new-console-template for more information
using System.Collections;



bool loop = true;
bool loop2 = true;
int versuche = 1;


while (loop2)
{
    int a = 1;
    int b = 101;


    Console.WriteLine($"Write big if the guessed number is higher or small if its lower. If its right then write correct");
    Console.WriteLine("Think of a number! If you did then press ENTER");
    Console.ReadLine();
    Console.Clear();
    loop = true;
    try
    {
        while (loop)
        {

            Random randomChoose = new Random();   //Guessed number by computer
            int compchoosedNumber = randomChoose.Next(a, b);
            Console.WriteLine($"Guess: {compchoosedNumber}");
            string rating = Console.ReadLine();


            try
            {
                if (rating == "small" || rating == "Small")
                {
                    b = compchoosedNumber;
                    b -= 1;
                    versuche++;

                }

                else if (rating == "big" || rating == "Big")
                {
                    a = compchoosedNumber;
                    a += 1;
                    versuche++;


                }
                else if (rating == "correct" || rating == "Correct")
                {
                    Console.WriteLine($"I guessed the right number at {versuche} tries");
                    Console.WriteLine("Do you want me to try again? [y|n]");
                    string tryAgain = Console.ReadLine();

                    if (tryAgain == "y")
                    {
                        versuche = 1;
                        loop = false; // while-loop is false. It will get out of this loop.
                        loop2 = true; // this loop is true that means it will start from first.

                    }
                    else if (tryAgain == "n")
                    {
                        Console.WriteLine("Thanks for Playing!");
                        loop2 = false; // while-loop is false. It will get out of this loop.
                        loop = false; //this one is also false so it will get out of another loop too and program ends. 
                    }
                }


            }
            catch
            {
                Console.WriteLine("Invalid");
                Console.WriteLine("Write big, small or correct");
                loop = true;
            }
        }
    }
    catch
    {
        Console.WriteLine("Invalid"); // The output will be Invalid
        Console.WriteLine("Do you want me to play again? [y|n]"); // It will ask you if you want to try again.
        string tryAgain = Console.ReadLine();

        if (tryAgain == "y") // If the input is yes then the loop will start again
        {
            loop = false;
            loop2 = true;

        }
        else // If the input is no then it will thank you for playing.
        {
            Console.WriteLine("Thanks for Playing!");
            loop = false;
            loop2 = false;
        }


    }
}




