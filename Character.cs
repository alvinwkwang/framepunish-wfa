using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FramePunishV2
{
    class Character
    {
        public string name { get; set; }
        public List<Move> moves { get; set; }

        /// <summary>
        /// Constructor for a character
        /// </summary>
        /// <param name="name"></param>
        public Character(string name)
        {
            this.name = name;
            this.moves = new List<Move>();
        }

        /// <summary>
        /// Add a move to character moves list
        /// </summary>
        /// <param name="moveName"></param>
        /// <param name="startup"></param>
        /// <param name="active"></param>
        /// <param name="recovery"></param>
        /// <param name="onBlock"></param>
        /// <param name="onHit"></param>
        public void addMove(string moveName, string startup, string active, string recovery, string onBlock, string onHit)
        {
            this.moves.Add(new Move(moveName, startup, active, recovery, onBlock, onHit));
        }

        /// <summary>
        /// Returns a list of selected character data
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        public static List<String> getFrameData(Character ch)
        {
            List<string> data = new List<string>();

            string header = String.Format("{0,-18}{1,6}{2,6}{3,6}{4,6}{5,6}",
                                          "Name", "S", "A", "R", "OB", "OH");
            data.Add(header);
            data.Add("=================================================");

            String output;
            foreach (Move move in ch.moves)
            {
                output = String.Format("{0,-18}{1,6}{2,6}{3,6}{4,6}{5,6}",
                    move.moveName, move.startup, move.active, move.recovery, move.onBlock, move.onHit);
                data.Add(output);

            }

            return data;
        }

        /// <summary>
        /// Creates a list of all characters in the roster
        /// </summary>
        /// <returns></returns>
        public static List<string> fillRoster()
        {
            StreamReader sr = new StreamReader("Characters/Roster.txt");
            string line = "";
            List<string> tempRoster = new List<string>();

            while (line != null)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    tempRoster.Add(line);
                }
            }

            return tempRoster;
        }

        /// <summary>
        /// Load all character data
        /// </summary>
        /// <param name="roster"></param>
        /// <returns></returns>
        public static List<Character> loadCharacters(List<string> roster)
        {
            List<Character> characters = new List<Character>();
            Character temp;

            foreach (string name in roster)
            {
                temp = new Character(name);
                loadCharacterMoves(temp);
                characters.Add(temp);
            }

            return characters;
        }

        /// <summary>
        /// Load character's moves data from text file
        /// </summary>
        /// <param name="ch"></param>
        public static void loadCharacterMoves(Character ch)
        {
            StreamReader sr = new StreamReader("Characters/" + ch.name + ".txt");
            string line = "";
            List<string> moveData;

            while (line != null)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    moveData = new List<string>(line.Split(','));
                    ch.addMove(moveData[0], moveData[1], moveData[2], moveData[3],
                        moveData[4], moveData[5]);
                }
            }
        }

        /// <summary>
        /// Returns a list of moves that punishes a certain blocked move
        /// </summary>
        /// <param name="blocked"></param>
        /// <param name="ch"></param>
        /// <param name="opponent"></param>
        public static List<string> calculatePunishList(Move blocked, Character ch, string opponent)
        {
            List<Tuple<string, int>> punishList = new List<Tuple<string, int>>();
            Tuple<string, int> temp;
            List<string> punishData = new List<string>();

            foreach (Move possibleMove in ch.moves)
            {
                temp = calculateFrames(blocked, possibleMove);
                if (temp.Item2 < 0)
                    punishList.Add(temp);
            }

            punishData.Add("Blocked move:: " + opponent + "'s " + blocked.moveName + " :: (" 
                + blocked.onBlock + "f on block)");
            punishData.Add(ch.name + " can punish with:");

            if (punishList.Count == 0)
                punishData.Add(opponent + "'s "+ blocked.moveName + " is UNPUNISHABLE!");
            else
            {
                foreach (Tuple<string, int> punish in punishList)
                {
                    punishData.Add(punish.Item1 + " is a " + (punish.Item2 * -1) + " frame punish.");
                }
            }

            return punishData;
        }

        /// <summary>
        /// Calculates frame data for punishes
        /// </summary>
        /// <param name="mv"></param>
        /// <param name="possibleMove"></param>
        /// <returns></returns>
        public static Tuple<string, int> calculateFrames(Move blocked, Move possibleMove)
        {
            Tuple<string, int> temp =
                new Tuple<string, int>(possibleMove.moveName,
                    (Int32.Parse(blocked.onBlock) + (Int32.Parse(possibleMove.startup) - 1)));
            return temp;
        }
    }
}
