using System;

public class Characters
{
    // ArrayList API = new ArrayList();
    // API.Add(
    // RestClient starwarsClient = new RestClient("https://swapi.py4e.com/api/");
    // RestRequest request = new RestRequest("people/1/");

    // RestResponse response = starwarsClient.GetAsync(request).Result;
    // Player p = JsonSerializer.Deserialize<Player>(response.Content);
    // );
    // API.Add(
    // RestClient starwarsClient = new RestClient("https://swapi.py4e.com/api/");
    // RestRequest request = new RestRequest("people/13/");

    // RestResponse response = starwarsClient.GetAsync(request).Result;
    // Player p = JsonSerializer.Deserialize<Player>(response.Content);
    // )

    protected Color color;

    public Characters()
    {
        rect = new Rectangle(0,0,32,32);
    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, color);
    }

    public virtual void Update() 
    {
        
    }

    public weapon weapon;
    private static object starwarsClient;
    private int HP;
    private Rectangle rect;

    public void attack(Characters target)
    {
        int damage = weapon.GetDamage();
        (target.HP -= damage); 
        target.HP = Math.Max(0, target.HP);
    }
}
