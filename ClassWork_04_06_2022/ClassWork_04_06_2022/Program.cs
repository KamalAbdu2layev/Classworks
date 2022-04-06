using System;
using Utils.Enums;
using Utils.Exceptions;
using Entities.Models;

namespace ClassWork_04_06_2022
{
    public class Program
    {
        static void Main(string[] args)
        {

            int platform;
            bool isNum;
            bool check = true;

            Store store = new Store();

            do
            {
                Console.WriteLine("\n=========== MENU ===========");
                Console.WriteLine("0. Quit \n1. Add game \n2. Get game by id \n3. Delete game by id " +
                    "\n4. Filter game by price \n5. Filter game by discount price \n6. Get all games");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        check = false;
                        break;
                    case "1":
                        try
                        {
                            Console.WriteLine("Please enter name:");
                            string name = Console.ReadLine();

                            do
                            {
                                Console.WriteLine("Platform: (1.Pc  2.PlayStation  3.Xbox)");
                                string platformStr = Console.ReadLine();
                                isNum = Int32.TryParse(platformStr, out platform);
                            } while (!isNum || !Enum.IsDefined(typeof(Platform), platform));

                            Console.WriteLine("Please enter price");
                            double price = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Please enter discount percent");
                            int discountPercent = Convert.ToInt32(Console.ReadLine());

                            Platform myPlatform = (Platform)platform;

                            Game game = new Game(name, myPlatform, price)
                            {
                                DiscountPercent = discountPercent
                            };

                            store.AddGame(game);
                        }
                        catch (AlreadyExistsException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "2":
                        try
                        {
                            Console.WriteLine("Please enter id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("*************************");
                            store.GetGameById(id).ShowInfo();
                            Console.WriteLine("*************************");
                        }
                        catch (NullReferenceException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "3":
                        try
                        {
                            Console.WriteLine("Please enter id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            store.RemoveGameById(id);
                        }
                        catch (NotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (NullReferenceException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "4":
                        try
                        {
                            Console.WriteLine("Please enter minimum price: ");
                            double minPrice = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter maximum price: ");
                            double maxPrice = Convert.ToDouble(Console.ReadLine());
                            store.FilterGamesByPrice(minPrice, maxPrice);

                            Console.WriteLine("*************************");
                            foreach (var game in store.FilterGamesByPrice(minPrice, maxPrice))
                            {
                                game.ShowInfo();
                            }
                            Console.WriteLine("*************************");
                        }
                        catch (NotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "5":
                        try
                        {
                            Console.WriteLine("Please enter minimum price: ");
                            double minPrice = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter maximum price: ");
                            double maxPrice = Convert.ToDouble(Console.ReadLine());

                            store.FilterGamesByDiscountPrice(minPrice, maxPrice);

                            Console.WriteLine("*************************");
                            foreach (var game in store.FilterGamesByPrice(minPrice, maxPrice))
                            {
                                game.ShowInfo();
                            }
                            Console.WriteLine("*************************");
                        }
                        catch (NotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "6":
                        Console.WriteLine("*************************");
                        foreach (var game in store.games)
                        {
                            game.ShowInfo();
                        }
                        Console.WriteLine("*************************");
                        break;
                    default:
                        Console.WriteLine("Wrong Input!!!");
                        break;
                }

            } while (check);

        }
    }
}