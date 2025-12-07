using TechStore.Business.Abstract;
using TechStore.DataAccess.Abstract;
using TechStore.Entities.Concrete;

namespace TechStore.Business.Concrete;

public class AppUserManager:GenericServiceManager<AppUser>,IAppUserService
{
    public AppUserManager(IGenericRepository<AppUser> repository) : base(repository) { }
}
