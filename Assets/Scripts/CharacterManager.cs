using System;
using System.Collections.Generic;

namespace CCG
{
    public class CharacterManager
    {
        private NecromancerDTO _necromancer = null;

        public NecromancerDTO Necromancer
        {
            get {
                if(_necromancer == null) {
                    _necromancer = CreateNecromancer();
                }

                return _necromancer;
            }
        }

        private NecromancerDTO CreateNecromancer()
        {
            return null;
        }
    }
}