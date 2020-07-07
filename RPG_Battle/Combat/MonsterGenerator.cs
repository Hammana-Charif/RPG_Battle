using RPG_Battle.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    static class MonsterGenerator
    {
        public static Monster CreateAMonster()
        {
            Dice de2 = new Dice(2);
            if (de2.Launch() == 1)
                return new Gobelin(20);
            else
                return new Ogre(40);
        }
    }
}
