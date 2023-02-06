using System;

public class Player: Characters
{
    Texture2D playerImage = Raylib.LoadTexture("luke.png");

    public string name { get; set; }    //variblar vars information ska hämtas från en API

    public string height { get; set; }

    public string mass { get; set; }

    public Player()
    {
      // color = Color.BLUE;
      // rect = new Rectangle(400,300,32,32);
      Raylib.DrawTexture(playerImage, (int)rect.x, (int)rect.y, Color.WHITE);
    }

  public override void Update()   //movement för spelaren
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