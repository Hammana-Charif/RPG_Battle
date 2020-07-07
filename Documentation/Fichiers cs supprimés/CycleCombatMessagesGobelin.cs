using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    static class CycleCombatMessagesGobelin
    {
        public static int Executer_Cycle_CombatMessages_Gobelin(Attaque attaque, CombatService combatService)
        {
            int resultatGobelin = attaque.Generer_Degats_Physique_Monstre();
            if (resultatGobelin == 0)
            {
                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                Console.WriteLine(MessagesGobelin.Afficher_Preparation_Attaque_Gobelin());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Gobelin(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesHeros.Afficher_Preparation_Defense_Heros());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Heros(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesGobelin.Afficher_Attaque_Ratée_Gobelin());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                Console.WriteLine(MessagesHeros.Afficher_PointDeVie_Heros(combatService));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                return resultatGobelin;
            }
            else
            {
                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                Console.WriteLine(MessagesGobelin.Afficher_Preparation_Attaque_Gobelin());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Gobelin(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesHeros.Afficher_Preparation_Defense_Heros());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Heros(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesGobelin.Afficher_Attaque_Gobelin());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                Console.WriteLine(MessagesHeros.Afficher_PointDeVie_Heros(combatService));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                return resultatGobelin;
            }
        }
    }
}
