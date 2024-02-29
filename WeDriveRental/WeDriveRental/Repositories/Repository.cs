using Microsoft.EntityFrameworkCore;
using Shared.Models;
using WeDriveRental.Data;

namespace WeDriveRental.Repositories
{
    public class Repository
    {

        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }


        // Hämta Id 
        public async Task<RentalModel?> GetRentalByIdAsync(int rentalId)
        {
            return await _context.Rentals.FirstOrDefaultAsync(p => p.Id == rentalId);
        }

        // Hämta alla rentals 
        public async Task<List<RentalModel>> GetAllRentalsAsync()
        {
            return await _context.Rentals.ToListAsync();
        }

    }
}
