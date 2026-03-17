using ProjetoFinal.Business.Interface;
using ProjetoFinal.Data.Models;
using ProjetoFinal.Data.Repository;
using ProjetoFinal.Data.Repository.Interface;
using System;

namespace ProjetoFinal.Business.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacters _charactersRep;
        public CharacterService(ICharacters charactersRep)
        {
            _charactersRep = charactersRep;
        }
        public async Task<List<Characters>> GetCharactersAsync(List<int> charactersID)
        {
            List<Characters> characters = new List<Characters>();

            foreach (var id in charactersID)
            {
                Characters character = await _charactersRep.GetByIdAsync(id);
                characters.Add(character);
            }

            return characters;
        }
        
        public List<Characters> OrderCharactersByAge(List<Characters> characters)
        {
            characters = characters.OrderByDescending(t => t.Age).ToList();
            return characters;
        }
        public int GetVictoryPercentage(Characters characters)
        {
            if (characters.Fights == 0)
            {
                return 0;
            }
            int GetVictoryPercentage = (int)Math.Round(100.0 * characters.Fights / characters.Fights);
            return GetVictoryPercentage;
        }

        public async Task<Characters> UpdateResultsAsync(Characters characters)
        {
            await _charactersRep.UpdateAsync(characters);
            return characters;
        }
    }
}
