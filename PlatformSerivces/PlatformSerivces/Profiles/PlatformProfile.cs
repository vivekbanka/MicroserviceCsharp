using AutoMapper;
using PlatformSerivces.DTOs;
using PlatformSerivces.Models;

namespace PlatformSerivces.Profiles
{
    public class PlatformProfile: Profile
    {
        public PlatformProfile()
        {
            // source to targer 

            CreateMap<Platform, PlatformDTO>();
            CreateMap<PlatformCreateDTO, Platform>();
        }
    }
}
