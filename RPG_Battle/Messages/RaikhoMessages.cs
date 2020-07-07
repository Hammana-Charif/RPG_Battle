using System;
using System.Collections.Generic;
using System.Text;


namespace RPG_Battle
{
    class RaikhoMessages : EntityMessages
    {
        /// <summary>
        /// Messages liés au cycle de combat du Raikho.
        /// </summary>
        public override string AttackPreparation => "Raikho se prépare à attaquer...";


        public override string DefensePreparation => "Raikho se prépare à parer l'attaque...";


        public override string Attack => "Le héros effectue une \"tempête de lames\" et cisaille le monstre dans un tourbillon infernal !";


        public override string FailedAttack => "Le héros manque de concentration et rate son attaque...";

        public override string Death => "GAME OVER !!! Ca y est... c'est fini.. le héros a rendu son dernier souffle... Paix à son âme !";

        /// <summary>
        /// Messages ne concernant pas Raikho dans sa version actuelle.
        /// </summary>
        public override string MonsterArrival => null;

        public override string IncantationMagique => null;

        public override string IncantationRatée => null;

        public override string SortMagique => null;
    }
}
