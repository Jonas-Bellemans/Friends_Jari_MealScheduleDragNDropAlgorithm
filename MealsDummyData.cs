using System;
using System.Collections;
using System.Collections.Generic;

namespace Jari_AppMealScheduling
{
    public static class MealDummyData {
        public static List<Meal> GetMealsFromDatabase() 
        {
            return new List<Meal>() 
            {
                new Meal() { ID = 0, MealName = "Sosis", Date = new DateTime(year: 2020, month: 11, day: 19) },
                new Meal() { ID = 1, MealName = "Spaghetti", Date = new DateTime(year: 2020, month: 11, day: 20) },
                new Meal() { ID = 2, MealName = "Pizza", Date = new DateTime(year: 2020, month: 11, day: 21) },
                new Meal() { ID = 3, MealName = "Lasagne", Date = new DateTime(year: 2020, month: 11, day: 22) },
                new Meal() { ID = 4, MealName = "Tomaten", Date = new DateTime(year: 2020, month: 11, day: 23) },
                new Meal() { ID = 5, MealName = "Patatten", Date = new DateTime(year: 2020, month: 11, day: 24) },
            };
        }
    }
}
