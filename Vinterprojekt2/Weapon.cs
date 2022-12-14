using System;

public class weapon
{
    public string name = "lightsaber";
    public int maxDamage = 80;
    public int minDamage = 70;
    private Random generator = new();
    
    public int GetDamage()
    {
        return generator.Next(minDamage, maxDamage);
    }
}
