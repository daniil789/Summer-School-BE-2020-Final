using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Summer_School_BE_2020_Final.Interfaces;
using Summer_School_BE_2020_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Summer_School_BE_2020_Final.Services
{
    public class GameService : IGameService
    {
        private ApplicationContext db;
        private readonly IValidateService _validateService;
        public GameService(ApplicationContext context, IValidateService validateService)
        {
            db = context;
            _validateService = validateService;
        }
        public void AddGame(Game game)
        {
            db.Games.Add(game);
            db.SaveChanges();
            
        }

        public async Task<Game[]> ViewGames()
        {
            var games = await db.Games.ToArrayAsync();
            return games;
             
        }

        public void BuyGame(Purchase purchase)
        { 
                var games = db.Games;
                foreach (var game in games)
                {
                    if (purchase.Game == game.Name)
                    {
                        db.Games.Remove(game);
                        db.SaveChanges();
                        break;
                    }
                }   
        }
    }
}
