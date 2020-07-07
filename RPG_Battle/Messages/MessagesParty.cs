using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    public class MessagesParty
    {
        //Messages de bienvenue.
        public const string Welcome = "Bienvenue dans le simulateur de combat viruel \"RPG_Battle\" !\n" +
                                        "--------------------------------------------------------\n" +
                                        "Votre héros va combattre de terribles monstres avant de rendre l'âme.\n" +
                                        "--------------------------------------------------------\n" +
                                        "Jusqu'où va t'il aller ?\n" +
                                        "--------------------------------------------------------\n" +
                                        "C'est parti !\n" +
                                        "________________________________________________________\n";
                                        

        public const string ButtonClic = "Veuillez appuyez sur un bouton pour continuer...\n";

        //Messages de mise en forme du texte.
        public const string ASpace = "----------------------------";

        public const string ASpace2 = "____________________________";

        //Messages liés au combat : héros, gobelin, ogre.
        public const string Egalite = "Les adversaires se regardent dans les yeux...";
    }
}
