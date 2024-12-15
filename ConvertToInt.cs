static class ConvertToInt
{
    public static int TryConvertStringToInt(string userInput)
    {
        var result = Int32.Parse(userInput);
        return result;
    }
}