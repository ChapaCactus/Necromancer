using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace CCG
{
    public class Battle : MonoBehaviour
    {
        private void Awake()
        {
            if(!GameManager.IsInitialized)
            {
                GameManager.Initialize();
            }

            // PlayerGameObject作成
            NecromancerDTO necromancerDTO = GameManager.CharacterManager.Necromancer;
            CreateNecromancerGO(necromancerDTO);
        }

        private void CreateNecromancerGO(NecromancerDTO dto)
        {
            Necromancer necromancer = new GameObject("Necromancer", typeof(Necromancer))
                .GetComponent<Necromancer>();

            necromancer.Setup(dto);
        }
    }
}