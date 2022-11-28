using System;

public class Characters
{
    protected Rectangle rect;

    protected Color color;


    public Characters()
     {
        rect = new Rectangle(0,0,32,32);
     }

     public void Draw()
     {
        Raylib.DrawRectangleRec(rect, color);
     }

     public virtual void Update() 
     {
        
     }

    public int HP = 100;
}
