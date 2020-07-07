using RPG_Battle.Entities;
using System;
using System.Collections.Generic;

namespace RPG_Battle
{
    static class Counter
    {
        /// <summary>
        /// Système de comptage de points : gobelin / ogre / gobelin + ogre.
        /// </summary>
        public static int GlobalPoints => OgrePoints + GobelinPoints;

        public static int OgrePoints { get; set; }

        public static int GobelinPoints { get; set; }

        public static void AddDeath(Monster monster)
        {
            switch (monster)
            {
                case Gobelin _: ++GobelinPoints; break;
                case Ogre _: ++OgrePoints; break;
            }
        }

    }
}
