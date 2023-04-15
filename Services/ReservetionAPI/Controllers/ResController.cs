using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationAPI.Infrastructure;
using ReservationAPI.Models;

namespace ReservetionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ResController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }
        [HttpGet]
        public Reservation Get(int id)
        {
            return reservationService.GetResByBkNumer(id);
        }
    }
}
