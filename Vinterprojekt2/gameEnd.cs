// using System;

// public class gameEnd: Area
// {
//     private Player player;
//     private Enemy enemy;
//     private Vector2 textPos = new Vector2(350, 200);

//     public gameEnd()
//     {
//         player = new Player();
//         enemy = new Enemy();
//     }

//     public void Draw()
//     {
//         if(player.HP == 0 && enemy.HP == 0)
//         {
//             Raylib.DrawTextEx(default, "TIE", textPos, 20, 10, Color.BLACK);
//         }
//         else if(player.HP == 0) 
//         {
//             Raylib.DrawTextEx(default, "You Lose", textPos, 20, 10, Color.BLACK);
//         }
//         else if(enemy.HP == 0)
//         {
//             Raylib.DrawTextEx(default, "You Win", textPos, 20, 10, Color.BLACK);
//         }
//     }
// }