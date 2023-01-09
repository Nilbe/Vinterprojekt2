// using System;

// public class gameStart
// {
//     private Player player;
//     public int gameState = 0;
//     private Rectangle rect;
//     private Rectangle rect2;
//     private Color color;

//     public gameStart()
//     {   
//         player = new Player();

//         color = Color.BLACK;
//         rect = new Rectangle(50,50,0,0);
//         rect2 = new Rectangle(50,50,200,200);
//     }

//     public void Update()
//     {
//         player.Update();

//         if (Raylib.CheckCollisionRecs(player.rect, rect))
//         {
//             if (Raylib.IsKeyPressed(KeyboardKey.KEY_E)) gameState = 1; 
//         }
//     }
//     public void Draw()
//     {
//         player.Draw();

//         Raylib.DrawRectangleRec(rect, Color.BLACK);
//         Raylib.DrawRectangleRec(rect2, Color.BLACK);
//     }
// }
