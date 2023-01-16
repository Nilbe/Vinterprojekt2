global using Raylib_cs;
global using RestSharp;
global using System.Text.Json;
global using System.Numerics;
global using System.Collections;


RestClient starwarsClient = new RestClient("https://swapi.py4e.com/api/");
RestRequest request = new RestRequest("people/1/");

RestResponse response = starwarsClient.GetAsync(request).Result;
Player player = JsonSerializer.Deserialize<Player>(response.Content);


Raylib.SetTargetFPS(60);
Raylib.InitWindow(800,600, "Slagsmålsspelet i 2D");

// gameStart start = new gameStart();
Area hoth = new Area();
// gameEnd end = new gameEnd();

while (!Raylib.WindowShouldClose())
{
    // start.Update();
    hoth.Update();
    // end.Update();

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);

    // if(start.gameState == 0)
    // {
    //     start.Draw();
    // }
    // if(start.gameState == 1)
    // {
    // }

        hoth.Draw();
    Raylib.EndDrawing();
}