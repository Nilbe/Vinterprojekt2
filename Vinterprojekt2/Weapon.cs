using System;

public class weapon
{
    public string name = "lightsaber";
    public int maxDamage = 20;
    public int minDamage = 8;
    private Random generator = new();
    
    public int GetDamage()
    {
        return generator.Next(minDamage, maxDamage);
    }
}
