using System;

public class Player: Characters
{
    string name { get;set; }

    public Player()
    {
        rect = new Rectangle(0, 0, playerImage.width, playerImage.height);
    }

  public override void Update()
  {
    if(Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
    {
      rect.x += 2;
    }
    if(Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
    {
      rect.x -= 2;
    }
    if(Raylib.IsKeyDown(KeyboardKey.KEY_UP))
    {
      rect.y -= 2;
    }
    if(Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
    {
      rect.y += 2;
    }
  }
}
