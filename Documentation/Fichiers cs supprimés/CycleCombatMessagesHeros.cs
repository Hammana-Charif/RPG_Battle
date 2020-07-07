using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    static class CycleCombatMessagesHeros
    {
        public static int Executer_Cycle_CombatMessages_HerosVSGobelin(Attaque attaque, CombatService combatService)
        {
            int resultatHeros = attaque.Generer_Degats_Physique_HerosVSGobelin();
            if (resultatHeros == 0)
            {
                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                Console.WriteLine(MessagesHeros.Afficher_Preparation_Attaque_Heros());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Heros(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesGobelin.Afficher_Preparation_Defense_Gobelin());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Gobelin(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());               
                Console.WriteLine(MessagesHeros.Afficher_Attaque_Ratée_Heros());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesGobelin.Afficher_PointDeVie_Gobelin(combatService));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                return resultatHeros;
            }
            else 
            {
                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                Console.WriteLine(MessagesHeros.Afficher_Preparation_Attaque_Heros());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Heros(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesGobelin.Afficher_Preparation_Defense_Gobelin());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Gobelin(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesHeros.Afficher_Attaque_Heros());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesGobelin.Afficher_PointDeVie_Gobelin(combatService));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                return resultatHeros;
            }
        }

        public static int Executer_Cycle_CombatMessages_HerosVSOgre(Attaque attaque, CombatService combatService)
        {
            int resultatHeros = attaque.Generer_Degats_Physique_HerosVSOgre();
            if (resultatHeros == 0)
            {
                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                Console.WriteLine(MessagesHeros.Afficher_Preparation_Attaque_Heros());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Heros(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(Messages_Ogre.Afficher_Preparation_Defense_Ogre());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Ogre(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesHeros.Afficher_Attaque_Ratée_Heros());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(Messages_Ogre.Afficher_PointDeVie_Ogre(combatService));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                return resultatHeros;
            }
            else
            {
                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                Console.WriteLine(MessagesHeros.Afficher_Preparation_Attaque_Heros());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Heros(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(Messages_Ogre.Afficher_Preparation_Defense_Ogre());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Ogre(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesHeros.Afficher_Attaque_Heros());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(Messages_Ogre.Afficher_PointDeVie_Ogre(combatService));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                return resultatHeros;
            }
        }
    }
}
