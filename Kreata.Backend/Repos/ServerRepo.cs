
using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.EntityFrameworkCore;

public class ServerRepo : IServerRepo
{
    private readonly KretaInMemoryContext _dbContext;

    public ServerRepo(KretaInMemoryContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<Server>> GetAll()
    {
        return await _dbContext.Servers.ToListAsync();
    }
    
    public async Task<Server?> GetBy(Guid id)
    {
        return await _dbContext.Servers.FirstOrDefaultAsync(s => s.Id == id);
    }
}