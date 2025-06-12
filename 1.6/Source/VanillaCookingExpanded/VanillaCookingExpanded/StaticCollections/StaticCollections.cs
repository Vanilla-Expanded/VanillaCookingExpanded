
using Verse;
using System;
using RimWorld;
using System.Collections.Generic;
using System.Linq;
using VanillaCookingExpanded;


namespace VanillaCookingExpanded
{
    [StaticConstructorOnStartup]
    public static class StaticCollections
    {

      
        public static List<ThingDef> allowedMeals = new List<ThingDef>() { InternalDefOf.MealSimple, InternalDefOf.MealFine, InternalDefOf.MealFine_Meat, InternalDefOf.MealFine_Veg,
        InternalDefOf.VCE_SimpleBake,InternalDefOf.VCE_FineBake,InternalDefOf.VCE_SimpleGrill,InternalDefOf.VCE_FineGrill };

        static StaticCollections()
        {

        }



    }
}
