using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    interface IEntity
    {
        string Name { get; set; }

        public int Health { get; set; }

        int RemaningLife { get; set; }

        int Damage { get; }

        bool isAlive { get; }

        Dice AttackDice { get; set; }

        Dice DefenseDice { get; set; }

        public abstract AttackMessages Attack(IEntity target);

    }
}
