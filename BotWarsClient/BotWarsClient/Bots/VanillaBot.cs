using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotWarsClient.Bots
{
    public class VanillaBot : BotBaseClass
    {
        public string OpponentName { get; set; }        
        public int Health { get; set; }
        public int Flips { get; set; }
        public int Fuel { get; set; }
        public int FlipOdds { get; set; }
        public int ArenaSize { get; set; }
        public char Direction { get; set; }
        public bool Flipped { get; set; }
        public bool OpponentFlipped { get; set; }

        public VanillaBot()
        {            
        }

        /// <summary>
        /// Tell the server what we'd like to do in our move
        /// </summary>
        public override Move GetMove()
        {
            return Move.MoveBackwards; // This bot isn't very smart - it'll pick a walk backwards until it falls out of the arena and dies
        }

        public override void SetStartValues(string opponentName, int health, int arenaSize, int flips, int flipOdds, int fuel, char direction, int startIndex)
        {
            OpponentName = opponentName;
            Health = health;
            ArenaSize = arenaSize;
            Flips = flips;
            FlipOdds = flipOdds;
            Fuel = fuel;
            Direction = direction;
            Flipped = false;
            OpponentFlipped = false;

            base.SetStartValues(opponentName, health, arenaSize, flips, flipOdds, fuel, direction, startIndex);
        }

        public override void CaptureOpponentsLastMove(Move lastOpponentsMove)
        {
                     
        }

        public override void SetFlippedStatus(bool flipped)
        {

        }
        public override void SetOpponentFlippedStatus(bool opponentFlipped)
        {

        }


    }
}
