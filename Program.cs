using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedCombatGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 40;
            int enemyHp = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;

            Random random = new Random();

            while(playerHp > 0 && enemyHp > 0)
            {
                //  Player turn

                Console.WriteLine();

                Console.WriteLine("-- Player Turn --");
                Console.WriteLine("Player Hp - " + playerHp + ". Enemy Hp - " + enemyHp);
                Console.WriteLine("Enter 'a' to attack or 'h' to heal");

                string choice = Console.ReadLine();

                if(choice == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine("Player attack enemy and deals " + playerAttack + " damage!");
                }
                else
                {
                    playerHp += healAmount;
                    Console.WriteLine("Player restores " + healAmount + " Health points");
                }

                // Enemy Turn
                if(enemyHp > 0)
                {
                    Console.WriteLine("- - Enemy Turn - -");
                    Console.WriteLine("Player Hp - " + playerHp + ". Enemy Hp - " + enemyHp);
                    int enemyChoice = random.Next(0, 2);

                    if(enemyChoice==0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine("Enemy Attack And Deals " + enemyAttack + " damage!");
                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine("Enemy Restores " + healAmount + " health points!");
                    }
                }
            }

            if (playerHp > 0)
            {
                Console.WriteLine("Congratulations, You Have Won!");
            }
            else
            {
                Console.WriteLine("You Lose");           
            }
            Console.ReadLine();
        }
    }
}
