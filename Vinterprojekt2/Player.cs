using System;

public class Player: Characters
{
    Texture2D playerImage = Raylib.LoadTexture("luke.png");
    // internal Rectangle rect;
    public  Rectangle  rect = new Rectangle(400,300,32,32);
    internal int HP;

    public string name { get; set; }

    public string height { get; set; }

    public string mass { get; set; }

    public Player()
    {
    //   color = Color.BLUE;
    //   rect = new Rectangle(400,300,32,32);
    Raylib.DrawTexture(playerImage, (int)rect.x, (int)rect.y, Color.WHITE);
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
