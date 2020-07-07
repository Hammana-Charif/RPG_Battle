using RPG_Battle;
using System;

namespace RPG_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>    
            ///Affiche message de bienvenue et description du jeu
            /// </summary>     
            Console.WriteLine(MessagesParty.Welcome);

            ///<summary>
            ///Demarrage du programme
            /// </summary>
            CombatService.ExecuterCycleCombat();
        }
    }
}
