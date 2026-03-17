using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Business.Interface;
using ProjetoFinal.Business.Services;
using ProjetoFinal.Data;
using ProjetoFinal.Data.Models;
using ProjetoFinal.Data.Repository.Interface;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ProjetoFinal.Business.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ProjectContext _dbContext;
        private readonly ICharacters _charactersRep;
        private readonly IChampionshipService _championshipService;
        public HomeController(ILogger<HomeController> logger, ProjectContext dbContext, ICharacters charactersRep, 
            IChampionshipService championshipService)
        {
            _logger = logger;
            _dbContext = dbContext;
            _charactersRep = charactersRep;
            _championshipService = championshipService;
        }

        public async Task<IActionResult> Index()
        {
           return View();
        }

        public IActionResult Championship()
        {
            return View();
        }

        public async Task<IActionResult> Characters()
        {
            var characters = await _charactersRep.GetAllAsync();
            return View(characters);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Rules()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<String> InitiateChampionship(List<int> championship)
        {
            List<Characters> choosenCharacters = new List<Characters>();
            var characters = await _charactersRep.GetAllAsync();

            for(int i = 0; i < championship.Count(); i++)
            {
                foreach(Characters character in characters)
                {
                    if (championship[i] == character.Id)
                    {
                        choosenCharacters.Add(character);
                    }
                }
            }

            var champion = await _championshipService.StartChampionship(choosenCharacters);

            return champion.Name;
        }
    }
}
