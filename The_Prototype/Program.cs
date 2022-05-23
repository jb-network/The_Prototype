// This is challenge work for the "C# Players Guide"
// Level 11 The Prototype Challenge
// User 1 (The pilot) enters a number to guess
// User 2 (The Hunter) enters a guess
// The program will indicate if the guess was too high, too low, or is correct

String playGame;
do
{
    //Game set up
    Console.WriteLine("The Prototype Guessing Machine");
    Console.WriteLine("User 2: Please turn away from the screen");
    Console.WriteLine("Hit any key when ready");
    Console.ReadKey();
    Console.Clear();

    //Capture user1's guess
    int user1Guess;
    do
    {
        Console.WriteLine("User 1: Please enter a number between 0 and 100");
        user1Guess = Convert.ToInt32(Console.ReadLine());
    } while (user1Guess < 0 || user1Guess > 100);
    
    Console.WriteLine($"The number {user1Guess} is locked in.");
    Console.WriteLine("Hit any key to hide your number");
    Console.ReadKey();
    Console.Clear();

    //Capture user2's guess
    //Cycle and provide higher/lower feedback to user until user gets the number
    Console.WriteLine("User 2: Please turn return to the screen");

    int user2Guess = -1;
    while (user2Guess != user1Guess)
    {
        Console.WriteLine("User 2: Enter your best guess");
        user2Guess = Convert.ToInt32(Console.ReadLine());

        if (user2Guess < user1Guess) Console.WriteLine($"{user2Guess} is too low");

        else if (user2Guess > user1Guess) Console.WriteLine($"{user2Guess} is too high");

        else break;
    }
    Console.WriteLine($"Congratulation! You guessed {user2Guess} and User 1 guessed {user1Guess}");
    Console.WriteLine("This game is over, press any key to continue");
    Console.ReadKey();
    Console.Clear();

    //Play again
    Console.WriteLine("Do you want to play again: yes or no?");
    playGame = Console.ReadLine();
    Console.Clear();

} while (playGame != "no");