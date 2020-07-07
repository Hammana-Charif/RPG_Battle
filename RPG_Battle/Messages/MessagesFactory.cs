using RPG_Battle.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    static class MessagesFactory
    {
        /// <summary>
        /// Génère les messages en fonction de l'entité créee.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static EntityMessages CreateMessageForEntity(Entity entity)
        {
            switch (entity)
            {
                case Heros _:
                    return new RaikhoMessages();
                case Ogre _:
                    return new OgreMessages();
                case Gobelin _:
                    return new GobelinMessages();
                    
                //return new MessageGobelin();
                default: throw new ArgumentException("Il n'y a pas de combat en cours...");
            }
        }
    }
}
