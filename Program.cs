var newRandomRoll = RandomDie.RandomRoll;
var welcomeMessage = WelcomeText.Welcome();
var winningDie = newRandomRoll();
Console.WriteLine(welcomeMessage);
string userInput;
int convertedInput;
bool isInputANumber;
int numOfGuesses = 3;

Console.WriteLine($"The winning number is {winningDie}");

for (int i = 0; i < numOfGuesses; i++)
{
    do
    {
        Console.WriteLine("Pick a number between 1-6");
        userInput = Console.ReadLine();
        isInputANumber = CheckIfNumberBetween1And6.CheckIfCorrectUserInput(userInput, out convertedInput);
        if (!isInputANumber)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
        }
    } while (!isInputANumber);

    Console.WriteLine($"You chose {convertedInput}, You have {numOfGuesses - i - 1} guesses left");

    if (convertedInput == winningDie)
    {
        Console.WriteLine("Congratulations! You guessed the correct number.");
        Console.WriteLine("Congratulations! You guessed the correct number.");
        Console.WriteLine("Congratulations! You guessed the correct number.");
        Console.WriteLine("Press any button to exit the program.");
        break;
    }
    else if (i == numOfGuesses - 1)
    {
        Console.WriteLine("You lost. No more guesses left.");
        Console.WriteLine("Press any button to exit the program.");
    }
    else
    {
        Console.WriteLine("Wrong guess. Try again.");
    }

   
}

Console.ReadKey();
