using System;

public class Characters
{
    public int HP = 100;
   
    public Weapon weapon;

    protected Rectangle rect;

    protected Color color;


    public Characters()
     {
        rect = new Rectangle(400,300,32,32);
     }

     public void Draw()
     {
        Raylib.DrawRectangleRec(rect, color);
     }

       public void attack(Player target)
    {
        int damage = weapon.GetDamage();
        target.HP -= damage; 
        target.HP = Math.Max(0, target.HP);
    }

     public virtual void Update() 
     {
        
     }
}
