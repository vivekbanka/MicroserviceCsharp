using PlatformSerivces.Models;

namespace PlatformSerivces.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;
        }
        void IPlatformRepo.CreatePlatform(Platform platform)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Platform> IPlatformRepo.GetAllPlatforms()
        {
           return _context.Platforms.ToList();
        }

        Platform IPlatformRepo.GetPlatformById(int id)
        {
            throw new NotImplementedException();
        }

        bool IPlatformRepo.savechanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
