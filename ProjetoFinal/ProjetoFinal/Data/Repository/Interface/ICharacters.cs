using ProjetoFinal.Data.Models;

namespace ProjetoFinal.Data.Repository.Interface
{
    public interface ICharacters
    {
        Task<List<Characters>> GetAllAsync();
        Task<Characters> GetByIdAsync(int id);
        Task UpdateAsync(Characters character);

    }
}
