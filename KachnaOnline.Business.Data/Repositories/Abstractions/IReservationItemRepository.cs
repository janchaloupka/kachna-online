// IReservationItemRepository.cs
// Author: František Nečas

using System.Collections.Generic;
using System.Threading.Tasks;
using KachnaOnline.Data.Entities.BoardGames;

namespace KachnaOnline.Business.Data.Repositories.Abstractions
{
    public interface IReservationItemRepository : IGenericRepository<ReservationItem, int>
    {
        Task<ICollection<ReservationItem>> ItemsInReservation(int reservationId);
    }
}
