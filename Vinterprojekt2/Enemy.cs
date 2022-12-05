using System;

public class Enemy: Characters
{
    string name { get;set; }

    public Enemy()
    {
        color = Color.RED;
        rect = new Rectangle(500,300,32,32);
    }

}