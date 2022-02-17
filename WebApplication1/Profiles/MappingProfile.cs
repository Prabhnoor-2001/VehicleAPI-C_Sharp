using AutoMapper;
using Vehicles;
using WebApplication1.Contracts;

namespace WebApplication1.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Vehicle, VehicleContract>();
    }
}