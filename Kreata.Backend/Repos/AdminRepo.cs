
using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.EntityFrameworkCore;

public class AdminRepo : IAdminRepo
{
    private readonly KretaInMemoryContext _dbContext;

    public AdminRepo(KretaInMemoryContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<Admin>> GetAll()
    {
        return await _dbContext.Admins.ToListAsync();
    }

    public async Task<Admin?> GetBy(Guid id)
    {
        return await _dbContext.Admins.FirstOrDefaultAsync(s => s.Id == id);
    }
}