using System;

public class Area
{
    private Player player;
    private Enemy enemy;
    private bool hasAttacked = false;
    private int end = 0;
    private Vector2 textPos = new Vector2(0, 0);

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
            end = 1;
        }
        else if(player.HP == 0) 
        {
            end = 2;
        }
        else if(enemy.HP ==0)
        {
            end = 3;
        }
    }

    public void Draw()
    {
        if(end == 0)
        {
            player.Draw();
            enemy.Draw();

            Raylib.DrawText(player.HP.ToString(), 50, 20, 25, Color.BLACK);
            Raylib.DrawText(enemy.HP.ToString(), 700, 20, 25, Color.BLACK);
        }
        if(end == 1)
        {
            Raylib.DrawTextEx(default, "TIE", textPos, 20, 10, Color.BLACK);
        }
        if(end == 2)
        {
            Raylib.DrawTextEx(default, "You Lose", textPos, 20, 10, Color.BLACK);
        }
        if(end == 3)
        {
            Raylib.DrawTextEx(default, "You Win", textPos, 20, 10, Color.BLACK);
        }
    }
}