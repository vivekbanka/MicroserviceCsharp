using PlatformSerivces.Models;

namespace PlatformSerivces.Data
{
    public interface IPlatformRepo
    {
        bool savechanges();
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform platform);
    }
}
