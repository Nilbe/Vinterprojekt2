global using Raylib_cs;
using RestSharp;
using System.Text.Json;

RestClient starwarsClient = new RestClient("https://swapi.py4e.com/api/");
RestRequest request = new RestRequest("people/1/");

RestResponse response = starwarsClient.GetAsync(request).Result;
Player p = JsonSerializer.Deserialize<Player>(response.Content);


Raylib.SetTargetFPS(60);
Raylib.InitWindow(800,600, "GAME");

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
        
    

    Raylib.EndDrawing();
}