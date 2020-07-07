using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    static class CycleCombatMessagesOgre
    {
        public static int Executer_Cycle_CombatMessages_Ogre(Attaque attaque, CombatService combatService)
        {
            int resultatOgre = attaque.Generer_Degats_Physique_Monstre();
            if (resultatOgre == 0)
            {
                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                Console.WriteLine(Messages_Ogre.Afficher_Preparation_Attaque_Ogre());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Ogre(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesHeros.Afficher_Preparation_Defense_Heros());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Heros(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(Messages_Ogre.Afficher_Attaque_Ratée_Ogre()); 

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                Console.WriteLine(MessagesHeros.Afficher_PointDeVie_Heros(combatService));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                return resultatOgre;
            }
            else
            {
                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                Console.WriteLine(Messages_Ogre.Afficher_Preparation_Attaque_Ogre());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Ogre(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesHeros.Afficher_Preparation_Defense_Heros());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Heros(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(Messages_Ogre.Afficher_Attaque_Ogre());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                Console.WriteLine(MessagesHeros.Afficher_PointDeVie_Heros(combatService));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                return resultatOgre;
            }
        }

        public static int Executer_Cycle_CombatMessagesMagie_Ogre(Ogre ogre, Attaque attaque, CombatService combatService)
        {
            int resultatMagieOgre = attaque.Generer_Degats_Magique_Ogre(ogre);
            if (resultatMagieOgre == 0)
            {
                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                Console.WriteLine(Messages_Ogre.Afficher_Debut_Incantation_Ogre());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Magie_Ogre(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesHeros.Afficher_Preparation_Defense_Heros());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(Messages_Ogre.Afficher_Incantation_Ratée());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                Console.WriteLine(MessagesHeros.Afficher_PointDeVie_Heros(combatService));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                return resultatMagieOgre;
            }
            else
            {
                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                Console.WriteLine(Messages_Ogre.Afficher_Debut_Incantation_Ogre());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Lancer_De());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesDe.Afficher_Tirage_Magie_Ogre(attaque));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(MessagesHeros.Afficher_Preparation_Defense_Heros());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace());
                Console.WriteLine(Messages_Ogre.Afficher_Incantation_Magique_Ogre());

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                Console.WriteLine(MessagesHeros.Afficher_PointDeVie_Heros(combatService));

                Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
                return resultatMagieOgre;
            }
        }
    }
}
