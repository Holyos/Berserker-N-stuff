using System;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using UnityEngine.UI;
using NeoModLoader.General.UI.Tab;

namespace BNM
{
    public static class BNMTab
    {
        private static PowersTab tab;

        public static void Init()
        {
            Sprite tabIcon = SpriteTextureLoader.getSprite("ui/Icons/tabIconBNM");
            if (tabIcon == null)
            {
                Texture2D defaultTexture = new Texture2D(2, 2);
                defaultTexture.SetPixel(0, 0, Color.white);
                defaultTexture.Apply();
                tabIcon = Sprite.Create(defaultTexture, new Rect(0, 0, 2, 2), new Vector2(0.5f, 0.5f));
            }

            Localization.AddOrSet("Button_Tab_BNM", "BNM");
            Localization.AddOrSet("Button_Tab_BNM Description", "BNM mod tab");
            Localization.AddOrSet("bnm_mod_creator", "core.skull");

            tab = TabManager.CreateTab(
                "BNM",
                "Button_Tab_BNM",
                "Button_Tab_BNM Description",
                tabIcon,
                "bnm_mod_creator"
            );

            if (tab == null)
            {
                return;
            }

            AddLogo();
            AddSectionLabel();
        }

        private static void AddLogo()
        {
            Sprite logoSprite = SpriteTextureLoader.getSprite("ui/Icons/iconBNMLogo");
            if (logoSprite == null)
            {
                return;
            }

            GameObject logoObject = new GameObject("BNMLogo");
            logoObject.transform.SetParent(tab.transform, false);
            Image logoImage = logoObject.AddComponent<Image>();
            logoImage.sprite = logoSprite;
            logoImage.rectTransform.sizeDelta = new Vector2(83f, 88f);
            logoImage.rectTransform.anchoredPosition = new Vector2(760f, 0f);
        }

        private static void AddSectionLabel()
        {
            GameObject labelObject = new GameObject("BNMLabel");
            labelObject.transform.SetParent(tab.transform, false);
            Text labelText = labelObject.AddComponent<Text>();
            labelText.text = "Coded by ahoyos";
            labelText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            labelText.fontSize = 16;
            labelText.color = Color.white;
            labelText.alignment = TextAnchor.MiddleLeft;
            labelText.rectTransform.sizeDelta = new Vector2(100f, 20f);
            labelText.rectTransform.anchoredPosition = new Vector2(72f, 54f);
        }
    }
}