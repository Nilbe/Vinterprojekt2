using System;

public class Area
{
    private Player player;
    private Enemy enemy;
    private bool hasAttacked = false;

    public Area()
    {
        player = new Player();
        enemy = new Enemy();

        player.weapon = new weapon();
        enemy.weapon = new weapon();
    }

    public void Update()
    {
        player.Update();
        enemy.Update();

        if (Raylib.CheckCollisionRecs(player.rect, enemy.rect))
        {
            if (hasAttacked)
            {
                return;
            }
            player.attack(enemy);
            enemy.attack(player);

            hasAttacked = true;
        }
        else
        {
            hasAttacked = false;
        }
        
        if(player.HP == 0 && enemy.HP == 0)
        {
            
        }
        else if(player.HP == 0 || enemy.HP == 0) 
        {
           
        }
    }

    public void Draw()
    {
        player.Draw();
        enemy.Draw();

        Raylib.DrawText(player.HP.ToString(), 50, 20, 25, Color.BLACK);
        Raylib.DrawText(enemy.HP.ToString(), 700, 20, 25, Color.BLACK);
    }
}