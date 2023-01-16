using System;

// RestClient starwarsClient = new RestClient("https://swapi.py4e.com/api/");
// RestRequest request = new RestRequest("people/1/");

// RestResponse response = starwarsClient.GetAsync(request).Result;
// Player p = JsonSerializer.Deserialize<Player>(response.Content);

public class Player: Characters
{
    internal Rectangle rect;
    internal int HP;

    public string name { get; set; }

    public string height { get; set; }

    public string mass { get; set; }

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
