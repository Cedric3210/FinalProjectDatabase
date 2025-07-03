using Consultation.Infrastructure.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DesktopTesting.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentDashBoardController
    {
        private readonly AppDbContext _context;

        public StudentDashBoardController(AppDbContext context)
        {
            _context = context;
        }
    }
}
