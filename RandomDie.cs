



class RandomDie
{

    private static readonly Random rnd = new Random();

    public static int RandomRoll()
    {
        return rnd.Next(1, 7);
    }
}