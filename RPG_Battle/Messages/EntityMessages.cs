using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    abstract class EntityMessages
    {
        /// <summary>
        /// Messages liés au déroulement du combat.
        /// </summary>
        public abstract string MonsterArrival { get; }

        public abstract string AttackPreparation { get; }

        public abstract string DefensePreparation { get; }

        public abstract string Attack { get; }

        public abstract string FailedAttack { get; }

        public abstract string Death { get; }

        public abstract string IncantationMagique { get; }

        public abstract string IncantationRatée { get; }

        public abstract string SortMagique { get; }

    }
}
