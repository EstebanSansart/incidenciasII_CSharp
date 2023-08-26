using ApiIncidenciasII.Dtos;
using Dominio;
using AutoMapper;
using Dominio.Entities;

namespace ApiIncidenciasII.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles(){
        CreateMap<Pais,PaisDto>().ReverseMap();
        CreateMap<Departamento,DepartamentoDto>().ReverseMap();
        /*CreateMap<Estado,EstadoDto>()
        .ForMember(dest => dest.IdEstado, opt => opt.MapFrom(src => src.IdCod))
        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.nombreEstado))
        .ReverseMap();*/
    }
}