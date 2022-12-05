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
    }

    public void Draw()
    {
        player.Draw();
        enemy.Draw();

        Raylib.DrawText(player.HP.ToString(), 50, 20, 25, Color.BLACK);
    }
}
