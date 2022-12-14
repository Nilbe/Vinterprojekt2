using System;

public class Characters
{
    public int HP = 100;

    public Rectangle rect;

    protected Color color;

   // public Texture2D playerImage = Raylib.LoadTexture("luke.png");


    public Characters()
     {
        rect = new Rectangle(0,0,32,32);
     }

     public void Draw()
     {
        Raylib.DrawRectangleRec(rect, color);
        //Raylib.DrawTexture(playerImage, (int)rect.x, (int)rect.y, Color.BLACK);
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
