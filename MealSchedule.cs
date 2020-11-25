using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Jari_AppMealScheduling
{
    public class MealScheduler 
    {
        ///
        /// @param meals: complete list of meals
        /// @parma targetIndex: index welk item naar waar gesleept
        /// @parma originIndex: index welk item versleept wordt
        public List<Meal> GetNewMealSchedule(List<Meal> meals, int targetIndex, int originIndex) {
            if(targetIndex == originIndex) {
                // Do nothing!
                return meals;
            }

            // Enkel meals tussen start & end are affected -> dient zuiver om in debugger te tonen met de meals te tonen die geaffected zullen zijn
            int start = (targetIndex < originIndex ? targetIndex : originIndex);
            int end = (targetIndex > originIndex ? targetIndex : originIndex);
            List<Meal> affectedMeals = meals
                .Skip(start)
                .Take(end)
                .ToList();

            // Setup negative/positive increase (hangt af of je iets van verleden in toekomst dropt of omgekeerd)
            int increase;
            if(originIndex > targetIndex) {
                // Alles moet 1 dag opgeschoven worden in de toekomst.
                increase = 1;
            } else {
                // Alles moet 1 dag opgeschoven worden in het verleden.
                increase = -1;
            }

            // Code below is in-memory scheduling
            // Begin bij het "replacen" van target door origin
            List<Meal> newMealsSchedule = new List<Meal>();
            Meal current = meals[targetIndex].DeepClone(); 
            Meal next = meals[originIndex].DeepClone();
            next.Date = current.Date;
            newMealsSchedule.Add(next);

            // Daarna begin je bij target en overwrite je de volgende
            int currentIndex = targetIndex;
            for (int i = 0; i < affectedMeals.Count-1; i++)
            {
                int nextIndex = currentIndex+increase;
                current = meals[currentIndex].DeepClone(); 
                next = meals[nextIndex].DeepClone();

                current.Date = next.Date;
                newMealsSchedule.Add(current);
                currentIndex = nextIndex;
            }

            return newMealsSchedule;
        }
    }
}



