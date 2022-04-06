using System;
using System.Collections.Generic;
using System.Text;
using Utils.Enums;
namespace Entities.Models
{
    public class Game
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public Platform Platform { get; set; }
        public double Price { get; set; }
        public int DiscountPercent { get; set; }
        public string Publisher { get; set; }
        public bool IsDeleted { get; set; }

        public Game(string name, Platform platform, double price)
        {
            _id++;
            Id = _id;
            Name = name;
            Platform = platform;
            Price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} \nName: {Name}\nPlatform: {Platform} \nPrice: {Price} " +
                $"\nDiscountPercent: {DiscountPercent} \nPublisher: {Publisher} \nIsDeleted: {IsDeleted}\n");
        }

        public double GetDiscountPrice(int DiscountPercent)
        {
            return Price * (100 - DiscountPercent) / 100;
        }

        public static void Sortt(double price)
        {
            Store store = new Store();
            //games.Sort(x => x.Price);
            store.games.Sort((x, price) => x.Price.CompareTo(price));
            //List<Game> sortedGames = games.Sort(delegate(   ))

        }
    }
}
