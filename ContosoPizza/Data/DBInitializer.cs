using ContosoPizza.Models;
using ContosoPizza.Services;

namespace ContosoPizza.Data
{
    public static class DBInitializer
    {
        public static void Initialze(PizzaContext context)
        {
            if (context.Pizzas.Any() && context.Topping.Any() && context.Sauces.Any())
                return; //DB has been seed
            var pepperoniTopping = new Topping { Name = "Pepperoni", Calories = 130 };
            var sausageTopping = new Topping { Name = "Sausage", Calories = 100 };
            var hamTopping = new Topping { Name = "Ham", Calories = 70 };
            var chikenTopping = new Topping { Name = "Chiken", Calories = 50 };
            var pineappleTopping = new Topping { Name = "Pineapple", Calories = 75 };

            var tomatoSauce = new Sauce { Name = "Tomato", IsVegan = true };
            var alfredoSauce = new Sauce { Name = "Alfredo", IsVegan = false };

            var pizzas = new Pizza[]
            {
                new Pizza
                {
                    Name = "meat Lovers",
                    Sauce = tomatoSauce,
                    Toppings = new List<Topping>
                    {
                        pepperoniTopping,sausageTopping,hamTopping,chikenTopping
                    }
                },
                new Pizza
                {
                    Name= "Hawwaiian",
                    Sauce = tomatoSauce,
                    Toppings =new List<Topping>
                    {
                        pineappleTopping,hamTopping
                    }
                },
                new Pizza
                {
                    Name="Alfredo Chiken",
                    Sauce =alfredoSauce,
                    Toppings = new List<Topping>
                    {
                        chikenTopping
                    }
                }
            };
            context.Pizzas.AddRange(pizzas);
            context.SaveChanges();
        }
        
    }
}
