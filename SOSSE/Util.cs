using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOSSE
{
    class Util
    {
        public static void LoadItemNameList()
        {
            if (Item.ItemNameList == null)
            {
                string txt = Properties.Resources.ResourceManager.GetString("ItemName");
                Item.ItemNameList = txt.Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadBlueprintNameList()
        {
            if (BlueprintEditingForm.BlueprintNameList == null)
            {
                string txt = Properties.Resources.ResourceManager.GetString("BlueprintName");
                BlueprintEditingForm.BlueprintNameList = txt.Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadBlueprintSetNameList()
        {
            if (BlueprintEditingForm.BlueprintSetNameList == null)
            {
                string txt = Properties.Resources.ResourceManager.GetString("BlueprintSetName");
                BlueprintEditingForm.BlueprintSetNameList = txt.Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadPatternNameList()
        {
            if (PatternEditingForm.PatternNameList == null)
            {
                string txt = Properties.Resources.ResourceManager.GetString("PatternName");
                PatternEditingForm.PatternNameList = txt.Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadPatternSetNameList()
        {
            if (PatternEditingForm.PatternSetNameList == null)
            {
                string txt = Properties.Resources.ResourceManager.GetString("PatternSetName");
                PatternEditingForm.PatternSetNameList = txt.Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadRecipeSetNameList()
        {
            if (RecipeEditingForm.RecipeSetNameList == null)
            {
                string txt = Properties.Resources.ResourceManager.GetString("RecipeSetName");
                RecipeEditingForm.RecipeSetNameList = txt.Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadAnimalTypeList()
        {
            if (AnimalEditingForm.AnimalTypeList == null)
            {
                string txt = Properties.Resources.ResourceManager.GetString("AnimalType");
                AnimalEditingForm.AnimalTypeList = txt.Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadAnimalPersonalityList()
        {
            if (AnimalEditingForm.AnimalPersonalityList == null)
            {
                string txt = Properties.Resources.ResourceManager.GetString("AnimalPersonality");
                AnimalEditingForm.AnimalPersonalityList = txt.Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadShopNameList()
        {
            if (ShopEditingForm.ShopNameList == null)
            {
                string txt = Properties.Resources.ResourceManager.GetString("ShopName");
                ShopEditingForm.ShopNameList = txt.Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadTradingCategory()
        {
            if (ConquestEditingForm.TradingCategory == null)
            {
                string txt = Properties.Resources.ResourceManager.GetString("TradingCategory");
                ConquestEditingForm.TradingCategory = txt.Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadObjectNameList()
        {
            if (ObjectEditingForm.ObjectNameList == null)
            {
                string txt = Properties.Resources.ResourceManager.GetString("ObjectName");
                ObjectEditingForm.ObjectNameList = txt.Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadItemObjectCategory()
        {
            if (ShipLogEditingForm.ItemObjectCategory == null)
            {
                string txt = Properties.Resources.ResourceManager.GetString("ItemObjectCategory");
                ShipLogEditingForm.ItemObjectCategory = txt.Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadMonth()
        {
            if (GeneralEditingForm.Month == null)
            {
                string txt = Properties.Resources.ResourceManager.GetString("Month");
                GeneralEditingForm.Month = txt.Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadNPCName()
        {
            if (NPCEditingForm.NPCNameList == null)
            {
                string txt = Properties.Resources.ResourceManager.GetString("NPCName");
                NPCEditingForm.NPCNameList = txt.Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadEventFlag()
        {
            if (EventEditingForm.EventFlagList == null)
            {
                string txt = Properties.Resources.ResourceManager.GetString("EventFlag");
                EventEditingForm.EventFlagList = txt.Replace("\r", "").Split(new[] { '\n' });
            }
        }
    }
}
