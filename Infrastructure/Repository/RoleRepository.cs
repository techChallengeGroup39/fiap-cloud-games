using Core.Entity;
using Core.Repository;
namespace Infrastructure.Repository
{
    public class RoleRepository : EFRepository<Role>, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
