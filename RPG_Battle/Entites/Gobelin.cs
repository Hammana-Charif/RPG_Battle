using RPG_Battle.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    class Gobelin : Monster
    {
        public Gobelin(int points): base(points)
        {

        }

        /// <summary>
        /// Dégâts spécifiques, liés au gobelin.
        /// </summary>
        public override int Damage => 10;
    }
}