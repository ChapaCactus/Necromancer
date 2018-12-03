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
        }
    }
}