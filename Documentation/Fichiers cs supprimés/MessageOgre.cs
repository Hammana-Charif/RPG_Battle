using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle.Messages
{
    class MessageOgre : Message
    {
        public override string PreparationAttaque => "L'ogre attaque";

        public override string PreparatrionDefense => "L'ogre se défends..";
    }
}
