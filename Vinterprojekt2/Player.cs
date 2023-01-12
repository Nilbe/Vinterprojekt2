using System;

public class Player: Characters
{
    string name { get;set; }

    public Player()
    {
      color = Color.BLUE;
      rect = new Rectangle(400,300,32,32);
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
