using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    class GobelinMessages : EntityMessages
    {
        /// <summary>
        /// Messages liés au cycle de combat du gobelin.
        /// </summary>
        public override string MonsterArrival => "Un gobelin surgit !";

        public override string AttackPreparation => "Le gobelin se prépare à frapper !";

        public override string DefensePreparation => "Le gobelin se prépare à parer l'attaque...";

        public override string Attack => "Le petit gobelin effectue un \"heurtoir\" et frappe le héros avec son gourdin ! Aïe, ça fait mal !";

        public override string FailedAttack => "Le héros effectue une \"esquive magistrale\" et le gobelin frappe dans le vide !";

        public override string Death => "AaRrrrrgghHH... Le gobelin succombe...";

        /// <summary>
        /// Messages qui ne concernent pas le gobelin dans sa version actuelle. Retourne null.
        /// </summary>

        public override string IncantationMagique => null;

        public override string IncantationRatée => null;

        public override string SortMagique => null;
    }
}
