using ETreeks.Core.Data;
using ETreeks.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETreeks.Core.IService
{
    public interface IReservationService
    {

        Task<int> CreateReservation(Reservation reservation);

        Task UpdateReservation(Reservation reservation);

        Task DeleteReservation(int id);

        Task<List<ReservationDate2>> GetAllReservations();

        Task<List<ReservationDate4>> GetAllReservations4();
        Task<Reservation> GetReservationById(int id);
    }
}
