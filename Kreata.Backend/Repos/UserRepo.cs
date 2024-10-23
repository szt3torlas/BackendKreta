
using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.EntityFrameworkCore;

public class UserRepo : IUserRepo
{
    private readonly KretaInMemoryContext _dbContext;

    public UserRepo(KretaInMemoryContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<User>> GetAll()
    {
        return await _dbContext.Users.ToListAsync();
    }

    public async Task<User?> GetBy(Guid id)
    {
        return await _dbContext.Users.FirstOrDefaultAsync(s => s.Id == id);
    }
}