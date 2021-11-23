using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebTime.Data;

namespace WebTime.Services
{
    public class MainService
    {
        public ApplicationDbContext _context;
        public UserService _userService;
        public AdminService _adminService;
        public ClientService _clientService;
        public BookingService _bookingService;
        public ClubService _clubService;
        public HallService _hallService;
        public TimeTableService _timeTableService;
        public TrainerService _trainerService;


        public MainService(ApplicationDbContext context, UserService userService, AdminService adminService, ClientService clientService, BookingService bookingService, ClubService clubService, HallService hallService, TimeTableService timeTableService, TrainerService trainerService)
        {
            _context = context;
            _userService = userService;
            _adminService = adminService;
            _clientService = clientService;
            _bookingService = bookingService;
            _clubService = clubService;
            _hallService = hallService;
            _timeTableService = timeTableService;
            _trainerService = trainerService;
            
        }
    }
}