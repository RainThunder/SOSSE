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
                var txt = (string)Properties.Resources.ResourceManager.GetObject("ItemName");
                Item.ItemNameList = ((string)txt).Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadBlueprintNameList()
        {
            if (BlueprintEditingForm.BlueprintNameList == null)
            {
                Object txt = (string)Properties.Resources.ResourceManager.GetObject("BlueprintName");
                BlueprintEditingForm.BlueprintNameList = ((string)txt).Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadBlueprintSetNameList()
        {
            if (BlueprintEditingForm.BlueprintSetNameList == null)
            {
                Object txt = (string)Properties.Resources.ResourceManager.GetObject("BlueprintSetName");
                BlueprintEditingForm.BlueprintSetNameList = ((string)txt).Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadPatternNameList()
        {
            if (PatternEditingForm.PatternNameList == null)
            {
                Object txt = (string)Properties.Resources.ResourceManager.GetObject("PatternName");
                PatternEditingForm.PatternNameList = ((string)txt).Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadPatternSetNameList()
        {
            if (PatternEditingForm.PatternSetNameList == null)
            {
                Object txt = (string)Properties.Resources.ResourceManager.GetObject("PatternSetName");
                PatternEditingForm.PatternSetNameList = ((string)txt).Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadRecipeSetNameList()
        {
            if (RecipeEditingForm.RecipeSetNameList == null)
            {
                Object txt = (string)Properties.Resources.ResourceManager.GetObject("RecipeSetName");
                RecipeEditingForm.RecipeSetNameList = ((string)txt).Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadAnimalTypeList()
        {
            if (AnimalEditingForm.AnimalTypeList == null)
            {
                Object txt = (string)Properties.Resources.ResourceManager.GetObject("AnimalType");
                AnimalEditingForm.AnimalTypeList = ((string)txt).Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadAnimalPersonalityList()
        {
            if (AnimalEditingForm.AnimalPersonalityList == null)
            {
                Object txt = (string)Properties.Resources.ResourceManager.GetObject("AnimalPersonality");
                AnimalEditingForm.AnimalPersonalityList = ((string)txt).Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadShopNameList()
        {
            if (ShopEditingForm.ShopNameList == null)
            {
                Object txt = (string)Properties.Resources.ResourceManager.GetObject("ShopName");
                ShopEditingForm.ShopNameList = ((string)txt).Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadTradingCategory()
        {
            if (ConquestEditingForm.TradingCategory == null)
            {
                Object txt = (string)Properties.Resources.ResourceManager.GetObject("TradingCategory");
                ConquestEditingForm.TradingCategory = ((string)txt).Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadObjectNameList()
        {
            if (ObjectEditingForm.ObjectNameList == null)
            {
                var txt = (string)Properties.Resources.ResourceManager.GetObject("ObjectName");
                ObjectEditingForm.ObjectNameList = ((string)txt).Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadItemObjectCategory()
        {
            if (ShipLogEditingForm.ItemObjectCategory == null)
            {
                var txt = (string)Properties.Resources.ResourceManager.GetObject("ItemObjectCategory");
                ShipLogEditingForm.ItemObjectCategory = ((string)txt).Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadMonth()
        {
            if (GeneralEditingForm.Month == null)
            {
                var txt = (string)Properties.Resources.ResourceManager.GetObject("Month");
                GeneralEditingForm.Month = ((string)txt).Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadNPCName()
        {
            if (NPCEditingForm.NPCNameList == null)
            {
                var txt = (string)Properties.Resources.ResourceManager.GetObject("NPCName");
                NPCEditingForm.NPCNameList = ((string)txt).Replace("\r", "").Split(new[] { '\n' });
            }
        }

        public static void LoadEventFlag()
        {
            if (EventEditingForm.EventFlagList == null)
            {
                var txt = (string)Properties.Resources.ResourceManager.GetObject("EventFlag");
                EventEditingForm.EventFlagList = ((string)txt).Replace("\r", "").Split(new[] { '\n' });
            }
        }
    }
}
