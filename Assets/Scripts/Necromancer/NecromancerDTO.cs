using System;
using System.Collections.Generic;

namespace CCG
{
    public class NecromancerDTO : DTOBase
    {
        private CharacterVO _characterVO;

        public string Name => _characterVO.name;
        public int Level => _characterVO.level;
        public int Exp => _characterVO.exp;
        public int Attack => _characterVO.attack;
        public int Defense => _characterVO.defense;

        public void SetCharacterVO(CharacterVO vo)
        {
            _characterVO = vo;
        }
    }
}