using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{

    class PizzaMaker
    {
        private PizzaOven oven;

        public PizzaMaker()
        {
            oven = new PizzaOven();
        }
        public void MakePizza(PizzaType type)
        {
            PizzaIngredients pizzaIngredients;
            switch (type)
            {
                case PizzaType.Tomato:
                    pizzaIngredients = new PizzaIngredients();
                    Console.WriteLine("Making Tomato Pizza");
                    oven.Bake(pizzaIngredients);
                    break;
                case PizzaType.Mushroom:
                    pizzaIngredients = new PizzaIngredients();
                    Console.WriteLine("Making Mushroom Pizza");
                    oven.Bake(pizzaIngredients);
                    break;
                default:
                    pizzaIngredients = new PizzaIngredients();
                    oven.Bake(pizzaIngredients);
                    break;
            }
        }
    }
    class UpgradePizzaMaker
    {
        private PizzaOven oven;
        public UpgradePizzaMaker()
        {
            oven = new PizzaOven();
        }
        public void MakePizza(Pizza pizza)
        {
            Console.WriteLine("Making {0} Pizza", pizza.PizzaType);
            // pizzaMake(oven);
        }
    }
    class Pizza
    {
        protected PizzaIngredients ingredients;
        public PizzaType PizzaType { get { return _pizzaType; } }
        private PizzaType _pizzaType;

        public Pizza(PizzaType type)
        {
            _pizzaType = type;
        }
        protected virtual void SetIngredients()
        {
            Console.WriteLine("Base Pizza Ingredients Set");
        }
        public void Make(PizzaOven oven)
        {
            oven.Bake(ingredients);
        }
    }
    class TomatoPizza : Pizza
    {
        public TomatoPizza() : base(PizzaType.Tomato) { }
        protected override void SetIngredients()
        {

            Console.WriteLine("Tomato Pizza Ingredients Set");
            ingredients = new PizzaIngredients();
        }
    }
    class MushroomPizza : Pizza
    {
        public MushroomPizza() : base(PizzaType.Tomato) { }
        protected override void SetIngredients()
        {
            Console.WriteLine("Mushroom Pizza Ingredients Set");
            ingredients = new PizzaIngredients();
        }
    }
    enum PizzaType
    {
        Tomato = 1,
        Mushroom = 2
    }
    class PizzaOven
    {
        public void Bake(PizzaIngredients ingredients)
        {

        }
    }
    class PizzaIngredients
    { }
}
