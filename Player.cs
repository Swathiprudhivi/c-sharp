using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPlayerDetails
{
    abstract class Player
    {
        protected string name;
        protected string teamname;
        protected int noofmatches;
        public Player(string name, string teamname, int noofmatches)
        {
            this.name = name;
            this.teamname = teamname;
            this.noofmatches = noofmatches;
        }
        public abstract void Displayplayerstatistics();

    }
    class Cricketplayer : Player
    {
        int totalrunscored;
        int noofwicketstaken;
        public Cricketplayer( string name, string teamname, int noofmatches,int totalrunscored, int noofwicketstaken) : base(name, teamname, noofmatches)
        {
            this.totalrunscored = totalrunscored;
            this.noofwicketstaken = noofwicketstaken;
        }
        public override void Displayplayerstatistics()
        {
            Console.WriteLine("name:\t" + this.name + "score:\t" + this.totalrunscored + "\t no of wickets" + this.noofwicketstaken);
        }
    }
    class Hockeyplayer : Player
    {
        string position;
        int noofgoals;
        public Hockeyplayer(string name, string teamname, int noofmatches, string position, int noofgoals):base(name,teamname,noofmatches)
        {
            this.position = position;
            this.noofgoals = noofgoals;
        }
        public override void Displayplayerstatistics()
        {
            Console.WriteLine("name:"+ this.name + "position:" + this.position + " no of goals"  + this.noofgoals);
        }
    }
}

