using System;

public class Area
{
    private Player player;
    private Enemy enemy;
    private gameStart gameStart;
    private bool hasAttacked = false;
    private Vector2 textPos = new Vector2(350, 200);

    public Area()
    {
        player = new Player();
        enemy = new Enemy();

        player.weapon = new weapon();
        enemy.weapon = new weapon();

        gameStart = new gameStart();
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
            gameStart.gameState = 2;
        }
        else if(player.HP == 0) 
        {
            gameStart.gameState = 3;
        }
        else if(enemy.HP == 0)
        {
            gameStart.gameState = 4;
        }
    }

    public void Draw()
    {
        if(gameStart.gameState == 1)
        {
            player.Draw();
            enemy.Draw();

            Raylib.DrawText(player.HP.ToString(), 50, 20, 25, Color.BLACK);
            Raylib.DrawText(enemy.HP.ToString(), 700, 20, 25, Color.BLACK);
        }
        if(gameStart.gameState == 2)
        {
            Raylib.DrawTextEx(default, "TIE", textPos, 20, 10, Color.BLACK);
        }
        if(gameStart.gameState == 3)
        {
            Raylib.DrawTextEx(default, "You Lose", textPos, 20, 10, Color.BLACK);
        }
        if(gameStart.gameState == 4)
        {
            Raylib.DrawTextEx(default, "You Win", textPos, 20, 10, Color.BLACK);
        }
    }
}