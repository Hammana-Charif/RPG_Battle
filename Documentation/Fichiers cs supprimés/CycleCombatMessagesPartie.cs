using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    public static class CycleCombatMessagesPartie
    {
        public static int pointsGlobal = 0;
        public static int pointsGobelin = 0;
        public static int pointsOgre = 0;

        public static int Executer_Cycle_Points_Global()
        {
            pointsGlobal = Compteur.CompterPointsGlobal();
            Console.WriteLine(MessagesPartie.Afficher_Comptage_Global());
            return pointsGlobal;
        }

        public static int Executer_Cycle_Points_Gobelin()
        {
            pointsGobelin = Compteur.CompterPointsGobelin();
            Console.WriteLine(MessagesPartie.Afficher_Comptage_Gobelin());
            return pointsGobelin;
        }

        public static int Executer_Cycle_Points_Ogre()
        {
            pointsOgre = Compteur.CompterPointsOgre();
            Console.WriteLine(MessagesPartie.Afficher_Comptage_Ogre());
            return pointsOgre;
        }

        public static void Demander_Appuyer_Bouton()
        {
            Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
            Console.Write(MessagesPartie.Afficher_Clic_Bouton());
            Console.ReadKey();
            Console.WriteLine(MessagesPartie.Afficher_Un_Espace2());
        }
    }
}
