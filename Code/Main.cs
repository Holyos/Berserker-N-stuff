using System;
using NCMS;
using UnityEngine;
using HarmonyLib;
using System.Reflection;

namespace BNM
{
    [ModEntry]
    class Main : MonoBehaviour
    {
        public static Main instance;
        private static bool initialized = false;

        void Awake()
        {
            if (initialized)
            {
                return;
            }
            instance = this;
            BNMTab.Init();
            var harmony = new Harmony("com.bnm.mod");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            
            if (AssetManager.items is ItemLibrary itemLibrary)
            {
                BnmItems.AddItems(itemLibrary);
            }
            
            initialized = true;
        }
    }
}
