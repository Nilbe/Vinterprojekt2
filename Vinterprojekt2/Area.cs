using System;

public class Area
{
    private Player player;
    private Enemy enemy;
    public Area()
    {
        player = new Player();
        enemy = new Enemy();
    }

    public void Update()
    {
        player.Update();
        enemy.Update();

        if (Raylib.CheckCollisionRecs(player.rect, enemy.rect))
        {
            player.attack(enemy);
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
