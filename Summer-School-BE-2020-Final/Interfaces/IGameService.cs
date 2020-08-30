using Microsoft.AspNetCore.Mvc;
using Summer_School_BE_2020_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Summer_School_BE_2020_Final.Interfaces
{
   public interface IGameService
    {
         Task<Game[]> ViewGames();
         void AddGame(Game game);
         void BuyGame(Purchase purchase);


    }
}
