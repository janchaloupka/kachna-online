// IReservationItemEventRepository.cs
// Author: František Nečas

using System.Collections.Generic;
using System.Threading.Tasks;
using KachnaOnline.Data.Entities.BoardGames;

namespace KachnaOnline.Business.Data.Repositories.Abstractions
{
    public interface IReservationItemEventRepository : IGenericRepository<ReservationItemEvent, int>
    {
        IAsyncEnumerable<ReservationItemEvent> GetByItemId(int itemId);
        Task<ReservationItemEvent> GetLatestEvent(int itemId);
    }
}
