using System;
using System.Collections.Generic;
using UnityEngine;

namespace CCG
{
    public static class GameManager
    {
        public static CharacterManager CharacterManager { get; private set; }

        public static bool IsInitialized { get; private set; } = false;

        public static void Initialize()
        {
            IsInitialized = false;

            CharacterManager = new CharacterManager();

            IsInitialized = true;

            Debug.Log("Initialized.");
        }
    }
}