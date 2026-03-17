using ProjetoFinal.Business.Interface;
using ProjetoFinal.Data.Models;
using ProjetoFinal.Data.Repository.Interface;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProjetoFinal.Business.Services
{
    public class ChampionshipService : IChampionshipService
    {
        private readonly ICharacterService _characterService;

        //public ChampionshipService()
        //{

        //}

        public ChampionshipService(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        public async Task<Characters> Tiebreaker(Characters character1, Characters character2)
        {
            if (character1.Power == character2.Power)
            {
                if (character1.Fights > character2.Fights)
                {
                    character2.Defeat++;
                    await _characterService.UpdateResultsAsync(character2);
                    return character1;
                }
                else 
                {
                    character1.Defeat++;
                    await _characterService.UpdateResultsAsync(character1);
                    return character2;
                }
            }
            else if (character1.Power > character2.Power)
            {
                character2.Defeat++;
                await _characterService.UpdateResultsAsync(character2);
                return character1;
            }
            else
            {
                character1.Defeat++;
                await _characterService.UpdateResultsAsync(character1);
                return character2;
            }

        }

        public async Task<Characters> Rounds(Characters character1, Characters character2)
        {
            //Funcionamento das rodadas do torneio
            int percentageVictoryCharacter1 = _characterService.GetVictoryPercentage(character1);
            int percentageVictoryCharacter2 = _characterService.GetVictoryPercentage(character2);
            Characters winner = null;

            character1.Fights++;
            character2.Fights++;

            if (percentageVictoryCharacter1 == percentageVictoryCharacter2)
            {
                return await Tiebreaker(character1, character2);
            }
            else if (percentageVictoryCharacter1 > percentageVictoryCharacter2)
            {
                character2.Defeat++;
                await _characterService.UpdateResultsAsync(character2);
                winner = character1;
            }
            else
            {
                character1.Defeat++;
                await _characterService.UpdateResultsAsync(character1);
                winner = character2;
            }
            return winner;
        }

        public async Task<List<Characters>> WinnersPerRound(List<Characters> characters)
        {
            //Lista de vencedores por rodada
            var winners = new List<Characters>();
            var numberCharacters = characters.Count;

            for (int i = 0; i < numberCharacters; i += 2)
            {
                var winner = await Rounds(characters[i], characters[i + 1]);
                winners.Add(winner);
            }
            return winners;
        }

        public async Task<List<Characters>> TheLast16(List<Characters> characters)
        {
            var charactersOrderedByAge = _characterService.OrderCharactersByAge(characters);
            var winnersOfTheLast16 = await WinnersPerRound(charactersOrderedByAge);

            return winnersOfTheLast16;
        }

        public async Task<List<Characters>> TheLast8(List<Characters> characters)
        {
            var charactersOrderedByAge = _characterService.OrderCharactersByAge(characters);
            var winnersOfTheLast8 = await WinnersPerRound(charactersOrderedByAge);

            return winnersOfTheLast8;
        }

        public async Task<List<Characters>> SemiFinal(List<Characters> characters)
        {
            var charactersOrderedByAge = _characterService.OrderCharactersByAge(characters);
            var winnersOfSemiFinal = await WinnersPerRound(charactersOrderedByAge);

            return winnersOfSemiFinal;
        }
        public async Task<Characters> Final(List<Characters> characters)
        {
            var winner = await WinnersPerRound(characters);
            var champion = winner.First();
            
            champion.Victory++;
            await _characterService.UpdateResultsAsync(champion);

            return champion;
        }

        public async Task<Characters> StartChampionship(List<Characters> characters)
        {
            characters = await TheLast16(characters);
            characters = await TheLast8(characters);
            characters = await SemiFinal(characters);
            var champion = await Final(characters);

            return champion;
        }
    }
}
