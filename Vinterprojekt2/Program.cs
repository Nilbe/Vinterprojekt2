﻿global using Raylib_cs;
global using RestSharp;
global using System.Text.Json;
global using System.Numerics;


RestClient starwarsClient = new RestClient("https://swapi.py4e.com/api/");
RestRequest request = new RestRequest("people/1/");

RestResponse response = starwarsClient.GetAsync(request).Result;
Player p = JsonSerializer.Deserialize<Player>(response.Content);


Raylib.SetTargetFPS(60);
Raylib.InitWindow(800,600, "GAME");

Area hoth = new Area();
gameEnd end = new gameEnd();

Player player = new Player();
Enemy enemy = new Enemy();

while (!Raylib.WindowShouldClose())
{
    hoth.Update();
    end.Update();

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    
    if(player.HP > 0 && enemy.HP > 0)
    {
        hoth.Draw();
    }
    else
    {
        end.Draw();
    }
    Raylib.EndDrawing();
}