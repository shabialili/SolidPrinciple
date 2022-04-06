using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Single Responsibility Principle

            InterestCalculate calc = new InterestCalculate();
            BankAccount acc = new BankAccount();
            acc.AccountNumber = "1";
            calc.CalculateInterest(acc);
            Console.ReadKey();


            //Open Close Principle

            //PizzaMaker pizzaMaker = new PizzaMaker();
            //pizzaMaker.MakePizza(PizzaType.Tomato);
            TomatoPizza tomatoPizza = new TomatoPizza();
            MushroomPizza mushroomPizza = new MushroomPizza();
            UpgradePizzaMaker upgradePizzaMaker = new UpgradePizzaMaker();
            upgradePizzaMaker.MakePizza(mushroomPizza);
            upgradePizzaMaker.MakePizza(tomatoPizza);
            Console.ReadLine();


            //Liskov Substitution Principle

            Fruit fruit1 = new Apple();
            Console.WriteLine(fruit1.GetColor());
            Fruit fruit2 = new Orange();
            Console.WriteLine(fruit2.GetColor());
            Console.ReadKey();


            //Interface Segregation Principle

            Shirt shirt = new Shirt();
            shirt.id = 1;
            shirt.price = "29$";
            shirt.color = "Red";
            shirt.fabric = "cotton";
            Console.WriteLine(shirt.id);
            Console.WriteLine(shirt.price);
            Console.WriteLine(shirt.color);
            Console.WriteLine(shirt.fabric);
            Console.Read();

            Trousers trousers = new Trousers();
            trousers.id = 2;
            trousers.price = "60$";
            trousers.color = "Black";
            trousers.length = "35 sm";
            Console.WriteLine(trousers.id);
            Console.WriteLine(trousers.price);
            Console.WriteLine(trousers.color);
            Console.WriteLine(trousers.length);
            Console.Read();


            //Dependency Inversion Principle

            var person = new Person(new AServiceProvider());
            person.DeliveryMessage("Hello, how are you?");

        }
    }
}
