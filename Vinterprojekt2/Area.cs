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

        while(!hasAttacked)
        {
            if (Raylib.CheckCollisionRecs(player.rect, enemy.rect))
            {
                player.attack(enemy);
                enemy.attack(player);

                hasAttacked = true;
                return;
            }
            else if(!Raylib.CheckCollisionRecs(player.rect, enemy.rect))
            {
                hasAttacked = false;
            }
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
