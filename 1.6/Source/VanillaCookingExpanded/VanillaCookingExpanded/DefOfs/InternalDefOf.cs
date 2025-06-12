using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;
using RimWorld;


namespace VanillaCookingExpanded
{

    [DefOf]
    public static class InternalDefOf
    {
        static InternalDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(InternalDefOf));
        }

        public static StatDef VCE_FoodImprovementChance;
        public static StatDef VCEF_FoodCondimentChance;

        public static ThingDef MealLavish;
        public static ThingDef MealSimple;
        public static ThingDef MealFine;
        public static ThingDef MealFine_Meat;
        public static ThingDef MealFine_Veg;
        public static ThingDef MealLavish_Meat;
        public static ThingDef MealLavish_Veg;
        public static ThingDef VCE_SimpleBake;
        public static ThingDef VCE_FineBake;
        public static ThingDef VCE_LavishBake;
        public static ThingDef VCE_SimpleGrill;
        public static ThingDef VCE_FineGrill;
        public static ThingDef VCE_LavishGrill;
        public static ThingDef VCE_DigestibleResurrectorNanites;

        public static ThingCategoryDef VCE_Condiments;



    }
}