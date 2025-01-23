using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;
using RimWorld;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;


namespace VanillaCookingExpanded
{


    [HarmonyPatch(typeof(GenRecipe))]
    [HarmonyPatch("MakeRecipeProducts")]

    public static class VanillaCookingExpanded_GenRecipe_MakeRecipeProducts_Patch
    {

        public static IEnumerable<Thing> Postfix(IEnumerable<Thing> values, RecipeDef recipeDef, Pawn worker)
        {
            List<Thing> resultingList = values.ToList();
            if (recipeDef.products != null)
            {

                if (Rand.Chance(worker.GetStatValue(InternalDefOf.VCE_FoodImprovementChance)))
                {

                    foreach (Thing thing in resultingList)
                    {
                        if (StaticCollections.allowedMeals.Contains(thing.def))
                        {

                            if (thing.def == InternalDefOf.MealSimple)
                            {
                                thing.def = InternalDefOf.MealFine;
                            }
                            else
                            if (thing.def == InternalDefOf.MealFine_Meat)
                            {
                                thing.def = InternalDefOf.MealLavish_Meat;
                            }
                            else
                            if (thing.def == InternalDefOf.MealFine_Veg)
                            {
                                thing.def = InternalDefOf.MealLavish_Veg;
                            }
                            else
                            if (thing.def == InternalDefOf.VCE_SimpleBake)
                            {
                                thing.def = InternalDefOf.VCE_FineBake;
                            }
                            else
                            if (thing.def == InternalDefOf.VCE_FineBake)
                            {
                                thing.def = InternalDefOf.VCE_LavishBake;
                            }
                            else
                            if (thing.def == InternalDefOf.VCE_SimpleGrill)
                            {
                                thing.def = InternalDefOf.VCE_FineGrill;
                            }
                            else
                            if (thing.def == InternalDefOf.VCE_FineGrill)
                            {
                                thing.def = InternalDefOf.VCE_LavishGrill;
                            }
                            else thing.def = InternalDefOf.MealLavish;


                        }

                    }
                }

                if (Rand.Chance(worker.GetStatValue(InternalDefOf.VCEF_FoodCondimentChance)))
                {

                    foreach (Thing thing in resultingList)
                    {
                        if (thing.def.ingestible?.IsMeal == true)
                        {
                            CompIngredients comp = thing.TryGetComp<CompIngredients>();
                            if (comp != null)
                            {
                                ThingDef condiment = DefDatabase<ThingDef>.AllDefsListForReading.Where(x => x.thingCategories?.Contains(InternalDefOf.VCE_Condiments) == true
           && x != InternalDefOf.VCE_DigestibleResurrectorNanites).RandomElement();

                                comp.ingredients.Add(condiment);
                            }
                        }

                    }
                }

            }
            return resultingList;









        }

    }





}
