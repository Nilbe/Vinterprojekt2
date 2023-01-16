using System;

public class Enemy: Characters
{
    internal Rectangle rect;
    internal int HP;

    string name { get;set; }

    public Enemy()
    {
        color = Color.RED;
        rect = new Rectangle(500,300,32,32);
    }
}