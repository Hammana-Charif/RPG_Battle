using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle.Entities
{
    abstract class Monster : Entity
    {
        protected Monster(int health): base(health)
        {

        }

        /// <summary>
        /// Tirage du lancé de dé pour les dégâts magiques de l'entité ogre.
        /// </summary>
        public int MagicDraw { get; set; }
    }
}
