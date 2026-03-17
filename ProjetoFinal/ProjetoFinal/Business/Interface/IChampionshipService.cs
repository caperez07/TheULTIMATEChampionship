using ProjetoFinal.Data.Models;

namespace ProjetoFinal.Business.Interface
{
    public interface IChampionshipService
    {
        Task<Characters> Rounds(Characters character1, Characters character2);
        Task<Characters> Tiebreaker(Characters character1, Characters character2);
        Task<List<Characters>> WinnersPerRound(List<Characters> characters);
        Task<List<Characters>> TheLast16(List<Characters> characters);
        Task<List<Characters>> TheLast8(List<Characters> characters);
        Task<List<Characters>> SemiFinal(List<Characters> characters);
        Task<Characters> Final(List<Characters> characters);
        Task<Characters> StartChampionship(List<Characters> characters);
    }
}
