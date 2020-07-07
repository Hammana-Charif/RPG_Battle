using RPG_Battle.Entities;
using System;

namespace RPG_Battle
{
    class CombatService
    {
        public static void ExecuterCycleCombat()
        {
            /// <summary>
            /// Génère l'entité héros. Reste en combat tant qu'il est en vie.
            /// </summary>
            Heros raikho = new Raikho(150);
            
            do
            {
                /// <summary>
                /// Génère un monstre aléatoire. Reste en combat tant qu'il est en vie.
                /// </summary>
                Monster monster = MonsterGenerator.CreateAMonster();

                EntityMessages monsterMessage = MessagesFactory.CreateMessageForEntity(monster);
                EntityMessages raikhoMessage = MessagesFactory.CreateMessageForEntity(raikho);

                Console.WriteLine(monsterMessage.MonsterArrival);
                Console.WriteLine(MessagesParty.ASpace2);
                
                do
                {
                    /// <summary>
                    /// Le héros a toujours l'initiative de l'attaque, dans cette version du jeu.
                    /// </summary>
                    var raikhoAttackMessage = raikho.Attack(monster);

                    Console.WriteLine(raikhoMessage.AttackPreparation);
                    Console.WriteLine($"Le tirage est de {raikhoAttackMessage.AttackDraw}");
                    Console.WriteLine(monsterMessage.DefensePreparation);
                    Console.WriteLine($"Le tirage est de {raikhoAttackMessage.DefenseDraw}");

                    /// <summary>
                    /// Lancé de dés pour déterminer si l'attaque du héros touche ou rate. Possibilité d'égalité en cas de tirage 0.
                    /// </summary>
                    if (raikhoAttackMessage.Hit == true)
                    {
                        Console.WriteLine(raikhoMessage.Attack);
                    }
                    else if (raikhoAttackMessage.AttackDraw == raikhoAttackMessage.DefenseDraw)
                    {
                        Console.WriteLine(MessagesParty.Egalite);
                    }
                    else
                    {
                        Console.WriteLine(raikhoMessage.FailedAttack);
                    }

                    /// <summary>
                    /// Affiche les dégâts infligés par le héros.
                    /// </summary>
                    Console.WriteLine(MessagesParty.ASpace);
                    Console.WriteLine($"Dégâts infligés :{raikhoAttackMessage.Damage}");
                    Console.WriteLine(MessagesParty.ASpace2);

                    Console.ReadKey();

                    /// <summary>
                    /// Si le monstre meurt, on passe à l'étape générer un nouveau monstre. Si le monstre est vivant, c'est à son tour d'attaquer. 
                    /// Comptage de points en cas de mort.
                    /// </summary>
                    if (!monster.isAlive)
                    {
                        Console.WriteLine(monsterMessage.Death);
                        Counter.AddDeath(monster);
                        break;
                    }

                    /// <summary>
                    /// Le monstre attaque et en fonction de l'entité du monstre, il execute une attaque spéciale supplémentaire.
                    /// </summary>
                    var monsterAttackMessage = monster.Attack(raikho);
                    Console.WriteLine(monsterMessage.AttackPreparation);
                    Console.WriteLine($"Le tirage est de {monsterAttackMessage.AttackDraw}");
                    Console.WriteLine(raikhoMessage.DefensePreparation);
                    Console.WriteLine($"Le tirage est de {monsterAttackMessage.DefenseDraw}");

                    /// <summary>
                    /// Lancé de dés pour determiner si l'attaque du monstre touche ou rate.
                    /// </summary>
                    if (monsterAttackMessage.Hit == true)
                    {
                        Console.WriteLine(monsterMessage.Attack);
                    }
                    else if (monsterAttackMessage.AttackDraw == monsterAttackMessage.DefenseDraw)
                    {
                        Console.WriteLine(MessagesParty.Egalite);
                    }
                    else
                    {
                        Console.WriteLine(monsterMessage.FailedAttack);
                    }

                    Console.WriteLine(MessagesParty.ASpace);

                    /// <summary>
                    /// Lancé de dé pour determiner les dégâts infligés par l'attaque spéciale. L'attaque spéciale touche toujours 
                    /// mais a 1/6 de chance de faire 0.
                    /// </summary>
                    if (monsterAttackMessage.MagicSpell == true)
                    {
                        Console.WriteLine(monsterMessage.IncantationMagique);
                        Console.WriteLine($"Le tirage est de {monster.MagicDraw}");
                    }

                    if (monsterAttackMessage.MagicHit == true)
                    {
                        Console.WriteLine(monsterMessage.SortMagique);
                    }
                    else
                    {
                        Console.WriteLine(monsterMessage.IncantationRatée);
                    }

                    /// <summary>
                    /// Affichage des dégâts globaux de l'entité monstre.
                    /// </summary>
                    Console.WriteLine(MessagesParty.ASpace);
                    Console.WriteLine($"Dégâts infligés :{monsterAttackMessage.Damage}");
                    Console.WriteLine(MessagesParty.ASpace2);

                    Console.ReadKey();

                    /// <summary>
                    /// Indique les points de vie restants des entités.
                    /// </summary>
                    Console.WriteLine($"PV héro: {raikho.RemaningLife}. PV Monstre: {monster.RemaningLife}");
                    Console.WriteLine(MessagesParty.ASpace2);
                }
                /// <summary>
                /// Tant que les deux entités héros et monstre sont vivants, ils enchaînent les attaques.
                /// </summary>
                while (monster.isAlive && raikho.isAlive);

                /// <summary>
                /// Affiche un message, quand les points de vie de l'entité héros atteignent 0.
                /// </summary>
                if (!raikho.isAlive)
                {
                    Console.WriteLine(raikhoMessage.Death);
                    Console.WriteLine(MessagesParty.ASpace2);
                    break;
                }
            }
            /// <summary>
            /// Tant que le héro est vivant, il enchaîne les monstres.
            /// </summary>
            while (raikho.isAlive);

            /// <summary>
            /// Résultats de la partie.
            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            /// 
            /// </summary>
            Console.WriteLine($"Points gobelin :{Counter.GobelinPoints} Points ogre :{Counter.OgrePoints} Total points :{Counter.GlobalPoints}");
        }
    }
}
