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
            if (platform != null)
            {
                throw new ArgumentException(nameof(platform));
            }
            else
            {
                _context.Platforms.Add(platform);
                
            }
        }

        IEnumerable<Platform> IPlatformRepo.GetAllPlatforms()
        {
           return _context.Platforms.ToList();
        }

        Platform IPlatformRepo.GetPlatformById(int id)
        {
            return _context.Platforms.FirstOrDefault(x => x.Id == id);
        }

        bool IPlatformRepo.savechanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
