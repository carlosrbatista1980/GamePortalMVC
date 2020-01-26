using Microsoft.EntityFrameworkCore;

namespace GamePortalMVC.Data.Repositories.Interfaces
{
    public interface IEntity<TPrimaryKey> where TPrimaryKey : struct
    {
        TPrimaryKey EntityId { get; }
    }
}