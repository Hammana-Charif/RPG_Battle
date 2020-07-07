using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    class OgreMessages : EntityMessages
    {
        /// <summary>
        /// Messages liés au cycle de combat du l'ogre.
        /// </summary>
        public override string MonsterArrival => "Un ogre surgit !";

        public override string AttackPreparation => "L'ogre serre le poing et se prépare à frapper !";
        
        public override string DefensePreparation => "L'ogre se prépare à parer l'attaque...";
        
        public override string Attack => "L'ogre effectue un \"poing d'acier\" et porte une frappe dévastatrice !";
       
        public override string FailedAttack => "L'ogre, fou de rage, charge à l'aveugle et frappe dans le vent...";

        public override string Death => "AaRrrrrgghHH... L'ogre succombe...";

        public override string IncantationMagique => "L'ogre commence une incantation magique... !";

        public override string IncantationRatée => "Le héros effectue une \"charge furieuse\" et interrompt l'incantation du monstre !";

        public override string SortMagique => "L'ogre incante une gigantesque \"boule de magma\", qui s'abat sur le héros ! Ouïe, ça brûle !!";
    }
}
