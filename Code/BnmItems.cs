using UnityEngine;
using NCMS.Utils;
using System.Collections.Generic;

namespace BNM
{
    public static class BnmItems
    {
        public static void AddItems(ItemLibrary itemLibrary)
        {

            EquipmentAsset boots1 = itemLibrary.clone("bnm_boots1", "$boots");
            boots1.equipment_type = EquipmentType.Boots;
            boots1.material = "leather";
            boots1.equipment_value = 5;
            boots1.setCost(0, "leather", 1, "none", 0);
            boots1.rigidity_rating = 1;
            boots1.base_stats["armor"] = 2f;
            boots1.base_stats["stamina"] = 10f;
            boots1.base_stats["speed"] = 1f;
            boots1.path_icon = "ui/icons/items/icon_bnm_boots1";
            boots1.path_gameplay_sprite = "weapons/bnm_boots1";
            boots1.name_templates = AssetLibrary<EquipmentAsset>.l<string>("boots_name");
            itemLibrary.add(boots1);

            EquipmentAsset armor1 = itemLibrary.clone("bnm_armor1", "$armor");
            armor1.equipment_type = EquipmentType.Armor;
            armor1.material = "leather";
            armor1.equipment_value = 5;
            armor1.setCost(0, "leather", 1, "none", 0);
            armor1.rigidity_rating = 1;
            armor1.base_stats["armor"] = 2f;
            armor1.base_stats["stamina"] = 20f;
            armor1.base_stats["speed"] = 1f;
            armor1.path_icon = "ui/icons/items/icon_bnm_armor1";
            armor1.path_gameplay_sprite = "weapons/bnm_armor1";
            armor1.name_templates = AssetLibrary<EquipmentAsset>.l<string>("armor_name");
            itemLibrary.add(armor1);

            EquipmentAsset helmet1 = itemLibrary.clone("bnm_helmet1", "$helmet");
            helmet1.equipment_type = EquipmentType.Helmet;
            helmet1.material = "leather";
            helmet1.equipment_value = 5;
            helmet1.setCost(0, "leather", 1, "none", 0);
            helmet1.rigidity_rating = 1;
            helmet1.base_stats["armor"] = 2f;
            helmet1.base_stats["stamina"] = 10f;
            helmet1.base_stats["speed"] = 1f;
            helmet1.path_icon = "ui/icons/items/icon_bnm_helmet1";
            helmet1.path_gameplay_sprite = "weapons/bnm_helmet1";
            helmet1.name_templates = AssetLibrary<EquipmentAsset>.l<string>("helmet_name");
            itemLibrary.add(helmet1);

            EquipmentAsset sword1 = itemLibrary.clone("bnm_sword1", "$sword");
            sword1.equipment_type = EquipmentType.Weapon;
            sword1.material = "wood";
            sword1.equipment_value = 1;
            sword1.setCost(0, "wood", 1, "none", 0);
            sword1.rigidity_rating = 1;
            sword1.base_stats["damage"] = 1f;
            sword1.base_stats["stamina"] = 5f;
            sword1.path_icon = "ui/icons/items/icon_bnm_sword1";
            sword1.path_gameplay_sprite = "weapons/bnm_sword1";
            sword1.name_templates = AssetLibrary<EquipmentAsset>.l<string>("sword_name");
            sword1.is_pool_weapon = true;
            sword1.pool_rate = 5;
            itemLibrary.add(sword1);

            EquipmentAsset sword2 = itemLibrary.clone("bnm_sword2", "$sword");
            sword2.equipment_type = EquipmentType.Weapon;
            sword2.material = "stone";
            sword2.equipment_value = 10;
            sword2.setCost(0, "stone", 1, "none", 0);
            sword2.rigidity_rating = 2;
            sword2.base_stats["damage"] = 3f;
            sword2.base_stats["speed"] = -2f;
            sword2.path_icon = "ui/icons/items/icon_bnm_sword2";
            sword2.path_gameplay_sprite = "weapons/bnm_sword2";
            sword2.name_templates = AssetLibrary<EquipmentAsset>.l<string>("sword_name");
            sword2.is_pool_weapon = true;
            sword2.pool_rate = 5;
            itemLibrary.add(sword2);

            EquipmentAsset sword3 = itemLibrary.clone("bnm_sword3", "$sword");
            sword3.equipment_type = EquipmentType.Weapon;
            sword3.material = "iron";
            sword3.equipment_value = 30;
            sword3.setCost(0, "iron", 1, "none", 0);
            sword3.rigidity_rating = 4;
            sword3.base_stats["damage"] = 6f;
            sword3.base_stats["critical_chance"] = 0.05f;
            sword3.base_stats["stamina"] = 5f;
            sword3.path_icon = "ui/icons/items/icon_bnm_sword3";
            sword3.path_gameplay_sprite = "weapons/bnm_sword3";
            sword3.name_templates = AssetLibrary<EquipmentAsset>.l<string>("sword_name");
            sword3.is_pool_weapon = true;
            sword3.pool_rate = 5;
            itemLibrary.add(sword3);

            EquipmentAsset sword4 = itemLibrary.clone("bnm_sword4", "$sword");
            sword4.equipment_type = EquipmentType.Weapon;
            sword4.material = "adamantine";
            sword4.equipment_value = 70;
            sword4.setCost(0, "adamantine", 1, "none", 0);
            sword4.rigidity_rating = 7;
            sword4.base_stats["damage"] = 10f;
            sword4.base_stats["speed"] = 1f;
            sword4.base_stats["critical_chance"] = 0.15f;
            sword4.base_stats["mana"] = 35f;
            sword4.base_stats["stamina"] = 10f;
            sword4.path_icon = "ui/icons/items/icon_bnm_sword4";
            sword4.path_gameplay_sprite = "weapons/bnm_sword4";
            sword4.name_templates = AssetLibrary<EquipmentAsset>.l<string>("sword_name");
            sword4.is_pool_weapon = true;
            sword4.pool_rate = 5;
            itemLibrary.add(sword4);

            // ----- Bullshit yo💔 -----

            itemLibrary.pot_weapon_assets_all.Add(sword1);
            itemLibrary.pot_weapon_assets_all.Add(sword2);
            itemLibrary.pot_weapon_assets_all.Add(sword3);
            itemLibrary.pot_weapon_assets_all.Add(sword4);

            itemLibrary.pot_weapon_assets_unlocked.Add(sword1);
            itemLibrary.pot_weapon_assets_unlocked.Add(sword2);
            itemLibrary.pot_weapon_assets_unlocked.Add(sword3);
            itemLibrary.pot_weapon_assets_unlocked.Add(sword4);

            AddToSubtype(itemLibrary, "boots", boots1);
            AddToSubtype(itemLibrary, "armor", armor1);
            AddToSubtype(itemLibrary, "helmet", helmet1);
            AddToSubtype(itemLibrary, "sword", sword1, sword2, sword3, sword4);

            AddToGroupAll(itemLibrary, "boots", boots1);
            AddToGroupAll(itemLibrary, "armor", armor1);
            AddToGroupAll(itemLibrary, "helmet", helmet1);
            AddToGroupAll(itemLibrary, "sword", sword1, sword2, sword3, sword4);

            AddToGroupUnlocked(itemLibrary, "boots", boots1);
            AddToGroupUnlocked(itemLibrary, "armor", armor1);
            AddToGroupUnlocked(itemLibrary, "helmet", helmet1);
            AddToGroupUnlocked(itemLibrary, "sword", sword1, sword2, sword3, sword4);
        }

        private static void AddToSubtype(ItemLibrary lib, string subtype, params EquipmentAsset[] items)
        {
            if (!lib.equipment_by_subtypes.ContainsKey(subtype))
                lib.equipment_by_subtypes.Add(subtype, new List<EquipmentAsset>());
            foreach (var item in items)
                lib.equipment_by_subtypes[subtype].Add(item);
        }

        private static void AddToGroupAll(ItemLibrary lib, string group, params EquipmentAsset[] items)
        {
            if (!lib.pot_equipment_by_groups_all.ContainsKey(group))
                lib.pot_equipment_by_groups_all.Add(group, new List<EquipmentAsset>());
            foreach (var item in items)
                lib.pot_equipment_by_groups_all[group].Add(item);
        }

        private static void AddToGroupUnlocked(ItemLibrary lib, string group, params EquipmentAsset[] items)
        {
            if (!lib.pot_equipment_by_groups_unlocked.ContainsKey(group))
                lib.pot_equipment_by_groups_unlocked.Add(group, new List<EquipmentAsset>());
            foreach (var item in items)
                lib.pot_equipment_by_groups_unlocked[group].Add(item);
        }
    }
}