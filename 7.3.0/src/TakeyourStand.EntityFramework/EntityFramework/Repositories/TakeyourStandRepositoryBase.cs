using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TakeyourStand.EntityFramework.Repositories
{
    public abstract class TakeyourStandRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TakeyourStandDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TakeyourStandRepositoryBase(IDbContextProvider<TakeyourStandDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TakeyourStandRepositoryBase<TEntity> : TakeyourStandRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TakeyourStandRepositoryBase(IDbContextProvider<TakeyourStandDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
