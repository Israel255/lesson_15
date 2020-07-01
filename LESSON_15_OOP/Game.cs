using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_15_OOP
{
    class Game
    {
        public string _name;
        public int _number_of_players;
        public float _rating;
        public string _origin_country;
        public int _first_team_players;
        public int _second_team_players;

        public Game()
        {

        }

        public Game(string name, float rating = 5.5f)
        {
            _name = name;
            _rating = rating;
        }

        public Game(string name, int number_of_players, float rating, string origin_country,int first_team_players,int second_team_players)
        {
            _name = name;
            _number_of_players = number_of_players;
            _rating = rating;
            _origin_country = origin_country;
            _first_team_players = first_team_players;
            _second_team_players = second_team_players;
        }

        public Game(string name, string origin_country)
        {
            _name = name;
            _origin_country = origin_country;
        }

        public int Tell_ME_How_Many_Players()
        {
            _number_of_players = _first_team_players + _second_team_players;
            return _number_of_players;
        }

        public override string ToString()
        {
            return "Game Name: " + _name + " ,Number Of Players: " + _number_of_players + " ,Rating: " + _rating + " ,Origin Country: " + _origin_country;
        }
    }
}
