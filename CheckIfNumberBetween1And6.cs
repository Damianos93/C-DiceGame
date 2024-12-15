

static class CheckIfNumberBetween1And6
{
    public static bool CheckIfCorrectUserInput(string input,out int number)
    {
        var isNumber = int.TryParse(input,out number);
        if (isNumber && number >= 1 && number <= 6)
        {   
            return true;
        }
        else
        {
            return false;
        }
    }
}