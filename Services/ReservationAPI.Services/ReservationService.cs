using ReservationAPI.Infrastructure;
using ReservationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationAPI.Services
{
    public class ReservationService : IReservationService
    {
        public Reservation GetResByBkNumer(int BkgNumber)
        {
            return new Reservation { Id = new Random().Next(100), Amount = new Random().Next(1000),BkgDate=DateTime.Now,CheckingDate=DateTime.Now.AddDays(30),CheckoutDate=DateTime.Now.AddDays(37),BkgNumber=BkgNumber };
        }
    }
}
