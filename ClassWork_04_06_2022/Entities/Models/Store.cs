using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Utils.Exceptions;

namespace Entities.Models
{
    public class Store : IEnumerable
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public List<Game> games;
        public Store()
        {
            _id++;
            Id = _id;
            games = new List<Game>();
        }

        public void AddGame(Game game)
        {
            Game gm = games.Find(e => e.Name == game.Name && !e.IsDeleted);
            if (gm == null)
            {
                games.Add(game);
                return;
            }
            throw new AlreadyExistsException("Game alrey exist!!!");
        }

        public Game GetGameById(int? id)
        {
            if (id != null)
            {
                Game gm = games.Find(e => e.Id == id && !e.IsDeleted);
                if (gm != null)
                {
                    return gm;
                }
                return null;
            }
            throw new NullReferenceException("Id shouldn't be null!!!");
        }

        public void RemoveGameById(int? id)
        {
            if(id != null)
            {
                Game gm = games.Find(e => e.Id == id && e.IsDeleted == false);
                if (gm != null)
                {
                    gm.IsDeleted = true;
                    return;
                }
                throw new NotFoundException("Game not found!!!");
            }
            throw new NullReferenceException("Id shouldn't be null!!!");
        }

        public List<Game> FilterGamesByPrice(double min, double max)
        {
            List<Game> gm = games.FindAll(e => e.Price >= min && e.Price <= max && !e.IsDeleted);
            if(gm != null)
            {
                return gm;
            }
            throw new NotFoundException("Game not found!!!");
        }
        public List<Game> FilterGamesByDiscountPrice(double min, double max)
        {
            List<Game> gm = games.FindAll(e => e.GetDiscountPrice(e.DiscountPercent) >= min && e.GetDiscountPrice(e.DiscountPercent) <= max && !e.IsDeleted);

            if (gm != null)
            {
                return gm;
            }
            throw new NotFoundException("Game not found!!!");
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var game in games)
            {
                yield return game;
            }
        }

    }
}
