using RPG_Battle.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    public class AttackMessages
    {
        /// <summary>
        /// Messages liés aux attaques.
        /// </summary>
        public bool Hit { get; set; }

        public bool MagicSpell { get; set; }

        public bool MagicHit { get; set; }

        public int Damage { get; set; }

        /// <summary>
        /// Les lancés de dés des entités.
        /// </summary>
        public int AttackDraw { get; set; }

        public int DefenseDraw { get; set; }

        /// <summary>
        /// Messages liés au comptage des points.
        /// </summary>
        public int ComptageGlobal { get; set; }

        public int ComptageGobelin { get; set; }

        public int ComptageOgre { get; set; }
    }
}
