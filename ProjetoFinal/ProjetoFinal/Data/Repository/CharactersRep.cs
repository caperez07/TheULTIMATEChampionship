using ProjetoFinal.Data.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using ProjetoFinal.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoFinal.Data.Repository
{
    public class CharactersRep : ICharacters
    {
        private readonly ProjectContext _dbContext;

        public CharactersRep(ProjectContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Characters>> GetAllAsync()
        {
            return await _dbContext.Characters
                .ToListAsync();
        }

        public async Task<Characters> GetByIdAsync(int id)
        {
            return await _dbContext.Characters
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task UpdateAsync(Characters character)
        {
            _dbContext.Update(character);
            await _dbContext.SaveChangesAsync();
        }
    }
}
