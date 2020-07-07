using RPG_Battle.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    class Raikho : Heros
    {
        public Raikho(int health): base(health)
        {
            
        }

        /// <summary>
        /// Dégâts définies pour le Raikho.
        /// </summary>
        public override int Damage => 20;
    }
}
