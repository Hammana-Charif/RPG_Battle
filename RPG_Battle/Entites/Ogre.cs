using RPG_Battle.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    class Ogre : Monster
    {
        protected Dice SpellAttackDraw = new Dice();

        public Ogre(int points) : base(points)
        {
        }

        /// <summary>
        /// Dégâts spécifiques de l'ogre.
        /// </summary>
        public override int Damage => 20;


        public int MagicSpell { get; set; }

        /// <summary>
        /// Ogre attaque normalement puis lance une attaque spéciale / lancé de dé et calcul spécifique de l'attaque spéciale.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public override AttackMessages Attack(Entity target)
        {
            //Dégâts physique sur la cible.
            var attackMessage = target.Attack(target);

            //Puis faire une attaque magique.
            MagicDraw = SpellAttackDraw.Launch();

            //L'attaque magique n'existe que quand le tirage est supérieur à 0.
            if (MagicDraw > 0)
            { 
                attackMessage.MagicSpell = true;
            }

            //1 chance sur 6 qu'elle n'inflige pas de dégâts.
            if (MagicDraw < 6)
            {
                target.RemaningLife-= MagicDraw * 5;
                attackMessage.Damage += MagicDraw * 5;
                attackMessage.MagicHit = true;
            }
            return attackMessage;
        }
    }
}
