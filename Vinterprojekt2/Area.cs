using System;

public class Area
{
    private Player player;

    public Area()
    {
        player = new Player();
    }

    public void Update()
    {
        player.Update();
    }

    public void Draw()
    {
        player.Draw();
    }
}
