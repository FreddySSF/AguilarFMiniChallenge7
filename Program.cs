// Fernando Aguilar
// 10-20-22
// Mini Challenge 7 Reverse It Endpoint
// Create a program that asks the user for a number and reverses the number for them.
// Include option to replay and data validation.

Console.Clear();

Console.WriteLine( " Freddy: Hey buddy! I can reverse any number you throw at me! Just try it! ");

string playAgain = ("yes");
while(playAgain == "yes"){


string num = "";
bool isConverted = false;
bool isNumber;
int x = 0;
int y = 0;

    
while(isConverted != true){
    Console.Write("Give me a number of your choice! ");
    num = Console.ReadLine();
    isNumber = Int32.TryParse(num, out x);
    if(isNumber == true)
    {
        isConverted = true;
    }
    else
    {
        Console.WriteLine(" What's that? I need numbers buddy! ");
    }
}
 while(x != 0){
    int z = x % 10;
    y = y * 10 + z;
    x /= 10;
}
    Console.WriteLine("Here is your reversed number! " + y);
    Console.WriteLine( " Wanna try another number? ");
    Console.WriteLine( " type yes to try another number, or type no to end the program. ");
    playAgain = Console.ReadLine().ToLower();
if(playAgain.ToLower() == "no")
{
    Console.WriteLine(" Pretty cool huh? Well, I'll see ya in class tomorrow! Check ya later! ");
    isConverted = true;
}
}
