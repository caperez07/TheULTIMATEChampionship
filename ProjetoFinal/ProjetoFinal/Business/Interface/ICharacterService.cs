using ProjetoFinal.Data.Models;

namespace ProjetoFinal.Business.Interface
{
    public interface ICharacterService
    {
        Task<List<Characters>> GetCharactersAsync(List<int> charactersID);
        List<Characters> OrderCharactersByAge(List<Characters> characters);
        int GetVictoryPercentage(Characters characters);
        Task<Characters> UpdateResultsAsync(Characters characters);
    }
}
