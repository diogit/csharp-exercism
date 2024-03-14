using System;

public class Player
{
    private Random rng = new Random();
    public int RollDie()
    {
        return rng.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        return rng.NextDouble() * 100;
    }
}
