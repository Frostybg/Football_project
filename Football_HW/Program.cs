using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_HW
{

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // Клас за футболист, който наследява Person
    public class FootballPlayer : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }

        public FootballPlayer(string name, int age, int number, double height)
            : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }

    // Класове за различните позиции на играчите
    public class Goalkeeper : FootballPlayer
    {
        public Goalkeeper(string name, int age, int number, double height)
            : base(name, age, number, height)
        {
        }
    }

    public class Defender : FootballPlayer
    {
        public Defender(string name, int age, int number, double height)
            : base(name, age, number, height)
        {
        }
    }

    public class Midfielder : FootballPlayer
    {
        public Midfielder(string name, int age, int number, double height)
            : base(name, age, number, height)
        {
        }
    }

    public class Striker : FootballPlayer
    {
        public Striker(string name, int age, int number, double height)
            : base(name, age, number, height)
        {
        }
    }

    // Класове за треньор и съдия
    public class Coach : Person
    {
        public Coach(string name, int age)
            : base(name, age)
        {
        }
    }

    public class Referee : Person
    {
        public Referee(string name, int age)
            : base(name, age)
        {
        }
    }

    // Клас за отбор
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }

        public Team(Coach coach, List<FootballPlayer> players)
        {
            Coach = coach;
            Players = players;
        }

        public double AverageAge;
    }

    // Клас за мач
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<Goal> Goals { get; set; }
        public string Result { get; set; }
        public string Winner { get; set; }

        public Game(Team team1, Team team2, Referee referee)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            Goals = new List<Goal>();
        }
    }

    // Клас за гол
    public class Goal
    {
        public int Minute { get; set; }
        public FootballPlayer Player { get; set; }

        public Goal(int minute, FootballPlayer player)
        {
            Minute = minute;
            Player = player;
        }
    }
}
