using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Game
    {   //setting gameOver to false
        private bool _gameOver = false;
        //making all the characters 
        Character player = new Player(name: " Player ", maxHealth: 50, attackPower: 10, defensePower: 5);
        //Character enemy = new Character(name: "Enemy", maxHealth: 100, attackPower: 9, defensePower: 5);
        Enemy enemy = new Enemy(name: " Rick the unkillable ", maxHealth: 25, attackPower: 5, defensePower: 5);
        Enemy enemy2 = new Enemy(name: "Player Killer ", maxHealth: 5, attackPower: 5, defensePower: 0);
        Enemy enemy3 = new Enemy(name: " Rick, the Unyielding Player-Killer ", maxHealth: 5000, attackPower: 5000, defensePower: 4);
        
        //a line of code that im not using 
        
        private void Start()
        {
            //Print stats for player and enemy
            player.PrintStats();
            Console.WriteLine();
            enemy.PrintStats();


        }

        private void Update()
        {
            
            //combat loop
            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine("Press (Enter Key) to attack");

                Console.ReadKey();

                Console.Clear();
                //these are the damage commands 
                Console.WriteLine(player.Name + " took " + enemy.Fight(enemy, player) + " damage! ");
                Console.WriteLine(enemy.Name + " took " + player.Fight(player, enemy) + " damage! ");
                

                player.PrintStats();
                Console.WriteLine();
                enemy.PrintStats();

                //if player dies
                if (player.Health <= 0)
                {
                    player.Die();
                    _gameOver = true;

                }
                //if enemy dies
                else if (enemy.Health <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("-----------------------------");
                    enemy.Die();
                    Console.WriteLine(" WHAT!!!");
                    Console.WriteLine(" HOW!!! ");
                    Console.WriteLine(" Bro your cheating Rick literally has the title of unkillable ");
                    Console.WriteLine(" Fine now you have to fight someone else ");
                    Console.WriteLine("Press (Enter Key) to continue");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine( enemy2.Name + " HaHaHa your done kid ima hit you with the skill issue");
                    Console.WriteLine(" Look at my super strong stats");
                    enemy2.PrintStats();

                    //enemy 2 now fights the player
                    
                    Console.WriteLine("Press (Enter Key) to attack");
                    Console.ReadKey();
                    
                    Console.WriteLine(player.Name + " took " + enemy.Fight(enemy2, player) + " damage! ");
                    Console.WriteLine();
                    Console.WriteLine(enemy2.Name + " took " + player.Fight(player, enemy2) + " damage! ");
                    Console.WriteLine();
                    
                    enemy2.Die();
                    
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine(" OK WTF!!!");
                    Console.WriteLine(" wait let me look at his stats again ");
                    Console.WriteLine("Name: Player Killer\r\nHealth: 5/5\r\nAttack Power: 5\r\nDefense Power:0");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine(" Oh ok i get it now the Dev hates me let me call him really quick " +
                        "\n ... mhm ... ok... can you spawn a elden ring type boss...please..." + "\n" +
                        " bro like this player is annoying me ... ill give you $5 (Call Ended)");
                    Console.WriteLine("Press (Enter Key) to continue");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("-------------------------------");
                    //spawning the OP boss
                    Console.WriteLine(" HaHaHa I just made the game impossible feast your eyes on these stats ");
                    enemy3.PrintStats();
                    Console.WriteLine(" Now you done RICK KILL HIM");
                    Console.WriteLine("Press (Enter Key) to attack");
                    Console.ReadKey();

                    Console.WriteLine(player.Name + " took " + enemy3.Fight(enemy3, player) + " damage! ");
                    Console.WriteLine();
                    Console.WriteLine(enemy3.Name + " took " + player.Fight(player, enemy) + " damage! ");
                    Console.WriteLine();
                    if (player.Health <= 0)
                    {
                        player.Die();
                        _gameOver = true;

                    }
                }
                
               
            }
        }

        private void End()
        {

        }

        public void Run()
        {
            Start();
            while(!_gameOver)
            {
                Update();
            }
            End();
        }
    }
}
