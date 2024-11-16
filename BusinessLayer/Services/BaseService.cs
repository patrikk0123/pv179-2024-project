using BusinessLayer.Services.Interfaces;
using DAL.Data;

namespace BusinessLayer.Services;

public class BaseService(BookHubDBContext dBContext) : IBaseService
{
    public async Task SaveAsync(bool save)
    {
        if (save)
        {
            await dBContext.SaveChangesAsync();
        }
    }
}
