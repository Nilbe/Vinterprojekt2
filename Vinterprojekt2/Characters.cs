using System;

public class Characters
{
    public int HP = 100;

    public Rectangle rect;

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

    public weapon weapon;
    public void attack(Characters target)
    {
        int damage = weapon.GetDamage();
        target.HP -= damage; 
        target.HP = Math.Max(0, target.HP);
    }
}
