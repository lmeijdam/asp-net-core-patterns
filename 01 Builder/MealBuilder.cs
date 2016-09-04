using Builder.Models;

namespace Builder
{
    public class MealBuilder
    {
        public Meal PrepareChickenMeal()
        {
            var meal = new Meal();
            meal.AddItem(new Coffee());
            meal.AddItem(new ChickenBurger());

            return meal;
        }

        public Meal PrepareBurgerMeal()
        {
            var meal = new Meal();
            meal.AddItem(new Hamburger());
            meal.AddItem(new Cola());

            return meal;
        }

    }
}
