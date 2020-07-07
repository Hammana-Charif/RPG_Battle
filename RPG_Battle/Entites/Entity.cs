using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    /// <summary>
    /// Définie le squelette d'une entité. Détermine les attributs et fonction de base. 
    /// Classe abstraire, ne peut être instanciée.
    /// </summary>
    abstract class Entity
    {
        protected Entity(int health)
        {
            Health = health;
            RemaningLife = Health; // Par défaut il a tous ses points de vie.

            AttackDice = new Dice();
            DefenseDice = new Dice();
        }

        public Dice AttackDice { get; protected set; }

        public Dice DefenseDice { get; protected set; }

        /// <summary>
        /// Point de vie maximum de l'entité. Ne peut pas être modifié.
        /// </summary>
        public int Health { get; }

        /// <summary>
        /// Point de vie actuel.
        /// </summary>
        public int RemaningLife { get; set; }

        /// <summary>
        /// Entité est en vie tant que points de vie supérieur à 0.
        /// </summary>
        public bool isAlive => RemaningLife > 0;

        /// <summary>
        /// Dégâts à définir pour chaque entité.
        /// </summary>
        public virtual int Damage { get; set; }    

        /// <summary>
        /// Entité attaque la cible. Lancés de dés déterminent si attaque touche ou rate / Récupère données pour les afficher.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public virtual AttackMessages Attack(Entity target)
        {
            //Lancés de dés pour détermminer si l'attaque touche ou rate.
            int attackDraw = AttackDice.Launch();
            int defenseDraw = target.DefenseDice.Launch();

            //Le lancé de dé de l'entité est inférieur à celui de la cible.
            AttackMessages attackMessages = new AttackMessages()
            {
                AttackDraw = attackDraw,
                DefenseDraw = defenseDraw,
                Damage = 0,
                Hit = false
            };
            
            //Le lancé de dé de l'entité est supérieur à celui de la cible.
            if (attackDraw > defenseDraw)
            {
                target.RemaningLife -= Damage;
                attackMessages.Damage = Damage;
                attackMessages.Hit = true;
            }

            return attackMessages;
        }
    }
}
