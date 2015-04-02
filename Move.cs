using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FramePunishV2
{
    class Move
    {
        public string moveName { get; set; }
        public string startup { get; set; }
        public string active { get; set; }
        public string recovery { get; set; }
        public string onBlock { get; set; }
        public string onHit { get; set; }

        /// <summary>
        /// Constructor for a move
        /// </summary>
        /// <param name="moveName"></param>
        /// <param name="startup"></param>
        /// <param name="active"></param>
        /// <param name="recovery"></param>
        /// <param name="onBlock"></param>
        /// <param name="onHit"></param>
        public Move(string moveName, string startup, string active, string recovery, string onBlock, string onHit)
        {
            this.moveName = moveName;
            this.startup = startup;
            this.active = active;
            this.recovery = recovery;
            this.onBlock = onBlock;
            this.onHit = onHit;
        }
    }
}
