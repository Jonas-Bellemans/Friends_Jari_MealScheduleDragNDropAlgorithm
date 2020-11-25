using System;
using System.Collections;
using System.Collections.Generic;

namespace Jari_AppMealScheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var mealScheduler = new MealScheduler();

            List<Meal> meals = MealDummyData.GetMealsFromDatabase();
            List<Meal> newMeals = new MealScheduler().GetNewMealSchedule(meals, targetIndex: 1, originIndex: 3);
            Console.ReadKey();
        }
    }
}
