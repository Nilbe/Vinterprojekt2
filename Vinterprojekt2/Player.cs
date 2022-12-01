using System;

public class Player: Characters
{
    string name { get;set; }

    public Player()
    {
        color = Color.BLUE;
    }

      public override void Update()
  {
    if(Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
    {
      rect.x++;
    }
    if(Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
    {
      rect.x -= 1;
    }
    if(Raylib.IsKeyDown(KeyboardKey.KEY_UP))
    {
      rect.y -= 1;
    }
    if(Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
    {
      rect.y++;
    }
  }
}
