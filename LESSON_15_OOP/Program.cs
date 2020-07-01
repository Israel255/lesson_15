using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_15_OOP
{
    class Program
    {
        static void Print_Game(Game g)
        {
            int number = g.Tell_ME_How_Many_Players();
            Console.WriteLine(g);
        }
        static void Main(string[] args)
        {
            Game soccer = new Game
            {
                 _name = "Soccer",
                 _first_team_players = 11,
                 _second_team_players = 11,
                 //_number_of_players = 22,
                 _origin_country = "England",
                 _rating = 6.3f
            };
            soccer.Tell_ME_How_Many_Players();
            Console.WriteLine(soccer);
            Console.WriteLine("--------------------------------------------------------------------------");
            Game basketball = new Game("Basketball")
            {
                _first_team_players = 5,
                _second_team_players = 5,
                //_number_of_players = 10,
                _origin_country = "usa"
            };
            basketball.Tell_ME_How_Many_Players();
            Console.WriteLine(basketball);
            Console.WriteLine("--------------------------------------------------------------------------");
            Game tennis = new Game("Tennis", "France")
            {
                 _first_team_players = 1,
                 _second_team_players = 1,
                 //_number_of_players = 2,
                 _rating = 3.4f
            };
            tennis.Tell_ME_How_Many_Players();
            Console.WriteLine(tennis);
            Console.WriteLine("--------------------------------------------------------------------------");
            Game wrestling = new Game("Wrestling", 2, 2.2f, "Greece",1,1);
            Console.WriteLine(wrestling);
            Console.WriteLine("--------------------------------------------------------------------------");
            Print_Game(soccer);
            Console.WriteLine("--------------------------------------------------------------------------");
            Print_Game(basketball);
            Console.WriteLine("--------------------------------------------------------------------------");
            Print_Game(tennis);
            Console.WriteLine("--------------------------------------------------------------------------");
            Print_Game(wrestling);
            Console.WriteLine("--------------------------------------------------------------------------");
        }
    }
}
